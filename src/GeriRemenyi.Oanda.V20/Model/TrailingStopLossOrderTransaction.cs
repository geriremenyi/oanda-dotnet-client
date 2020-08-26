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
    /// A TrailingStopLossOrderTransaction represents the creation of a TrailingStopLoss Order in the user&#39;s Account.
    /// </summary>
    [DataContract]
    public partial class TrailingStopLossOrderTransaction :  IEquatable<TrailingStopLossOrderTransaction>, IValidatableObject
    {
        /// <summary>
        /// The Type of the Transaction.
        /// </summary>
        /// <value>The Type of the Transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum CREATE for value: CREATE
            /// </summary>
            [EnumMember(Value = "CREATE")]
            CREATE = 1,

            /// <summary>
            /// Enum CLOSE for value: CLOSE
            /// </summary>
            [EnumMember(Value = "CLOSE")]
            CLOSE = 2,

            /// <summary>
            /// Enum REOPEN for value: REOPEN
            /// </summary>
            [EnumMember(Value = "REOPEN")]
            REOPEN = 3,

            /// <summary>
            /// Enum CLIENTCONFIGURE for value: CLIENT_CONFIGURE
            /// </summary>
            [EnumMember(Value = "CLIENT_CONFIGURE")]
            CLIENTCONFIGURE = 4,

            /// <summary>
            /// Enum CLIENTCONFIGUREREJECT for value: CLIENT_CONFIGURE_REJECT
            /// </summary>
            [EnumMember(Value = "CLIENT_CONFIGURE_REJECT")]
            CLIENTCONFIGUREREJECT = 5,

            /// <summary>
            /// Enum TRANSFERFUNDS for value: TRANSFER_FUNDS
            /// </summary>
            [EnumMember(Value = "TRANSFER_FUNDS")]
            TRANSFERFUNDS = 6,

            /// <summary>
            /// Enum TRANSFERFUNDSREJECT for value: TRANSFER_FUNDS_REJECT
            /// </summary>
            [EnumMember(Value = "TRANSFER_FUNDS_REJECT")]
            TRANSFERFUNDSREJECT = 7,

            /// <summary>
            /// Enum MARKETORDER for value: MARKET_ORDER
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER")]
            MARKETORDER = 8,

            /// <summary>
            /// Enum MARKETORDERREJECT for value: MARKET_ORDER_REJECT
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER_REJECT")]
            MARKETORDERREJECT = 9,

            /// <summary>
            /// Enum FIXEDPRICEORDER for value: FIXED_PRICE_ORDER
            /// </summary>
            [EnumMember(Value = "FIXED_PRICE_ORDER")]
            FIXEDPRICEORDER = 10,

            /// <summary>
            /// Enum LIMITORDER for value: LIMIT_ORDER
            /// </summary>
            [EnumMember(Value = "LIMIT_ORDER")]
            LIMITORDER = 11,

            /// <summary>
            /// Enum LIMITORDERREJECT for value: LIMIT_ORDER_REJECT
            /// </summary>
            [EnumMember(Value = "LIMIT_ORDER_REJECT")]
            LIMITORDERREJECT = 12,

            /// <summary>
            /// Enum STOPORDER for value: STOP_ORDER
            /// </summary>
            [EnumMember(Value = "STOP_ORDER")]
            STOPORDER = 13,

            /// <summary>
            /// Enum STOPORDERREJECT for value: STOP_ORDER_REJECT
            /// </summary>
            [EnumMember(Value = "STOP_ORDER_REJECT")]
            STOPORDERREJECT = 14,

            /// <summary>
            /// Enum MARKETIFTOUCHEDORDER for value: MARKET_IF_TOUCHED_ORDER
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER")]
            MARKETIFTOUCHEDORDER = 15,

            /// <summary>
            /// Enum MARKETIFTOUCHEDORDERREJECT for value: MARKET_IF_TOUCHED_ORDER_REJECT
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER_REJECT")]
            MARKETIFTOUCHEDORDERREJECT = 16,

            /// <summary>
            /// Enum TAKEPROFITORDER for value: TAKE_PROFIT_ORDER
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT_ORDER")]
            TAKEPROFITORDER = 17,

            /// <summary>
            /// Enum TAKEPROFITORDERREJECT for value: TAKE_PROFIT_ORDER_REJECT
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT_ORDER_REJECT")]
            TAKEPROFITORDERREJECT = 18,

            /// <summary>
            /// Enum STOPLOSSORDER for value: STOP_LOSS_ORDER
            /// </summary>
            [EnumMember(Value = "STOP_LOSS_ORDER")]
            STOPLOSSORDER = 19,

            /// <summary>
            /// Enum STOPLOSSORDERREJECT for value: STOP_LOSS_ORDER_REJECT
            /// </summary>
            [EnumMember(Value = "STOP_LOSS_ORDER_REJECT")]
            STOPLOSSORDERREJECT = 20,

            /// <summary>
            /// Enum TRAILINGSTOPLOSSORDER for value: TRAILING_STOP_LOSS_ORDER
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER")]
            TRAILINGSTOPLOSSORDER = 21,

            /// <summary>
            /// Enum TRAILINGSTOPLOSSORDERREJECT for value: TRAILING_STOP_LOSS_ORDER_REJECT
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER_REJECT")]
            TRAILINGSTOPLOSSORDERREJECT = 22,

            /// <summary>
            /// Enum ORDERFILL for value: ORDER_FILL
            /// </summary>
            [EnumMember(Value = "ORDER_FILL")]
            ORDERFILL = 23,

            /// <summary>
            /// Enum ORDERCANCEL for value: ORDER_CANCEL
            /// </summary>
            [EnumMember(Value = "ORDER_CANCEL")]
            ORDERCANCEL = 24,

            /// <summary>
            /// Enum ORDERCANCELREJECT for value: ORDER_CANCEL_REJECT
            /// </summary>
            [EnumMember(Value = "ORDER_CANCEL_REJECT")]
            ORDERCANCELREJECT = 25,

            /// <summary>
            /// Enum ORDERCLIENTEXTENSIONSMODIFY for value: ORDER_CLIENT_EXTENSIONS_MODIFY
            /// </summary>
            [EnumMember(Value = "ORDER_CLIENT_EXTENSIONS_MODIFY")]
            ORDERCLIENTEXTENSIONSMODIFY = 26,

            /// <summary>
            /// Enum ORDERCLIENTEXTENSIONSMODIFYREJECT for value: ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT
            /// </summary>
            [EnumMember(Value = "ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT")]
            ORDERCLIENTEXTENSIONSMODIFYREJECT = 27,

            /// <summary>
            /// Enum TRADECLIENTEXTENSIONSMODIFY for value: TRADE_CLIENT_EXTENSIONS_MODIFY
            /// </summary>
            [EnumMember(Value = "TRADE_CLIENT_EXTENSIONS_MODIFY")]
            TRADECLIENTEXTENSIONSMODIFY = 28,

            /// <summary>
            /// Enum TRADECLIENTEXTENSIONSMODIFYREJECT for value: TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT
            /// </summary>
            [EnumMember(Value = "TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT")]
            TRADECLIENTEXTENSIONSMODIFYREJECT = 29,

            /// <summary>
            /// Enum MARGINCALLENTER for value: MARGIN_CALL_ENTER
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_ENTER")]
            MARGINCALLENTER = 30,

            /// <summary>
            /// Enum MARGINCALLEXTEND for value: MARGIN_CALL_EXTEND
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_EXTEND")]
            MARGINCALLEXTEND = 31,

            /// <summary>
            /// Enum MARGINCALLEXIT for value: MARGIN_CALL_EXIT
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_EXIT")]
            MARGINCALLEXIT = 32,

            /// <summary>
            /// Enum DELAYEDTRADECLOSURE for value: DELAYED_TRADE_CLOSURE
            /// </summary>
            [EnumMember(Value = "DELAYED_TRADE_CLOSURE")]
            DELAYEDTRADECLOSURE = 33,

            /// <summary>
            /// Enum DAILYFINANCING for value: DAILY_FINANCING
            /// </summary>
            [EnumMember(Value = "DAILY_FINANCING")]
            DAILYFINANCING = 34,

            /// <summary>
            /// Enum RESETRESETTABLEPL for value: RESET_RESETTABLE_PL
            /// </summary>
            [EnumMember(Value = "RESET_RESETTABLE_PL")]
            RESETRESETTABLEPL = 35

        }

        /// <summary>
        /// The Type of the Transaction.
        /// </summary>
        /// <value>The Type of the Transaction.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD.
        /// </summary>
        /// <value>The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeInForceEnum
        {
            /// <summary>
            /// Enum GTC for value: GTC
            /// </summary>
            [EnumMember(Value = "GTC")]
            GTC = 1,

            /// <summary>
            /// Enum GTD for value: GTD
            /// </summary>
            [EnumMember(Value = "GTD")]
            GTD = 2,

            /// <summary>
            /// Enum GFD for value: GFD
            /// </summary>
            [EnumMember(Value = "GFD")]
            GFD = 3

        }

        /// <summary>
        /// The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD.
        /// </summary>
        /// <value>The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD.</value>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Specification of which price component should be used when determining if an Order should be triggered and filled. This allows Orders to be triggered based on the bid, ask, mid, default (ask for buy, bid for sell) or inverse (ask for sell, bid for buy) price depending on the desired behaviour. Orders are always filled using their default price component. A special restriction applies when creating a guaranteed Stop Loss Order. In this case the TriggerCondition value must either be \&quot;DEFAULT\&quot;, or the \&quot;natural\&quot; trigger side \&quot;DEFAULT\&quot; results in. So for a Stop Loss Order for a long trade valid values are \&quot;DEFAULT\&quot; and \&quot;BID\&quot;, and for short trades \&quot;DEFAULT\&quot; and \&quot;ASK\&quot; are valid.
        /// </summary>
        /// <value>Specification of which price component should be used when determining if an Order should be triggered and filled. This allows Orders to be triggered based on the bid, ask, mid, default (ask for buy, bid for sell) or inverse (ask for sell, bid for buy) price depending on the desired behaviour. Orders are always filled using their default price component. A special restriction applies when creating a guaranteed Stop Loss Order. In this case the TriggerCondition value must either be \&quot;DEFAULT\&quot;, or the \&quot;natural\&quot; trigger side \&quot;DEFAULT\&quot; results in. So for a Stop Loss Order for a long trade valid values are \&quot;DEFAULT\&quot; and \&quot;BID\&quot;, and for short trades \&quot;DEFAULT\&quot; and \&quot;ASK\&quot; are valid.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TriggerConditionEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT = 1,

            /// <summary>
            /// Enum INVERSE for value: INVERSE
            /// </summary>
            [EnumMember(Value = "INVERSE")]
            INVERSE = 2,

            /// <summary>
            /// Enum BID for value: BID
            /// </summary>
            [EnumMember(Value = "BID")]
            BID = 3,

            /// <summary>
            /// Enum ASK for value: ASK
            /// </summary>
            [EnumMember(Value = "ASK")]
            ASK = 4,

            /// <summary>
            /// Enum MID for value: MID
            /// </summary>
            [EnumMember(Value = "MID")]
            MID = 5

        }

        /// <summary>
        /// Specification of which price component should be used when determining if an Order should be triggered and filled. This allows Orders to be triggered based on the bid, ask, mid, default (ask for buy, bid for sell) or inverse (ask for sell, bid for buy) price depending on the desired behaviour. Orders are always filled using their default price component. A special restriction applies when creating a guaranteed Stop Loss Order. In this case the TriggerCondition value must either be \&quot;DEFAULT\&quot;, or the \&quot;natural\&quot; trigger side \&quot;DEFAULT\&quot; results in. So for a Stop Loss Order for a long trade valid values are \&quot;DEFAULT\&quot; and \&quot;BID\&quot;, and for short trades \&quot;DEFAULT\&quot; and \&quot;ASK\&quot; are valid.
        /// </summary>
        /// <value>Specification of which price component should be used when determining if an Order should be triggered and filled. This allows Orders to be triggered based on the bid, ask, mid, default (ask for buy, bid for sell) or inverse (ask for sell, bid for buy) price depending on the desired behaviour. Orders are always filled using their default price component. A special restriction applies when creating a guaranteed Stop Loss Order. In this case the TriggerCondition value must either be \&quot;DEFAULT\&quot;, or the \&quot;natural\&quot; trigger side \&quot;DEFAULT\&quot; results in. So for a Stop Loss Order for a long trade valid values are \&quot;DEFAULT\&quot; and \&quot;BID\&quot;, and for short trades \&quot;DEFAULT\&quot; and \&quot;ASK\&quot; are valid.</value>
        [DataMember(Name="triggerCondition", EmitDefaultValue=false)]
        public TriggerConditionEnum? TriggerCondition { get; set; }
        /// <summary>
        /// The reason that the Stop Loss Order was initiated
        /// </summary>
        /// <value>The reason that the Stop Loss Order was initiated</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum CLIENTORDER for value: CLIENT_ORDER
            /// </summary>
            [EnumMember(Value = "CLIENT_ORDER")]
            CLIENTORDER = 1,

            /// <summary>
            /// Enum REPLACEMENT for value: REPLACEMENT
            /// </summary>
            [EnumMember(Value = "REPLACEMENT")]
            REPLACEMENT = 2,

            /// <summary>
            /// Enum ONFILL for value: ON_FILL
            /// </summary>
            [EnumMember(Value = "ON_FILL")]
            ONFILL = 3

        }

        /// <summary>
        /// The reason that the Stop Loss Order was initiated
        /// </summary>
        /// <value>The reason that the Stop Loss Order was initiated</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrailingStopLossOrderTransaction" /> class.
        /// </summary>
        /// <param name="id">The Transaction&#39;s Identifier..</param>
        /// <param name="time">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        /// <param name="userID">The ID of the user that initiated the creation of the Transaction..</param>
        /// <param name="accountID">The Account&#39;s identifier.</param>
        /// <param name="batchID">The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously..</param>
        /// <param name="requestID">The Request ID of the request which generated the transaction..</param>
        /// <param name="type">The Type of the Transaction..</param>
        /// <param name="tradeID">The ID of the Trade to close when the price threshold is breached..</param>
        /// <param name="clientTradeID">The client ID of the Trade to be closed when the price threshold is breached..</param>
        /// <param name="distance">Specifies the distance (in price units) from the Account&#39;s current price to use as the Stop Loss Order price. If the Trade is short the Instrument&#39;s bid price is used, and for long Trades the ask is used..</param>
        /// <param name="timeInForce">The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD..</param>
        /// <param name="gtdTime">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        /// <param name="triggerCondition">Specification of which price component should be used when determining if an Order should be triggered and filled. This allows Orders to be triggered based on the bid, ask, mid, default (ask for buy, bid for sell) or inverse (ask for sell, bid for buy) price depending on the desired behaviour. Orders are always filled using their default price component. A special restriction applies when creating a guaranteed Stop Loss Order. In this case the TriggerCondition value must either be \&quot;DEFAULT\&quot;, or the \&quot;natural\&quot; trigger side \&quot;DEFAULT\&quot; results in. So for a Stop Loss Order for a long trade valid values are \&quot;DEFAULT\&quot; and \&quot;BID\&quot;, and for short trades \&quot;DEFAULT\&quot; and \&quot;ASK\&quot; are valid..</param>
        /// <param name="reason">The reason that the Stop Loss Order was initiated.</param>
        /// <param name="clientExtensions">clientExtensions.</param>
        /// <param name="orderFillTransactionID">The ID of the OrderFill Transaction that caused this Order to be created (only provided if this Order was created automatically when another Order was filled)..</param>
        /// <param name="replacesOrderID">The ID of the Order that this Order replaces (only provided if this Order replaces an existing Order)..</param>
        /// <param name="cancellingTransactionID">The ID of the Transaction that cancels the replaced Order (only provided if this Order replaces an existing Order)..</param>
        public TrailingStopLossOrderTransaction(int id = default(int), string time = default(string), int userID = default(int), string accountID = default(string), int batchID = default(int), string requestID = default(string), TypeEnum? type = default(TypeEnum?), int tradeID = default(int), string clientTradeID = default(string), double distance = default(double), TimeInForceEnum? timeInForce = default(TimeInForceEnum?), string gtdTime = default(string), TriggerConditionEnum? triggerCondition = default(TriggerConditionEnum?), ReasonEnum? reason = default(ReasonEnum?), InlineResponse2005ChangesClientExtensions clientExtensions = default(InlineResponse2005ChangesClientExtensions), int orderFillTransactionID = default(int), int replacesOrderID = default(int), int cancellingTransactionID = default(int))
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.TradeID = tradeID;
            this.ClientTradeID = clientTradeID;
            this.Distance = distance;
            this.TimeInForce = timeInForce;
            this.GtdTime = gtdTime;
            this.TriggerCondition = triggerCondition;
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.OrderFillTransactionID = orderFillTransactionID;
            this.ReplacesOrderID = replacesOrderID;
            this.CancellingTransactionID = cancellingTransactionID;
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
        /// Gets or Sets ClientExtensions
        /// </summary>
        [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
        public InlineResponse2005ChangesClientExtensions ClientExtensions { get; set; }

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
            sb.Append("class TrailingStopLossOrderTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  BatchID: ").Append(BatchID).Append("\n");
            sb.Append("  RequestID: ").Append(RequestID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TradeID: ").Append(TradeID).Append("\n");
            sb.Append("  ClientTradeID: ").Append(ClientTradeID).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
            sb.Append("  TriggerCondition: ").Append(TriggerCondition).Append("\n");
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
            return this.Equals(input as TrailingStopLossOrderTransaction);
        }

        /// <summary>
        /// Returns true if TrailingStopLossOrderTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of TrailingStopLossOrderTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrailingStopLossOrderTransaction input)
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
                    this.TradeID == input.TradeID ||
                    this.TradeID.Equals(input.TradeID)
                ) && 
                (
                    this.ClientTradeID == input.ClientTradeID ||
                    (this.ClientTradeID != null &&
                    this.ClientTradeID.Equals(input.ClientTradeID))
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
                hashCode = hashCode * 59 + this.TradeID.GetHashCode();
                if (this.ClientTradeID != null)
                    hashCode = hashCode * 59 + this.ClientTradeID.GetHashCode();
                hashCode = hashCode * 59 + this.Distance.GetHashCode();
                hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.GtdTime != null)
                    hashCode = hashCode * 59 + this.GtdTime.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerCondition.GetHashCode();
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
