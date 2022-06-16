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
    /// ResourceTagTemplateDTO
    /// </summary>
    [DataContract(Name = "ResourceTagTemplateDTO")]
    public partial class ResourceTagTemplateDTO : IEquatable<ResourceTagTemplateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceTagTemplateDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceTagTemplateDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceTagTemplateDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="policyResourceTemplateId">policyResourceTemplateId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="validationType">validationType (required).</param>
        /// <param name="validationParams">validationParams (required).</param>
        /// <param name="ordno">ordno (required).</param>
        /// <param name="pii">pii (required).</param>
        /// <param name="e2eEncrypted">e2eEncrypted (required).</param>
        public ResourceTagTemplateDTO(string id = default(string), string policyResourceTemplateId = default(string), string name = default(string), string validationType = default(string), string validationParams = default(string), double ordno = default(double), bool pii = default(bool), bool e2eEncrypted = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ResourceTagTemplateDTO and cannot be null");
            }
            this.Id = id;
            // to ensure "policyResourceTemplateId" is required (not null)
            if (policyResourceTemplateId == null) {
                throw new ArgumentNullException("policyResourceTemplateId is a required property for ResourceTagTemplateDTO and cannot be null");
            }
            this.PolicyResourceTemplateId = policyResourceTemplateId;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ResourceTagTemplateDTO and cannot be null");
            }
            this.Name = name;
            // to ensure "validationType" is required (not null)
            if (validationType == null) {
                throw new ArgumentNullException("validationType is a required property for ResourceTagTemplateDTO and cannot be null");
            }
            this.ValidationType = validationType;
            // to ensure "validationParams" is required (not null)
            if (validationParams == null) {
                throw new ArgumentNullException("validationParams is a required property for ResourceTagTemplateDTO and cannot be null");
            }
            this.ValidationParams = validationParams;
            this.Ordno = ordno;
            this.Pii = pii;
            this.E2eEncrypted = e2eEncrypted;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PolicyResourceTemplateId
        /// </summary>
        [DataMember(Name = "policyResourceTemplateId", IsRequired = true, EmitDefaultValue = false)]
        public string PolicyResourceTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ValidationType
        /// </summary>
        [DataMember(Name = "validationType", IsRequired = true, EmitDefaultValue = false)]
        public string ValidationType { get; set; }

        /// <summary>
        /// Gets or Sets ValidationParams
        /// </summary>
        [DataMember(Name = "validationParams", IsRequired = true, EmitDefaultValue = false)]
        public string ValidationParams { get; set; }

        /// <summary>
        /// Gets or Sets Ordno
        /// </summary>
        [DataMember(Name = "ordno", IsRequired = true, EmitDefaultValue = false)]
        public double Ordno { get; set; }

        /// <summary>
        /// Gets or Sets Pii
        /// </summary>
        [DataMember(Name = "pii", IsRequired = true, EmitDefaultValue = true)]
        public bool Pii { get; set; }

        /// <summary>
        /// Gets or Sets E2eEncrypted
        /// </summary>
        [DataMember(Name = "e2eEncrypted", IsRequired = true, EmitDefaultValue = true)]
        public bool E2eEncrypted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceTagTemplateDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PolicyResourceTemplateId: ").Append(PolicyResourceTemplateId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
            sb.Append("  ValidationParams: ").Append(ValidationParams).Append("\n");
            sb.Append("  Ordno: ").Append(Ordno).Append("\n");
            sb.Append("  Pii: ").Append(Pii).Append("\n");
            sb.Append("  E2eEncrypted: ").Append(E2eEncrypted).Append("\n");
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
            return this.Equals(input as ResourceTagTemplateDTO);
        }

        /// <summary>
        /// Returns true if ResourceTagTemplateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceTagTemplateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceTagTemplateDTO input)
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
                    this.PolicyResourceTemplateId == input.PolicyResourceTemplateId ||
                    (this.PolicyResourceTemplateId != null &&
                    this.PolicyResourceTemplateId.Equals(input.PolicyResourceTemplateId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ValidationType == input.ValidationType ||
                    (this.ValidationType != null &&
                    this.ValidationType.Equals(input.ValidationType))
                ) && 
                (
                    this.ValidationParams == input.ValidationParams ||
                    (this.ValidationParams != null &&
                    this.ValidationParams.Equals(input.ValidationParams))
                ) && 
                (
                    this.Ordno == input.Ordno ||
                    this.Ordno.Equals(input.Ordno)
                ) && 
                (
                    this.Pii == input.Pii ||
                    this.Pii.Equals(input.Pii)
                ) && 
                (
                    this.E2eEncrypted == input.E2eEncrypted ||
                    this.E2eEncrypted.Equals(input.E2eEncrypted)
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
                if (this.PolicyResourceTemplateId != null)
                    hashCode = hashCode * 59 + this.PolicyResourceTemplateId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ValidationType != null)
                    hashCode = hashCode * 59 + this.ValidationType.GetHashCode();
                if (this.ValidationParams != null)
                    hashCode = hashCode * 59 + this.ValidationParams.GetHashCode();
                hashCode = hashCode * 59 + this.Ordno.GetHashCode();
                hashCode = hashCode * 59 + this.Pii.GetHashCode();
                hashCode = hashCode * 59 + this.E2eEncrypted.GetHashCode();
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
