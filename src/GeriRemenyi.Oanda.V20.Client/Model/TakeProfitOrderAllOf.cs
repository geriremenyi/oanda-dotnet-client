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
using OpenAPIDateConverter = GeriRemenyi.Oanda.V20.Client.Client.OpenAPIDateConverter;

namespace GeriRemenyi.Oanda.V20.Client.Model
{
    /// <summary>
    /// TakeProfitOrderAllOf
    /// </summary>
    [DataContract]
    public partial class TakeProfitOrderAllOf :  IEquatable<TakeProfitOrderAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TakeProfitOrderAllOf" /> class.
        /// </summary>
        /// <param name="price">The price threshold specified for the TakeProfit Order. The associated Trade will be closed by a market price that is equal to or better  than this threshold..</param>
        public TakeProfitOrderAllOf(double price = default(double))
        {
            this.Price = price;
        }
        
        /// <summary>
        /// The price threshold specified for the TakeProfit Order. The associated Trade will be closed by a market price that is equal to or better  than this threshold.
        /// </summary>
        /// <value>The price threshold specified for the TakeProfit Order. The associated Trade will be closed by a market price that is equal to or better  than this threshold.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TakeProfitOrderAllOf {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
            return this.Equals(input as TakeProfitOrderAllOf);
        }

        /// <summary>
        /// Returns true if TakeProfitOrderAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TakeProfitOrderAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TakeProfitOrderAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
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
                hashCode = hashCode * 59 + this.Price.GetHashCode();
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