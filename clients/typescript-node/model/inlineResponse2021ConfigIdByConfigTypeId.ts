/**
 * untitled API
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 5229
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { RequestFile } from '../api';

export class InlineResponse2021ConfigIdByConfigTypeId {
    '_6fa5c2bcB7f747f89229E927722adb27'?: string;
    '_7491e52d97e847598a63C8ea8a75f822'?: string;
    'b1582680Ab7b45d0Ac36B00f82df8e79'?: string;
    'e7f6ef8dDa57444cB677F03974f5d8be': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "_6fa5c2bcB7f747f89229E927722adb27",
            "baseName": "6fa5c2bc-b7f7-47f8-9229-e927722adb27",
            "type": "string"
        },
        {
            "name": "_7491e52d97e847598a63C8ea8a75f822",
            "baseName": "7491e52d-97e8-4759-8a63-c8ea8a75f822",
            "type": "string"
        },
        {
            "name": "b1582680Ab7b45d0Ac36B00f82df8e79",
            "baseName": "b1582680-ab7b-45d0-ac36-b00f82df8e79",
            "type": "string"
        },
        {
            "name": "e7f6ef8dDa57444cB677F03974f5d8be",
            "baseName": "e7f6ef8d-da57-444c-b677-f03974f5d8be",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return InlineResponse2021ConfigIdByConfigTypeId.attributeTypeMap;
    }
}
