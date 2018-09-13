/* 
 * The SMS Works API
 *
 * The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed messages are refunded.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// MessageResponseFailurereason
    /// </summary>
    [DataContract]
    public partial class MessageResponseFailurereason :  IEquatable<MessageResponseFailurereason>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResponseFailurereason" /> class.
        /// </summary>
        /// <param name="Code">Code.</param>
        /// <param name="Details">Details.</param>
        /// <param name="Permanent">Permanent.</param>
        public MessageResponseFailurereason(decimal? Code = default(decimal?), string Details = default(string), bool? Permanent = default(bool?))
        {
            this.Code = Code;
            this.Details = Details;
            this.Permanent = Permanent;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public decimal? Code { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets Permanent
        /// </summary>
        [DataMember(Name="permanent", EmitDefaultValue=false)]
        public bool? Permanent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageResponseFailurereason {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Permanent: ").Append(Permanent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as MessageResponseFailurereason);
        }

        /// <summary>
        /// Returns true if MessageResponseFailurereason instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageResponseFailurereason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageResponseFailurereason input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Permanent == input.Permanent ||
                    (this.Permanent != null &&
                    this.Permanent.Equals(input.Permanent))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Permanent != null)
                    hashCode = hashCode * 59 + this.Permanent.GetHashCode();
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