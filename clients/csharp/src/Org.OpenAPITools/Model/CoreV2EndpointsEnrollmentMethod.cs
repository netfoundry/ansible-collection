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
    /// CoreV2EndpointsEnrollmentMethod
    /// </summary>
    [DataContract]
    public partial class CoreV2EndpointsEnrollmentMethod :  IEquatable<CoreV2EndpointsEnrollmentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreV2EndpointsEnrollmentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CoreV2EndpointsEnrollmentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreV2EndpointsEnrollmentMethod" /> class.
        /// </summary>
        /// <param name="ott">ott (required).</param>
        public CoreV2EndpointsEnrollmentMethod(bool ott = default(bool))
        {
            // to ensure "ott" is required (not null)
            if (ott == null)
            {
                throw new InvalidDataException("ott is a required property for CoreV2EndpointsEnrollmentMethod and cannot be null");
            }
            else
            {
                this.Ott = ott;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets Ott
        /// </summary>
        [DataMember(Name="ott", EmitDefaultValue=true)]
        public bool Ott { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoreV2EndpointsEnrollmentMethod {\n");
            sb.Append("  Ott: ").Append(Ott).Append("\n");
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
            return this.Equals(input as CoreV2EndpointsEnrollmentMethod);
        }

        /// <summary>
        /// Returns true if CoreV2EndpointsEnrollmentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of CoreV2EndpointsEnrollmentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoreV2EndpointsEnrollmentMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ott == input.Ott ||
                    (this.Ott != null &&
                    this.Ott.Equals(input.Ott))
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
                if (this.Ott != null)
                    hashCode = hashCode * 59 + this.Ott.GetHashCode();
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