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


import com.squareup.moshi.Json
/**
 * 
 * @param zitiCliLinuxBinaryPeriodShaMinus1 
 * @param zitiTunnelLinuxBinary 
 * @param zitiTunnelLinuxBinaryPeriodShaMinus1 
 * @param zitiControllerBinary 
 * @param zitiCliLinuxBinaryPeriodMd5 
 * @param zitiRouterLinuxBinaryPeriodShaMinus1 
 * @param zitiRouterLinuxBinaryPeriodShaMinus256 
 * @param zitiRouterLinuxBinaryPeriodMd5 
 * @param zitiWindowsDesktopEdge 
 * @param zitiMacDesktopEdge 
 * @param zitiControllerBinaryPeriodShaMinus1 
 * @param zitiControllerBinaryPeriodMd5 
 * @param zitiControllerBinaryPeriodShaMinus256 
 * @param zitiIosEdge 
 * @param zitiCliLinuxBinary 
 * @param zitiVersion 
 * @param zitiRouterLinuxBinary 
 * @param zitiTunnelLinuxBinaryPeriodShaMinus256 
 * @param zitiAndroidEdge 
 * @param zitiTunnelLinuxBinaryPeriodMd5 
 * @param zitiCliLinuxBinaryPeriodShaMinus256 
 * @param active 
 */

data class InlineResponse20019710 (
    @Json(name = "zitiCliLinuxBinary.sha-1")
    val zitiCliLinuxBinaryPeriodShaMinus1: kotlin.String,
    @Json(name = "zitiTunnelLinuxBinary")
    val zitiTunnelLinuxBinary: kotlin.String,
    @Json(name = "zitiTunnelLinuxBinary.sha-1")
    val zitiTunnelLinuxBinaryPeriodShaMinus1: kotlin.String,
    @Json(name = "zitiControllerBinary")
    val zitiControllerBinary: kotlin.String,
    @Json(name = "zitiCliLinuxBinary.md5")
    val zitiCliLinuxBinaryPeriodMd5: kotlin.String,
    @Json(name = "zitiRouterLinuxBinary.sha-1")
    val zitiRouterLinuxBinaryPeriodShaMinus1: kotlin.String,
    @Json(name = "zitiRouterLinuxBinary.sha-256")
    val zitiRouterLinuxBinaryPeriodShaMinus256: kotlin.String,
    @Json(name = "zitiRouterLinuxBinary.md5")
    val zitiRouterLinuxBinaryPeriodMd5: kotlin.String,
    @Json(name = "zitiWindowsDesktopEdge")
    val zitiWindowsDesktopEdge: kotlin.String,
    @Json(name = "zitiMacDesktopEdge")
    val zitiMacDesktopEdge: kotlin.String,
    @Json(name = "zitiControllerBinary.sha-1")
    val zitiControllerBinaryPeriodShaMinus1: kotlin.String,
    @Json(name = "zitiControllerBinary.md5")
    val zitiControllerBinaryPeriodMd5: kotlin.String,
    @Json(name = "zitiControllerBinary.sha-256")
    val zitiControllerBinaryPeriodShaMinus256: kotlin.String,
    @Json(name = "zitiIosEdge")
    val zitiIosEdge: kotlin.String,
    @Json(name = "zitiCliLinuxBinary")
    val zitiCliLinuxBinary: kotlin.String,
    @Json(name = "zitiVersion")
    val zitiVersion: kotlin.String,
    @Json(name = "zitiRouterLinuxBinary")
    val zitiRouterLinuxBinary: kotlin.String,
    @Json(name = "zitiTunnelLinuxBinary.sha-256")
    val zitiTunnelLinuxBinaryPeriodShaMinus256: kotlin.String,
    @Json(name = "zitiAndroidEdge")
    val zitiAndroidEdge: kotlin.String,
    @Json(name = "zitiTunnelLinuxBinary.md5")
    val zitiTunnelLinuxBinaryPeriodMd5: kotlin.String,
    @Json(name = "zitiCliLinuxBinary.sha-256")
    val zitiCliLinuxBinaryPeriodShaMinus256: kotlin.String,
    @Json(name = "active")
    val active: kotlin.Boolean
)
