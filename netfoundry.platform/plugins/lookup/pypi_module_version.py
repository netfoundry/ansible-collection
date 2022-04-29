# python 3 headers, required if submitting to Ansible
from __future__ import (absolute_import, division, print_function)
__metaclass__ = type

DOCUMENTATION = """
  lookup: pypi_module_version
  author: Kenneth Bingham <kenneth.bingham@netfoundry.io>
  version_added: "1.18.1"
  short_description: import the NetFoundry PyPi module and return its version
  description:
      - This lookup returns the version of the NetFoundry PyPi module from the perspective of the Python environment used by the Ansible controller.
"""

# options:
#   _terms:
#     description: name of the module to import
#     required: True
# option1:
#   description:
#         - Sample option that could modify plugin behaviour.
#         - This one can be set directly ``option1='x'`` or in ansible.cfg, but can also use vars or environment.
#   type: string
#   ini:
#     - section: file_lookup
#       key: option1
# notes:
#   - if read in variable context, the file can be interpreted as YAML if the content is valid to the parser.
#   - this lookup does not understand globing --- use the fileglob lookup instead.

from ansible.errors import AnsibleError, AnsibleParserError
from ansible.plugins.lookup import LookupBase
from ansible.utils.display import Display

display = Display()


class LookupModule(LookupBase):

    def run(self, terms, variables=None, **kwargs):

        # First of all populate options,
        # this will already take into account env vars and ini config
        self.set_options(var_options=variables, direct=kwargs)

        # lookups in general are expected to both take a list as input and output a list
        # this is done so they work with the looping construct 'with_'.
        ret = list()
        # Don't use print or your own logging, the display class
        # takes care of it in a unified way.
        try:
            from netfoundry import __version__ as netfoundry_version
        except ImportError as err:
            raise AnsibleError(f"could not import PyPi module 'netfoundry', caught {err}")
        else:
            display.vvvv(f"Found NetFoundry PyPi module version '{netfoundry_version}'")
            ret.append(netfoundry_version)

        return ret
