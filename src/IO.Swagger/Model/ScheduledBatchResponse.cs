/* 
 * The SMS Works API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    /// ScheduledBatchResponse
    /// </summary>
    [DataContract]
    public partial class ScheduledBatchResponse :  IEquatable<ScheduledBatchResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledBatchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduledBatchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledBatchResponse" /> class.
        /// </summary>
        /// <param name="Batchid">Batchid (required).</param>
        /// <param name="Status">Status (required).</param>
        public ScheduledBatchResponse(string Batchid = default(string), string Status = default(string))
        {
            // to ensure "Batchid" is required (not null)
            if (Batchid == null)
            {
                throw new InvalidDataException("Batchid is a required property for ScheduledBatchResponse and cannot be null");
            }
            else
            {
                this.Batchid = Batchid;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for ScheduledBatchResponse and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
        }
        
        /// <summary>
        /// Gets or Sets Batchid
        /// </summary>
        [DataMember(Name="batchid", EmitDefaultValue=false)]
        public string Batchid { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledBatchResponse {\n");
            sb.Append("  Batchid: ").Append(Batchid).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ScheduledBatchResponse);
        }

        /// <summary>
        /// Returns true if ScheduledBatchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduledBatchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledBatchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Batchid == other.Batchid ||
                    this.Batchid != null &&
                    this.Batchid.Equals(other.Batchid)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Batchid != null)
                    hash = hash * 59 + this.Batchid.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
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
