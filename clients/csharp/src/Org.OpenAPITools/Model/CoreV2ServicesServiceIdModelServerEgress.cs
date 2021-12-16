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
    /// CoreV2ServicesServiceIdModelServerEgress
    /// </summary>
    [DataContract]
    public partial class CoreV2ServicesServiceIdModelServerEgress :  IEquatable<CoreV2ServicesServiceIdModelServerEgress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreV2ServicesServiceIdModelServerEgress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CoreV2ServicesServiceIdModelServerEgress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreV2ServicesServiceIdModelServerEgress" /> class.
        /// </summary>
        /// <param name="dialInterceptAddress">dialInterceptAddress (required).</param>
        /// <param name="dialInterceptPort">dialInterceptPort (required).</param>
        /// <param name="port">port (required).</param>
        /// <param name="dialInterceptProtocol">dialInterceptProtocol (required).</param>
        /// <param name="address">address (required).</param>
        /// <param name="protocol">protocol (required).</param>
        public CoreV2ServicesServiceIdModelServerEgress(AnyType dialInterceptAddress = default(AnyType), AnyType dialInterceptPort = default(AnyType), decimal port = default(decimal), bool dialInterceptProtocol = default(bool), string address = default(string), AnyType protocol = default(AnyType))
        {
            // to ensure "dialInterceptAddress" is required (not null)
            if (dialInterceptAddress == null)
            {
                throw new InvalidDataException("dialInterceptAddress is a required property for CoreV2ServicesServiceIdModelServerEgress and cannot be null");
            }
            else
            {
                this.DialInterceptAddress = dialInterceptAddress;
            }
            
            // to ensure "dialInterceptPort" is required (not null)
            if (dialInterceptPort == null)
            {
                throw new InvalidDataException("dialInterceptPort is a required property for CoreV2ServicesServiceIdModelServerEgress and cannot be null");
            }
            else
            {
                this.DialInterceptPort = dialInterceptPort;
            }
            
            // to ensure "port" is required (not null)
            if (port == null)
            {
                throw new InvalidDataException("port is a required property for CoreV2ServicesServiceIdModelServerEgress and cannot be null");
            }
            else
            {
                this.Port = port;
            }
            
            // to ensure "dialInterceptProtocol" is required (not null)
            if (dialInterceptProtocol == null)
            {
                throw new InvalidDataException("dialInterceptProtocol is a required property for CoreV2ServicesServiceIdModelServerEgress and cannot be null");
            }
            else
            {
                this.DialInterceptProtocol = dialInterceptProtocol;
            }
            
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for CoreV2ServicesServiceIdModelServerEgress and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            
            // to ensure "protocol" is required (not null)
            if (protocol == null)
            {
                throw new InvalidDataException("protocol is a required property for CoreV2ServicesServiceIdModelServerEgress and cannot be null");
            }
            else
            {
                this.Protocol = protocol;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets DialInterceptAddress
        /// </summary>
        [DataMember(Name="dialInterceptAddress", EmitDefaultValue=true)]
        public AnyType DialInterceptAddress { get; set; }

        /// <summary>
        /// Gets or Sets DialInterceptPort
        /// </summary>
        [DataMember(Name="dialInterceptPort", EmitDefaultValue=true)]
        public AnyType DialInterceptPort { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public decimal Port { get; set; }

        /// <summary>
        /// Gets or Sets DialInterceptProtocol
        /// </summary>
        [DataMember(Name="dialInterceptProtocol", EmitDefaultValue=true)]
        public bool DialInterceptProtocol { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name="protocol", EmitDefaultValue=true)]
        public AnyType Protocol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoreV2ServicesServiceIdModelServerEgress {\n");
            sb.Append("  DialInterceptAddress: ").Append(DialInterceptAddress).Append("\n");
            sb.Append("  DialInterceptPort: ").Append(DialInterceptPort).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  DialInterceptProtocol: ").Append(DialInterceptProtocol).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
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
            return this.Equals(input as CoreV2ServicesServiceIdModelServerEgress);
        }

        /// <summary>
        /// Returns true if CoreV2ServicesServiceIdModelServerEgress instances are equal
        /// </summary>
        /// <param name="input">Instance of CoreV2ServicesServiceIdModelServerEgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoreV2ServicesServiceIdModelServerEgress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DialInterceptAddress == input.DialInterceptAddress ||
                    (this.DialInterceptAddress != null &&
                    this.DialInterceptAddress.Equals(input.DialInterceptAddress))
                ) && 
                (
                    this.DialInterceptPort == input.DialInterceptPort ||
                    (this.DialInterceptPort != null &&
                    this.DialInterceptPort.Equals(input.DialInterceptPort))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.DialInterceptProtocol == input.DialInterceptProtocol ||
                    (this.DialInterceptProtocol != null &&
                    this.DialInterceptProtocol.Equals(input.DialInterceptProtocol))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
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
                if (this.DialInterceptAddress != null)
                    hashCode = hashCode * 59 + this.DialInterceptAddress.GetHashCode();
                if (this.DialInterceptPort != null)
                    hashCode = hashCode * 59 + this.DialInterceptPort.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.DialInterceptProtocol != null)
                    hashCode = hashCode * 59 + this.DialInterceptProtocol.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
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