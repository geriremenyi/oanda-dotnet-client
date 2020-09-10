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
    /// TradeOrderBaseAllOf
    /// </summary>
    [DataContract]
    public partial class TradeOrderBaseAllOf :  IEquatable<TradeOrderBaseAllOf>, IValidatableObject
    {
        /// <summary>
        /// The type of the Order.
        /// </summary>
        /// <value>The type of the Order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum TAKEPROFIT for value: TAKE_PROFIT
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT")]
            TAKEPROFIT = 1,

            /// <summary>
            /// Enum STOPLOSS for value: STOP_LOSS
            /// </summary>
            [EnumMember(Value = "STOP_LOSS")]
            STOPLOSS = 2,

            /// <summary>
            /// Enum TRAILINGSTOPLOSS for value: TRAILING_STOP_LOSS
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS")]
            TRAILINGSTOPLOSS = 3

        }

        /// <summary>
        /// The type of the Order.
        /// </summary>
        /// <value>The type of the Order.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
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
        /// Initializes a new instance of the <see cref="TradeOrderBaseAllOf" /> class.
        /// </summary>
        /// <param name="type">The type of the Order..</param>
        /// <param name="tradeID">The ID of the Trade to close when the price threshold is breached..</param>
        /// <param name="clientTradeID">The client ID of the Trade to be closed when the price threshold is breached..</param>
        /// <param name="timeInForce">timeInForce.</param>
        /// <param name="gtdTime">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        /// <param name="triggerCondition">triggerCondition.</param>
        /// <param name="fillingTransactionID">ID of the Transaction that filled this Order (only provided when the Order&#39;s state is FILLED).</param>
        /// <param name="filledTime">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        /// <param name="tradeOpenedID">Trade ID of Trade opened when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was opened as a result of the fill).</param>
        /// <param name="tradeReducedID">Trade ID of Trade reduced when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was reduced as a result of the fill).</param>
        /// <param name="tradeClosedIDs">Trade IDs of Trades closed when the Order was filled (only provided when the Order&#39;s state is FILLED and one or more Trades were closed as a result of the fill).</param>
        /// <param name="cancellingTransactionID">ID of the Transaction that cancelled the Order (only provided when the Order&#39;s state is CANCELLED).</param>
        /// <param name="cancelledTime">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        /// <param name="replacesOrderID">The ID of the Order that was replaced by this Order (only provided if this Order was created as part of a cancel/replace)..</param>
        /// <param name="replacedByOrderID">The ID of the Order that replaced this Order (only provided if this Order was cancelled as part of a cancel/replace)..</param>
        public TradeOrderBaseAllOf(TypeEnum? type = default(TypeEnum?), int tradeID = default(int), string clientTradeID = default(string), TradeOrderTimeInForce? timeInForce = default(TradeOrderTimeInForce?), string gtdTime = default(string), TradeOrderTriggerCondition? triggerCondition = default(TradeOrderTriggerCondition?), int fillingTransactionID = default(int), string filledTime = default(string), int tradeOpenedID = default(int), int tradeReducedID = default(int), List<int> tradeClosedIDs = default(List<int>), int cancellingTransactionID = default(int), string cancelledTime = default(string), int replacesOrderID = default(int), int replacedByOrderID = default(int))
        {
            this.Type = type;
            this.TradeID = tradeID;
            this.ClientTradeID = clientTradeID;
            this.TimeInForce = timeInForce;
            this.GtdTime = gtdTime;
            this.TriggerCondition = triggerCondition;
            this.FillingTransactionID = fillingTransactionID;
            this.FilledTime = filledTime;
            this.TradeOpenedID = tradeOpenedID;
            this.TradeReducedID = tradeReducedID;
            this.TradeClosedIDs = tradeClosedIDs;
            this.CancellingTransactionID = cancellingTransactionID;
            this.CancelledTime = cancelledTime;
            this.ReplacesOrderID = replacesOrderID;
            this.ReplacedByOrderID = replacedByOrderID;
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
        /// A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).
        /// </summary>
        /// <value>A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).</value>
        [DataMember(Name="gtdTime", EmitDefaultValue=false)]
        public string GtdTime { get; set; }

        /// <summary>
        /// ID of the Transaction that filled this Order (only provided when the Order&#39;s state is FILLED)
        /// </summary>
        /// <value>ID of the Transaction that filled this Order (only provided when the Order&#39;s state is FILLED)</value>
        [DataMember(Name="fillingTransactionID", EmitDefaultValue=false)]
        public int FillingTransactionID { get; set; }

        /// <summary>
        /// A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).
        /// </summary>
        /// <value>A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).</value>
        [DataMember(Name="filledTime", EmitDefaultValue=false)]
        public string FilledTime { get; set; }

        /// <summary>
        /// Trade ID of Trade opened when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was opened as a result of the fill)
        /// </summary>
        /// <value>Trade ID of Trade opened when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was opened as a result of the fill)</value>
        [DataMember(Name="tradeOpenedID", EmitDefaultValue=false)]
        public int TradeOpenedID { get; set; }

        /// <summary>
        /// Trade ID of Trade reduced when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was reduced as a result of the fill)
        /// </summary>
        /// <value>Trade ID of Trade reduced when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was reduced as a result of the fill)</value>
        [DataMember(Name="tradeReducedID", EmitDefaultValue=false)]
        public int TradeReducedID { get; set; }

        /// <summary>
        /// Trade IDs of Trades closed when the Order was filled (only provided when the Order&#39;s state is FILLED and one or more Trades were closed as a result of the fill)
        /// </summary>
        /// <value>Trade IDs of Trades closed when the Order was filled (only provided when the Order&#39;s state is FILLED and one or more Trades were closed as a result of the fill)</value>
        [DataMember(Name="tradeClosedIDs", EmitDefaultValue=false)]
        public List<int> TradeClosedIDs { get; set; }

        /// <summary>
        /// ID of the Transaction that cancelled the Order (only provided when the Order&#39;s state is CANCELLED)
        /// </summary>
        /// <value>ID of the Transaction that cancelled the Order (only provided when the Order&#39;s state is CANCELLED)</value>
        [DataMember(Name="cancellingTransactionID", EmitDefaultValue=false)]
        public int CancellingTransactionID { get; set; }

        /// <summary>
        /// A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).
        /// </summary>
        /// <value>A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).</value>
        [DataMember(Name="cancelledTime", EmitDefaultValue=false)]
        public string CancelledTime { get; set; }

        /// <summary>
        /// The ID of the Order that was replaced by this Order (only provided if this Order was created as part of a cancel/replace).
        /// </summary>
        /// <value>The ID of the Order that was replaced by this Order (only provided if this Order was created as part of a cancel/replace).</value>
        [DataMember(Name="replacesOrderID", EmitDefaultValue=false)]
        public int ReplacesOrderID { get; set; }

        /// <summary>
        /// The ID of the Order that replaced this Order (only provided if this Order was cancelled as part of a cancel/replace).
        /// </summary>
        /// <value>The ID of the Order that replaced this Order (only provided if this Order was cancelled as part of a cancel/replace).</value>
        [DataMember(Name="replacedByOrderID", EmitDefaultValue=false)]
        public int ReplacedByOrderID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradeOrderBaseAllOf {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TradeID: ").Append(TradeID).Append("\n");
            sb.Append("  ClientTradeID: ").Append(ClientTradeID).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
            sb.Append("  TriggerCondition: ").Append(TriggerCondition).Append("\n");
            sb.Append("  FillingTransactionID: ").Append(FillingTransactionID).Append("\n");
            sb.Append("  FilledTime: ").Append(FilledTime).Append("\n");
            sb.Append("  TradeOpenedID: ").Append(TradeOpenedID).Append("\n");
            sb.Append("  TradeReducedID: ").Append(TradeReducedID).Append("\n");
            sb.Append("  TradeClosedIDs: ").Append(TradeClosedIDs).Append("\n");
            sb.Append("  CancellingTransactionID: ").Append(CancellingTransactionID).Append("\n");
            sb.Append("  CancelledTime: ").Append(CancelledTime).Append("\n");
            sb.Append("  ReplacesOrderID: ").Append(ReplacesOrderID).Append("\n");
            sb.Append("  ReplacedByOrderID: ").Append(ReplacedByOrderID).Append("\n");
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
            return this.Equals(input as TradeOrderBaseAllOf);
        }

        /// <summary>
        /// Returns true if TradeOrderBaseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeOrderBaseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeOrderBaseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
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
                    this.FillingTransactionID == input.FillingTransactionID ||
                    this.FillingTransactionID.Equals(input.FillingTransactionID)
                ) && 
                (
                    this.FilledTime == input.FilledTime ||
                    (this.FilledTime != null &&
                    this.FilledTime.Equals(input.FilledTime))
                ) && 
                (
                    this.TradeOpenedID == input.TradeOpenedID ||
                    this.TradeOpenedID.Equals(input.TradeOpenedID)
                ) && 
                (
                    this.TradeReducedID == input.TradeReducedID ||
                    this.TradeReducedID.Equals(input.TradeReducedID)
                ) && 
                (
                    this.TradeClosedIDs == input.TradeClosedIDs ||
                    this.TradeClosedIDs != null &&
                    input.TradeClosedIDs != null &&
                    this.TradeClosedIDs.SequenceEqual(input.TradeClosedIDs)
                ) && 
                (
                    this.CancellingTransactionID == input.CancellingTransactionID ||
                    this.CancellingTransactionID.Equals(input.CancellingTransactionID)
                ) && 
                (
                    this.CancelledTime == input.CancelledTime ||
                    (this.CancelledTime != null &&
                    this.CancelledTime.Equals(input.CancelledTime))
                ) && 
                (
                    this.ReplacesOrderID == input.ReplacesOrderID ||
                    this.ReplacesOrderID.Equals(input.ReplacesOrderID)
                ) && 
                (
                    this.ReplacedByOrderID == input.ReplacedByOrderID ||
                    this.ReplacedByOrderID.Equals(input.ReplacedByOrderID)
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
                hashCode = hashCode * 59 + this.TradeID.GetHashCode();
                if (this.ClientTradeID != null)
                    hashCode = hashCode * 59 + this.ClientTradeID.GetHashCode();
                hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.GtdTime != null)
                    hashCode = hashCode * 59 + this.GtdTime.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerCondition.GetHashCode();
                hashCode = hashCode * 59 + this.FillingTransactionID.GetHashCode();
                if (this.FilledTime != null)
                    hashCode = hashCode * 59 + this.FilledTime.GetHashCode();
                hashCode = hashCode * 59 + this.TradeOpenedID.GetHashCode();
                hashCode = hashCode * 59 + this.TradeReducedID.GetHashCode();
                if (this.TradeClosedIDs != null)
                    hashCode = hashCode * 59 + this.TradeClosedIDs.GetHashCode();
                hashCode = hashCode * 59 + this.CancellingTransactionID.GetHashCode();
                if (this.CancelledTime != null)
                    hashCode = hashCode * 59 + this.CancelledTime.GetHashCode();
                hashCode = hashCode * 59 + this.ReplacesOrderID.GetHashCode();
                hashCode = hashCode * 59 + this.ReplacedByOrderID.GetHashCode();
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

            // FilledTime (string) pattern
            Regex regexFilledTime = new Regex(@"^(?:(?:\\d+(?:\\.\\d{1,9})?)|(?:[1-9]\\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)T(?:[01]\\d|2[0-3]):[0-5]\\d:[0-5]\\d(?:\\.\\d{1,9})?(?:Z|[+-][01]\\d:[0-5]\\d))$", RegexOptions.CultureInvariant);
            if (false == regexFilledTime.Match(this.FilledTime).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FilledTime, must match a pattern of " + regexFilledTime, new [] { "FilledTime" });
            }

            // CancelledTime (string) pattern
            Regex regexCancelledTime = new Regex(@"^(?:(?:\\d+(?:\\.\\d{1,9})?)|(?:[1-9]\\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)T(?:[01]\\d|2[0-3]):[0-5]\\d:[0-5]\\d(?:\\.\\d{1,9})?(?:Z|[+-][01]\\d:[0-5]\\d))$", RegexOptions.CultureInvariant);
            if (false == regexCancelledTime.Match(this.CancelledTime).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CancelledTime, must match a pattern of " + regexCancelledTime, new [] { "CancelledTime" });
            }

            yield break;
        }
    }

}