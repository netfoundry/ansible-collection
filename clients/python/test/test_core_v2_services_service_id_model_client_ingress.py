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
from openapi_client.models.core_v2_services_service_id_model_client_ingress import CoreV2ServicesServiceIdModelClientIngress  # noqa: E501
from openapi_client.rest import ApiException

class TestCoreV2ServicesServiceIdModelClientIngress(unittest.TestCase):
    """CoreV2ServicesServiceIdModelClientIngress unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test CoreV2ServicesServiceIdModelClientIngress
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = openapi_client.models.core_v2_services_service_id_model_client_ingress.CoreV2ServicesServiceIdModelClientIngress()  # noqa: E501
        if include_optional :
            return CoreV2ServicesServiceIdModelClientIngress(
                addresses = [
                    '0'
                    ], 
                ports = [
                    openapi_client.models._core_v2_services_model_client_ingress_ports._core_v2_services_model_clientIngress_ports(
                        high = '0', 
                        low = '0', )
                    ], 
                protocols = [
                    '0'
                    ]
            )
        else :
            return CoreV2ServicesServiceIdModelClientIngress(
                addresses = [
                    '0'
                    ],
                ports = [
                    openapi_client.models._core_v2_services_model_client_ingress_ports._core_v2_services_model_clientIngress_ports(
                        high = '0', 
                        low = '0', )
                    ],
                protocols = [
                    '0'
                    ],
        )

    def testCoreV2ServicesServiceIdModelClientIngress(self):
        """Test CoreV2ServicesServiceIdModelClientIngress"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()