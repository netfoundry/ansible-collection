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
 *
 */

import ApiClient from '../ApiClient';
import AnyType from './AnyType';
import InlineResponse2021Links from './InlineResponse2021Links';
import InlineResponse2023ConfigIdByConfigTypeId from './InlineResponse2023ConfigIdByConfigTypeId';
import InlineResponse2023Model from './InlineResponse2023Model';

/**
 * The InlineResponse2023 model module.
 * @module model/InlineResponse2023
 * @version 5229
 */
class InlineResponse2023 {
    /**
     * Constructs a new <code>InlineResponse2023</code>.
     * @alias module:model/InlineResponse2023
     * @param deletedAt {module:model/AnyType} 
     * @param networkId {String} 
     * @param name {String} 
     * @param updatedAt {String} 
     * @param model {module:model/InlineResponse2023Model} 
     * @param zitiId {String} 
     * @param ownerIdentityId {String} 
     * @param attributes {Array.<String>} 
     * @param modelType {String} 
     * @param id {String} 
     * @param configIdByConfigTypeId {module:model/InlineResponse2023ConfigIdByConfigTypeId} 
     * @param createdAt {String} 
     * @param createdBy {String} 
     * @param deletedBy {module:model/AnyType} 
     * @param encryptionRequired {Boolean} 
     * @param authority {module:model/AnyType} 
     * @param links {module:model/InlineResponse2021Links} 
     */
    constructor(deletedAt, networkId, name, updatedAt, model, zitiId, ownerIdentityId, attributes, modelType, id, configIdByConfigTypeId, createdAt, createdBy, deletedBy, encryptionRequired, authority, links) { 
        
        InlineResponse2023.initialize(this, deletedAt, networkId, name, updatedAt, model, zitiId, ownerIdentityId, attributes, modelType, id, configIdByConfigTypeId, createdAt, createdBy, deletedBy, encryptionRequired, authority, links);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj, deletedAt, networkId, name, updatedAt, model, zitiId, ownerIdentityId, attributes, modelType, id, configIdByConfigTypeId, createdAt, createdBy, deletedBy, encryptionRequired, authority, links) { 
        obj['deletedAt'] = deletedAt;
        obj['networkId'] = networkId;
        obj['name'] = name;
        obj['updatedAt'] = updatedAt;
        obj['model'] = model;
        obj['zitiId'] = zitiId;
        obj['ownerIdentityId'] = ownerIdentityId;
        obj['attributes'] = attributes;
        obj['modelType'] = modelType;
        obj['id'] = id;
        obj['configIdByConfigTypeId'] = configIdByConfigTypeId;
        obj['createdAt'] = createdAt;
        obj['createdBy'] = createdBy;
        obj['deletedBy'] = deletedBy;
        obj['encryptionRequired'] = encryptionRequired;
        obj['authority'] = authority;
        obj['_links'] = links;
    }

    /**
     * Constructs a <code>InlineResponse2023</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/InlineResponse2023} obj Optional instance to populate.
     * @return {module:model/InlineResponse2023} The populated <code>InlineResponse2023</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new InlineResponse2023();

            if (data.hasOwnProperty('deletedAt')) {
                obj['deletedAt'] = ApiClient.convertToType(data['deletedAt'], AnyType);
            }
            if (data.hasOwnProperty('networkId')) {
                obj['networkId'] = ApiClient.convertToType(data['networkId'], 'String');
            }
            if (data.hasOwnProperty('name')) {
                obj['name'] = ApiClient.convertToType(data['name'], 'String');
            }
            if (data.hasOwnProperty('updatedAt')) {
                obj['updatedAt'] = ApiClient.convertToType(data['updatedAt'], 'String');
            }
            if (data.hasOwnProperty('model')) {
                obj['model'] = InlineResponse2023Model.constructFromObject(data['model']);
            }
            if (data.hasOwnProperty('zitiId')) {
                obj['zitiId'] = ApiClient.convertToType(data['zitiId'], 'String');
            }
            if (data.hasOwnProperty('ownerIdentityId')) {
                obj['ownerIdentityId'] = ApiClient.convertToType(data['ownerIdentityId'], 'String');
            }
            if (data.hasOwnProperty('attributes')) {
                obj['attributes'] = ApiClient.convertToType(data['attributes'], ['String']);
            }
            if (data.hasOwnProperty('modelType')) {
                obj['modelType'] = ApiClient.convertToType(data['modelType'], 'String');
            }
            if (data.hasOwnProperty('id')) {
                obj['id'] = ApiClient.convertToType(data['id'], 'String');
            }
            if (data.hasOwnProperty('configIdByConfigTypeId')) {
                obj['configIdByConfigTypeId'] = InlineResponse2023ConfigIdByConfigTypeId.constructFromObject(data['configIdByConfigTypeId']);
            }
            if (data.hasOwnProperty('createdAt')) {
                obj['createdAt'] = ApiClient.convertToType(data['createdAt'], 'String');
            }
            if (data.hasOwnProperty('createdBy')) {
                obj['createdBy'] = ApiClient.convertToType(data['createdBy'], 'String');
            }
            if (data.hasOwnProperty('deletedBy')) {
                obj['deletedBy'] = ApiClient.convertToType(data['deletedBy'], AnyType);
            }
            if (data.hasOwnProperty('encryptionRequired')) {
                obj['encryptionRequired'] = ApiClient.convertToType(data['encryptionRequired'], 'Boolean');
            }
            if (data.hasOwnProperty('authority')) {
                obj['authority'] = ApiClient.convertToType(data['authority'], AnyType);
            }
            if (data.hasOwnProperty('_links')) {
                obj['_links'] = InlineResponse2021Links.constructFromObject(data['_links']);
            }
        }
        return obj;
    }


}

/**
 * @member {module:model/AnyType} deletedAt
 */
InlineResponse2023.prototype['deletedAt'] = undefined;

/**
 * @member {String} networkId
 */
InlineResponse2023.prototype['networkId'] = undefined;

/**
 * @member {String} name
 */
InlineResponse2023.prototype['name'] = undefined;

/**
 * @member {String} updatedAt
 */
InlineResponse2023.prototype['updatedAt'] = undefined;

/**
 * @member {module:model/InlineResponse2023Model} model
 */
InlineResponse2023.prototype['model'] = undefined;

/**
 * @member {String} zitiId
 */
InlineResponse2023.prototype['zitiId'] = undefined;

/**
 * @member {String} ownerIdentityId
 */
InlineResponse2023.prototype['ownerIdentityId'] = undefined;

/**
 * @member {Array.<String>} attributes
 */
InlineResponse2023.prototype['attributes'] = undefined;

/**
 * @member {String} modelType
 */
InlineResponse2023.prototype['modelType'] = undefined;

/**
 * @member {String} id
 */
InlineResponse2023.prototype['id'] = undefined;

/**
 * @member {module:model/InlineResponse2023ConfigIdByConfigTypeId} configIdByConfigTypeId
 */
InlineResponse2023.prototype['configIdByConfigTypeId'] = undefined;

/**
 * @member {String} createdAt
 */
InlineResponse2023.prototype['createdAt'] = undefined;

/**
 * @member {String} createdBy
 */
InlineResponse2023.prototype['createdBy'] = undefined;

/**
 * @member {module:model/AnyType} deletedBy
 */
InlineResponse2023.prototype['deletedBy'] = undefined;

/**
 * @member {Boolean} encryptionRequired
 */
InlineResponse2023.prototype['encryptionRequired'] = undefined;

/**
 * @member {module:model/AnyType} authority
 */
InlineResponse2023.prototype['authority'] = undefined;

/**
 * @member {module:model/InlineResponse2021Links} _links
 */
InlineResponse2023.prototype['_links'] = undefined;






export default InlineResponse2023;
