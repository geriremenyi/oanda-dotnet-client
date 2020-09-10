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
    /// A StopLossOrder represents the creation of a StopLoss Order in the user&#39;s Account.
    /// </summary>
    [DataContract]
    public partial class StopLossOrderTransactionBase :  IEquatable<StopLossOrderTransactionBase>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TimeInForce
        /// </summary>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public TradeOrderTimeInForce? TimeInForce { get; set; }
        /// <summary>
        /// Gets or Sets TriggerCondition
        /// </summary>
        [DataMember(Name="triggerCondition", EmitDefaultValue=false)]
        public TradeOrderTriggerCondition? TriggerCondition { get; set; }
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public TradeOrderTransactionReason? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StopLossOrderTransactionBase" /> class.
        /// </summary>
        /// <param name="tradeID">The ID of the Trade to close when the price threshold is breached..</param>
        /// <param name="clientTradeID">The client ID of the Trade to be closed when the price threshold is breached..</param>
        /// <param name="price">The price threshold specified for the Stop Loss Order. If the guaranteed flag is false, the associated Trade will be closed by a market price that is equal to or worse than this threshold. If the flag is true the associated Trade will be closed at this price..</param>
        /// <param name="distance">Specifies the distance (in price units) from the Account&#39;s current price to use as the Stop Loss Order price. If the Trade is short the Instrument&#39;s bid price is used, and for long Trades the ask is used..</param>
        /// <param name="timeInForce">timeInForce.</param>
        /// <param name="gtdTime">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        /// <param name="triggerCondition">triggerCondition.</param>
        /// <param name="guaranteed">Flag indicating that the Stop Loss Order is guaranteed. The default value depends on the GuaranteedStopLossOrderMode of the account, if it is REQUIRED, the default will be true, for DISABLED or ENABLED the default is false..</param>
        /// <param name="guaranteedExecutionPremium">The fee that will be charged if the Stop Loss Order is guaranteed and the Order is filled at the guaranteed price. The value is determined at Order creation time. It is in price units and is charged for each unit of the Trade..</param>
        /// <param name="reason">reason.</param>
        /// <param name="clientExtensions">clientExtensions.</param>
        /// <param name="orderFillTransactionID">The ID of the OrderFill Transaction that caused this Order to be created (only provided if this Order was created automatically when another Order was filled)..</param>
        /// <param name="replacesOrderID">The ID of the Order that this Order replaces (only provided if this Order replaces an existing Order)..</param>
        /// <param name="cancellingTransactionID">The ID of the Transaction that cancels the replaced Order (only provided if this Order replaces an existing Order)..</param>
        public StopLossOrderTransactionBase(int tradeID = default(int), string clientTradeID = default(string), double price = default(double), double distance = default(double), TradeOrderTimeInForce? timeInForce = default(TradeOrderTimeInForce?), string gtdTime = default(string), TradeOrderTriggerCondition? triggerCondition = default(TradeOrderTriggerCondition?), bool guaranteed = default(bool), double guaranteedExecutionPremium = default(double), TradeOrderTransactionReason? reason = default(TradeOrderTransactionReason?), ClientExtensions clientExtensions = default(ClientExtensions), int orderFillTransactionID = default(int), int replacesOrderID = default(int), int cancellingTransactionID = default(int))
        {
            this.TradeID = tradeID;
            this.ClientTradeID = clientTradeID;
            this.Price = price;
            this.Distance = distance;
            this.TimeInForce = timeInForce;
            this.GtdTime = gtdTime;
            this.TriggerCondition = triggerCondition;
            this.Guaranteed = guaranteed;
            this.GuaranteedExecutionPremium = guaranteedExecutionPremium;
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.OrderFillTransactionID = orderFillTransactionID;
            this.ReplacesOrderID = replacesOrderID;
            this.CancellingTransactionID = cancellingTransactionID;
        }
        
        /// <summary>
        /// The ID of the Trade to close when the price threshold is breached.
        /// </summary>
        /// <value>The ID of the Trade to close when the price threshold is breached.</value>
        [DataMember(Name="tradeID", EmitDefaultValue=false)]
        public int TradeID { get; set; }

        /// <summary>
        /// The client ID of the Trade to be closed when the price threshold is breached.
        /// </summary>
        /// <value>The client ID of the Trade to be closed when the price threshold is breached.</value>
        [DataMember(Name="clientTradeID", EmitDefaultValue=false)]
        public string ClientTradeID { get; set; }

        /// <summary>
        /// The price threshold specified for the Stop Loss Order. If the guaranteed flag is false, the associated Trade will be closed by a market price that is equal to or worse than this threshold. If the flag is true the associated Trade will be closed at this price.
        /// </summary>
        /// <value>The price threshold specified for the Stop Loss Order. If the guaranteed flag is false, the associated Trade will be closed by a market price that is equal to or worse than this threshold. If the flag is true the associated Trade will be closed at this price.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double Price { get; set; }

        /// <summary>
        /// Specifies the distance (in price units) from the Account&#39;s current price to use as the Stop Loss Order price. If the Trade is short the Instrument&#39;s bid price is used, and for long Trades the ask is used.
        /// </summary>
        /// <value>Specifies the distance (in price units) from the Account&#39;s current price to use as the Stop Loss Order price. If the Trade is short the Instrument&#39;s bid price is used, and for long Trades the ask is used.</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public double Distance { get; set; }

        /// <summary>
        /// A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).
        /// </summary>
        /// <value>A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).</value>
        [DataMember(Name="gtdTime", EmitDefaultValue=false)]
        public string GtdTime { get; set; }

        /// <summary>
        /// Flag indicating that the Stop Loss Order is guaranteed. The default value depends on the GuaranteedStopLossOrderMode of the account, if it is REQUIRED, the default will be true, for DISABLED or ENABLED the default is false.
        /// </summary>
        /// <value>Flag indicating that the Stop Loss Order is guaranteed. The default value depends on the GuaranteedStopLossOrderMode of the account, if it is REQUIRED, the default will be true, for DISABLED or ENABLED the default is false.</value>
        [DataMember(Name="guaranteed", EmitDefaultValue=false)]
        public bool Guaranteed { get; set; }

        /// <summary>
        /// The fee that will be charged if the Stop Loss Order is guaranteed and the Order is filled at the guaranteed price. The value is determined at Order creation time. It is in price units and is charged for each unit of the Trade.
        /// </summary>
        /// <value>The fee that will be charged if the Stop Loss Order is guaranteed and the Order is filled at the guaranteed price. The value is determined at Order creation time. It is in price units and is charged for each unit of the Trade.</value>
        [DataMember(Name="guaranteedExecutionPremium", EmitDefaultValue=false)]
        public double GuaranteedExecutionPremium { get; set; }

        /// <summary>
        /// Gets or Sets ClientExtensions
        /// </summary>
        [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
        public ClientExtensions ClientExtensions { get; set; }

        /// <summary>
        /// The ID of the OrderFill Transaction that caused this Order to be created (only provided if this Order was created automatically when another Order was filled).
        /// </summary>
        /// <value>The ID of the OrderFill Transaction that caused this Order to be created (only provided if this Order was created automatically when another Order was filled).</value>
        [DataMember(Name="orderFillTransactionID", EmitDefaultValue=false)]
        public int OrderFillTransactionID { get; set; }

        /// <summary>
        /// The ID of the Order that this Order replaces (only provided if this Order replaces an existing Order).
        /// </summary>
        /// <value>The ID of the Order that this Order replaces (only provided if this Order replaces an existing Order).</value>
        [DataMember(Name="replacesOrderID", EmitDefaultValue=false)]
        public int ReplacesOrderID { get; set; }

        /// <summary>
        /// The ID of the Transaction that cancels the replaced Order (only provided if this Order replaces an existing Order).
        /// </summary>
        /// <value>The ID of the Transaction that cancels the replaced Order (only provided if this Order replaces an existing Order).</value>
        [DataMember(Name="cancellingTransactionID", EmitDefaultValue=false)]
        public int CancellingTransactionID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopLossOrderTransactionBase {\n");
            sb.Append("  TradeID: ").Append(TradeID).Append("\n");
            sb.Append("  ClientTradeID: ").Append(ClientTradeID).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
            sb.Append("  TriggerCondition: ").Append(TriggerCondition).Append("\n");
            sb.Append("  Guaranteed: ").Append(Guaranteed).Append("\n");
            sb.Append("  GuaranteedExecutionPremium: ").Append(GuaranteedExecutionPremium).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
            sb.Append("  OrderFillTransactionID: ").Append(OrderFillTransactionID).Append("\n");
            sb.Append("  ReplacesOrderID: ").Append(ReplacesOrderID).Append("\n");
            sb.Append("  CancellingTransactionID: ").Append(CancellingTransactionID).Append("\n");
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
            return this.Equals(input as StopLossOrderTransactionBase);
        }

        /// <summary>
        /// Returns true if StopLossOrderTransactionBase instances are equal
        /// </summary>
        /// <param name="input">Instance of StopLossOrderTransactionBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StopLossOrderTransactionBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TradeID == input.TradeID ||
                    this.TradeID.Equals(input.TradeID)
                ) && 
                (
                    this.ClientTradeID == input.ClientTradeID ||
                    (this.ClientTradeID != null &&
                    this.ClientTradeID.Equals(input.ClientTradeID))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Distance == input.Distance ||
                    this.Distance.Equals(input.Distance)
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    this.TimeInForce.Equals(input.TimeInForce)
                ) && 
                (
                    this.GtdTime == input.GtdTime ||
                    (this.GtdTime != null &&
                    this.GtdTime.Equals(input.GtdTime))
                ) && 
                (
                    this.TriggerCondition == input.TriggerCondition ||
                    this.TriggerCondition.Equals(input.TriggerCondition)
                ) && 
                (
                    this.Guaranteed == input.Guaranteed ||
                    this.Guaranteed.Equals(input.Guaranteed)
                ) && 
                (
                    this.GuaranteedExecutionPremium == input.GuaranteedExecutionPremium ||
                    this.GuaranteedExecutionPremium.Equals(input.GuaranteedExecutionPremium)
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
                ) && 
                (
                    this.ClientExtensions == input.ClientExtensions ||
                    (this.ClientExtensions != null &&
                    this.ClientExtensions.Equals(input.ClientExtensions))
                ) && 
                (
                    this.OrderFillTransactionID == input.OrderFillTransactionID ||
                    this.OrderFillTransactionID.Equals(input.OrderFillTransactionID)
                ) && 
                (
                    this.ReplacesOrderID == input.ReplacesOrderID ||
                    this.ReplacesOrderID.Equals(input.ReplacesOrderID)
                ) && 
                (
                    this.CancellingTransactionID == input.CancellingTransactionID ||
                    this.CancellingTransactionID.Equals(input.CancellingTransactionID)
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
                hashCode = hashCode * 59 + this.TradeID.GetHashCode();
                if (this.ClientTradeID != null)
                    hashCode = hashCode * 59 + this.ClientTradeID.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Distance.GetHashCode();
                hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.GtdTime != null)
                    hashCode = hashCode * 59 + this.GtdTime.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerCondition.GetHashCode();
                hashCode = hashCode * 59 + this.Guaranteed.GetHashCode();
                hashCode = hashCode * 59 + this.GuaranteedExecutionPremium.GetHashCode();
                hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.ClientExtensions != null)
                    hashCode = hashCode * 59 + this.ClientExtensions.GetHashCode();
                hashCode = hashCode * 59 + this.OrderFillTransactionID.GetHashCode();
                hashCode = hashCode * 59 + this.ReplacesOrderID.GetHashCode();
                hashCode = hashCode * 59 + this.CancellingTransactionID.GetHashCode();
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
            // GtdTime (string) pattern
            Regex regexGtdTime = new Regex(@"^(?:(?:\\d+(?:\\.\\d{1,9})?)|(?:[1-9]\\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)T(?:[01]\\d|2[0-3]):[0-5]\\d:[0-5]\\d(?:\\.\\d{1,9})?(?:Z|[+-][01]\\d:[0-5]\\d))$", RegexOptions.CultureInvariant);
            if (false == regexGtdTime.Match(this.GtdTime).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GtdTime, must match a pattern of " + regexGtdTime, new [] { "GtdTime" });
            }

            yield break;
        }
    }

}