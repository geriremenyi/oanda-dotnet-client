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
    /// A MarketOrderTransaction represents the creation of a Market Order in the user&#39;s account. A Market Order is an Order that is filled immediately at the current market price.
    /// </summary>
    [DataContract]
    public partial class MarketOrderTransaction :  IEquatable<MarketOrderTransaction>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TransactionType? Type { get; set; }
        /// <summary>
        /// Gets or Sets Instrument
        /// </summary>
        [DataMember(Name="instrument", EmitDefaultValue=false)]
        public InstrumentName? Instrument { get; set; }
        /// <summary>
        /// Gets or Sets PositionFill
        /// </summary>
        [DataMember(Name="positionFill", EmitDefaultValue=false)]
        public MarketOrderPositionFill? PositionFill { get; set; }
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public MarketOrderReason? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketOrderTransaction" /> class.
        /// </summary>
        /// <param name="id">The Transaction&#39;s Identifier..</param>
        /// <param name="time">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        /// <param name="userID">The ID of the user that initiated the creation of the Transaction..</param>
        /// <param name="accountID">The Account&#39;s identifier.</param>
        /// <param name="batchID">The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously..</param>
        /// <param name="requestID">The Request ID of the request which generated the transaction..</param>
        /// <param name="type">type.</param>
        /// <param name="instrument">instrument.</param>
        /// <param name="units">The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order..</param>
        /// <param name="timeInForce">timeInForce.</param>
        /// <param name="priceBound">The worst price that the client is willing to have the Market Order filled at..</param>
        /// <param name="positionFill">positionFill.</param>
        /// <param name="tradeClose">tradeClose.</param>
        /// <param name="longPositionCloseout">longPositionCloseout.</param>
        /// <param name="shortPositionCloseout">shortPositionCloseout.</param>
        /// <param name="marginCloseout">marginCloseout.</param>
        /// <param name="delayedTradeClose">delayedTradeClose.</param>
        /// <param name="reason">reason.</param>
        /// <param name="clientExtensions">clientExtensions.</param>
        /// <param name="takeProfitOnFill">takeProfitOnFill.</param>
        /// <param name="stopLossOnFill">stopLossOnFill.</param>
        /// <param name="trailingStopLossOnFill">trailingStopLossOnFill.</param>
        /// <param name="tradeClientExtensions">tradeClientExtensions.</param>
        public MarketOrderTransaction(int id = default(int), string time = default(string), int userID = default(int), string accountID = default(string), int batchID = default(int), string requestID = default(string), TransactionType? type = default(TransactionType?), InstrumentName? instrument = default(InstrumentName?), double units = default(double), MarketOrderTradeClose timeInForce = default(MarketOrderTradeClose), double priceBound = default(double), MarketOrderPositionFill? positionFill = default(MarketOrderPositionFill?), MarketOrderTradeClose tradeClose = default(MarketOrderTradeClose), MarketOrderPositionCloseout longPositionCloseout = default(MarketOrderPositionCloseout), MarketOrderPositionCloseout shortPositionCloseout = default(MarketOrderPositionCloseout), MarketOrderMarginCloseout marginCloseout = default(MarketOrderMarginCloseout), MarketOrderDelayedTradeClose delayedTradeClose = default(MarketOrderDelayedTradeClose), MarketOrderReason? reason = default(MarketOrderReason?), ClientExtensions clientExtensions = default(ClientExtensions), TakeProfitDetails takeProfitOnFill = default(TakeProfitDetails), StopLossDetails stopLossOnFill = default(StopLossDetails), TrailingStopLossDetails trailingStopLossOnFill = default(TrailingStopLossDetails), ClientExtensions tradeClientExtensions = default(ClientExtensions))
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.Instrument = instrument;
            this.Units = units;
            this.TimeInForce = timeInForce;
            this.PriceBound = priceBound;
            this.PositionFill = positionFill;
            this.TradeClose = tradeClose;
            this.LongPositionCloseout = longPositionCloseout;
            this.ShortPositionCloseout = shortPositionCloseout;
            this.MarginCloseout = marginCloseout;
            this.DelayedTradeClose = delayedTradeClose;
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.TakeProfitOnFill = takeProfitOnFill;
            this.StopLossOnFill = stopLossOnFill;
            this.TrailingStopLossOnFill = trailingStopLossOnFill;
            this.TradeClientExtensions = tradeClientExtensions;
        }
        
        /// <summary>
        /// The Transaction&#39;s Identifier.
        /// </summary>
        /// <value>The Transaction&#39;s Identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).
        /// </summary>
        /// <value>A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// The ID of the user that initiated the creation of the Transaction.
        /// </summary>
        /// <value>The ID of the user that initiated the creation of the Transaction.</value>
        [DataMember(Name="userID", EmitDefaultValue=false)]
        public int UserID { get; set; }

        /// <summary>
        /// The Account&#39;s identifier
        /// </summary>
        /// <value>The Account&#39;s identifier</value>
        [DataMember(Name="accountID", EmitDefaultValue=false)]
        public string AccountID { get; set; }

        /// <summary>
        /// The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously.
        /// </summary>
        /// <value>The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously.</value>
        [DataMember(Name="batchID", EmitDefaultValue=false)]
        public int BatchID { get; set; }

        /// <summary>
        /// The Request ID of the request which generated the transaction.
        /// </summary>
        /// <value>The Request ID of the request which generated the transaction.</value>
        [DataMember(Name="requestID", EmitDefaultValue=false)]
        public string RequestID { get; set; }

        /// <summary>
        /// The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.
        /// </summary>
        /// <value>The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public double Units { get; set; }

        /// <summary>
        /// Gets or Sets TimeInForce
        /// </summary>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public MarketOrderTradeClose TimeInForce { get; set; }

        /// <summary>
        /// The worst price that the client is willing to have the Market Order filled at.
        /// </summary>
        /// <value>The worst price that the client is willing to have the Market Order filled at.</value>
        [DataMember(Name="priceBound", EmitDefaultValue=false)]
        public double PriceBound { get; set; }

        /// <summary>
        /// Gets or Sets TradeClose
        /// </summary>
        [DataMember(Name="tradeClose", EmitDefaultValue=false)]
        public MarketOrderTradeClose TradeClose { get; set; }

        /// <summary>
        /// Gets or Sets LongPositionCloseout
        /// </summary>
        [DataMember(Name="longPositionCloseout", EmitDefaultValue=false)]
        public MarketOrderPositionCloseout LongPositionCloseout { get; set; }

        /// <summary>
        /// Gets or Sets ShortPositionCloseout
        /// </summary>
        [DataMember(Name="shortPositionCloseout", EmitDefaultValue=false)]
        public MarketOrderPositionCloseout ShortPositionCloseout { get; set; }

        /// <summary>
        /// Gets or Sets MarginCloseout
        /// </summary>
        [DataMember(Name="marginCloseout", EmitDefaultValue=false)]
        public MarketOrderMarginCloseout MarginCloseout { get; set; }

        /// <summary>
        /// Gets or Sets DelayedTradeClose
        /// </summary>
        [DataMember(Name="delayedTradeClose", EmitDefaultValue=false)]
        public MarketOrderDelayedTradeClose DelayedTradeClose { get; set; }

        /// <summary>
        /// Gets or Sets ClientExtensions
        /// </summary>
        [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
        public ClientExtensions ClientExtensions { get; set; }

        /// <summary>
        /// Gets or Sets TakeProfitOnFill
        /// </summary>
        [DataMember(Name="takeProfitOnFill", EmitDefaultValue=false)]
        public TakeProfitDetails TakeProfitOnFill { get; set; }

        /// <summary>
        /// Gets or Sets StopLossOnFill
        /// </summary>
        [DataMember(Name="stopLossOnFill", EmitDefaultValue=false)]
        public StopLossDetails StopLossOnFill { get; set; }

        /// <summary>
        /// Gets or Sets TrailingStopLossOnFill
        /// </summary>
        [DataMember(Name="trailingStopLossOnFill", EmitDefaultValue=false)]
        public TrailingStopLossDetails TrailingStopLossOnFill { get; set; }

        /// <summary>
        /// Gets or Sets TradeClientExtensions
        /// </summary>
        [DataMember(Name="tradeClientExtensions", EmitDefaultValue=false)]
        public ClientExtensions TradeClientExtensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketOrderTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  BatchID: ").Append(BatchID).Append("\n");
            sb.Append("  RequestID: ").Append(RequestID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  PriceBound: ").Append(PriceBound).Append("\n");
            sb.Append("  PositionFill: ").Append(PositionFill).Append("\n");
            sb.Append("  TradeClose: ").Append(TradeClose).Append("\n");
            sb.Append("  LongPositionCloseout: ").Append(LongPositionCloseout).Append("\n");
            sb.Append("  ShortPositionCloseout: ").Append(ShortPositionCloseout).Append("\n");
            sb.Append("  MarginCloseout: ").Append(MarginCloseout).Append("\n");
            sb.Append("  DelayedTradeClose: ").Append(DelayedTradeClose).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
            sb.Append("  TakeProfitOnFill: ").Append(TakeProfitOnFill).Append("\n");
            sb.Append("  StopLossOnFill: ").Append(StopLossOnFill).Append("\n");
            sb.Append("  TrailingStopLossOnFill: ").Append(TrailingStopLossOnFill).Append("\n");
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
            return this.Equals(input as MarketOrderTransaction);
        }

        /// <summary>
        /// Returns true if MarketOrderTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketOrderTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketOrderTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.UserID == input.UserID ||
                    this.UserID.Equals(input.UserID)
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.BatchID == input.BatchID ||
                    this.BatchID.Equals(input.BatchID)
                ) && 
                (
                    this.RequestID == input.RequestID ||
                    (this.RequestID != null &&
                    this.RequestID.Equals(input.RequestID))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Instrument == input.Instrument ||
                    this.Instrument.Equals(input.Instrument)
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    (this.TimeInForce != null &&
                    this.TimeInForce.Equals(input.TimeInForce))
                ) && 
                (
                    this.PriceBound == input.PriceBound ||
                    this.PriceBound.Equals(input.PriceBound)
                ) && 
                (
                    this.PositionFill == input.PositionFill ||
                    this.PositionFill.Equals(input.PositionFill)
                ) && 
                (
                    this.TradeClose == input.TradeClose ||
                    (this.TradeClose != null &&
                    this.TradeClose.Equals(input.TradeClose))
                ) && 
                (
                    this.LongPositionCloseout == input.LongPositionCloseout ||
                    (this.LongPositionCloseout != null &&
                    this.LongPositionCloseout.Equals(input.LongPositionCloseout))
                ) && 
                (
                    this.ShortPositionCloseout == input.ShortPositionCloseout ||
                    (this.ShortPositionCloseout != null &&
                    this.ShortPositionCloseout.Equals(input.ShortPositionCloseout))
                ) && 
                (
                    this.MarginCloseout == input.MarginCloseout ||
                    (this.MarginCloseout != null &&
                    this.MarginCloseout.Equals(input.MarginCloseout))
                ) && 
                (
                    this.DelayedTradeClose == input.DelayedTradeClose ||
                    (this.DelayedTradeClose != null &&
                    this.DelayedTradeClose.Equals(input.DelayedTradeClose))
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
                    this.TakeProfitOnFill == input.TakeProfitOnFill ||
                    (this.TakeProfitOnFill != null &&
                    this.TakeProfitOnFill.Equals(input.TakeProfitOnFill))
                ) && 
                (
                    this.StopLossOnFill == input.StopLossOnFill ||
                    (this.StopLossOnFill != null &&
                    this.StopLossOnFill.Equals(input.StopLossOnFill))
                ) && 
                (
                    this.TrailingStopLossOnFill == input.TrailingStopLossOnFill ||
                    (this.TrailingStopLossOnFill != null &&
                    this.TrailingStopLossOnFill.Equals(input.TrailingStopLossOnFill))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                hashCode = hashCode * 59 + this.UserID.GetHashCode();
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                hashCode = hashCode * 59 + this.BatchID.GetHashCode();
                if (this.RequestID != null)
                    hashCode = hashCode * 59 + this.RequestID.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Instrument.GetHashCode();
                hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.TimeInForce != null)
                    hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                hashCode = hashCode * 59 + this.PriceBound.GetHashCode();
                hashCode = hashCode * 59 + this.PositionFill.GetHashCode();
                if (this.TradeClose != null)
                    hashCode = hashCode * 59 + this.TradeClose.GetHashCode();
                if (this.LongPositionCloseout != null)
                    hashCode = hashCode * 59 + this.LongPositionCloseout.GetHashCode();
                if (this.ShortPositionCloseout != null)
                    hashCode = hashCode * 59 + this.ShortPositionCloseout.GetHashCode();
                if (this.MarginCloseout != null)
                    hashCode = hashCode * 59 + this.MarginCloseout.GetHashCode();
                if (this.DelayedTradeClose != null)
                    hashCode = hashCode * 59 + this.DelayedTradeClose.GetHashCode();
                hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.ClientExtensions != null)
                    hashCode = hashCode * 59 + this.ClientExtensions.GetHashCode();
                if (this.TakeProfitOnFill != null)
                    hashCode = hashCode * 59 + this.TakeProfitOnFill.GetHashCode();
                if (this.StopLossOnFill != null)
                    hashCode = hashCode * 59 + this.StopLossOnFill.GetHashCode();
                if (this.TrailingStopLossOnFill != null)
                    hashCode = hashCode * 59 + this.TrailingStopLossOnFill.GetHashCode();
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
            // Time (string) pattern
            Regex regexTime = new Regex(@"^(?:(?:\\d+(?:\\.\\d{1,9})?)|(?:[1-9]\\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)T(?:[01]\\d|2[0-3]):[0-5]\\d:[0-5]\\d(?:\\.\\d{1,9})?(?:Z|[+-][01]\\d:[0-5]\\d))$", RegexOptions.CultureInvariant);
            if (false == regexTime.Match(this.Time).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Time, must match a pattern of " + regexTime, new [] { "Time" });
            }

            // AccountID (string) pattern
            Regex regexAccountID = new Regex(@"^\\d+-\\d+-\\d+-\\d+$", RegexOptions.CultureInvariant);
            if (false == regexAccountID.Match(this.AccountID).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountID, must match a pattern of " + regexAccountID, new [] { "AccountID" });
            }

            yield break;
        }
    }

}
