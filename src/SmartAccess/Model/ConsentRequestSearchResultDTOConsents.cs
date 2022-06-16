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
    /// ConsentRequestSearchResultDTOConsents
    /// </summary>
    [DataContract(Name = "ConsentRequestSearchResultDTO_consents")]
    public partial class ConsentRequestSearchResultDTOConsents : IEquatable<ConsentRequestSearchResultDTOConsents>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public ConsentType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentRequestSearchResultDTOConsents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsentRequestSearchResultDTOConsents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentRequestSearchResultDTOConsents" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">id (required).</param>
        public ConsentRequestSearchResultDTOConsents(ConsentType type = default(ConsentType), string id = default(string))
        {
            this.Type = type;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ConsentRequestSearchResultDTOConsents and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsentRequestSearchResultDTOConsents {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ConsentRequestSearchResultDTOConsents);
        }

        /// <summary>
        /// Returns true if ConsentRequestSearchResultDTOConsents instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsentRequestSearchResultDTOConsents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsentRequestSearchResultDTOConsents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
