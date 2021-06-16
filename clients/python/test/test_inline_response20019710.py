# coding: utf-8

"""
    untitled API

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)  # noqa: E501

    The version of the OpenAPI document: 5170
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest
import datetime

import openapi_client
from openapi_client.models.inline_response20019710 import InlineResponse20019710  # noqa: E501
from openapi_client.rest import ApiException

class TestInlineResponse20019710(unittest.TestCase):
    """InlineResponse20019710 unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test InlineResponse20019710
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = openapi_client.models.inline_response20019710.InlineResponse20019710()  # noqa: E501
        if include_optional :
            return InlineResponse20019710(
                ziti_cli_linux_binary_sha_1 = '0', 
                ziti_tunnel_linux_binary = '0', 
                ziti_tunnel_linux_binary_sha_1 = '0', 
                ziti_controller_binary = '0', 
                ziti_cli_linux_binary_md5 = '0', 
                ziti_router_linux_binary_sha_1 = '0', 
                ziti_router_linux_binary_sha_256 = '0', 
                ziti_router_linux_binary_md5 = '0', 
                ziti_windows_desktop_edge = '0', 
                ziti_mac_desktop_edge = '0', 
                ziti_controller_binary_sha_1 = '0', 
                ziti_controller_binary_md5 = '0', 
                ziti_controller_binary_sha_256 = '0', 
                ziti_ios_edge = '0', 
                ziti_cli_linux_binary = '0', 
                ziti_version = '0', 
                ziti_router_linux_binary = '0', 
                ziti_tunnel_linux_binary_sha_256 = '0', 
                ziti_android_edge = '0', 
                ziti_tunnel_linux_binary_md5 = '0', 
                ziti_cli_linux_binary_sha_256 = '0', 
                active = True
            )
        else :
            return InlineResponse20019710(
                ziti_cli_linux_binary_sha_1 = '0',
                ziti_tunnel_linux_binary = '0',
                ziti_tunnel_linux_binary_sha_1 = '0',
                ziti_controller_binary = '0',
                ziti_cli_linux_binary_md5 = '0',
                ziti_router_linux_binary_sha_1 = '0',
                ziti_router_linux_binary_sha_256 = '0',
                ziti_router_linux_binary_md5 = '0',
                ziti_windows_desktop_edge = '0',
                ziti_mac_desktop_edge = '0',
                ziti_controller_binary_sha_1 = '0',
                ziti_controller_binary_md5 = '0',
                ziti_controller_binary_sha_256 = '0',
                ziti_ios_edge = '0',
                ziti_cli_linux_binary = '0',
                ziti_version = '0',
                ziti_router_linux_binary = '0',
                ziti_tunnel_linux_binary_sha_256 = '0',
                ziti_android_edge = '0',
                ziti_tunnel_linux_binary_md5 = '0',
                ziti_cli_linux_binary_sha_256 = '0',
                active = True,
        )

    def testInlineResponse20019710(self):
        """Test InlineResponse20019710"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()