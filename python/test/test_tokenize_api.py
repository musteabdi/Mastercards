# coding: utf-8

"""
    MDES for Merchants

    The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.    # noqa: E501

    The version of the OpenAPI document: 1.2.7
    Generated by: https://openapi-generator.tech
"""

from __future__ import absolute_import

import json
import os
import unittest

from client_encryption.api_encryption import add_encryption_layer
from oauth1.signer_interceptor import add_signer_layer

import openapi_client
from openapi_client.api.tokenize_api import TokenizeApi
from openapi_client.model.account_holder_data import AccountHolderData
from openapi_client.model.billing_address import BillingAddress
from openapi_client.model.card_account_data_inbound import CardAccountDataInbound
from openapi_client.model.funding_account_data import FundingAccountData
from openapi_client.model.funding_account_info import FundingAccountInfo
from openapi_client.model.funding_account_info_encrypted_payload import FundingAccountInfoEncryptedPayload
from openapi_client.model.tokenize_request_schema import TokenizeRequestSchema

FLE_CONFIG_PATH = "resources/fle_config.json"
BASE_PATH = "https://sandbox.api.mastercard.com/mdes"
P12 = ''  # TODO
KEY_PASSWORD = ''  # TODO
CONSUMER_KEY = ''  # TODO


class TestTokenizeApi(unittest.TestCase):

    def setUp(self):
        c = openapi_client.Configuration()
        c.host = BASE_PATH
        self.cli = openapi_client.ApiClient(c)

        # Add OAuth1.0a interceptor
        add_signer_layer(self.cli, P12, KEY_PASSWORD, CONSUMER_KEY)

        # Add Field Level Encryption interceptor
        config_file = os.path.join(os.path.dirname(__file__), FLE_CONFIG_PATH)
        add_encryption_layer(self.cli, config_file)

    def test_create_tokenize_with_schema_body(self):
        """TokenizeApi create_tokenize unit test"""
        api = openapi_client.api.tokenize_api.TokenizeApi(self.cli)
        res = api.create_tokenize(tokenize_request_schema=self.create_body_schema())
        assert res
        self.assertEqual(res.decision, 'APPROVED')  # 5.2.1

    def test_create_tokenize_with_dict_body(self):
        """TokenizeApi create_tokenize unit test"""
        api = openapi_client.api.tokenize_api.TokenizeApi(self.cli)
        res = api.create_tokenize(tokenize_request_schema=self.create_body_dict())
        assert res
        self.assertEqual(res.decision, 'APPROVED')  # 5.2.1

    @staticmethod
    def create_body_schema():
        return TokenizeRequestSchema(
            consumer_language="en",
            request_id="123456",
            response_host="site1.your-server.com",
            task_id="123456",
            token_requestor_id="98765432101",
            token_type="CLOUD",
            tokenization_authentication_value="RHVtbXkgYmFzZSA2NCBkYXRhIC0gdGhpcyBpcyBub3QgYSByZWFsIFRBViBleGFtcGxl",
            funding_account_info=FundingAccountInfo(
                encrypted_payload=FundingAccountInfoEncryptedPayload(
                    encrypted_data=FundingAccountData(
                        account_holder_data=AccountHolderData(
                            account_holder_address=BillingAddress(
                                city="St. Louis",
                                country="USA",
                                country_subdivision="MO",
                                line1="100 1st Street",
                                line2="Apt. 4B",
                                postal_code="61000"
                            ),
                            account_holder_name="John Doe",
                        ),
                        card_account_data=CardAccountDataInbound(
                            account_number="5123456789012345",
                            expiry_month="09",
                            expiry_year="21",
                            security_code="123",
                        ),
                        source="ACCOUNT_ON_FILE",
                    ),
                ),
            )
        )

    def create_body_dict(self):
            return {
                "consumer_language": "en",
                "funding_account_info": {
                    "encrypted_payload": {
                        "encrypted_data": {
                            "account_holder_data": {
                                "account_holder_address": {
                                    "city": "St. Louis",
                                    "country": "USA",
                                    "country_subdivision": "MO",
                                    "line1": "100 1st Street",
                                    "line2": "Apt. 4B",
                                    "postal_code": "61000"
                                },
                                "account_holder_name": "John Doe"
                            },
                            "card_account_data": {
                                "account_number": "5123456789012345",
                                "expiry_month": "09",
                                "expiry_year": "21",
                                "security_code": "123"
                            },
                            "source": "ACCOUNT_ON_FILE"
                        }
                    }
                },
                "request_id": "123456",
                "response_host": "site1.your-server.com",
                "task_id": "123456",
                "token_requestor_id": "98765432101",
                "token_type": "CLOUD",
                "tokenization_authentication_value": "RHVtbXkgYmFzZSA2NCBkYXRhIC0gdGhpcyBpcyBub3QgYSByZWFsIFRBViBleGFtcGxl"
            }


if __name__ == '__main__':
    unittest.main()
