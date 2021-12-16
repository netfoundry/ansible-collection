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
import java.math.BigDecimal;
import org.openapitools.client.model.InlineResponse2002EmbeddedLinks;
import org.openapitools.client.model.oas_any_type_not_mapped;

/**
 * InlineResponse2002EmbeddedDataCenters
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-03T11:59:07.273777-04:00[America/New_York]")
public class InlineResponse2002EmbeddedDataCenters {
  public static final String SERIALIZED_NAME_CITY = "city";
  @SerializedName(SERIALIZED_NAME_CITY)
  private oas_any_type_not_mapped city = null;

  public static final String SERIALIZED_NAME_CONTINENT_CODE = "continentCode";
  @SerializedName(SERIALIZED_NAME_CONTINENT_CODE)
  private oas_any_type_not_mapped continentCode = null;

  public static final String SERIALIZED_NAME_STATE_CODE = "stateCode";
  @SerializedName(SERIALIZED_NAME_STATE_CODE)
  private oas_any_type_not_mapped stateCode = null;

  public static final String SERIALIZED_NAME_LNG = "lng";
  @SerializedName(SERIALIZED_NAME_LNG)
  private BigDecimal lng;

  public static final String SERIALIZED_NAME_PROVIDER = "provider";
  @SerializedName(SERIALIZED_NAME_PROVIDER)
  private String provider;

  public static final String SERIALIZED_NAME_STATE_NAME = "stateName";
  @SerializedName(SERIALIZED_NAME_STATE_NAME)
  private oas_any_type_not_mapped stateName = null;

  public static final String SERIALIZED_NAME_CONTINENT_NAME = "continentName";
  @SerializedName(SERIALIZED_NAME_CONTINENT_NAME)
  private oas_any_type_not_mapped continentName = null;

  public static final String SERIALIZED_NAME_ISP = "isp";
  @SerializedName(SERIALIZED_NAME_ISP)
  private oas_any_type_not_mapped isp = null;

  public static final String SERIALIZED_NAME_LOCATION_CODE = "locationCode";
  @SerializedName(SERIALIZED_NAME_LOCATION_CODE)
  private String locationCode;

  public static final String SERIALIZED_NAME_COUNTRY_NAME = "countryName";
  @SerializedName(SERIALIZED_NAME_COUNTRY_NAME)
  private oas_any_type_not_mapped countryName = null;

  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_COUNTRY_CODE = "countryCode";
  @SerializedName(SERIALIZED_NAME_COUNTRY_CODE)
  private oas_any_type_not_mapped countryCode = null;

  public static final String SERIALIZED_NAME_ADDRESS = "address";
  @SerializedName(SERIALIZED_NAME_ADDRESS)
  private oas_any_type_not_mapped address = null;

  public static final String SERIALIZED_NAME_LOCATION_NAME = "locationName";
  @SerializedName(SERIALIZED_NAME_LOCATION_NAME)
  private String locationName;

  public static final String SERIALIZED_NAME_LAT = "lat";
  @SerializedName(SERIALIZED_NAME_LAT)
  private BigDecimal lat;

  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private InlineResponse2002EmbeddedLinks links;


  public InlineResponse2002EmbeddedDataCenters city(oas_any_type_not_mapped city) {
    
    this.city = city;
    return this;
  }

   /**
   * Get city
   * @return city
  **/
  @ApiModelProperty(required = true, value = "")

  public oas_any_type_not_mapped getCity() {
    return city;
  }


  public void setCity(oas_any_type_not_mapped city) {
    this.city = city;
  }


  public InlineResponse2002EmbeddedDataCenters continentCode(oas_any_type_not_mapped continentCode) {
    
    this.continentCode = continentCode;
    return this;
  }

   /**
   * Get continentCode
   * @return continentCode
  **/
  @ApiModelProperty(required = true, value = "")

  public oas_any_type_not_mapped getContinentCode() {
    return continentCode;
  }


  public void setContinentCode(oas_any_type_not_mapped continentCode) {
    this.continentCode = continentCode;
  }


  public InlineResponse2002EmbeddedDataCenters stateCode(oas_any_type_not_mapped stateCode) {
    
    this.stateCode = stateCode;
    return this;
  }

   /**
   * Get stateCode
   * @return stateCode
  **/
  @ApiModelProperty(required = true, value = "")

  public oas_any_type_not_mapped getStateCode() {
    return stateCode;
  }


  public void setStateCode(oas_any_type_not_mapped stateCode) {
    this.stateCode = stateCode;
  }


  public InlineResponse2002EmbeddedDataCenters lng(BigDecimal lng) {
    
    this.lng = lng;
    return this;
  }

   /**
   * Get lng
   * @return lng
  **/
  @ApiModelProperty(required = true, value = "")

  public BigDecimal getLng() {
    return lng;
  }


  public void setLng(BigDecimal lng) {
    this.lng = lng;
  }


  public InlineResponse2002EmbeddedDataCenters provider(String provider) {
    
    this.provider = provider;
    return this;
  }

   /**
   * Get provider
   * @return provider
  **/
  @ApiModelProperty(required = true, value = "")

  public String getProvider() {
    return provider;
  }


  public void setProvider(String provider) {
    this.provider = provider;
  }


  public InlineResponse2002EmbeddedDataCenters stateName(oas_any_type_not_mapped stateName) {
    
    this.stateName = stateName;
    return this;
  }

   /**
   * Get stateName
   * @return stateName
  **/
  @ApiModelProperty(required = true, value = "")

  public oas_any_type_not_mapped getStateName() {
    return stateName;
  }


  public void setStateName(oas_any_type_not_mapped stateName) {
    this.stateName = stateName;
  }


  public InlineResponse2002EmbeddedDataCenters continentName(oas_any_type_not_mapped continentName) {
    
    this.continentName = continentName;
    return this;
  }

   /**
   * Get continentName
   * @return continentName
  **/
  @ApiModelProperty(required = true, value = "")

  public oas_any_type_not_mapped getContinentName() {
    return continentName;
  }


  public void setContinentName(oas_any_type_not_mapped continentName) {
    this.continentName = continentName;
  }


  public InlineResponse2002EmbeddedDataCenters isp(oas_any_type_not_mapped isp) {
    
    this.isp = isp;
    return this;
  }

   /**
   * Get isp
   * @return isp
  **/
  @ApiModelProperty(required = true, value = "")

  public oas_any_type_not_mapped getIsp() {
    return isp;
  }


  public void setIsp(oas_any_type_not_mapped isp) {
    this.isp = isp;
  }


  public InlineResponse2002EmbeddedDataCenters locationCode(String locationCode) {
    
    this.locationCode = locationCode;
    return this;
  }

   /**
   * Get locationCode
   * @return locationCode
  **/
  @ApiModelProperty(required = true, value = "")

  public String getLocationCode() {
    return locationCode;
  }


  public void setLocationCode(String locationCode) {
    this.locationCode = locationCode;
  }


  public InlineResponse2002EmbeddedDataCenters countryName(oas_any_type_not_mapped countryName) {
    
    this.countryName = countryName;
    return this;
  }

   /**
   * Get countryName
   * @return countryName
  **/
  @ApiModelProperty(required = true, value = "")

  public oas_any_type_not_mapped getCountryName() {
    return countryName;
  }


  public void setCountryName(oas_any_type_not_mapped countryName) {
    this.countryName = countryName;
  }


  public InlineResponse2002EmbeddedDataCenters id(String id) {
    
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(required = true, value = "")

  public String getId() {
    return id;
  }


  public void setId(String id) {
    this.id = id;
  }


  public InlineResponse2002EmbeddedDataCenters countryCode(oas_any_type_not_mapped countryCode) {
    
    this.countryCode = countryCode;
    return this;
  }

   /**
   * Get countryCode
   * @return countryCode
  **/
  @ApiModelProperty(required = true, value = "")

  public oas_any_type_not_mapped getCountryCode() {
    return countryCode;
  }


  public void setCountryCode(oas_any_type_not_mapped countryCode) {
    this.countryCode = countryCode;
  }


  public InlineResponse2002EmbeddedDataCenters address(oas_any_type_not_mapped address) {
    
    this.address = address;
    return this;
  }

   /**
   * Get address
   * @return address
  **/
  @ApiModelProperty(required = true, value = "")

  public oas_any_type_not_mapped getAddress() {
    return address;
  }


  public void setAddress(oas_any_type_not_mapped address) {
    this.address = address;
  }


  public InlineResponse2002EmbeddedDataCenters locationName(String locationName) {
    
    this.locationName = locationName;
    return this;
  }

   /**
   * Get locationName
   * @return locationName
  **/
  @ApiModelProperty(required = true, value = "")

  public String getLocationName() {
    return locationName;
  }


  public void setLocationName(String locationName) {
    this.locationName = locationName;
  }


  public InlineResponse2002EmbeddedDataCenters lat(BigDecimal lat) {
    
    this.lat = lat;
    return this;
  }

   /**
   * Get lat
   * @return lat
  **/
  @ApiModelProperty(required = true, value = "")

  public BigDecimal getLat() {
    return lat;
  }


  public void setLat(BigDecimal lat) {
    this.lat = lat;
  }


  public InlineResponse2002EmbeddedDataCenters links(InlineResponse2002EmbeddedLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @ApiModelProperty(required = true, value = "")

  public InlineResponse2002EmbeddedLinks getLinks() {
    return links;
  }


  public void setLinks(InlineResponse2002EmbeddedLinks links) {
    this.links = links;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineResponse2002EmbeddedDataCenters inlineResponse2002EmbeddedDataCenters = (InlineResponse2002EmbeddedDataCenters) o;
    return Objects.equals(this.city, inlineResponse2002EmbeddedDataCenters.city) &&
        Objects.equals(this.continentCode, inlineResponse2002EmbeddedDataCenters.continentCode) &&
        Objects.equals(this.stateCode, inlineResponse2002EmbeddedDataCenters.stateCode) &&
        Objects.equals(this.lng, inlineResponse2002EmbeddedDataCenters.lng) &&
        Objects.equals(this.provider, inlineResponse2002EmbeddedDataCenters.provider) &&
        Objects.equals(this.stateName, inlineResponse2002EmbeddedDataCenters.stateName) &&
        Objects.equals(this.continentName, inlineResponse2002EmbeddedDataCenters.continentName) &&
        Objects.equals(this.isp, inlineResponse2002EmbeddedDataCenters.isp) &&
        Objects.equals(this.locationCode, inlineResponse2002EmbeddedDataCenters.locationCode) &&
        Objects.equals(this.countryName, inlineResponse2002EmbeddedDataCenters.countryName) &&
        Objects.equals(this.id, inlineResponse2002EmbeddedDataCenters.id) &&
        Objects.equals(this.countryCode, inlineResponse2002EmbeddedDataCenters.countryCode) &&
        Objects.equals(this.address, inlineResponse2002EmbeddedDataCenters.address) &&
        Objects.equals(this.locationName, inlineResponse2002EmbeddedDataCenters.locationName) &&
        Objects.equals(this.lat, inlineResponse2002EmbeddedDataCenters.lat) &&
        Objects.equals(this.links, inlineResponse2002EmbeddedDataCenters.links);
  }

  @Override
  public int hashCode() {
    return Objects.hash(city, continentCode, stateCode, lng, provider, stateName, continentName, isp, locationCode, countryName, id, countryCode, address, locationName, lat, links);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineResponse2002EmbeddedDataCenters {\n");
    sb.append("    city: ").append(toIndentedString(city)).append("\n");
    sb.append("    continentCode: ").append(toIndentedString(continentCode)).append("\n");
    sb.append("    stateCode: ").append(toIndentedString(stateCode)).append("\n");
    sb.append("    lng: ").append(toIndentedString(lng)).append("\n");
    sb.append("    provider: ").append(toIndentedString(provider)).append("\n");
    sb.append("    stateName: ").append(toIndentedString(stateName)).append("\n");
    sb.append("    continentName: ").append(toIndentedString(continentName)).append("\n");
    sb.append("    isp: ").append(toIndentedString(isp)).append("\n");
    sb.append("    locationCode: ").append(toIndentedString(locationCode)).append("\n");
    sb.append("    countryName: ").append(toIndentedString(countryName)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    countryCode: ").append(toIndentedString(countryCode)).append("\n");
    sb.append("    address: ").append(toIndentedString(address)).append("\n");
    sb.append("    locationName: ").append(toIndentedString(locationName)).append("\n");
    sb.append("    lat: ").append(toIndentedString(lat)).append("\n");
    sb.append("    links: ").append(toIndentedString(links)).append("\n");
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
