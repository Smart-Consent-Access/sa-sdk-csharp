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
    /// Fields to filter on in the search. Atleast reqServiceProviderId or consServiceProviderId or both is required and the searching serviceprovider (caller) must be one of them. The other fields are optional. It is a search hit if all fields matches a consent request (AND)
    /// </summary>
    [DataContract(Name = "SearchConsentRequestsDTO_fields")]
    public partial class SearchConsentRequestsDTOFields : IEquatable<SearchConsentRequestsDTOFields>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchConsentRequestsDTOFields" /> class.
        /// </summary>
        /// <param name="stopCreatedAt">Only take consent requests created before or equal to this timestamp..</param>
        /// <param name="startCreatedAt">Only take consent requests created after or equal to this timestamp. Will be passed to JavaScripts Date constructor so must be a valid time-string that is accepted. The database stores dates without timezone (UTC) and the comparison is done without timezone.</param>
        /// <param name="status">Consent request status, for example \&quot;INITIALIZED\&quot;, \&quot;FINALIZED\&quot; or \&quot;INACTIVE\&quot;.</param>
        /// <param name="consServiceProviderId">The consenting serviceprovider on consent request.</param>
        /// <param name="reqServiceProviderId">The requesting serviceprovider on consent request.</param>
        public SearchConsentRequestsDTOFields(string stopCreatedAt = default(string), string startCreatedAt = default(string), string status = default(string), string consServiceProviderId = default(string), string reqServiceProviderId = default(string))
        {
            this.StopCreatedAt = stopCreatedAt;
            this.StartCreatedAt = startCreatedAt;
            this.Status = status;
            this.ConsServiceProviderId = consServiceProviderId;
            this.ReqServiceProviderId = reqServiceProviderId;
        }

        /// <summary>
        /// Only take consent requests created before or equal to this timestamp.
        /// </summary>
        /// <value>Only take consent requests created before or equal to this timestamp.</value>
        [DataMember(Name = "stopCreatedAt", EmitDefaultValue = false)]
        public string StopCreatedAt { get; set; }

        /// <summary>
        /// Only take consent requests created after or equal to this timestamp. Will be passed to JavaScripts Date constructor so must be a valid time-string that is accepted. The database stores dates without timezone (UTC) and the comparison is done without timezone
        /// </summary>
        /// <value>Only take consent requests created after or equal to this timestamp. Will be passed to JavaScripts Date constructor so must be a valid time-string that is accepted. The database stores dates without timezone (UTC) and the comparison is done without timezone</value>
        [DataMember(Name = "startCreatedAt", EmitDefaultValue = false)]
        public string StartCreatedAt { get; set; }

        /// <summary>
        /// Consent request status, for example \&quot;INITIALIZED\&quot;, \&quot;FINALIZED\&quot; or \&quot;INACTIVE\&quot;
        /// </summary>
        /// <value>Consent request status, for example \&quot;INITIALIZED\&quot;, \&quot;FINALIZED\&quot; or \&quot;INACTIVE\&quot;</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The consenting serviceprovider on consent request
        /// </summary>
        /// <value>The consenting serviceprovider on consent request</value>
        [DataMember(Name = "consServiceProviderId", EmitDefaultValue = false)]
        public string ConsServiceProviderId { get; set; }

        /// <summary>
        /// The requesting serviceprovider on consent request
        /// </summary>
        /// <value>The requesting serviceprovider on consent request</value>
        [DataMember(Name = "reqServiceProviderId", EmitDefaultValue = false)]
        public string ReqServiceProviderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchConsentRequestsDTOFields {\n");
            sb.Append("  StopCreatedAt: ").Append(StopCreatedAt).Append("\n");
            sb.Append("  StartCreatedAt: ").Append(StartCreatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ConsServiceProviderId: ").Append(ConsServiceProviderId).Append("\n");
            sb.Append("  ReqServiceProviderId: ").Append(ReqServiceProviderId).Append("\n");
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
            return this.Equals(input as SearchConsentRequestsDTOFields);
        }

        /// <summary>
        /// Returns true if SearchConsentRequestsDTOFields instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchConsentRequestsDTOFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchConsentRequestsDTOFields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StopCreatedAt == input.StopCreatedAt ||
                    (this.StopCreatedAt != null &&
                    this.StopCreatedAt.Equals(input.StopCreatedAt))
                ) && 
                (
                    this.StartCreatedAt == input.StartCreatedAt ||
                    (this.StartCreatedAt != null &&
                    this.StartCreatedAt.Equals(input.StartCreatedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ConsServiceProviderId == input.ConsServiceProviderId ||
                    (this.ConsServiceProviderId != null &&
                    this.ConsServiceProviderId.Equals(input.ConsServiceProviderId))
                ) && 
                (
                    this.ReqServiceProviderId == input.ReqServiceProviderId ||
                    (this.ReqServiceProviderId != null &&
                    this.ReqServiceProviderId.Equals(input.ReqServiceProviderId))
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
                if (this.StopCreatedAt != null)
                    hashCode = hashCode * 59 + this.StopCreatedAt.GetHashCode();
                if (this.StartCreatedAt != null)
                    hashCode = hashCode * 59 + this.StartCreatedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ConsServiceProviderId != null)
                    hashCode = hashCode * 59 + this.ConsServiceProviderId.GetHashCode();
                if (this.ReqServiceProviderId != null)
                    hashCode = hashCode * 59 + this.ReqServiceProviderId.GetHashCode();
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
