#!/usr/bin/env python3

# Copyright: (c) 2020, Kenneth Bingham <kenneth.bingham@netfoundry.io>
# GNU General Public License v3.0+ (see COPYING or https://www.gnu.org/licenses/gpl-3.0.txt)
from __future__ import (absolute_import, division, print_function)
from re import match
__metaclass__ = type

ANSIBLE_METADATA = {
    'metadata_version': '1.1',
    'status': ['preview'],
    'supported_by': 'community'
}

DOCUMENTATION = r'''
---
module: netfoundry_appwan

short_description: Create, update, or delete an AppWAN

# If this is part of a collection, you need to use semantic versioning,
# i.e. the version is of the form "2.5.0" and not "2.4".
version_added: "1.4.0"

description: Create and update always have result=changed

options:
    name:
        description: the name of the AppWAN
        required: true
        type: str
    endpoints:
        description: A list of Endpoint IDs or names or Endpoint role attributes prefixed with a \#hash mark.
        required: false
        type: list
    services:
        description: A list of Service IDs or names or Service role attributes prefixed with a \#hash mark.
        required: false
        type: list
    state:
        description: The desired state.
        required: false
        type: str
        choices: ["PROVISIONED","DELETED"]
        default: PROVISIONED
    network:
        description: The dictionary describing the Network on which to operate from netfoundry_info.network.
        required: true
        type: dict

author:
    - Kenneth Bingham (@qrkourier)

requirements:
    - netfoundry
'''

EXAMPLES = r'''
  - name: create AppWAN
    netfoundry_appwan:
      name: Telecommuter AppWAN
      network: "{{ netfoundry_info.network }}"
      endpoints:
      - "#workFromAnywhere"
      - "@gunter-laptop1"
      services:
      - "#welcomeWagon"
      - "@internal-portal"

  - name: Delete an AppWAN
    netfoundry_appwan:
      name: Telecommuter AppWAN
      state: DELETED
      network: "{{ netfoundry_info.network }}"
'''

RETURN = r'''
# These are examples of possible return values, and in general should use other names for return values.
message:
    description: The HTTP response from the create, update, or delete operation.
    type: dict
    returned: always
'''

from ansible.module_utils.basic import AnsibleModule
from ansible.module_utils.api import rate_limit_argument_spec, retry_argument_spec
from ansible.errors import AnsibleError
from ansible.module_utils._text import to_native
from netfoundry.organization import Organization
from netfoundry.network_group import NetworkGroup
from netfoundry.network import Network
from netfoundry.utility import Utility
#from uuid import UUID

def run_module():
    # define available arguments/parameters a user can pass to the module
    module_args = dict(
        name=dict(type='str', required=True),
        endpoints=dict(type='list', elements='str', required=False, default=[]),
        services=dict(type='list', elements='str', required=False, default=[]),
        posture_checks=dict(type='list', elements='str', required=False, default=[]),
        state=dict(type='str', required=False, default="PROVISIONED", choices=["PROVISIONED","DELETED"]),
        network=dict(type='dict', required=True),
    )

    # seed the result dict in the object
    # we primarily care about changed and state
    # changed is if this module effectively modified the target
    # state will include any data that you want your module to pass back
    # for consumption, for example, in a subsequent task
    result = dict(
        changed=False,
        message=dict()
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

    # manipulate or modify the state as needed (this is going to be the
    # part where your module will do what it needs to do)

    organization = Organization(
        **module.params['network']['session']
    )

    result['session'] = {
        "token": organization.token,
        "credentials": organization.credentials,
        "proxy": organization.proxy,
        "organization_id": organization.id,
        "log_file": organization.log_file,
        "debug": organization.debug,
    }

    # instantiate some utility methods like snake(), camel() for translating styles
    utility = Utility()

    network_group = NetworkGroup(
        organization,
        network_group_id=module.params['network']['networkGroupId']
    )

#    import epdb; epdb.serve()
    network = Network(network_group, network_id=module.params['network']['id'])
    # "endpoints" and "customer_edge_routers" are lists in the info module's
    # inventory that are valid for the "endpoint roles" field in an AppWAN.
    # This is because customer routers always produce a "managed endpoint" with
    # an identical name.
    if "endpoints" in module.params['network'] and "router_endpoints" in module.params['network']:
        endpoint_names = [
            endpoint['name'] for endpoint in 
                module.params['network']['endpoints'] + module.params['network']['router_endpoints']
        ]
    else:
        endpoint_names = [endpoint['name'] for endpoint in network.endpoints()]
    if "services" in module.params['network']:
        service_names = [service['name'] for service in module.params['network']['services']]
    else:
        service_names = [service['name'] for service in network.services()]
    if "posture_checks" in module.params['network']:
        posture_names = [posture['name'] for posture in module.params['network']['posture_checks']]
    else:
        posture_names = [posture['name'] for posture in network.posture_checks()]

    properties = {
        "name": module.params['name'],
        "endpoint_attributes": module.params['endpoints'],
        "service_attributes": module.params['services'],
        "posture_check_attributes": module.params['posture_checks'],
    }

    # if not empty list then verify @mentions resolve to existing entities
    if properties["endpoint_attributes"]:
        for role in properties["endpoint_attributes"]:
            # check if @mention
            if role[0:1] == '@':
                if not role[1:] in endpoint_names:
                    raise AnsibleError('Failed to find an Endpoint named "{}".'.format(role[1:]))
    if properties["service_attributes"]:
        for role in properties["service_attributes"]:
            # check if @mention
            if role[0:1] == '@':
                if not role[1:] in service_names:
                    raise AnsibleError('Failed to find a Service named "{}".'.format(role[1:]))
    if properties["posture_check_attributes"]:
        for role in properties["posture_check_attributes"]:
            # check if @mention
            if role[0:1] == '@':
                if not role[1:] in posture_names:
                    raise AnsibleError('Failed to find a Posture Check named "{}".'.format(role[1:]))

    # find AppWAN with the specified name
    found = network.get_resources(type="app-wans",name=properties['name'])
    if len(found) == 0:
        if module.params['state'] == "PROVISIONED":
            result['message'] = network.create_app_wan(**properties)
            result['changed'] = True
        elif module.params['state'] == "DELETED":
            result['changed'] = False
    elif len(found) == 1:
        appwan = found[0]
        if module.params['state'] == "PROVISIONED":
            for key in appwan.keys():
                # if there's an exact match for the existing property in properties then replace it
                snake_key = utility.snake(camel_str=key)
                if snake_key in properties.keys():
                    appwan[key] = properties[snake_key]
            result['message'] = network.patch_resource(appwan)
            result['changed'] = True
        elif module.params['state'] == "DELETED":
            try: network.delete_app_wan(id=appwan['id'])
            except Exception as e:
                raise AnsibleError('Failed to delete Service "{}". Caught exception: {}'.format(module.params['name'], to_native(e)))
            result['changed'] = True
    else:
        module.fail_json(msg='ERROR: "{name}" matched more than one Service'.format(name=module.params['name']), **result)

    module.exit_json(**result)

def main():
    run_module()

if __name__ == '__main__':
    main()
