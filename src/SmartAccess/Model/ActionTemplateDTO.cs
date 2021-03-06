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
    /// ActionTemplateDTO
    /// </summary>
    [DataContract(Name = "ActionTemplateDTO")]
    public partial class ActionTemplateDTO : IEquatable<ActionTemplateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionTemplateDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionTemplateDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionTemplateDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="serviceProviderId">serviceProviderId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="tenantName">tenantName (required).</param>
        /// <param name="systemName">systemName (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="resourceTemplates">resourceTemplates (required).</param>
        /// <param name="conditionTemplates">conditionTemplates (required).</param>
        public ActionTemplateDTO(string id = default(string), string serviceProviderId = default(string), string name = default(string), string description = default(string), double version = default(double), string tenantName = default(string), string systemName = default(string), string status = default(string), List<ResourceTemplateDTO> resourceTemplates = default(List<ResourceTemplateDTO>), List<ConditionTemplateDTO> conditionTemplates = default(List<ConditionTemplateDTO>))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ActionTemplateDTO and cannot be null");
            }
            this.Id = id;
            // to ensure "serviceProviderId" is required (not null)
            if (serviceProviderId == null) {
                throw new ArgumentNullException("serviceProviderId is a required property for ActionTemplateDTO and cannot be null");
            }
            this.ServiceProviderId = serviceProviderId;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ActionTemplateDTO and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null) {
                throw new ArgumentNullException("description is a required property for ActionTemplateDTO and cannot be null");
            }
            this.Description = description;
            this._Version = version;
            // to ensure "tenantName" is required (not null)
            if (tenantName == null) {
                throw new ArgumentNullException("tenantName is a required property for ActionTemplateDTO and cannot be null");
            }
            this.TenantName = tenantName;
            // to ensure "systemName" is required (not null)
            if (systemName == null) {
                throw new ArgumentNullException("systemName is a required property for ActionTemplateDTO and cannot be null");
            }
            this.SystemName = systemName;
            // to ensure "status" is required (not null)
            if (status == null) {
                throw new ArgumentNullException("status is a required property for ActionTemplateDTO and cannot be null");
            }
            this.Status = status;
            // to ensure "resourceTemplates" is required (not null)
            if (resourceTemplates == null) {
                throw new ArgumentNullException("resourceTemplates is a required property for ActionTemplateDTO and cannot be null");
            }
            this.ResourceTemplates = resourceTemplates;
            // to ensure "conditionTemplates" is required (not null)
            if (conditionTemplates == null) {
                throw new ArgumentNullException("conditionTemplates is a required property for ActionTemplateDTO and cannot be null");
            }
            this.ConditionTemplates = conditionTemplates;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ServiceProviderId
        /// </summary>
        [DataMember(Name = "serviceProviderId", IsRequired = true, EmitDefaultValue = false)]
        public string ServiceProviderId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public double _Version { get; set; }

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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ResourceTemplates
        /// </summary>
        [DataMember(Name = "resourceTemplates", IsRequired = true, EmitDefaultValue = false)]
        public List<ResourceTemplateDTO> ResourceTemplates { get; set; }

        /// <summary>
        /// Gets or Sets ConditionTemplates
        /// </summary>
        [DataMember(Name = "conditionTemplates", IsRequired = true, EmitDefaultValue = false)]
        public List<ConditionTemplateDTO> ConditionTemplates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionTemplateDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceProviderId: ").Append(ServiceProviderId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  TenantName: ").Append(TenantName).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ResourceTemplates: ").Append(ResourceTemplates).Append("\n");
            sb.Append("  ConditionTemplates: ").Append(ConditionTemplates).Append("\n");
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
            return this.Equals(input as ActionTemplateDTO);
        }

        /// <summary>
        /// Returns true if ActionTemplateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionTemplateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionTemplateDTO input)
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
                    this.ServiceProviderId == input.ServiceProviderId ||
                    (this.ServiceProviderId != null &&
                    this.ServiceProviderId.Equals(input.ServiceProviderId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ResourceTemplates == input.ResourceTemplates ||
                    this.ResourceTemplates != null &&
                    input.ResourceTemplates != null &&
                    this.ResourceTemplates.SequenceEqual(input.ResourceTemplates)
                ) && 
                (
                    this.ConditionTemplates == input.ConditionTemplates ||
                    this.ConditionTemplates != null &&
                    input.ConditionTemplates != null &&
                    this.ConditionTemplates.SequenceEqual(input.ConditionTemplates)
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
                if (this.ServiceProviderId != null)
                    hashCode = hashCode * 59 + this.ServiceProviderId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.TenantName != null)
                    hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ResourceTemplates != null)
                    hashCode = hashCode * 59 + this.ResourceTemplates.GetHashCode();
                if (this.ConditionTemplates != null)
                    hashCode = hashCode * 59 + this.ConditionTemplates.GetHashCode();
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
