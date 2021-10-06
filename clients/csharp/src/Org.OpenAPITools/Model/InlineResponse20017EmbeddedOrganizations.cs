/* 
 * untitled API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 5229
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// InlineResponse20017EmbeddedOrganizations
    /// </summary>
    [DataContract]
    public partial class InlineResponse20017EmbeddedOrganizations :  IEquatable<InlineResponse20017EmbeddedOrganizations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20017EmbeddedOrganizations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse20017EmbeddedOrganizations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20017EmbeddedOrganizations" /> class.
        /// </summary>
        /// <param name="organizationShortName">organizationShortName (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="zitiEnabled">zitiEnabled (required).</param>
        /// <param name="defaultAzureVirtualWanId">defaultAzureVirtualWanId (required).</param>
        /// <param name="ownerIdentityId">ownerIdentityId (required).</param>
        /// <param name="billingAccountId">billingAccountId (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="awsAutoScalingGatewayEnabled">awsAutoScalingGatewayEnabled (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="mfaRequired">mfaRequired (required).</param>
        /// <param name="deleted">deleted (required).</param>
        /// <param name="links">links (required).</param>
        public InlineResponse20017EmbeddedOrganizations(string organizationShortName = default(string), string name = default(string), string updatedAt = default(string), bool zitiEnabled = default(bool), AnyType defaultAzureVirtualWanId = default(AnyType), AnyType ownerIdentityId = default(AnyType), string billingAccountId = default(string), string id = default(string), bool awsAutoScalingGatewayEnabled = default(bool), string createdAt = default(string), bool mfaRequired = default(bool), bool deleted = default(bool), InlineResponse20011Links links = default(InlineResponse20011Links))
        {
            // to ensure "organizationShortName" is required (not null)
            if (organizationShortName == null)
            {
                throw new InvalidDataException("organizationShortName is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.OrganizationShortName = organizationShortName;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new InvalidDataException("updatedAt is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.UpdatedAt = updatedAt;
            }
            
            // to ensure "zitiEnabled" is required (not null)
            if (zitiEnabled == null)
            {
                throw new InvalidDataException("zitiEnabled is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.ZitiEnabled = zitiEnabled;
            }
            
            // to ensure "defaultAzureVirtualWanId" is required (not null)
            if (defaultAzureVirtualWanId == null)
            {
                throw new InvalidDataException("defaultAzureVirtualWanId is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.DefaultAzureVirtualWanId = defaultAzureVirtualWanId;
            }
            
            // to ensure "ownerIdentityId" is required (not null)
            if (ownerIdentityId == null)
            {
                throw new InvalidDataException("ownerIdentityId is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.OwnerIdentityId = ownerIdentityId;
            }
            
            // to ensure "billingAccountId" is required (not null)
            if (billingAccountId == null)
            {
                throw new InvalidDataException("billingAccountId is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.BillingAccountId = billingAccountId;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "awsAutoScalingGatewayEnabled" is required (not null)
            if (awsAutoScalingGatewayEnabled == null)
            {
                throw new InvalidDataException("awsAutoScalingGatewayEnabled is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.AwsAutoScalingGatewayEnabled = awsAutoScalingGatewayEnabled;
            }
            
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            
            // to ensure "mfaRequired" is required (not null)
            if (mfaRequired == null)
            {
                throw new InvalidDataException("mfaRequired is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.MfaRequired = mfaRequired;
            }
            
            // to ensure "deleted" is required (not null)
            if (deleted == null)
            {
                throw new InvalidDataException("deleted is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.Deleted = deleted;
            }
            
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new InvalidDataException("links is a required property for InlineResponse20017EmbeddedOrganizations and cannot be null");
            }
            else
            {
                this.Links = links;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets OrganizationShortName
        /// </summary>
        [DataMember(Name="organizationShortName", EmitDefaultValue=true)]
        public string OrganizationShortName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ZitiEnabled
        /// </summary>
        [DataMember(Name="zitiEnabled", EmitDefaultValue=true)]
        public bool ZitiEnabled { get; set; }

        /// <summary>
        /// Gets or Sets DefaultAzureVirtualWanId
        /// </summary>
        [DataMember(Name="defaultAzureVirtualWanId", EmitDefaultValue=true)]
        public AnyType DefaultAzureVirtualWanId { get; set; }

        /// <summary>
        /// Gets or Sets OwnerIdentityId
        /// </summary>
        [DataMember(Name="ownerIdentityId", EmitDefaultValue=true)]
        public AnyType OwnerIdentityId { get; set; }

        /// <summary>
        /// Gets or Sets BillingAccountId
        /// </summary>
        [DataMember(Name="billingAccountId", EmitDefaultValue=true)]
        public string BillingAccountId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AwsAutoScalingGatewayEnabled
        /// </summary>
        [DataMember(Name="awsAutoScalingGatewayEnabled", EmitDefaultValue=true)]
        public bool AwsAutoScalingGatewayEnabled { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets MfaRequired
        /// </summary>
        [DataMember(Name="mfaRequired", EmitDefaultValue=true)]
        public bool MfaRequired { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=true)]
        public InlineResponse20011Links Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20017EmbeddedOrganizations {\n");
            sb.Append("  OrganizationShortName: ").Append(OrganizationShortName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ZitiEnabled: ").Append(ZitiEnabled).Append("\n");
            sb.Append("  DefaultAzureVirtualWanId: ").Append(DefaultAzureVirtualWanId).Append("\n");
            sb.Append("  OwnerIdentityId: ").Append(OwnerIdentityId).Append("\n");
            sb.Append("  BillingAccountId: ").Append(BillingAccountId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AwsAutoScalingGatewayEnabled: ").Append(AwsAutoScalingGatewayEnabled).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  MfaRequired: ").Append(MfaRequired).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse20017EmbeddedOrganizations);
        }

        /// <summary>
        /// Returns true if InlineResponse20017EmbeddedOrganizations instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20017EmbeddedOrganizations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20017EmbeddedOrganizations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationShortName == input.OrganizationShortName ||
                    (this.OrganizationShortName != null &&
                    this.OrganizationShortName.Equals(input.OrganizationShortName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.ZitiEnabled == input.ZitiEnabled ||
                    (this.ZitiEnabled != null &&
                    this.ZitiEnabled.Equals(input.ZitiEnabled))
                ) && 
                (
                    this.DefaultAzureVirtualWanId == input.DefaultAzureVirtualWanId ||
                    (this.DefaultAzureVirtualWanId != null &&
                    this.DefaultAzureVirtualWanId.Equals(input.DefaultAzureVirtualWanId))
                ) && 
                (
                    this.OwnerIdentityId == input.OwnerIdentityId ||
                    (this.OwnerIdentityId != null &&
                    this.OwnerIdentityId.Equals(input.OwnerIdentityId))
                ) && 
                (
                    this.BillingAccountId == input.BillingAccountId ||
                    (this.BillingAccountId != null &&
                    this.BillingAccountId.Equals(input.BillingAccountId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AwsAutoScalingGatewayEnabled == input.AwsAutoScalingGatewayEnabled ||
                    (this.AwsAutoScalingGatewayEnabled != null &&
                    this.AwsAutoScalingGatewayEnabled.Equals(input.AwsAutoScalingGatewayEnabled))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.MfaRequired == input.MfaRequired ||
                    (this.MfaRequired != null &&
                    this.MfaRequired.Equals(input.MfaRequired))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.OrganizationShortName != null)
                    hashCode = hashCode * 59 + this.OrganizationShortName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ZitiEnabled != null)
                    hashCode = hashCode * 59 + this.ZitiEnabled.GetHashCode();
                if (this.DefaultAzureVirtualWanId != null)
                    hashCode = hashCode * 59 + this.DefaultAzureVirtualWanId.GetHashCode();
                if (this.OwnerIdentityId != null)
                    hashCode = hashCode * 59 + this.OwnerIdentityId.GetHashCode();
                if (this.BillingAccountId != null)
                    hashCode = hashCode * 59 + this.BillingAccountId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AwsAutoScalingGatewayEnabled != null)
                    hashCode = hashCode * 59 + this.AwsAutoScalingGatewayEnabled.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.MfaRequired != null)
                    hashCode = hashCode * 59 + this.MfaRequired.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}