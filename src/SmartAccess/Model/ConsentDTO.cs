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
    /// An approved consent, given by the person referenced by Legal Entity. Points to the corresponding (Authorization) Policy that this consent gives right to.
    /// </summary>
    [DataContract(Name = "ConsentDTO")]
    public partial class ConsentDTO : IEquatable<ConsentDTO>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public ConsentType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsentDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="legalEntity">legalEntity.</param>
        /// <param name="policy">policy.</param>
        public ConsentDTO(string id = default(string), ConsentType type = default(ConsentType), LegalEntityDTO legalEntity = default(LegalEntityDTO), List<PolicyDTO> policy = default(List<PolicyDTO>))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ConsentDTO and cannot be null");
            }
            this.Id = id;
            this.Type = type;
            this.LegalEntity = legalEntity;
            this.Policy = policy;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LegalEntity
        /// </summary>
        [DataMember(Name = "legalEntity", EmitDefaultValue = false)]
        public LegalEntityDTO LegalEntity { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public List<PolicyDTO> Policy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsentDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LegalEntity: ").Append(LegalEntity).Append("\n");
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
            return this.Equals(input as ConsentDTO);
        }

        /// <summary>
        /// Returns true if ConsentDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsentDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsentDTO input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.LegalEntity == input.LegalEntity ||
                    (this.LegalEntity != null &&
                    this.LegalEntity.Equals(input.LegalEntity))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LegalEntity != null)
                    hashCode = hashCode * 59 + this.LegalEntity.GetHashCode();
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
