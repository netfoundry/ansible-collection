/*
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


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.CoreV2ServicesServiceIdModelServerEgress;
import org.openapitools.client.model.InlineResponse2023ModelClientIngress;

/**
 * InlineResponse2023Model
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-03T11:59:07.273777-04:00[America/New_York]")
public class InlineResponse2023Model {
  public static final String SERIALIZED_NAME_BIND_ENDPOINT_ATTRIBUTES = "bindEndpointAttributes";
  @SerializedName(SERIALIZED_NAME_BIND_ENDPOINT_ATTRIBUTES)
  private List<String> bindEndpointAttributes = new ArrayList<String>();

  public static final String SERIALIZED_NAME_CLIENT_INGRESS = "clientIngress";
  @SerializedName(SERIALIZED_NAME_CLIENT_INGRESS)
  private InlineResponse2023ModelClientIngress clientIngress;

  public static final String SERIALIZED_NAME_EDGE_ROUTER_ATTRIBUTES = "edgeRouterAttributes";
  @SerializedName(SERIALIZED_NAME_EDGE_ROUTER_ATTRIBUTES)
  private List<String> edgeRouterAttributes = new ArrayList<String>();

  public static final String SERIALIZED_NAME_SERVER_EGRESS = "serverEgress";
  @SerializedName(SERIALIZED_NAME_SERVER_EGRESS)
  private CoreV2ServicesServiceIdModelServerEgress serverEgress;


  public InlineResponse2023Model bindEndpointAttributes(List<String> bindEndpointAttributes) {
    
    this.bindEndpointAttributes = bindEndpointAttributes;
    return this;
  }

  public InlineResponse2023Model addBindEndpointAttributesItem(String bindEndpointAttributesItem) {
    this.bindEndpointAttributes.add(bindEndpointAttributesItem);
    return this;
  }

   /**
   * Get bindEndpointAttributes
   * @return bindEndpointAttributes
  **/
  @ApiModelProperty(required = true, value = "")

  public List<String> getBindEndpointAttributes() {
    return bindEndpointAttributes;
  }


  public void setBindEndpointAttributes(List<String> bindEndpointAttributes) {
    this.bindEndpointAttributes = bindEndpointAttributes;
  }


  public InlineResponse2023Model clientIngress(InlineResponse2023ModelClientIngress clientIngress) {
    
    this.clientIngress = clientIngress;
    return this;
  }

   /**
   * Get clientIngress
   * @return clientIngress
  **/
  @ApiModelProperty(required = true, value = "")

  public InlineResponse2023ModelClientIngress getClientIngress() {
    return clientIngress;
  }


  public void setClientIngress(InlineResponse2023ModelClientIngress clientIngress) {
    this.clientIngress = clientIngress;
  }


  public InlineResponse2023Model edgeRouterAttributes(List<String> edgeRouterAttributes) {
    
    this.edgeRouterAttributes = edgeRouterAttributes;
    return this;
  }

  public InlineResponse2023Model addEdgeRouterAttributesItem(String edgeRouterAttributesItem) {
    this.edgeRouterAttributes.add(edgeRouterAttributesItem);
    return this;
  }

   /**
   * Get edgeRouterAttributes
   * @return edgeRouterAttributes
  **/
  @ApiModelProperty(required = true, value = "")

  public List<String> getEdgeRouterAttributes() {
    return edgeRouterAttributes;
  }


  public void setEdgeRouterAttributes(List<String> edgeRouterAttributes) {
    this.edgeRouterAttributes = edgeRouterAttributes;
  }


  public InlineResponse2023Model serverEgress(CoreV2ServicesServiceIdModelServerEgress serverEgress) {
    
    this.serverEgress = serverEgress;
    return this;
  }

   /**
   * Get serverEgress
   * @return serverEgress
  **/
  @ApiModelProperty(required = true, value = "")

  public CoreV2ServicesServiceIdModelServerEgress getServerEgress() {
    return serverEgress;
  }


  public void setServerEgress(CoreV2ServicesServiceIdModelServerEgress serverEgress) {
    this.serverEgress = serverEgress;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineResponse2023Model inlineResponse2023Model = (InlineResponse2023Model) o;
    return Objects.equals(this.bindEndpointAttributes, inlineResponse2023Model.bindEndpointAttributes) &&
        Objects.equals(this.clientIngress, inlineResponse2023Model.clientIngress) &&
        Objects.equals(this.edgeRouterAttributes, inlineResponse2023Model.edgeRouterAttributes) &&
        Objects.equals(this.serverEgress, inlineResponse2023Model.serverEgress);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bindEndpointAttributes, clientIngress, edgeRouterAttributes, serverEgress);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineResponse2023Model {\n");
    sb.append("    bindEndpointAttributes: ").append(toIndentedString(bindEndpointAttributes)).append("\n");
    sb.append("    clientIngress: ").append(toIndentedString(clientIngress)).append("\n");
    sb.append("    edgeRouterAttributes: ").append(toIndentedString(edgeRouterAttributes)).append("\n");
    sb.append("    serverEgress: ").append(toIndentedString(serverEgress)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
