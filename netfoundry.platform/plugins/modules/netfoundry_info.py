#!/usr/bin/python

# Copyright: (c) 2020, Kenneth Bingham <kenneth.bingham@netfoundry.io>
# GNU General Public License v3.0+ (see COPYING or https://www.gnu.org/licenses/gpl-3.0.txt)
from __future__ import absolute_import, division, print_function

from distutils.log import debug

__metaclass__ = type

ANSIBLE_METADATA = {
    'metadata_version': '1.1',
    'status': ['preview'],
    'supported_by': 'community'
}

DOCUMENTATION = r'''
---
module: netfoundry_info

short_description: Use or describe a NetFoundry Network

version_added: "1.0.0"

description: Discover NetFoundry Network resources with an API account

options:
    network:
        description: The name or UUID of the Network to use or describe.
        required: false
        type: str
    credentials:
        description: Path to API account credentials JSON file relative to playbook directory. Overrides default environment variables and file paths described in https://developer.netfoundry.io/guides/authentication/
        required: false
        type: path
    session:
        description: session object from netfoundry_info.session may be used to continue using an existing session instead of creating a new session with `credentials`, `organization`, `network_group`
        required: false
        type: str
    inventory:
        description: optionally, perform expensive operations to describe all resources
        required: false
        default: false
        type: bool
    organization:
        description: optional name or UUID of the identity Organization to use. This is not typically necessary because there is normally only one Organization, that of the caller's identity.
        required: false
        type: str
    network_group:
        description: optional name or UUID of the Network Group to use. This is not typically necessary because there is normally only one Group.
        required: false
        type: str

author:
    - Kenneth Bingham (@qrkourier)

requirements:
    - netfoundry
'''

EXAMPLES = r'''
- name: start a one-hour session for the default Organization
  netfoundry.platform.netfoundry_info:
    credentials: credentials.json
  register: netfoundry_organization

- name: renew a session if expiring within 30 minutes
  netfoundry.platform.netfoundry_info:
    session: "{{ netfoundry_organization.session }}"
  register: netfoundry_organization

- name: start a one-hour session for a particular Network
  netfoundry.platform.netfoundry_info:
    network: BibbidiBobbidiBoo
    credentials: credentials.json
  register: netfoundry_network

- name: re-use the session and discover resources in a Network with "inventory"
  netfoundry.platform.netfoundry_info:
    inventory: True
    network: "{{ netfoundry_network.network.id }}"
    session: "{{ network_network.session }}"
  register: network_inventory

'''

RETURN = r'''
original_message:
    description: The original name param that was passed in.
    type: str
    returned: always
    sample: 'BibbidiBobbidiBoo'
message:
    description: The dictionary containing information about your Network.
    type: dict
    returned: always
'''

from ansible.errors import AnsibleError
from ansible.module_utils.api import (rate_limit_argument_spec,
                                      retry_argument_spec)
from ansible.module_utils.basic import AnsibleModule
from netfoundry.network import Network
from netfoundry.network_group import NetworkGroup
from netfoundry.organization import Organization


def run_module():
    # define available arguments/parameters a user can pass to the module
    module_args = dict(
        network=dict(type='str'),
        network_group=dict(type='str'),
        organization=dict(type='str'),
        credentials=dict(type='path'),
        profile=dict(type='str'),
        session=dict(type='dict'),
        inventory=dict(type='bool', default=False),
        log_file=dict(type='str'),
        debug=dict(type='bool', default=False),
        proxy=dict(type='str', required=False)
    )

    # seed the result dict in the object
    # we primarily care about changed and state
    # changed is if this module effectively modified the target
    # state will include any data that you want your module to pass back
    # for consumption, for example, in a subsequent task
    result = dict(
        changed=False,
        original_message='',
        message='',
        my_useful_info={},
    )

    # the AnsibleModule object will be our abstraction working with Ansible
    # this includes instantiation, a couple of common attr would be the
    # args/params passed to the execution, as well as if the module
    # supports check mode
    module = AnsibleModule(
        argument_spec=module_args,
        supports_check_mode=True
    )

    # if the user is working with this module in only check mode we do not
    # want to make any changes to the environment, just return the current
    # state with no modifications
    if module.check_mode:
        module.exit_json(**result)

    result['original_message'] = module.params

    if module.params['session'] is not None:
        organization = Organization(**module.params['session'])
    elif module.params['credentials'] is not None:
        organization = Organization(
            credentials=module.params['credentials'],
            organization_label=module.params['organization'] if 'organization' in module.params else None,
            profile=module.params['profile'] if 'profile' in module.params else None,
            proxy=module.params['proxy'],
            log_file=module.params['log_file'],
            debug=module.params['debug'],
        )
    else:
        raise AnsibleError("Need arg 'credentials' or 'session' to use a NetFoundry organization")

    session = {
        "credentials": organization.credentials,
        "profile": organization.profile,
        "token": organization.token,
        "proxy": organization.proxy,
        "organization_id": organization.id,
        "log_file": organization.log_file,
        "debug": organization.debug,
    }
    result['session'] = session

    # use some Network Group, default is to use the first and there's typically only one
    network_group = NetworkGroup(
        organization,
        group=module.params['network_group'] if module.params['network_group'] else None
    )

    if module.params['network']:
        network_id = None
        network_name = None
        network = Network(
            network_group,
            network=module.params['network']
        )
        result['network'] = {
            **network.describe,
            'data_centers': network.get_edge_router_data_centers(),
            'session': session,
        }

        if module.params['inventory']:
            # optionally perform expensive inventory operations
            result['network'] = {
                **result['network'],
                'endpoints': network.endpoints(),                        # both types of endpoints
                'device_endpoints': network.endpoints(typeId="Device"),  # normal endpoint
                'router_endpoints': network.endpoints(typeId="Router"),  # system-managed built-in to router
                'services': network.services(),
                'hosted_edge_routers': network.edge_routers(only_hosted=True),
                'customer_edge_routers': network.edge_routers(only_customer=True),
                'edge_router_policies': network.edge_router_policies(),
                'app_wans': network.app_wans(),
                'posture_checks': network.posture_checks(),
            }

        # use the Network Group of the specified Network
        network_group = NetworkGroup(organization, network_group_id=network.network_group_id)
    elif module.params['network_group']:
        # use the specified Network Group
        network_group = NetworkGroup(
            organization,
            group=module.params['network_group']
        )
    else:
        # use the default Network Group (the first Network Group ID known to the Organization)
        network_group = NetworkGroup(organization)

    result['console'] = network_group.nfconsole
    # merge the session object to top-level resources on which we will perform
    #  operations so that only a single parameter is necessary when calling
    #  subsequent modules e.g. netfoundry_endpoint
    result['organization'] = {
        **organization.describe,
        "session": session
    }
    result['network_group'] = {
        **network_group.describe,
        "session": session
    }

    # in the event of a successful module execution, you will want to
    # simple AnsibleModule.exit_json(), passing the key/value results
    module.exit_json(**result)


def main():
    run_module()


if __name__ == '__main__':
    main()
