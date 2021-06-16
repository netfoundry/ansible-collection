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
import InlineResponse2003EmbeddedModel from './InlineResponse2003EmbeddedModel';
import InlineResponse2005ConfigIdByConfigTypeId from './InlineResponse2005ConfigIdByConfigTypeId';
import InlineResponse200Links from './InlineResponse200Links';

/**
 * The InlineResponse2005 model module.
 * @module model/InlineResponse2005
 * @version 5229
 */
class InlineResponse2005 {
    /**
     * Constructs a new <code>InlineResponse2005</code>.
     * @alias module:model/InlineResponse2005
     * @param deletedAt {module:model/AnyType} 
     * @param networkId {String} 
     * @param name {String} 
     * @param updatedAt {String} 
     * @param model {module:model/InlineResponse2003EmbeddedModel} 
     * @param zitiId {String} 
     * @param ownerIdentityId {String} 
     * @param attributes {Array.<String>} 
     * @param modelType {String} 
     * @param id {String} 
     * @param configIdByConfigTypeId {module:model/InlineResponse2005ConfigIdByConfigTypeId} 
     * @param createdAt {String} 
     * @param createdBy {String} 
     * @param deletedBy {module:model/AnyType} 
     * @param encryptionRequired {Boolean} 
     * @param authority {module:model/AnyType} 
     * @param links {module:model/InlineResponse200Links} 
     */
    constructor(deletedAt, networkId, name, updatedAt, model, zitiId, ownerIdentityId, attributes, modelType, id, configIdByConfigTypeId, createdAt, createdBy, deletedBy, encryptionRequired, authority, links) { 
        
        InlineResponse2005.initialize(this, deletedAt, networkId, name, updatedAt, model, zitiId, ownerIdentityId, attributes, modelType, id, configIdByConfigTypeId, createdAt, createdBy, deletedBy, encryptionRequired, authority, links);
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
     * Constructs a <code>InlineResponse2005</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/InlineResponse2005} obj Optional instance to populate.
     * @return {module:model/InlineResponse2005} The populated <code>InlineResponse2005</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new InlineResponse2005();

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
                obj['model'] = InlineResponse2003EmbeddedModel.constructFromObject(data['model']);
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
                obj['configIdByConfigTypeId'] = InlineResponse2005ConfigIdByConfigTypeId.constructFromObject(data['configIdByConfigTypeId']);
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
                obj['_links'] = InlineResponse200Links.constructFromObject(data['_links']);
            }
        }
        return obj;
    }


}

/**
 * @member {module:model/AnyType} deletedAt
 */
InlineResponse2005.prototype['deletedAt'] = undefined;

/**
 * @member {String} networkId
 */
InlineResponse2005.prototype['networkId'] = undefined;

/**
 * @member {String} name
 */
InlineResponse2005.prototype['name'] = undefined;

/**
 * @member {String} updatedAt
 */
InlineResponse2005.prototype['updatedAt'] = undefined;

/**
 * @member {module:model/InlineResponse2003EmbeddedModel} model
 */
InlineResponse2005.prototype['model'] = undefined;

/**
 * @member {String} zitiId
 */
InlineResponse2005.prototype['zitiId'] = undefined;

/**
 * @member {String} ownerIdentityId
 */
InlineResponse2005.prototype['ownerIdentityId'] = undefined;

/**
 * @member {Array.<String>} attributes
 */
InlineResponse2005.prototype['attributes'] = undefined;

/**
 * @member {String} modelType
 */
InlineResponse2005.prototype['modelType'] = undefined;

/**
 * @member {String} id
 */
InlineResponse2005.prototype['id'] = undefined;

/**
 * @member {module:model/InlineResponse2005ConfigIdByConfigTypeId} configIdByConfigTypeId
 */
InlineResponse2005.prototype['configIdByConfigTypeId'] = undefined;

/**
 * @member {String} createdAt
 */
InlineResponse2005.prototype['createdAt'] = undefined;

/**
 * @member {String} createdBy
 */
InlineResponse2005.prototype['createdBy'] = undefined;

/**
 * @member {module:model/AnyType} deletedBy
 */
InlineResponse2005.prototype['deletedBy'] = undefined;

/**
 * @member {Boolean} encryptionRequired
 */
InlineResponse2005.prototype['encryptionRequired'] = undefined;

/**
 * @member {module:model/AnyType} authority
 */
InlineResponse2005.prototype['authority'] = undefined;

/**
 * @member {module:model/InlineResponse200Links} _links
 */
InlineResponse2005.prototype['_links'] = undefined;






export default InlineResponse2005;
