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
package org.openapitools.client.models

import org.openapitools.client.models.AnyType
import org.openapitools.client.models.InlineResponse200Links

import com.squareup.moshi.Json
/**
 * 
 * @param deletedAt 
 * @param networkId 
 * @param name 
 * @param updatedAt 
 * @param provider 
 * @param online 
 * @param zitiId 
 * @param userData 
 * @param ownerIdentityId 
 * @param attributes 
 * @param providerId 
 * @param jwt 
 * @param id 
 * @param ipAddress 
 * @param status 
 * @param hostId 
 * @param createdAt 
 * @param createdBy 
 * @param deletedBy 
 * @param locationMetadataId 
 * @param linkListener 
 * @param dataCenterId 
 * @param verified 
 * @param links 
 */

data class InlineResponse20012 (
    @Json(name = "deletedAt")
    val deletedAt: AnyType,
    @Json(name = "networkId")
    val networkId: kotlin.String,
    @Json(name = "name")
    val name: kotlin.String,
    @Json(name = "updatedAt")
    val updatedAt: kotlin.String,
    @Json(name = "provider")
    val provider: AnyType,
    @Json(name = "online")
    val online: kotlin.Boolean,
    @Json(name = "zitiId")
    val zitiId: kotlin.String,
    @Json(name = "userData")
    val userData: AnyType,
    @Json(name = "ownerIdentityId")
    val ownerIdentityId: kotlin.String,
    @Json(name = "attributes")
    val attributes: kotlin.Array<kotlin.String>,
    @Json(name = "providerId")
    val providerId: AnyType,
    @Json(name = "jwt")
    val jwt: AnyType,
    @Json(name = "id")
    val id: kotlin.String,
    @Json(name = "ipAddress")
    val ipAddress: AnyType,
    @Json(name = "status")
    val status: kotlin.String,
    @Json(name = "hostId")
    val hostId: AnyType,
    @Json(name = "createdAt")
    val createdAt: kotlin.String,
    @Json(name = "createdBy")
    val createdBy: kotlin.String,
    @Json(name = "deletedBy")
    val deletedBy: AnyType,
    @Json(name = "locationMetadataId")
    val locationMetadataId: AnyType,
    @Json(name = "linkListener")
    val linkListener: kotlin.Boolean,
    @Json(name = "dataCenterId")
    val dataCenterId: AnyType,
    @Json(name = "verified")
    val verified: kotlin.Boolean,
    @Json(name = "_links")
    val links: InlineResponse200Links
)
