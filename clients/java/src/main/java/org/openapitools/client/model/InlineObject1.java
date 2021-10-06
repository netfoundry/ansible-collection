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
import org.openapitools.client.model.CoreV2ServicesModel;

/**
 * InlineObject1
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-03T11:59:07.273777-04:00[America/New_York]")
public class InlineObject1 {
  public static final String SERIALIZED_NAME_NETWORK_ID = "networkId";
  @SerializedName(SERIALIZED_NAME_NETWORK_ID)
  private String networkId;

  public static final String SERIALIZED_NAME_NAME = "name";
  @SerializedName(SERIALIZED_NAME_NAME)
  private String name;

  public static final String SERIALIZED_NAME_MODEL = "model";
  @SerializedName(SERIALIZED_NAME_MODEL)
  private CoreV2ServicesModel model;

  public static final String SERIALIZED_NAME_ATTRIBUTES = "attributes";
  @SerializedName(SERIALIZED_NAME_ATTRIBUTES)
  private List<String> attributes = new ArrayList<String>();

  public static final String SERIALIZED_NAME_MODEL_TYPE = "modelType";
  @SerializedName(SERIALIZED_NAME_MODEL_TYPE)
  private String modelType;

  public static final String SERIALIZED_NAME_ENCRYPTION_REQUIRED = "encryptionRequired";
  @SerializedName(SERIALIZED_NAME_ENCRYPTION_REQUIRED)
  private Boolean encryptionRequired;


  public InlineObject1 networkId(String networkId) {
    
    this.networkId = networkId;
    return this;
  }

   /**
   * Get networkId
   * @return networkId
  **/
  @ApiModelProperty(required = true, value = "")

  public String getNetworkId() {
    return networkId;
  }


  public void setNetworkId(String networkId) {
    this.networkId = networkId;
  }


  public InlineObject1 name(String name) {
    
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @ApiModelProperty(required = true, value = "")

  public String getName() {
    return name;
  }


  public void setName(String name) {
    this.name = name;
  }


  public InlineObject1 model(CoreV2ServicesModel model) {
    
    this.model = model;
    return this;
  }

   /**
   * Get model
   * @return model
  **/
  @ApiModelProperty(required = true, value = "")

  public CoreV2ServicesModel getModel() {
    return model;
  }


  public void setModel(CoreV2ServicesModel model) {
    this.model = model;
  }


  public InlineObject1 attributes(List<String> attributes) {
    
    this.attributes = attributes;
    return this;
  }

  public InlineObject1 addAttributesItem(String attributesItem) {
    this.attributes.add(attributesItem);
    return this;
  }

   /**
   * Get attributes
   * @return attributes
  **/
  @ApiModelProperty(required = true, value = "")

  public List<String> getAttributes() {
    return attributes;
  }


  public void setAttributes(List<String> attributes) {
    this.attributes = attributes;
  }


  public InlineObject1 modelType(String modelType) {
    
    this.modelType = modelType;
    return this;
  }

   /**
   * Get modelType
   * @return modelType
  **/
  @ApiModelProperty(required = true, value = "")

  public String getModelType() {
    return modelType;
  }


  public void setModelType(String modelType) {
    this.modelType = modelType;
  }


  public InlineObject1 encryptionRequired(Boolean encryptionRequired) {
    
    this.encryptionRequired = encryptionRequired;
    return this;
  }

   /**
   * Get encryptionRequired
   * @return encryptionRequired
  **/
  @ApiModelProperty(required = true, value = "")

  public Boolean getEncryptionRequired() {
    return encryptionRequired;
  }


  public void setEncryptionRequired(Boolean encryptionRequired) {
    this.encryptionRequired = encryptionRequired;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineObject1 inlineObject1 = (InlineObject1) o;
    return Objects.equals(this.networkId, inlineObject1.networkId) &&
        Objects.equals(this.name, inlineObject1.name) &&
        Objects.equals(this.model, inlineObject1.model) &&
        Objects.equals(this.attributes, inlineObject1.attributes) &&
        Objects.equals(this.modelType, inlineObject1.modelType) &&
        Objects.equals(this.encryptionRequired, inlineObject1.encryptionRequired);
  }

  @Override
  public int hashCode() {
    return Objects.hash(networkId, name, model, attributes, modelType, encryptionRequired);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineObject1 {\n");
    sb.append("    networkId: ").append(toIndentedString(networkId)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    model: ").append(toIndentedString(model)).append("\n");
    sb.append("    attributes: ").append(toIndentedString(attributes)).append("\n");
    sb.append("    modelType: ").append(toIndentedString(modelType)).append("\n");
    sb.append("    encryptionRequired: ").append(toIndentedString(encryptionRequired)).append("\n");
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
