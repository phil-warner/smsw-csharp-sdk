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
    /// MessageResponse
    /// </summary>
    [DataContract]
    public partial class MessageResponse :  IEquatable<MessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResponse" /> class.
        /// </summary>
        /// <param name="Batchid">Batchid (required).</param>
        /// <param name="Content">Content (required).</param>
        /// <param name="Created">Created (required).</param>
        /// <param name="Customerid">Customerid (required).</param>
        /// <param name="Destination">Destination (required).</param>
        /// <param name="Keyword">Keyword (required).</param>
        /// <param name="Messageid">Messageid (required).</param>
        /// <param name="Modified">Modified (required).</param>
        /// <param name="Schedule">Schedule (required).</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="Sender">Sender (required).</param>
        /// <param name="Tag">Tag (required).</param>
        public MessageResponse(string Batchid = default(string), string Content = default(string), string Created = default(string), string Customerid = default(string), decimal? Destination = default(decimal?), string Keyword = default(string), string Messageid = default(string), string Modified = default(string), string Schedule = default(string), string Status = default(string), string Sender = default(string), string Tag = default(string))
        {
            // to ensure "Batchid" is required (not null)
            if (Batchid == null)
            {
                throw new InvalidDataException("Batchid is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Batchid = Batchid;
            }
            // to ensure "Content" is required (not null)
            if (Content == null)
            {
                throw new InvalidDataException("Content is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Content = Content;
            }
            // to ensure "Created" is required (not null)
            if (Created == null)
            {
                throw new InvalidDataException("Created is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Created = Created;
            }
            // to ensure "Customerid" is required (not null)
            if (Customerid == null)
            {
                throw new InvalidDataException("Customerid is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Customerid = Customerid;
            }
            // to ensure "Destination" is required (not null)
            if (Destination == null)
            {
                throw new InvalidDataException("Destination is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Destination = Destination;
            }
            // to ensure "Keyword" is required (not null)
            if (Keyword == null)
            {
                throw new InvalidDataException("Keyword is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Keyword = Keyword;
            }
            // to ensure "Messageid" is required (not null)
            if (Messageid == null)
            {
                throw new InvalidDataException("Messageid is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Messageid = Messageid;
            }
            // to ensure "Modified" is required (not null)
            if (Modified == null)
            {
                throw new InvalidDataException("Modified is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Modified = Modified;
            }
            // to ensure "Schedule" is required (not null)
            if (Schedule == null)
            {
                throw new InvalidDataException("Schedule is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Schedule = Schedule;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Sender" is required (not null)
            if (Sender == null)
            {
                throw new InvalidDataException("Sender is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Sender = Sender;
            }
            // to ensure "Tag" is required (not null)
            if (Tag == null)
            {
                throw new InvalidDataException("Tag is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Tag = Tag;
            }
        }
        
        /// <summary>
        /// Gets or Sets Batchid
        /// </summary>
        [DataMember(Name="batchid", EmitDefaultValue=false)]
        public string Batchid { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Customerid
        /// </summary>
        [DataMember(Name="customerid", EmitDefaultValue=false)]
        public string Customerid { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public decimal? Destination { get; set; }

        /// <summary>
        /// Gets or Sets Keyword
        /// </summary>
        [DataMember(Name="keyword", EmitDefaultValue=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// Gets or Sets Messageid
        /// </summary>
        [DataMember(Name="messageid", EmitDefaultValue=false)]
        public string Messageid { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public string Modified { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageResponse {\n");
            sb.Append("  Batchid: ").Append(Batchid).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Customerid: ").Append(Customerid).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
            sb.Append("  Messageid: ").Append(Messageid).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(obj as MessageResponse);
        }

        /// <summary>
        /// Returns true if MessageResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageResponse other)
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
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Customerid == other.Customerid ||
                    this.Customerid != null &&
                    this.Customerid.Equals(other.Customerid)
                ) && 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) && 
                (
                    this.Keyword == other.Keyword ||
                    this.Keyword != null &&
                    this.Keyword.Equals(other.Keyword)
                ) && 
                (
                    this.Messageid == other.Messageid ||
                    this.Messageid != null &&
                    this.Messageid.Equals(other.Messageid)
                ) && 
                (
                    this.Modified == other.Modified ||
                    this.Modified != null &&
                    this.Modified.Equals(other.Modified)
                ) && 
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Sender == other.Sender ||
                    this.Sender != null &&
                    this.Sender.Equals(other.Sender)
                ) && 
                (
                    this.Tag == other.Tag ||
                    this.Tag != null &&
                    this.Tag.Equals(other.Tag)
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
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Customerid != null)
                    hash = hash * 59 + this.Customerid.GetHashCode();
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                if (this.Keyword != null)
                    hash = hash * 59 + this.Keyword.GetHashCode();
                if (this.Messageid != null)
                    hash = hash * 59 + this.Messageid.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Sender != null)
                    hash = hash * 59 + this.Sender.GetHashCode();
                if (this.Tag != null)
                    hash = hash * 59 + this.Tag.GetHashCode();
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
