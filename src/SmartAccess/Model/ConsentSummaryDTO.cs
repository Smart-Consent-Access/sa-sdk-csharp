/*
 * @ao/ah-api
 *
 * Telia Smart Access API
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = SmartAccess.Client.OpenAPIDateConverter;

namespace SmartAccess.Model
{
    /// <summary>
    /// ConsentSummaryDTO
    /// </summary>
    [DataContract(Name = "ConsentSummaryDTO")]
    public partial class ConsentSummaryDTO : IEquatable<ConsentSummaryDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentSummaryDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsentSummaryDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentSummaryDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="consPrincipalId">consPrincipalId (required).</param>
        /// <param name="consPrincipalName">consPrincipalName (required).</param>
        /// <param name="policy">policy.</param>
        public ConsentSummaryDTO(string id = default(string), string consPrincipalId = default(string), string consPrincipalName = default(string), List<PolicySummaryDTO> policy = default(List<PolicySummaryDTO>))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ConsentSummaryDTO and cannot be null");
            }
            this.Id = id;
            // to ensure "consPrincipalId" is required (not null)
            if (consPrincipalId == null) {
                throw new ArgumentNullException("consPrincipalId is a required property for ConsentSummaryDTO and cannot be null");
            }
            this.ConsPrincipalId = consPrincipalId;
            // to ensure "consPrincipalName" is required (not null)
            if (consPrincipalName == null) {
                throw new ArgumentNullException("consPrincipalName is a required property for ConsentSummaryDTO and cannot be null");
            }
            this.ConsPrincipalName = consPrincipalName;
            this.Policy = policy;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ConsPrincipalId
        /// </summary>
        [DataMember(Name = "consPrincipalId", IsRequired = true, EmitDefaultValue = false)]
        public string ConsPrincipalId { get; set; }

        /// <summary>
        /// Gets or Sets ConsPrincipalName
        /// </summary>
        [DataMember(Name = "consPrincipalName", IsRequired = true, EmitDefaultValue = false)]
        public string ConsPrincipalName { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public List<PolicySummaryDTO> Policy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsentSummaryDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConsPrincipalId: ").Append(ConsPrincipalId).Append("\n");
            sb.Append("  ConsPrincipalName: ").Append(ConsPrincipalName).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsentSummaryDTO);
        }

        /// <summary>
        /// Returns true if ConsentSummaryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsentSummaryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsentSummaryDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ConsPrincipalId == input.ConsPrincipalId ||
                    (this.ConsPrincipalId != null &&
                    this.ConsPrincipalId.Equals(input.ConsPrincipalId))
                ) && 
                (
                    this.ConsPrincipalName == input.ConsPrincipalName ||
                    (this.ConsPrincipalName != null &&
                    this.ConsPrincipalName.Equals(input.ConsPrincipalName))
                ) && 
                (
                    this.Policy == input.Policy ||
                    this.Policy != null &&
                    input.Policy != null &&
                    this.Policy.SequenceEqual(input.Policy)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ConsPrincipalId != null)
                    hashCode = hashCode * 59 + this.ConsPrincipalId.GetHashCode();
                if (this.ConsPrincipalName != null)
                    hashCode = hashCode * 59 + this.ConsPrincipalName.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
