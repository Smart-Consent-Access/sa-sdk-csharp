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
    /// Body to send when finalizing a consent approval. Contains a jwt signed by the issuer which is the requesting serviceprovider. The jwt payload is of type SAConsApprovalFinalizeSp1ToSaJWT
    /// </summary>
    [DataContract(Name = "ConsentApprovalFinalizeBody")]
    public partial class ConsentApprovalFinalizeBody : IEquatable<ConsentApprovalFinalizeBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentApprovalFinalizeBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsentApprovalFinalizeBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentApprovalFinalizeBody" /> class.
        /// </summary>
        /// <param name="consApprovalFinalizeJWT">Signed JWT (required).</param>
        public ConsentApprovalFinalizeBody(string consApprovalFinalizeJWT = default(string))
        {
            // to ensure "consApprovalFinalizeJWT" is required (not null)
            if (consApprovalFinalizeJWT == null) {
                throw new ArgumentNullException("consApprovalFinalizeJWT is a required property for ConsentApprovalFinalizeBody and cannot be null");
            }
            this.ConsApprovalFinalizeJWT = consApprovalFinalizeJWT;
        }

        /// <summary>
        /// Signed JWT
        /// </summary>
        /// <value>Signed JWT</value>
        [DataMember(Name = "consApprovalFinalizeJWT", IsRequired = true, EmitDefaultValue = false)]
        public string ConsApprovalFinalizeJWT { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsentApprovalFinalizeBody {\n");
            sb.Append("  ConsApprovalFinalizeJWT: ").Append(ConsApprovalFinalizeJWT).Append("\n");
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
            return this.Equals(input as ConsentApprovalFinalizeBody);
        }

        /// <summary>
        /// Returns true if ConsentApprovalFinalizeBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsentApprovalFinalizeBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsentApprovalFinalizeBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsApprovalFinalizeJWT == input.ConsApprovalFinalizeJWT ||
                    (this.ConsApprovalFinalizeJWT != null &&
                    this.ConsApprovalFinalizeJWT.Equals(input.ConsApprovalFinalizeJWT))
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
                if (this.ConsApprovalFinalizeJWT != null)
                    hashCode = hashCode * 59 + this.ConsApprovalFinalizeJWT.GetHashCode();
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
            // ConsApprovalFinalizeJWT (string) pattern
            Regex regexConsApprovalFinalizeJWT = new Regex(@"^([a-zA-Z0-9_=]+)\\.([a-zA-Z0-9_=]+)\\.([a-zA-Z0-9_\\-\\+\/=]*)$", RegexOptions.CultureInvariant);
            if (false == regexConsApprovalFinalizeJWT.Match(this.ConsApprovalFinalizeJWT).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConsApprovalFinalizeJWT, must match a pattern of " + regexConsApprovalFinalizeJWT, new [] { "ConsApprovalFinalizeJWT" });
            }

            yield break;
        }
    }

}
