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
    /// CloseTradeResponse
    /// </summary>
    [DataContract]
    public partial class CloseTradeResponse :  IEquatable<CloseTradeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloseTradeResponse" /> class.
        /// </summary>
        /// <param name="orderCreateTransaction">orderCreateTransaction.</param>
        /// <param name="orderFillTransaction">orderFillTransaction.</param>
        /// <param name="orderCancelTransaction">orderCancelTransaction.</param>
        /// <param name="lastTransactionID">The ID of the most recent Transaction created for the Account.</param>
        /// <param name="relatedTransactionIDs">The IDs of all Transactions that were created while satisfying the request..</param>
        public CloseTradeResponse(MarketOrderTransaction orderCreateTransaction = default(MarketOrderTransaction), OrderFillTransaction orderFillTransaction = default(OrderFillTransaction), OrderCancelTransaction orderCancelTransaction = default(OrderCancelTransaction), int lastTransactionID = default(int), List<int> relatedTransactionIDs = default(List<int>))
        {
            this.OrderCreateTransaction = orderCreateTransaction;
            this.OrderFillTransaction = orderFillTransaction;
            this.OrderCancelTransaction = orderCancelTransaction;
            this.LastTransactionID = lastTransactionID;
            this.RelatedTransactionIDs = relatedTransactionIDs;
        }
        
        /// <summary>
        /// Gets or Sets OrderCreateTransaction
        /// </summary>
        [DataMember(Name="orderCreateTransaction", EmitDefaultValue=false)]
        public MarketOrderTransaction OrderCreateTransaction { get; set; }

        /// <summary>
        /// Gets or Sets OrderFillTransaction
        /// </summary>
        [DataMember(Name="orderFillTransaction", EmitDefaultValue=false)]
        public OrderFillTransaction OrderFillTransaction { get; set; }

        /// <summary>
        /// Gets or Sets OrderCancelTransaction
        /// </summary>
        [DataMember(Name="orderCancelTransaction", EmitDefaultValue=false)]
        public OrderCancelTransaction OrderCancelTransaction { get; set; }

        /// <summary>
        /// The ID of the most recent Transaction created for the Account
        /// </summary>
        /// <value>The ID of the most recent Transaction created for the Account</value>
        [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
        public int LastTransactionID { get; set; }

        /// <summary>
        /// The IDs of all Transactions that were created while satisfying the request.
        /// </summary>
        /// <value>The IDs of all Transactions that were created while satisfying the request.</value>
        [DataMember(Name="relatedTransactionIDs", EmitDefaultValue=true)]
        public List<int> RelatedTransactionIDs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloseTradeResponse {\n");
            sb.Append("  OrderCreateTransaction: ").Append(OrderCreateTransaction).Append("\n");
            sb.Append("  OrderFillTransaction: ").Append(OrderFillTransaction).Append("\n");
            sb.Append("  OrderCancelTransaction: ").Append(OrderCancelTransaction).Append("\n");
            sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
            sb.Append("  RelatedTransactionIDs: ").Append(RelatedTransactionIDs).Append("\n");
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
            return this.Equals(input as CloseTradeResponse);
        }

        /// <summary>
        /// Returns true if CloseTradeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CloseTradeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloseTradeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderCreateTransaction == input.OrderCreateTransaction ||
                    (this.OrderCreateTransaction != null &&
                    this.OrderCreateTransaction.Equals(input.OrderCreateTransaction))
                ) && 
                (
                    this.OrderFillTransaction == input.OrderFillTransaction ||
                    (this.OrderFillTransaction != null &&
                    this.OrderFillTransaction.Equals(input.OrderFillTransaction))
                ) && 
                (
                    this.OrderCancelTransaction == input.OrderCancelTransaction ||
                    (this.OrderCancelTransaction != null &&
                    this.OrderCancelTransaction.Equals(input.OrderCancelTransaction))
                ) && 
                (
                    this.LastTransactionID == input.LastTransactionID ||
                    this.LastTransactionID.Equals(input.LastTransactionID)
                ) && 
                (
                    this.RelatedTransactionIDs == input.RelatedTransactionIDs ||
                    this.RelatedTransactionIDs != null &&
                    input.RelatedTransactionIDs != null &&
                    this.RelatedTransactionIDs.SequenceEqual(input.RelatedTransactionIDs)
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
                if (this.OrderCreateTransaction != null)
                    hashCode = hashCode * 59 + this.OrderCreateTransaction.GetHashCode();
                if (this.OrderFillTransaction != null)
                    hashCode = hashCode * 59 + this.OrderFillTransaction.GetHashCode();
                if (this.OrderCancelTransaction != null)
                    hashCode = hashCode * 59 + this.OrderCancelTransaction.GetHashCode();
                hashCode = hashCode * 59 + this.LastTransactionID.GetHashCode();
                if (this.RelatedTransactionIDs != null)
                    hashCode = hashCode * 59 + this.RelatedTransactionIDs.GetHashCode();
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
