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
    /// HomeConversions represents the factors to use to convert quantities of a given currency into the Account&#39;s home currency. The conversion factor depends on the scenario the conversion is required for.
    /// </summary>
    [DataContract]
    public partial class InlineResponse20021HomeConversions :  IEquatable<InlineResponse20021HomeConversions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20021HomeConversions" /> class.
        /// </summary>
        /// <param name="currency">The currency to be converted into the home currency. A string containing an ISO 4217 currency (http://en.wikipedia.org/wiki/ISO_4217).</param>
        /// <param name="accountGain">The factor used to convert any gains for an Account in the specified currency into the Account&#39;s home currency. This would include positive realized P/L and positive financing amounts. Conversion is performed by multiplying the positive P/L by the conversion factor..</param>
        /// <param name="accountLoss">The string representation of a decimal number..</param>
        /// <param name="positionValue">The factor used to convert a Position or Trade Value in the specified currency into the Account&#39;s home currency. Conversion is performed by multiplying the Position or Trade Value by the conversion factor..</param>
        public InlineResponse20021HomeConversions(string currency = default(string), double accountGain = default(double), double accountLoss = default(double), double positionValue = default(double))
        {
            this.Currency = currency;
            this.AccountGain = accountGain;
            this.AccountLoss = accountLoss;
            this.PositionValue = positionValue;
        }
        
        /// <summary>
        /// The currency to be converted into the home currency. A string containing an ISO 4217 currency (http://en.wikipedia.org/wiki/ISO_4217)
        /// </summary>
        /// <value>The currency to be converted into the home currency. A string containing an ISO 4217 currency (http://en.wikipedia.org/wiki/ISO_4217)</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The factor used to convert any gains for an Account in the specified currency into the Account&#39;s home currency. This would include positive realized P/L and positive financing amounts. Conversion is performed by multiplying the positive P/L by the conversion factor.
        /// </summary>
        /// <value>The factor used to convert any gains for an Account in the specified currency into the Account&#39;s home currency. This would include positive realized P/L and positive financing amounts. Conversion is performed by multiplying the positive P/L by the conversion factor.</value>
        [DataMember(Name="accountGain", EmitDefaultValue=false)]
        public double AccountGain { get; set; }

        /// <summary>
        /// The string representation of a decimal number.
        /// </summary>
        /// <value>The string representation of a decimal number.</value>
        [DataMember(Name="accountLoss", EmitDefaultValue=false)]
        public double AccountLoss { get; set; }

        /// <summary>
        /// The factor used to convert a Position or Trade Value in the specified currency into the Account&#39;s home currency. Conversion is performed by multiplying the Position or Trade Value by the conversion factor.
        /// </summary>
        /// <value>The factor used to convert a Position or Trade Value in the specified currency into the Account&#39;s home currency. Conversion is performed by multiplying the Position or Trade Value by the conversion factor.</value>
        [DataMember(Name="positionValue", EmitDefaultValue=false)]
        public double PositionValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20021HomeConversions {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AccountGain: ").Append(AccountGain).Append("\n");
            sb.Append("  AccountLoss: ").Append(AccountLoss).Append("\n");
            sb.Append("  PositionValue: ").Append(PositionValue).Append("\n");
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
            return this.Equals(input as InlineResponse20021HomeConversions);
        }

        /// <summary>
        /// Returns true if InlineResponse20021HomeConversions instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20021HomeConversions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20021HomeConversions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.AccountGain == input.AccountGain ||
                    this.AccountGain.Equals(input.AccountGain)
                ) && 
                (
                    this.AccountLoss == input.AccountLoss ||
                    this.AccountLoss.Equals(input.AccountLoss)
                ) && 
                (
                    this.PositionValue == input.PositionValue ||
                    this.PositionValue.Equals(input.PositionValue)
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                hashCode = hashCode * 59 + this.AccountGain.GetHashCode();
                hashCode = hashCode * 59 + this.AccountLoss.GetHashCode();
                hashCode = hashCode * 59 + this.PositionValue.GetHashCode();
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
            yield break;
        }
    }

}
