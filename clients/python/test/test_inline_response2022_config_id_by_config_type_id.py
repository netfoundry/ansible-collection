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
from openapi_client.models.inline_response2022_config_id_by_config_type_id import InlineResponse2022ConfigIdByConfigTypeId  # noqa: E501
from openapi_client.rest import ApiException

class TestInlineResponse2022ConfigIdByConfigTypeId(unittest.TestCase):
    """InlineResponse2022ConfigIdByConfigTypeId unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test InlineResponse2022ConfigIdByConfigTypeId
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = openapi_client.models.inline_response2022_config_id_by_config_type_id.InlineResponse2022ConfigIdByConfigTypeId()  # noqa: E501
        if include_optional :
            return InlineResponse2022ConfigIdByConfigTypeId(
                aca7f705_9f00_4ff6_8b86_63a4d44bde8a = '0', 
                _6cd51ae0_cfe4_499d_88d8_d02a9e18b25f = '0', 
                d28725c0_9771_47d7_a9da_e408bd0adf4e = '0', 
                _888d6565_4359_4d91_b38d_0a24124e4456 = '0', 
                feb075cd_dd2b_47c5_922c_86ef3b06fb16 = '0'
            )
        else :
            return InlineResponse2022ConfigIdByConfigTypeId(
        )

    def testInlineResponse2022ConfigIdByConfigTypeId(self):
        """Test InlineResponse2022ConfigIdByConfigTypeId"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()