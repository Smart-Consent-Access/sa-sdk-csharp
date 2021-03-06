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
    /// ServiceProviderDTO
    /// </summary>
    [DataContract(Name = "ServiceProviderDTO")]
    public partial class ServiceProviderDTO : IEquatable<ServiceProviderDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceProviderDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="iconUrl">iconUrl (required).</param>
        /// <param name="publicKey">publicKey (required).</param>
        /// <param name="initiateConsentRequestUrl">initiateConsentRequestUrl (required).</param>
        /// <param name="finalizeConsentRequestUrl">finalizeConsentRequestUrl (required).</param>
        /// <param name="initiateConsentUrl">initiateConsentUrl (required).</param>
        /// <param name="finalizeConsentUrl">finalizeConsentUrl (required).</param>
        /// <param name="allowUndefinedActions">allowUndefinedActions (required).</param>
        public ServiceProviderDTO(string id = default(string), string name = default(string), string iconUrl = default(string), string publicKey = default(string), string initiateConsentRequestUrl = default(string), string finalizeConsentRequestUrl = default(string), string initiateConsentUrl = default(string), string finalizeConsentUrl = default(string), bool allowUndefinedActions = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ServiceProviderDTO and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ServiceProviderDTO and cannot be null");
            }
            this.Name = name;
            // to ensure "iconUrl" is required (not null)
            if (iconUrl == null) {
                throw new ArgumentNullException("iconUrl is a required property for ServiceProviderDTO and cannot be null");
            }
            this.IconUrl = iconUrl;
            // to ensure "publicKey" is required (not null)
            if (publicKey == null) {
                throw new ArgumentNullException("publicKey is a required property for ServiceProviderDTO and cannot be null");
            }
            this.PublicKey = publicKey;
            // to ensure "initiateConsentRequestUrl" is required (not null)
            if (initiateConsentRequestUrl == null) {
                throw new ArgumentNullException("initiateConsentRequestUrl is a required property for ServiceProviderDTO and cannot be null");
            }
            this.InitiateConsentRequestUrl = initiateConsentRequestUrl;
            // to ensure "finalizeConsentRequestUrl" is required (not null)
            if (finalizeConsentRequestUrl == null) {
                throw new ArgumentNullException("finalizeConsentRequestUrl is a required property for ServiceProviderDTO and cannot be null");
            }
            this.FinalizeConsentRequestUrl = finalizeConsentRequestUrl;
            // to ensure "initiateConsentUrl" is required (not null)
            if (initiateConsentUrl == null) {
                throw new ArgumentNullException("initiateConsentUrl is a required property for ServiceProviderDTO and cannot be null");
            }
            this.InitiateConsentUrl = initiateConsentUrl;
            // to ensure "finalizeConsentUrl" is required (not null)
            if (finalizeConsentUrl == null) {
                throw new ArgumentNullException("finalizeConsentUrl is a required property for ServiceProviderDTO and cannot be null");
            }
            this.FinalizeConsentUrl = finalizeConsentUrl;
            this.AllowUndefinedActions = allowUndefinedActions;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name = "iconUrl", IsRequired = true, EmitDefaultValue = false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [DataMember(Name = "publicKey", IsRequired = true, EmitDefaultValue = false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or Sets InitiateConsentRequestUrl
        /// </summary>
        [DataMember(Name = "initiateConsentRequestUrl", IsRequired = true, EmitDefaultValue = true)]
        public string InitiateConsentRequestUrl { get; set; }

        /// <summary>
        /// Gets or Sets FinalizeConsentRequestUrl
        /// </summary>
        [DataMember(Name = "finalizeConsentRequestUrl", IsRequired = true, EmitDefaultValue = true)]
        public string FinalizeConsentRequestUrl { get; set; }

        /// <summary>
        /// Gets or Sets InitiateConsentUrl
        /// </summary>
        [DataMember(Name = "initiateConsentUrl", IsRequired = true, EmitDefaultValue = true)]
        public string InitiateConsentUrl { get; set; }

        /// <summary>
        /// Gets or Sets FinalizeConsentUrl
        /// </summary>
        [DataMember(Name = "finalizeConsentUrl", IsRequired = true, EmitDefaultValue = true)]
        public string FinalizeConsentUrl { get; set; }

        /// <summary>
        /// Gets or Sets AllowUndefinedActions
        /// </summary>
        [DataMember(Name = "allowUndefinedActions", IsRequired = true, EmitDefaultValue = true)]
        public bool AllowUndefinedActions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceProviderDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  InitiateConsentRequestUrl: ").Append(InitiateConsentRequestUrl).Append("\n");
            sb.Append("  FinalizeConsentRequestUrl: ").Append(FinalizeConsentRequestUrl).Append("\n");
            sb.Append("  InitiateConsentUrl: ").Append(InitiateConsentUrl).Append("\n");
            sb.Append("  FinalizeConsentUrl: ").Append(FinalizeConsentUrl).Append("\n");
            sb.Append("  AllowUndefinedActions: ").Append(AllowUndefinedActions).Append("\n");
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
            return this.Equals(input as ServiceProviderDTO);
        }

        /// <summary>
        /// Returns true if ServiceProviderDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceProviderDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceProviderDTO input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.InitiateConsentRequestUrl == input.InitiateConsentRequestUrl ||
                    (this.InitiateConsentRequestUrl != null &&
                    this.InitiateConsentRequestUrl.Equals(input.InitiateConsentRequestUrl))
                ) && 
                (
                    this.FinalizeConsentRequestUrl == input.FinalizeConsentRequestUrl ||
                    (this.FinalizeConsentRequestUrl != null &&
                    this.FinalizeConsentRequestUrl.Equals(input.FinalizeConsentRequestUrl))
                ) && 
                (
                    this.InitiateConsentUrl == input.InitiateConsentUrl ||
                    (this.InitiateConsentUrl != null &&
                    this.InitiateConsentUrl.Equals(input.InitiateConsentUrl))
                ) && 
                (
                    this.FinalizeConsentUrl == input.FinalizeConsentUrl ||
                    (this.FinalizeConsentUrl != null &&
                    this.FinalizeConsentUrl.Equals(input.FinalizeConsentUrl))
                ) && 
                (
                    this.AllowUndefinedActions == input.AllowUndefinedActions ||
                    this.AllowUndefinedActions.Equals(input.AllowUndefinedActions)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.InitiateConsentRequestUrl != null)
                    hashCode = hashCode * 59 + this.InitiateConsentRequestUrl.GetHashCode();
                if (this.FinalizeConsentRequestUrl != null)
                    hashCode = hashCode * 59 + this.FinalizeConsentRequestUrl.GetHashCode();
                if (this.InitiateConsentUrl != null)
                    hashCode = hashCode * 59 + this.InitiateConsentUrl.GetHashCode();
                if (this.FinalizeConsentUrl != null)
                    hashCode = hashCode * 59 + this.FinalizeConsentUrl.GetHashCode();
                hashCode = hashCode * 59 + this.AllowUndefinedActions.GetHashCode();
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
