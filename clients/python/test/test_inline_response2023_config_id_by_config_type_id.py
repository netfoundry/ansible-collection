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
from openapi_client.models.inline_response2023_config_id_by_config_type_id import InlineResponse2023ConfigIdByConfigTypeId  # noqa: E501
from openapi_client.rest import ApiException

class TestInlineResponse2023ConfigIdByConfigTypeId(unittest.TestCase):
    """InlineResponse2023ConfigIdByConfigTypeId unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test InlineResponse2023ConfigIdByConfigTypeId
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = openapi_client.models.inline_response2023_config_id_by_config_type_id.InlineResponse2023ConfigIdByConfigTypeId()  # noqa: E501
        if include_optional :
            return InlineResponse2023ConfigIdByConfigTypeId(
                _714a918a_7935_4b4f_82c3_afbadcd9e59b = '0', 
                _7cafedc5_17b8_4c1e_8b6f_0d9bc1b4b7bc = '0', 
                d75e27f0_ebab_4567_8440_c24f02f2eca5 = '0', 
                ea6e632b_d8e1_420f_bd8f_ad50b067bad6 = '0'
            )
        else :
            return InlineResponse2023ConfigIdByConfigTypeId(
        )

    def testInlineResponse2023ConfigIdByConfigTypeId(self):
        """Test InlineResponse2023ConfigIdByConfigTypeId"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()