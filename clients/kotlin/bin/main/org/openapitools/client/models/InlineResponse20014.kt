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
import org.openapitools.client.models.InlineResponse20014IdentityProviders
import org.openapitools.client.models.InlineResponse20014UpdatedAt

import com.squareup.moshi.Json
/**
 * 
 * @param deletedAt 
 * @param name 
 * @param updatedAt 
 * @param label 
 * @param id 
 * @param mfaProvider 
 * @param createdAt 
 * @param identityProviders 
 * @param deleted 
 * @param active 
 */

data class InlineResponse20014 (
    @Json(name = "deletedAt")
    val deletedAt: AnyType,
    @Json(name = "name")
    val name: kotlin.String,
    @Json(name = "updatedAt")
    val updatedAt: InlineResponse20014UpdatedAt,
    @Json(name = "label")
    val label: kotlin.String,
    @Json(name = "id")
    val id: kotlin.String,
    @Json(name = "mfaProvider")
    val mfaProvider: kotlin.String,
    @Json(name = "createdAt")
    val createdAt: InlineResponse20014UpdatedAt,
    @Json(name = "identityProviders")
    val identityProviders: kotlin.Array<InlineResponse20014IdentityProviders>,
    @Json(name = "deleted")
    val deleted: kotlin.Boolean,
    @Json(name = "active")
    val active: kotlin.Boolean
)
