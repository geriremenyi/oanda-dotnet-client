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
    /// InlineObject3
    /// </summary>
    [DataContract]
    public partial class InlineObject3 :  IEquatable<InlineObject3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject3" /> class.
        /// </summary>
        /// <param name="clientExtensions">clientExtensions.</param>
        /// <param name="tradeClientExtensions">tradeClientExtensions.</param>
        public InlineObject3(InlineResponse2005ChangesClientExtensions clientExtensions = default(InlineResponse2005ChangesClientExtensions), InlineResponse2005ChangesClientExtensions tradeClientExtensions = default(InlineResponse2005ChangesClientExtensions))
        {
            this.ClientExtensions = clientExtensions;
            this.TradeClientExtensions = tradeClientExtensions;
        }
        
        /// <summary>
        /// Gets or Sets ClientExtensions
        /// </summary>
        [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
        public InlineResponse2005ChangesClientExtensions ClientExtensions { get; set; }

        /// <summary>
        /// Gets or Sets TradeClientExtensions
        /// </summary>
        [DataMember(Name="tradeClientExtensions", EmitDefaultValue=false)]
        public InlineResponse2005ChangesClientExtensions TradeClientExtensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject3 {\n");
            sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
            sb.Append("  TradeClientExtensions: ").Append(TradeClientExtensions).Append("\n");
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
            return this.Equals(input as InlineObject3);
        }

        /// <summary>
        /// Returns true if InlineObject3 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientExtensions == input.ClientExtensions ||
                    (this.ClientExtensions != null &&
                    this.ClientExtensions.Equals(input.ClientExtensions))
                ) && 
                (
                    this.TradeClientExtensions == input.TradeClientExtensions ||
                    (this.TradeClientExtensions != null &&
                    this.TradeClientExtensions.Equals(input.TradeClientExtensions))
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
                if (this.ClientExtensions != null)
                    hashCode = hashCode * 59 + this.ClientExtensions.GetHashCode();
                if (this.TradeClientExtensions != null)
                    hashCode = hashCode * 59 + this.TradeClientExtensions.GetHashCode();
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
