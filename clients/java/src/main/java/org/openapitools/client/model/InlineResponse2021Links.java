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
import org.openapitools.client.model.InlineResponse200LinksNetwork;
import org.openapitools.client.model.InlineResponse200LinksSelf;

/**
 * InlineResponse2021Links
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-03T11:59:07.273777-04:00[America/New_York]")
public class InlineResponse2021Links {
  public static final String SERIALIZED_NAME_NETWORK = "network";
  @SerializedName(SERIALIZED_NAME_NETWORK)
  private InlineResponse200LinksNetwork network;

  public static final String SERIALIZED_NAME_PROCESS = "process";
  @SerializedName(SERIALIZED_NAME_PROCESS)
  private InlineResponse200LinksNetwork process;

  public static final String SERIALIZED_NAME_SELF = "self";
  @SerializedName(SERIALIZED_NAME_SELF)
  private InlineResponse200LinksSelf self;


  public InlineResponse2021Links network(InlineResponse200LinksNetwork network) {
    
    this.network = network;
    return this;
  }

   /**
   * Get network
   * @return network
  **/
  @ApiModelProperty(required = true, value = "")

  public InlineResponse200LinksNetwork getNetwork() {
    return network;
  }


  public void setNetwork(InlineResponse200LinksNetwork network) {
    this.network = network;
  }


  public InlineResponse2021Links process(InlineResponse200LinksNetwork process) {
    
    this.process = process;
    return this;
  }

   /**
   * Get process
   * @return process
  **/
  @ApiModelProperty(required = true, value = "")

  public InlineResponse200LinksNetwork getProcess() {
    return process;
  }


  public void setProcess(InlineResponse200LinksNetwork process) {
    this.process = process;
  }


  public InlineResponse2021Links self(InlineResponse200LinksSelf self) {
    
    this.self = self;
    return this;
  }

   /**
   * Get self
   * @return self
  **/
  @ApiModelProperty(required = true, value = "")

  public InlineResponse200LinksSelf getSelf() {
    return self;
  }


  public void setSelf(InlineResponse200LinksSelf self) {
    this.self = self;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineResponse2021Links inlineResponse2021Links = (InlineResponse2021Links) o;
    return Objects.equals(this.network, inlineResponse2021Links.network) &&
        Objects.equals(this.process, inlineResponse2021Links.process) &&
        Objects.equals(this.self, inlineResponse2021Links.self);
  }

  @Override
  public int hashCode() {
    return Objects.hash(network, process, self);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineResponse2021Links {\n");
    sb.append("    network: ").append(toIndentedString(network)).append("\n");
    sb.append("    process: ").append(toIndentedString(process)).append("\n");
    sb.append("    self: ").append(toIndentedString(self)).append("\n");
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
