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
    /// ConsentRequestSearchResultDTO
    /// </summary>
    [DataContract(Name = "ConsentRequestSearchResultDTO")]
    public partial class ConsentRequestSearchResultDTO : IEquatable<ConsentRequestSearchResultDTO>, IValidatableObject
    {
        /// <summary>
        /// Defines ResponseTotalStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResponseTotalStatusEnum
        {
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 1,

            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 2

        }


        /// <summary>
        /// Gets or Sets ResponseTotalStatus
        /// </summary>
        [DataMember(Name = "responseTotalStatus", IsRequired = true, EmitDefaultValue = false)]
        public ResponseTotalStatusEnum ResponseTotalStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentRequestSearchResultDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsentRequestSearchResultDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentRequestSearchResultDTO" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="actions">actions (required).</param>
        /// <param name="resources">resources (required).</param>
        /// <param name="conditions">conditions (required).</param>
        /// <param name="termsAndConditions">termsAndConditions (required).</param>
        /// <param name="purpose">purpose (required).</param>
        /// <param name="reqServiceProviderId">reqServiceProviderId (required).</param>
        /// <param name="reqServiceProviderName">reqServiceProviderName (required).</param>
        /// <param name="reqPrincipalId">reqPrincipalId (required).</param>
        /// <param name="reqPrincipalName">reqPrincipalName (required).</param>
        /// <param name="consServiceProviderId">consServiceProviderId (required).</param>
        /// <param name="consServiceProviderName">consServiceProviderName (required).</param>
        /// <param name="numApproved">numApproved (required).</param>
        /// <param name="numRejected">numRejected (required).</param>
        /// <param name="responseTotalStatus">responseTotalStatus (required).</param>
        /// <param name="numAffectedUsers">numAffectedUsers (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="consents">consents (required).</param>
        public ConsentRequestSearchResultDTO(string id = default(string), List<string> actions = default(List<string>), List<string> resources = default(List<string>), List<string> conditions = default(List<string>), string termsAndConditions = default(string), List<LocalizedStringDTO> purpose = default(List<LocalizedStringDTO>), string reqServiceProviderId = default(string), string reqServiceProviderName = default(string), string reqPrincipalId = default(string), string reqPrincipalName = default(string), string consServiceProviderId = default(string), string consServiceProviderName = default(string), double numApproved = default(double), double numRejected = default(double), ResponseTotalStatusEnum responseTotalStatus = default(ResponseTotalStatusEnum), double numAffectedUsers = default(double), string status = default(string), string createdAt = default(string), string updatedAt = default(string), List<ConsentRequestSearchResultDTOConsents> consents = default(List<ConsentRequestSearchResultDTOConsents>))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.Id = id;
            // to ensure "actions" is required (not null)
            if (actions == null) {
                throw new ArgumentNullException("actions is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.Actions = actions;
            // to ensure "resources" is required (not null)
            if (resources == null) {
                throw new ArgumentNullException("resources is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.Resources = resources;
            // to ensure "conditions" is required (not null)
            if (conditions == null) {
                throw new ArgumentNullException("conditions is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.Conditions = conditions;
            // to ensure "termsAndConditions" is required (not null)
            if (termsAndConditions == null) {
                throw new ArgumentNullException("termsAndConditions is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.TermsAndConditions = termsAndConditions;
            // to ensure "purpose" is required (not null)
            if (purpose == null) {
                throw new ArgumentNullException("purpose is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.Purpose = purpose;
            // to ensure "reqServiceProviderId" is required (not null)
            if (reqServiceProviderId == null) {
                throw new ArgumentNullException("reqServiceProviderId is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.ReqServiceProviderId = reqServiceProviderId;
            // to ensure "reqServiceProviderName" is required (not null)
            if (reqServiceProviderName == null) {
                throw new ArgumentNullException("reqServiceProviderName is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.ReqServiceProviderName = reqServiceProviderName;
            // to ensure "reqPrincipalId" is required (not null)
            if (reqPrincipalId == null) {
                throw new ArgumentNullException("reqPrincipalId is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.ReqPrincipalId = reqPrincipalId;
            // to ensure "reqPrincipalName" is required (not null)
            if (reqPrincipalName == null) {
                throw new ArgumentNullException("reqPrincipalName is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.ReqPrincipalName = reqPrincipalName;
            // to ensure "consServiceProviderId" is required (not null)
            if (consServiceProviderId == null) {
                throw new ArgumentNullException("consServiceProviderId is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.ConsServiceProviderId = consServiceProviderId;
            // to ensure "consServiceProviderName" is required (not null)
            if (consServiceProviderName == null) {
                throw new ArgumentNullException("consServiceProviderName is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.ConsServiceProviderName = consServiceProviderName;
            this.NumApproved = numApproved;
            this.NumRejected = numRejected;
            this.ResponseTotalStatus = responseTotalStatus;
            this.NumAffectedUsers = numAffectedUsers;
            // to ensure "status" is required (not null)
            if (status == null) {
                throw new ArgumentNullException("status is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.Status = status;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null) {
                throw new ArgumentNullException("createdAt is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "consents" is required (not null)
            if (consents == null) {
                throw new ArgumentNullException("consents is a required property for ConsentRequestSearchResultDTO and cannot be null");
            }
            this.Consents = consents;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name = "resources", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name = "conditions", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Conditions { get; set; }

        /// <summary>
        /// Gets or Sets TermsAndConditions
        /// </summary>
        [DataMember(Name = "termsAndConditions", IsRequired = true, EmitDefaultValue = false)]
        public string TermsAndConditions { get; set; }

        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name = "purpose", IsRequired = true, EmitDefaultValue = false)]
        public List<LocalizedStringDTO> Purpose { get; set; }

        /// <summary>
        /// Gets or Sets ReqServiceProviderId
        /// </summary>
        [DataMember(Name = "reqServiceProviderId", IsRequired = true, EmitDefaultValue = false)]
        public string ReqServiceProviderId { get; set; }

        /// <summary>
        /// Gets or Sets ReqServiceProviderName
        /// </summary>
        [DataMember(Name = "reqServiceProviderName", IsRequired = true, EmitDefaultValue = false)]
        public string ReqServiceProviderName { get; set; }

        /// <summary>
        /// Gets or Sets ReqPrincipalId
        /// </summary>
        [DataMember(Name = "reqPrincipalId", IsRequired = true, EmitDefaultValue = false)]
        public string ReqPrincipalId { get; set; }

        /// <summary>
        /// Gets or Sets ReqPrincipalName
        /// </summary>
        [DataMember(Name = "reqPrincipalName", IsRequired = true, EmitDefaultValue = false)]
        public string ReqPrincipalName { get; set; }

        /// <summary>
        /// Gets or Sets ConsServiceProviderId
        /// </summary>
        [DataMember(Name = "consServiceProviderId", IsRequired = true, EmitDefaultValue = false)]
        public string ConsServiceProviderId { get; set; }

        /// <summary>
        /// Gets or Sets ConsServiceProviderName
        /// </summary>
        [DataMember(Name = "consServiceProviderName", IsRequired = true, EmitDefaultValue = false)]
        public string ConsServiceProviderName { get; set; }

        /// <summary>
        /// Gets or Sets NumApproved
        /// </summary>
        [DataMember(Name = "numApproved", IsRequired = true, EmitDefaultValue = false)]
        public double NumApproved { get; set; }

        /// <summary>
        /// Gets or Sets NumRejected
        /// </summary>
        [DataMember(Name = "numRejected", IsRequired = true, EmitDefaultValue = false)]
        public double NumRejected { get; set; }

        /// <summary>
        /// Gets or Sets NumAffectedUsers
        /// </summary>
        [DataMember(Name = "numAffectedUsers", IsRequired = true, EmitDefaultValue = false)]
        public double NumAffectedUsers { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Consents
        /// </summary>
        [DataMember(Name = "consents", IsRequired = true, EmitDefaultValue = false)]
        public List<ConsentRequestSearchResultDTOConsents> Consents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsentRequestSearchResultDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  TermsAndConditions: ").Append(TermsAndConditions).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  ReqServiceProviderId: ").Append(ReqServiceProviderId).Append("\n");
            sb.Append("  ReqServiceProviderName: ").Append(ReqServiceProviderName).Append("\n");
            sb.Append("  ReqPrincipalId: ").Append(ReqPrincipalId).Append("\n");
            sb.Append("  ReqPrincipalName: ").Append(ReqPrincipalName).Append("\n");
            sb.Append("  ConsServiceProviderId: ").Append(ConsServiceProviderId).Append("\n");
            sb.Append("  ConsServiceProviderName: ").Append(ConsServiceProviderName).Append("\n");
            sb.Append("  NumApproved: ").Append(NumApproved).Append("\n");
            sb.Append("  NumRejected: ").Append(NumRejected).Append("\n");
            sb.Append("  ResponseTotalStatus: ").Append(ResponseTotalStatus).Append("\n");
            sb.Append("  NumAffectedUsers: ").Append(NumAffectedUsers).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Consents: ").Append(Consents).Append("\n");
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
            return this.Equals(input as ConsentRequestSearchResultDTO);
        }

        /// <summary>
        /// Returns true if ConsentRequestSearchResultDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsentRequestSearchResultDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsentRequestSearchResultDTO input)
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
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.TermsAndConditions == input.TermsAndConditions ||
                    (this.TermsAndConditions != null &&
                    this.TermsAndConditions.Equals(input.TermsAndConditions))
                ) && 
                (
                    this.Purpose == input.Purpose ||
                    this.Purpose != null &&
                    input.Purpose != null &&
                    this.Purpose.SequenceEqual(input.Purpose)
                ) && 
                (
                    this.ReqServiceProviderId == input.ReqServiceProviderId ||
                    (this.ReqServiceProviderId != null &&
                    this.ReqServiceProviderId.Equals(input.ReqServiceProviderId))
                ) && 
                (
                    this.ReqServiceProviderName == input.ReqServiceProviderName ||
                    (this.ReqServiceProviderName != null &&
                    this.ReqServiceProviderName.Equals(input.ReqServiceProviderName))
                ) && 
                (
                    this.ReqPrincipalId == input.ReqPrincipalId ||
                    (this.ReqPrincipalId != null &&
                    this.ReqPrincipalId.Equals(input.ReqPrincipalId))
                ) && 
                (
                    this.ReqPrincipalName == input.ReqPrincipalName ||
                    (this.ReqPrincipalName != null &&
                    this.ReqPrincipalName.Equals(input.ReqPrincipalName))
                ) && 
                (
                    this.ConsServiceProviderId == input.ConsServiceProviderId ||
                    (this.ConsServiceProviderId != null &&
                    this.ConsServiceProviderId.Equals(input.ConsServiceProviderId))
                ) && 
                (
                    this.ConsServiceProviderName == input.ConsServiceProviderName ||
                    (this.ConsServiceProviderName != null &&
                    this.ConsServiceProviderName.Equals(input.ConsServiceProviderName))
                ) && 
                (
                    this.NumApproved == input.NumApproved ||
                    this.NumApproved.Equals(input.NumApproved)
                ) && 
                (
                    this.NumRejected == input.NumRejected ||
                    this.NumRejected.Equals(input.NumRejected)
                ) && 
                (
                    this.ResponseTotalStatus == input.ResponseTotalStatus ||
                    this.ResponseTotalStatus.Equals(input.ResponseTotalStatus)
                ) && 
                (
                    this.NumAffectedUsers == input.NumAffectedUsers ||
                    this.NumAffectedUsers.Equals(input.NumAffectedUsers)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Consents == input.Consents ||
                    this.Consents != null &&
                    input.Consents != null &&
                    this.Consents.SequenceEqual(input.Consents)
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
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.TermsAndConditions != null)
                    hashCode = hashCode * 59 + this.TermsAndConditions.GetHashCode();
                if (this.Purpose != null)
                    hashCode = hashCode * 59 + this.Purpose.GetHashCode();
                if (this.ReqServiceProviderId != null)
                    hashCode = hashCode * 59 + this.ReqServiceProviderId.GetHashCode();
                if (this.ReqServiceProviderName != null)
                    hashCode = hashCode * 59 + this.ReqServiceProviderName.GetHashCode();
                if (this.ReqPrincipalId != null)
                    hashCode = hashCode * 59 + this.ReqPrincipalId.GetHashCode();
                if (this.ReqPrincipalName != null)
                    hashCode = hashCode * 59 + this.ReqPrincipalName.GetHashCode();
                if (this.ConsServiceProviderId != null)
                    hashCode = hashCode * 59 + this.ConsServiceProviderId.GetHashCode();
                if (this.ConsServiceProviderName != null)
                    hashCode = hashCode * 59 + this.ConsServiceProviderName.GetHashCode();
                hashCode = hashCode * 59 + this.NumApproved.GetHashCode();
                hashCode = hashCode * 59 + this.NumRejected.GetHashCode();
                hashCode = hashCode * 59 + this.ResponseTotalStatus.GetHashCode();
                hashCode = hashCode * 59 + this.NumAffectedUsers.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Consents != null)
                    hashCode = hashCode * 59 + this.Consents.GetHashCode();
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
