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
    /// DebugDTOExampleKeyPair
    /// </summary>
    [DataContract(Name = "DebugDTO_exampleKeyPair")]
    public partial class DebugDTOExampleKeyPair : IEquatable<DebugDTOExampleKeyPair>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebugDTOExampleKeyPair" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DebugDTOExampleKeyPair() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebugDTOExampleKeyPair" /> class.
        /// </summary>
        /// <param name="_private">_private (required).</param>
        /// <param name="_public">_public (required).</param>
        public DebugDTOExampleKeyPair(string _private = default(string), string _public = default(string))
        {
            // to ensure "_private" is required (not null)
            if (_private == null) {
                throw new ArgumentNullException("_private is a required property for DebugDTOExampleKeyPair and cannot be null");
            }
            this.Private = _private;
            // to ensure "_public" is required (not null)
            if (_public == null) {
                throw new ArgumentNullException("_public is a required property for DebugDTOExampleKeyPair and cannot be null");
            }
            this.Public = _public;
        }

        /// <summary>
        /// Gets or Sets Private
        /// </summary>
        [DataMember(Name = "private", IsRequired = true, EmitDefaultValue = false)]
        public string Private { get; set; }

        /// <summary>
        /// Gets or Sets Public
        /// </summary>
        [DataMember(Name = "public", IsRequired = true, EmitDefaultValue = false)]
        public string Public { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebugDTOExampleKeyPair {\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
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
            return this.Equals(input as DebugDTOExampleKeyPair);
        }

        /// <summary>
        /// Returns true if DebugDTOExampleKeyPair instances are equal
        /// </summary>
        /// <param name="input">Instance of DebugDTOExampleKeyPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebugDTOExampleKeyPair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Private == input.Private ||
                    (this.Private != null &&
                    this.Private.Equals(input.Private))
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
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
                if (this.Private != null)
                    hashCode = hashCode * 59 + this.Private.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
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
