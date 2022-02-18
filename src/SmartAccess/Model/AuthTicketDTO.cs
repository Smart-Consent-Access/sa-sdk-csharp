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
    /// Contains a signed jwt issued and signed by AO. The jwt payload is of type SAAuthTicket
    /// </summary>
    [DataContract(Name = "AuthTicketDTO")]
    public partial class AuthTicketDTO : IEquatable<AuthTicketDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTicketDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthTicketDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTicketDTO" /> class.
        /// </summary>
        /// <param name="authTicket">authTicket (required).</param>
        public AuthTicketDTO(string authTicket = default(string))
        {
            // to ensure "authTicket" is required (not null)
            if (authTicket == null) {
                throw new ArgumentNullException("authTicket is a required property for AuthTicketDTO and cannot be null");
            }
            this.AuthTicket = authTicket;
        }

        /// <summary>
        /// Gets or Sets AuthTicket
        /// </summary>
        [DataMember(Name = "authTicket", IsRequired = true, EmitDefaultValue = false)]
        public string AuthTicket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthTicketDTO {\n");
            sb.Append("  AuthTicket: ").Append(AuthTicket).Append("\n");
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
            return this.Equals(input as AuthTicketDTO);
        }

        /// <summary>
        /// Returns true if AuthTicketDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthTicketDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthTicketDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthTicket == input.AuthTicket ||
                    (this.AuthTicket != null &&
                    this.AuthTicket.Equals(input.AuthTicket))
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
                if (this.AuthTicket != null)
                    hashCode = hashCode * 59 + this.AuthTicket.GetHashCode();
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
