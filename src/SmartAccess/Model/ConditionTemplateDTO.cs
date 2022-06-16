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
    /// ConditionTemplateDTO
    /// </summary>
    [DataContract(Name = "ConditionTemplateDTO")]
    public partial class ConditionTemplateDTO : IEquatable<ConditionTemplateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionTemplateDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConditionTemplateDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionTemplateDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="policyActionTemplateId">policyActionTemplateId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="tenantName">tenantName (required).</param>
        /// <param name="systemName">systemName (required).</param>
        /// <param name="validationType">validationType (required).</param>
        /// <param name="validationParams">validationParams (required).</param>
        /// <param name="pii">pii (required).</param>
        /// <param name="e2eEncrypted">e2eEncrypted (required).</param>
        public ConditionTemplateDTO(string id = default(string), string policyActionTemplateId = default(string), string name = default(string), string tenantName = default(string), string systemName = default(string), string validationType = default(string), string validationParams = default(string), bool pii = default(bool), bool e2eEncrypted = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ConditionTemplateDTO and cannot be null");
            }
            this.Id = id;
            // to ensure "policyActionTemplateId" is required (not null)
            if (policyActionTemplateId == null) {
                throw new ArgumentNullException("policyActionTemplateId is a required property for ConditionTemplateDTO and cannot be null");
            }
            this.PolicyActionTemplateId = policyActionTemplateId;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ConditionTemplateDTO and cannot be null");
            }
            this.Name = name;
            // to ensure "tenantName" is required (not null)
            if (tenantName == null) {
                throw new ArgumentNullException("tenantName is a required property for ConditionTemplateDTO and cannot be null");
            }
            this.TenantName = tenantName;
            // to ensure "systemName" is required (not null)
            if (systemName == null) {
                throw new ArgumentNullException("systemName is a required property for ConditionTemplateDTO and cannot be null");
            }
            this.SystemName = systemName;
            // to ensure "validationType" is required (not null)
            if (validationType == null) {
                throw new ArgumentNullException("validationType is a required property for ConditionTemplateDTO and cannot be null");
            }
            this.ValidationType = validationType;
            // to ensure "validationParams" is required (not null)
            if (validationParams == null) {
                throw new ArgumentNullException("validationParams is a required property for ConditionTemplateDTO and cannot be null");
            }
            this.ValidationParams = validationParams;
            this.Pii = pii;
            this.E2eEncrypted = e2eEncrypted;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PolicyActionTemplateId
        /// </summary>
        [DataMember(Name = "policyActionTemplateId", IsRequired = true, EmitDefaultValue = false)]
        public string PolicyActionTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TenantName
        /// </summary>
        [DataMember(Name = "tenantName", IsRequired = true, EmitDefaultValue = false)]
        public string TenantName { get; set; }

        /// <summary>
        /// Gets or Sets SystemName
        /// </summary>
        [DataMember(Name = "systemName", IsRequired = true, EmitDefaultValue = false)]
        public string SystemName { get; set; }

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
            sb.Append("class ConditionTemplateDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PolicyActionTemplateId: ").Append(PolicyActionTemplateId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TenantName: ").Append(TenantName).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
            sb.Append("  ValidationParams: ").Append(ValidationParams).Append("\n");
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
            return this.Equals(input as ConditionTemplateDTO);
        }

        /// <summary>
        /// Returns true if ConditionTemplateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ConditionTemplateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionTemplateDTO input)
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
                    this.PolicyActionTemplateId == input.PolicyActionTemplateId ||
                    (this.PolicyActionTemplateId != null &&
                    this.PolicyActionTemplateId.Equals(input.PolicyActionTemplateId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TenantName == input.TenantName ||
                    (this.TenantName != null &&
                    this.TenantName.Equals(input.TenantName))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
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
                if (this.PolicyActionTemplateId != null)
                    hashCode = hashCode * 59 + this.PolicyActionTemplateId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TenantName != null)
                    hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.ValidationType != null)
                    hashCode = hashCode * 59 + this.ValidationType.GetHashCode();
                if (this.ValidationParams != null)
                    hashCode = hashCode * 59 + this.ValidationParams.GetHashCode();
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
