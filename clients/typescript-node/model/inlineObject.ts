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

export class InlineObject {
    'name': string;
    'size': string;
    'locationCode': string;
    'productVersion': string;
    'networkGroupId': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "size",
            "baseName": "size",
            "type": "string"
        },
        {
            "name": "locationCode",
            "baseName": "locationCode",
            "type": "string"
        },
        {
            "name": "productVersion",
            "baseName": "productVersion",
            "type": "string"
        },
        {
            "name": "networkGroupId",
            "baseName": "networkGroupId",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return InlineObject.attributeTypeMap;
    }
}
