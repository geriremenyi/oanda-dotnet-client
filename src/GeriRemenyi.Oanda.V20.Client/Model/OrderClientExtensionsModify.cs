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
    /// A OrderClientExtensionsModify represents the modification of an Order&#39;s Client Extensions.
    /// </summary>
    [DataContract]
    public partial class OrderClientExtensionsModify :  IEquatable<OrderClientExtensionsModify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderClientExtensionsModify" /> class.
        /// </summary>
        /// <param name="orderID">The ID of the Order who&#39;s client extensions are to be modified..</param>
        /// <param name="clientOrderID">The original Client ID of the Order who&#39;s client extensions are to be modified..</param>
        /// <param name="clientExtensionsModify">clientExtensionsModify.</param>
        /// <param name="tradeClientExtensionsModify">tradeClientExtensionsModify.</param>
        public OrderClientExtensionsModify(int orderID = default(int), string clientOrderID = default(string), ClientExtensions clientExtensionsModify = default(ClientExtensions), ClientExtensions tradeClientExtensionsModify = default(ClientExtensions))
        {
            this.OrderID = orderID;
            this.ClientOrderID = clientOrderID;
            this.ClientExtensionsModify = clientExtensionsModify;
            this.TradeClientExtensionsModify = tradeClientExtensionsModify;
        }
        
        /// <summary>
        /// The ID of the Order who&#39;s client extensions are to be modified.
        /// </summary>
        /// <value>The ID of the Order who&#39;s client extensions are to be modified.</value>
        [DataMember(Name="orderID", EmitDefaultValue=false)]
        public int OrderID { get; set; }

        /// <summary>
        /// The original Client ID of the Order who&#39;s client extensions are to be modified.
        /// </summary>
        /// <value>The original Client ID of the Order who&#39;s client extensions are to be modified.</value>
        [DataMember(Name="clientOrderID", EmitDefaultValue=false)]
        public string ClientOrderID { get; set; }

        /// <summary>
        /// Gets or Sets ClientExtensionsModify
        /// </summary>
        [DataMember(Name="clientExtensionsModify", EmitDefaultValue=false)]
        public ClientExtensions ClientExtensionsModify { get; set; }

        /// <summary>
        /// Gets or Sets TradeClientExtensionsModify
        /// </summary>
        [DataMember(Name="tradeClientExtensionsModify", EmitDefaultValue=false)]
        public ClientExtensions TradeClientExtensionsModify { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderClientExtensionsModify {\n");
            sb.Append("  OrderID: ").Append(OrderID).Append("\n");
            sb.Append("  ClientOrderID: ").Append(ClientOrderID).Append("\n");
            sb.Append("  ClientExtensionsModify: ").Append(ClientExtensionsModify).Append("\n");
            sb.Append("  TradeClientExtensionsModify: ").Append(TradeClientExtensionsModify).Append("\n");
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
            return this.Equals(input as OrderClientExtensionsModify);
        }

        /// <summary>
        /// Returns true if OrderClientExtensionsModify instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderClientExtensionsModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderClientExtensionsModify input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderID == input.OrderID ||
                    this.OrderID.Equals(input.OrderID)
                ) && 
                (
                    this.ClientOrderID == input.ClientOrderID ||
                    (this.ClientOrderID != null &&
                    this.ClientOrderID.Equals(input.ClientOrderID))
                ) && 
                (
                    this.ClientExtensionsModify == input.ClientExtensionsModify ||
                    (this.ClientExtensionsModify != null &&
                    this.ClientExtensionsModify.Equals(input.ClientExtensionsModify))
                ) && 
                (
                    this.TradeClientExtensionsModify == input.TradeClientExtensionsModify ||
                    (this.TradeClientExtensionsModify != null &&
                    this.TradeClientExtensionsModify.Equals(input.TradeClientExtensionsModify))
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
                hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                if (this.ClientOrderID != null)
                    hashCode = hashCode * 59 + this.ClientOrderID.GetHashCode();
                if (this.ClientExtensionsModify != null)
                    hashCode = hashCode * 59 + this.ClientExtensionsModify.GetHashCode();
                if (this.TradeClientExtensionsModify != null)
                    hashCode = hashCode * 59 + this.TradeClientExtensionsModify.GetHashCode();
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