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

export class InlineObject6 {
    'networkId': string;
    'name': string;
    'attributes': Array<string>;
    'linkListener': boolean;
    'dataCenterId'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "networkId",
            "baseName": "networkId",
            "type": "string"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "attributes",
            "baseName": "attributes",
            "type": "Array<string>"
        },
        {
            "name": "linkListener",
            "baseName": "linkListener",
            "type": "boolean"
        },
        {
            "name": "dataCenterId",
            "baseName": "dataCenterId",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return InlineObject6.attributeTypeMap;
    }
}
