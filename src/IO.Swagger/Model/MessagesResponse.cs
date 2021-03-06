/* 
 * The SMS Works API
 *
 * The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed messages are refunded.
 *
 * OpenAPI spec version: 1.1.0
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
    /// MessagesResponse
    /// </summary>
    [DataContract]
    public partial class MessagesResponse :  IEquatable<MessagesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResponse" /> class.
        /// </summary>
        /// <param name="Messages">Messages (required).</param>
        public MessagesResponse(MessagesResponseMessages Messages = default(MessagesResponseMessages))
        {
            // to ensure "Messages" is required (not null)
            if (Messages == null)
            {
                throw new InvalidDataException("Messages is a required property for MessagesResponse and cannot be null");
            }
            else
            {
                this.Messages = Messages;
            }
        }
        
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public MessagesResponseMessages Messages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagesResponse {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return this.Equals(input as MessagesResponse);
        }

        /// <summary>
        /// Returns true if MessagesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MessagesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Messages == input.Messages ||
                    (this.Messages != null &&
                    this.Messages.Equals(input.Messages))
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
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
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
