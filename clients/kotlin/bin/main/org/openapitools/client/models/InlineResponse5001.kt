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

import org.openapitools.client.models.InlineResponse5001Status

import com.squareup.moshi.Json
/**
 * 
 * @param errors 
 * @param status 
 * @param traceId 
 */

data class InlineResponse5001 (
    @Json(name = "errors")
    val errors: kotlin.Array<kotlin.String>,
    @Json(name = "status")
    val status: InlineResponse5001Status,
    @Json(name = "traceId")
    val traceId: kotlin.String
)
