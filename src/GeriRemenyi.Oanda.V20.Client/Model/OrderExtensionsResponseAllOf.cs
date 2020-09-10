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
    /// OrderExtensionsResponseAllOf
    /// </summary>
    [DataContract]
    public partial class OrderExtensionsResponseAllOf :  IEquatable<OrderExtensionsResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderExtensionsResponseAllOf" /> class.
        /// </summary>
        /// <param name="orderClientExtensionsModifyTransaction">orderClientExtensionsModifyTransaction.</param>
        public OrderExtensionsResponseAllOf(OrderClientExtensionsModifyTransaction orderClientExtensionsModifyTransaction = default(OrderClientExtensionsModifyTransaction))
        {
            this.OrderClientExtensionsModifyTransaction = orderClientExtensionsModifyTransaction;
        }
        
        /// <summary>
        /// Gets or Sets OrderClientExtensionsModifyTransaction
        /// </summary>
        [DataMember(Name="orderClientExtensionsModifyTransaction", EmitDefaultValue=false)]
        public OrderClientExtensionsModifyTransaction OrderClientExtensionsModifyTransaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderExtensionsResponseAllOf {\n");
            sb.Append("  OrderClientExtensionsModifyTransaction: ").Append(OrderClientExtensionsModifyTransaction).Append("\n");
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
            return this.Equals(input as OrderExtensionsResponseAllOf);
        }

        /// <summary>
        /// Returns true if OrderExtensionsResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderExtensionsResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderExtensionsResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderClientExtensionsModifyTransaction == input.OrderClientExtensionsModifyTransaction ||
                    (this.OrderClientExtensionsModifyTransaction != null &&
                    this.OrderClientExtensionsModifyTransaction.Equals(input.OrderClientExtensionsModifyTransaction))
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
                if (this.OrderClientExtensionsModifyTransaction != null)
                    hashCode = hashCode * 59 + this.OrderClientExtensionsModifyTransaction.GetHashCode();
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
