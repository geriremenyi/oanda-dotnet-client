/* 
 * OANDA v20 API
 *
 * The full OANDA v20 API Specification. This specification defines how to interact with v20 Accounts, Trades, Orders, Pricing and more.
 *
 * The version of the OpenAPI document: 3.0.25
 * Contact: api@oanda.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = GeriRemenyi.Oanda.V20.Client.OpenAPIDateConverter;

namespace GeriRemenyi.Oanda.V20.Model
{
    /// <summary>
    /// A TransactionHeartbeat object is injected into the Transaction stream to ensure that the HTTP connection remains active.
    /// </summary>
    [DataContract]
    public partial class TransactionHeartbeat :  IEquatable<TransactionHeartbeat>, IValidatableObject
    {
        /// <summary>
        /// The string \&quot;HEARTBEAT\&quot;
        /// </summary>
        /// <value>The string \&quot;HEARTBEAT\&quot;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum HEARTBEAT for value: HEARTBEAT
            /// </summary>
            [EnumMember(Value = "HEARTBEAT")]
            HEARTBEAT = 1

        }

        /// <summary>
        /// The string \&quot;HEARTBEAT\&quot;
        /// </summary>
        /// <value>The string \&quot;HEARTBEAT\&quot;</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionHeartbeat" /> class.
        /// </summary>
        /// <param name="type">The string \&quot;HEARTBEAT\&quot;.</param>
        /// <param name="lastTransactionID">The ID of the most recent Transaction created for the Account.</param>
        /// <param name="time">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        public TransactionHeartbeat(TypeEnum? type = default(TypeEnum?), int lastTransactionID = default(int), string time = default(string))
        {
            this.Type = type;
            this.LastTransactionID = lastTransactionID;
            this.Time = time;
        }
        
        /// <summary>
        /// The ID of the most recent Transaction created for the Account
        /// </summary>
        /// <value>The ID of the most recent Transaction created for the Account</value>
        [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
        public int LastTransactionID { get; set; }

        /// <summary>
        /// A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).
        /// </summary>
        /// <value>A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionHeartbeat {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransactionHeartbeat);
        }

        /// <summary>
        /// Returns true if TransactionHeartbeat instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionHeartbeat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionHeartbeat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.LastTransactionID == input.LastTransactionID ||
                    this.LastTransactionID.Equals(input.LastTransactionID)
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.LastTransactionID.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Time (string) pattern
            Regex regexTime = new Regex(@"^(?:(?:\\d+(?:\\.\\d{1,9})?)|(?:[1-9]\\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)T(?:[01]\\d|2[0-3]):[0-5]\\d:[0-5]\\d(?:\\.\\d{1,9})?(?:Z|[+-][01]\\d:[0-5]\\d))$", RegexOptions.CultureInvariant);
            if (false == regexTime.Match(this.Time).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Time, must match a pattern of " + regexTime, new [] { "Time" });
            }

            yield break;
        }
    }

}
