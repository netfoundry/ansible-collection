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

import org.openapitools.client.models.InlineResponse200LinksSelf

import com.squareup.moshi.Json
/**
 * 
 * @param first 
 * @param last 
 */

data class InlineResponse20017Links (
    @Json(name = "first")
    val first: InlineResponse200LinksSelf,
    @Json(name = "last")
    val last: InlineResponse200LinksSelf
)
