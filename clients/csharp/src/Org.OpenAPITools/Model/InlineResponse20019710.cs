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
    /// InlineResponse20019710
    /// </summary>
    [DataContract]
    public partial class InlineResponse20019710 :  IEquatable<InlineResponse20019710>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20019710" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse20019710() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20019710" /> class.
        /// </summary>
        /// <param name="zitiCliLinuxBinarySha1">zitiCliLinuxBinarySha1 (required).</param>
        /// <param name="zitiTunnelLinuxBinary">zitiTunnelLinuxBinary (required).</param>
        /// <param name="zitiTunnelLinuxBinarySha1">zitiTunnelLinuxBinarySha1 (required).</param>
        /// <param name="zitiControllerBinary">zitiControllerBinary (required).</param>
        /// <param name="zitiCliLinuxBinaryMd5">zitiCliLinuxBinaryMd5 (required).</param>
        /// <param name="zitiRouterLinuxBinarySha1">zitiRouterLinuxBinarySha1 (required).</param>
        /// <param name="zitiRouterLinuxBinarySha256">zitiRouterLinuxBinarySha256 (required).</param>
        /// <param name="zitiRouterLinuxBinaryMd5">zitiRouterLinuxBinaryMd5 (required).</param>
        /// <param name="zitiWindowsDesktopEdge">zitiWindowsDesktopEdge (required).</param>
        /// <param name="zitiMacDesktopEdge">zitiMacDesktopEdge (required).</param>
        /// <param name="zitiControllerBinarySha1">zitiControllerBinarySha1 (required).</param>
        /// <param name="zitiControllerBinaryMd5">zitiControllerBinaryMd5 (required).</param>
        /// <param name="zitiControllerBinarySha256">zitiControllerBinarySha256 (required).</param>
        /// <param name="zitiIosEdge">zitiIosEdge (required).</param>
        /// <param name="zitiCliLinuxBinary">zitiCliLinuxBinary (required).</param>
        /// <param name="zitiVersion">zitiVersion (required).</param>
        /// <param name="zitiRouterLinuxBinary">zitiRouterLinuxBinary (required).</param>
        /// <param name="zitiTunnelLinuxBinarySha256">zitiTunnelLinuxBinarySha256 (required).</param>
        /// <param name="zitiAndroidEdge">zitiAndroidEdge (required).</param>
        /// <param name="zitiTunnelLinuxBinaryMd5">zitiTunnelLinuxBinaryMd5 (required).</param>
        /// <param name="zitiCliLinuxBinarySha256">zitiCliLinuxBinarySha256 (required).</param>
        /// <param name="active">active (required).</param>
        public InlineResponse20019710(string zitiCliLinuxBinarySha1 = default(string), string zitiTunnelLinuxBinary = default(string), string zitiTunnelLinuxBinarySha1 = default(string), string zitiControllerBinary = default(string), string zitiCliLinuxBinaryMd5 = default(string), string zitiRouterLinuxBinarySha1 = default(string), string zitiRouterLinuxBinarySha256 = default(string), string zitiRouterLinuxBinaryMd5 = default(string), string zitiWindowsDesktopEdge = default(string), string zitiMacDesktopEdge = default(string), string zitiControllerBinarySha1 = default(string), string zitiControllerBinaryMd5 = default(string), string zitiControllerBinarySha256 = default(string), string zitiIosEdge = default(string), string zitiCliLinuxBinary = default(string), string zitiVersion = default(string), string zitiRouterLinuxBinary = default(string), string zitiTunnelLinuxBinarySha256 = default(string), string zitiAndroidEdge = default(string), string zitiTunnelLinuxBinaryMd5 = default(string), string zitiCliLinuxBinarySha256 = default(string), bool active = default(bool))
        {
            // to ensure "zitiCliLinuxBinarySha1" is required (not null)
            if (zitiCliLinuxBinarySha1 == null)
            {
                throw new InvalidDataException("zitiCliLinuxBinarySha1 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiCliLinuxBinarySha1 = zitiCliLinuxBinarySha1;
            }
            
            // to ensure "zitiTunnelLinuxBinary" is required (not null)
            if (zitiTunnelLinuxBinary == null)
            {
                throw new InvalidDataException("zitiTunnelLinuxBinary is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiTunnelLinuxBinary = zitiTunnelLinuxBinary;
            }
            
            // to ensure "zitiTunnelLinuxBinarySha1" is required (not null)
            if (zitiTunnelLinuxBinarySha1 == null)
            {
                throw new InvalidDataException("zitiTunnelLinuxBinarySha1 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiTunnelLinuxBinarySha1 = zitiTunnelLinuxBinarySha1;
            }
            
            // to ensure "zitiControllerBinary" is required (not null)
            if (zitiControllerBinary == null)
            {
                throw new InvalidDataException("zitiControllerBinary is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiControllerBinary = zitiControllerBinary;
            }
            
            // to ensure "zitiCliLinuxBinaryMd5" is required (not null)
            if (zitiCliLinuxBinaryMd5 == null)
            {
                throw new InvalidDataException("zitiCliLinuxBinaryMd5 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiCliLinuxBinaryMd5 = zitiCliLinuxBinaryMd5;
            }
            
            // to ensure "zitiRouterLinuxBinarySha1" is required (not null)
            if (zitiRouterLinuxBinarySha1 == null)
            {
                throw new InvalidDataException("zitiRouterLinuxBinarySha1 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiRouterLinuxBinarySha1 = zitiRouterLinuxBinarySha1;
            }
            
            // to ensure "zitiRouterLinuxBinarySha256" is required (not null)
            if (zitiRouterLinuxBinarySha256 == null)
            {
                throw new InvalidDataException("zitiRouterLinuxBinarySha256 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiRouterLinuxBinarySha256 = zitiRouterLinuxBinarySha256;
            }
            
            // to ensure "zitiRouterLinuxBinaryMd5" is required (not null)
            if (zitiRouterLinuxBinaryMd5 == null)
            {
                throw new InvalidDataException("zitiRouterLinuxBinaryMd5 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiRouterLinuxBinaryMd5 = zitiRouterLinuxBinaryMd5;
            }
            
            // to ensure "zitiWindowsDesktopEdge" is required (not null)
            if (zitiWindowsDesktopEdge == null)
            {
                throw new InvalidDataException("zitiWindowsDesktopEdge is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiWindowsDesktopEdge = zitiWindowsDesktopEdge;
            }
            
            // to ensure "zitiMacDesktopEdge" is required (not null)
            if (zitiMacDesktopEdge == null)
            {
                throw new InvalidDataException("zitiMacDesktopEdge is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiMacDesktopEdge = zitiMacDesktopEdge;
            }
            
            // to ensure "zitiControllerBinarySha1" is required (not null)
            if (zitiControllerBinarySha1 == null)
            {
                throw new InvalidDataException("zitiControllerBinarySha1 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiControllerBinarySha1 = zitiControllerBinarySha1;
            }
            
            // to ensure "zitiControllerBinaryMd5" is required (not null)
            if (zitiControllerBinaryMd5 == null)
            {
                throw new InvalidDataException("zitiControllerBinaryMd5 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiControllerBinaryMd5 = zitiControllerBinaryMd5;
            }
            
            // to ensure "zitiControllerBinarySha256" is required (not null)
            if (zitiControllerBinarySha256 == null)
            {
                throw new InvalidDataException("zitiControllerBinarySha256 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiControllerBinarySha256 = zitiControllerBinarySha256;
            }
            
            // to ensure "zitiIosEdge" is required (not null)
            if (zitiIosEdge == null)
            {
                throw new InvalidDataException("zitiIosEdge is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiIosEdge = zitiIosEdge;
            }
            
            // to ensure "zitiCliLinuxBinary" is required (not null)
            if (zitiCliLinuxBinary == null)
            {
                throw new InvalidDataException("zitiCliLinuxBinary is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiCliLinuxBinary = zitiCliLinuxBinary;
            }
            
            // to ensure "zitiVersion" is required (not null)
            if (zitiVersion == null)
            {
                throw new InvalidDataException("zitiVersion is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiVersion = zitiVersion;
            }
            
            // to ensure "zitiRouterLinuxBinary" is required (not null)
            if (zitiRouterLinuxBinary == null)
            {
                throw new InvalidDataException("zitiRouterLinuxBinary is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiRouterLinuxBinary = zitiRouterLinuxBinary;
            }
            
            // to ensure "zitiTunnelLinuxBinarySha256" is required (not null)
            if (zitiTunnelLinuxBinarySha256 == null)
            {
                throw new InvalidDataException("zitiTunnelLinuxBinarySha256 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiTunnelLinuxBinarySha256 = zitiTunnelLinuxBinarySha256;
            }
            
            // to ensure "zitiAndroidEdge" is required (not null)
            if (zitiAndroidEdge == null)
            {
                throw new InvalidDataException("zitiAndroidEdge is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiAndroidEdge = zitiAndroidEdge;
            }
            
            // to ensure "zitiTunnelLinuxBinaryMd5" is required (not null)
            if (zitiTunnelLinuxBinaryMd5 == null)
            {
                throw new InvalidDataException("zitiTunnelLinuxBinaryMd5 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiTunnelLinuxBinaryMd5 = zitiTunnelLinuxBinaryMd5;
            }
            
            // to ensure "zitiCliLinuxBinarySha256" is required (not null)
            if (zitiCliLinuxBinarySha256 == null)
            {
                throw new InvalidDataException("zitiCliLinuxBinarySha256 is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.ZitiCliLinuxBinarySha256 = zitiCliLinuxBinarySha256;
            }
            
            // to ensure "active" is required (not null)
            if (active == null)
            {
                throw new InvalidDataException("active is a required property for InlineResponse20019710 and cannot be null");
            }
            else
            {
                this.Active = active;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets ZitiCliLinuxBinarySha1
        /// </summary>
        [DataMember(Name="zitiCliLinuxBinary.sha-1", EmitDefaultValue=true)]
        public string ZitiCliLinuxBinarySha1 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiTunnelLinuxBinary
        /// </summary>
        [DataMember(Name="zitiTunnelLinuxBinary", EmitDefaultValue=true)]
        public string ZitiTunnelLinuxBinary { get; set; }

        /// <summary>
        /// Gets or Sets ZitiTunnelLinuxBinarySha1
        /// </summary>
        [DataMember(Name="zitiTunnelLinuxBinary.sha-1", EmitDefaultValue=true)]
        public string ZitiTunnelLinuxBinarySha1 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiControllerBinary
        /// </summary>
        [DataMember(Name="zitiControllerBinary", EmitDefaultValue=true)]
        public string ZitiControllerBinary { get; set; }

        /// <summary>
        /// Gets or Sets ZitiCliLinuxBinaryMd5
        /// </summary>
        [DataMember(Name="zitiCliLinuxBinary.md5", EmitDefaultValue=true)]
        public string ZitiCliLinuxBinaryMd5 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiRouterLinuxBinarySha1
        /// </summary>
        [DataMember(Name="zitiRouterLinuxBinary.sha-1", EmitDefaultValue=true)]
        public string ZitiRouterLinuxBinarySha1 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiRouterLinuxBinarySha256
        /// </summary>
        [DataMember(Name="zitiRouterLinuxBinary.sha-256", EmitDefaultValue=true)]
        public string ZitiRouterLinuxBinarySha256 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiRouterLinuxBinaryMd5
        /// </summary>
        [DataMember(Name="zitiRouterLinuxBinary.md5", EmitDefaultValue=true)]
        public string ZitiRouterLinuxBinaryMd5 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiWindowsDesktopEdge
        /// </summary>
        [DataMember(Name="zitiWindowsDesktopEdge", EmitDefaultValue=true)]
        public string ZitiWindowsDesktopEdge { get; set; }

        /// <summary>
        /// Gets or Sets ZitiMacDesktopEdge
        /// </summary>
        [DataMember(Name="zitiMacDesktopEdge", EmitDefaultValue=true)]
        public string ZitiMacDesktopEdge { get; set; }

        /// <summary>
        /// Gets or Sets ZitiControllerBinarySha1
        /// </summary>
        [DataMember(Name="zitiControllerBinary.sha-1", EmitDefaultValue=true)]
        public string ZitiControllerBinarySha1 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiControllerBinaryMd5
        /// </summary>
        [DataMember(Name="zitiControllerBinary.md5", EmitDefaultValue=true)]
        public string ZitiControllerBinaryMd5 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiControllerBinarySha256
        /// </summary>
        [DataMember(Name="zitiControllerBinary.sha-256", EmitDefaultValue=true)]
        public string ZitiControllerBinarySha256 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiIosEdge
        /// </summary>
        [DataMember(Name="zitiIosEdge", EmitDefaultValue=true)]
        public string ZitiIosEdge { get; set; }

        /// <summary>
        /// Gets or Sets ZitiCliLinuxBinary
        /// </summary>
        [DataMember(Name="zitiCliLinuxBinary", EmitDefaultValue=true)]
        public string ZitiCliLinuxBinary { get; set; }

        /// <summary>
        /// Gets or Sets ZitiVersion
        /// </summary>
        [DataMember(Name="zitiVersion", EmitDefaultValue=true)]
        public string ZitiVersion { get; set; }

        /// <summary>
        /// Gets or Sets ZitiRouterLinuxBinary
        /// </summary>
        [DataMember(Name="zitiRouterLinuxBinary", EmitDefaultValue=true)]
        public string ZitiRouterLinuxBinary { get; set; }

        /// <summary>
        /// Gets or Sets ZitiTunnelLinuxBinarySha256
        /// </summary>
        [DataMember(Name="zitiTunnelLinuxBinary.sha-256", EmitDefaultValue=true)]
        public string ZitiTunnelLinuxBinarySha256 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiAndroidEdge
        /// </summary>
        [DataMember(Name="zitiAndroidEdge", EmitDefaultValue=true)]
        public string ZitiAndroidEdge { get; set; }

        /// <summary>
        /// Gets or Sets ZitiTunnelLinuxBinaryMd5
        /// </summary>
        [DataMember(Name="zitiTunnelLinuxBinary.md5", EmitDefaultValue=true)]
        public string ZitiTunnelLinuxBinaryMd5 { get; set; }

        /// <summary>
        /// Gets or Sets ZitiCliLinuxBinarySha256
        /// </summary>
        [DataMember(Name="zitiCliLinuxBinary.sha-256", EmitDefaultValue=true)]
        public string ZitiCliLinuxBinarySha256 { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=true)]
        public bool Active { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20019710 {\n");
            sb.Append("  ZitiCliLinuxBinarySha1: ").Append(ZitiCliLinuxBinarySha1).Append("\n");
            sb.Append("  ZitiTunnelLinuxBinary: ").Append(ZitiTunnelLinuxBinary).Append("\n");
            sb.Append("  ZitiTunnelLinuxBinarySha1: ").Append(ZitiTunnelLinuxBinarySha1).Append("\n");
            sb.Append("  ZitiControllerBinary: ").Append(ZitiControllerBinary).Append("\n");
            sb.Append("  ZitiCliLinuxBinaryMd5: ").Append(ZitiCliLinuxBinaryMd5).Append("\n");
            sb.Append("  ZitiRouterLinuxBinarySha1: ").Append(ZitiRouterLinuxBinarySha1).Append("\n");
            sb.Append("  ZitiRouterLinuxBinarySha256: ").Append(ZitiRouterLinuxBinarySha256).Append("\n");
            sb.Append("  ZitiRouterLinuxBinaryMd5: ").Append(ZitiRouterLinuxBinaryMd5).Append("\n");
            sb.Append("  ZitiWindowsDesktopEdge: ").Append(ZitiWindowsDesktopEdge).Append("\n");
            sb.Append("  ZitiMacDesktopEdge: ").Append(ZitiMacDesktopEdge).Append("\n");
            sb.Append("  ZitiControllerBinarySha1: ").Append(ZitiControllerBinarySha1).Append("\n");
            sb.Append("  ZitiControllerBinaryMd5: ").Append(ZitiControllerBinaryMd5).Append("\n");
            sb.Append("  ZitiControllerBinarySha256: ").Append(ZitiControllerBinarySha256).Append("\n");
            sb.Append("  ZitiIosEdge: ").Append(ZitiIosEdge).Append("\n");
            sb.Append("  ZitiCliLinuxBinary: ").Append(ZitiCliLinuxBinary).Append("\n");
            sb.Append("  ZitiVersion: ").Append(ZitiVersion).Append("\n");
            sb.Append("  ZitiRouterLinuxBinary: ").Append(ZitiRouterLinuxBinary).Append("\n");
            sb.Append("  ZitiTunnelLinuxBinarySha256: ").Append(ZitiTunnelLinuxBinarySha256).Append("\n");
            sb.Append("  ZitiAndroidEdge: ").Append(ZitiAndroidEdge).Append("\n");
            sb.Append("  ZitiTunnelLinuxBinaryMd5: ").Append(ZitiTunnelLinuxBinaryMd5).Append("\n");
            sb.Append("  ZitiCliLinuxBinarySha256: ").Append(ZitiCliLinuxBinarySha256).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(input as InlineResponse20019710);
        }

        /// <summary>
        /// Returns true if InlineResponse20019710 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20019710 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20019710 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ZitiCliLinuxBinarySha1 == input.ZitiCliLinuxBinarySha1 ||
                    (this.ZitiCliLinuxBinarySha1 != null &&
                    this.ZitiCliLinuxBinarySha1.Equals(input.ZitiCliLinuxBinarySha1))
                ) && 
                (
                    this.ZitiTunnelLinuxBinary == input.ZitiTunnelLinuxBinary ||
                    (this.ZitiTunnelLinuxBinary != null &&
                    this.ZitiTunnelLinuxBinary.Equals(input.ZitiTunnelLinuxBinary))
                ) && 
                (
                    this.ZitiTunnelLinuxBinarySha1 == input.ZitiTunnelLinuxBinarySha1 ||
                    (this.ZitiTunnelLinuxBinarySha1 != null &&
                    this.ZitiTunnelLinuxBinarySha1.Equals(input.ZitiTunnelLinuxBinarySha1))
                ) && 
                (
                    this.ZitiControllerBinary == input.ZitiControllerBinary ||
                    (this.ZitiControllerBinary != null &&
                    this.ZitiControllerBinary.Equals(input.ZitiControllerBinary))
                ) && 
                (
                    this.ZitiCliLinuxBinaryMd5 == input.ZitiCliLinuxBinaryMd5 ||
                    (this.ZitiCliLinuxBinaryMd5 != null &&
                    this.ZitiCliLinuxBinaryMd5.Equals(input.ZitiCliLinuxBinaryMd5))
                ) && 
                (
                    this.ZitiRouterLinuxBinarySha1 == input.ZitiRouterLinuxBinarySha1 ||
                    (this.ZitiRouterLinuxBinarySha1 != null &&
                    this.ZitiRouterLinuxBinarySha1.Equals(input.ZitiRouterLinuxBinarySha1))
                ) && 
                (
                    this.ZitiRouterLinuxBinarySha256 == input.ZitiRouterLinuxBinarySha256 ||
                    (this.ZitiRouterLinuxBinarySha256 != null &&
                    this.ZitiRouterLinuxBinarySha256.Equals(input.ZitiRouterLinuxBinarySha256))
                ) && 
                (
                    this.ZitiRouterLinuxBinaryMd5 == input.ZitiRouterLinuxBinaryMd5 ||
                    (this.ZitiRouterLinuxBinaryMd5 != null &&
                    this.ZitiRouterLinuxBinaryMd5.Equals(input.ZitiRouterLinuxBinaryMd5))
                ) && 
                (
                    this.ZitiWindowsDesktopEdge == input.ZitiWindowsDesktopEdge ||
                    (this.ZitiWindowsDesktopEdge != null &&
                    this.ZitiWindowsDesktopEdge.Equals(input.ZitiWindowsDesktopEdge))
                ) && 
                (
                    this.ZitiMacDesktopEdge == input.ZitiMacDesktopEdge ||
                    (this.ZitiMacDesktopEdge != null &&
                    this.ZitiMacDesktopEdge.Equals(input.ZitiMacDesktopEdge))
                ) && 
                (
                    this.ZitiControllerBinarySha1 == input.ZitiControllerBinarySha1 ||
                    (this.ZitiControllerBinarySha1 != null &&
                    this.ZitiControllerBinarySha1.Equals(input.ZitiControllerBinarySha1))
                ) && 
                (
                    this.ZitiControllerBinaryMd5 == input.ZitiControllerBinaryMd5 ||
                    (this.ZitiControllerBinaryMd5 != null &&
                    this.ZitiControllerBinaryMd5.Equals(input.ZitiControllerBinaryMd5))
                ) && 
                (
                    this.ZitiControllerBinarySha256 == input.ZitiControllerBinarySha256 ||
                    (this.ZitiControllerBinarySha256 != null &&
                    this.ZitiControllerBinarySha256.Equals(input.ZitiControllerBinarySha256))
                ) && 
                (
                    this.ZitiIosEdge == input.ZitiIosEdge ||
                    (this.ZitiIosEdge != null &&
                    this.ZitiIosEdge.Equals(input.ZitiIosEdge))
                ) && 
                (
                    this.ZitiCliLinuxBinary == input.ZitiCliLinuxBinary ||
                    (this.ZitiCliLinuxBinary != null &&
                    this.ZitiCliLinuxBinary.Equals(input.ZitiCliLinuxBinary))
                ) && 
                (
                    this.ZitiVersion == input.ZitiVersion ||
                    (this.ZitiVersion != null &&
                    this.ZitiVersion.Equals(input.ZitiVersion))
                ) && 
                (
                    this.ZitiRouterLinuxBinary == input.ZitiRouterLinuxBinary ||
                    (this.ZitiRouterLinuxBinary != null &&
                    this.ZitiRouterLinuxBinary.Equals(input.ZitiRouterLinuxBinary))
                ) && 
                (
                    this.ZitiTunnelLinuxBinarySha256 == input.ZitiTunnelLinuxBinarySha256 ||
                    (this.ZitiTunnelLinuxBinarySha256 != null &&
                    this.ZitiTunnelLinuxBinarySha256.Equals(input.ZitiTunnelLinuxBinarySha256))
                ) && 
                (
                    this.ZitiAndroidEdge == input.ZitiAndroidEdge ||
                    (this.ZitiAndroidEdge != null &&
                    this.ZitiAndroidEdge.Equals(input.ZitiAndroidEdge))
                ) && 
                (
                    this.ZitiTunnelLinuxBinaryMd5 == input.ZitiTunnelLinuxBinaryMd5 ||
                    (this.ZitiTunnelLinuxBinaryMd5 != null &&
                    this.ZitiTunnelLinuxBinaryMd5.Equals(input.ZitiTunnelLinuxBinaryMd5))
                ) && 
                (
                    this.ZitiCliLinuxBinarySha256 == input.ZitiCliLinuxBinarySha256 ||
                    (this.ZitiCliLinuxBinarySha256 != null &&
                    this.ZitiCliLinuxBinarySha256.Equals(input.ZitiCliLinuxBinarySha256))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
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
                if (this.ZitiCliLinuxBinarySha1 != null)
                    hashCode = hashCode * 59 + this.ZitiCliLinuxBinarySha1.GetHashCode();
                if (this.ZitiTunnelLinuxBinary != null)
                    hashCode = hashCode * 59 + this.ZitiTunnelLinuxBinary.GetHashCode();
                if (this.ZitiTunnelLinuxBinarySha1 != null)
                    hashCode = hashCode * 59 + this.ZitiTunnelLinuxBinarySha1.GetHashCode();
                if (this.ZitiControllerBinary != null)
                    hashCode = hashCode * 59 + this.ZitiControllerBinary.GetHashCode();
                if (this.ZitiCliLinuxBinaryMd5 != null)
                    hashCode = hashCode * 59 + this.ZitiCliLinuxBinaryMd5.GetHashCode();
                if (this.ZitiRouterLinuxBinarySha1 != null)
                    hashCode = hashCode * 59 + this.ZitiRouterLinuxBinarySha1.GetHashCode();
                if (this.ZitiRouterLinuxBinarySha256 != null)
                    hashCode = hashCode * 59 + this.ZitiRouterLinuxBinarySha256.GetHashCode();
                if (this.ZitiRouterLinuxBinaryMd5 != null)
                    hashCode = hashCode * 59 + this.ZitiRouterLinuxBinaryMd5.GetHashCode();
                if (this.ZitiWindowsDesktopEdge != null)
                    hashCode = hashCode * 59 + this.ZitiWindowsDesktopEdge.GetHashCode();
                if (this.ZitiMacDesktopEdge != null)
                    hashCode = hashCode * 59 + this.ZitiMacDesktopEdge.GetHashCode();
                if (this.ZitiControllerBinarySha1 != null)
                    hashCode = hashCode * 59 + this.ZitiControllerBinarySha1.GetHashCode();
                if (this.ZitiControllerBinaryMd5 != null)
                    hashCode = hashCode * 59 + this.ZitiControllerBinaryMd5.GetHashCode();
                if (this.ZitiControllerBinarySha256 != null)
                    hashCode = hashCode * 59 + this.ZitiControllerBinarySha256.GetHashCode();
                if (this.ZitiIosEdge != null)
                    hashCode = hashCode * 59 + this.ZitiIosEdge.GetHashCode();
                if (this.ZitiCliLinuxBinary != null)
                    hashCode = hashCode * 59 + this.ZitiCliLinuxBinary.GetHashCode();
                if (this.ZitiVersion != null)
                    hashCode = hashCode * 59 + this.ZitiVersion.GetHashCode();
                if (this.ZitiRouterLinuxBinary != null)
                    hashCode = hashCode * 59 + this.ZitiRouterLinuxBinary.GetHashCode();
                if (this.ZitiTunnelLinuxBinarySha256 != null)
                    hashCode = hashCode * 59 + this.ZitiTunnelLinuxBinarySha256.GetHashCode();
                if (this.ZitiAndroidEdge != null)
                    hashCode = hashCode * 59 + this.ZitiAndroidEdge.GetHashCode();
                if (this.ZitiTunnelLinuxBinaryMd5 != null)
                    hashCode = hashCode * 59 + this.ZitiTunnelLinuxBinaryMd5.GetHashCode();
                if (this.ZitiCliLinuxBinarySha256 != null)
                    hashCode = hashCode * 59 + this.ZitiCliLinuxBinarySha256.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
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