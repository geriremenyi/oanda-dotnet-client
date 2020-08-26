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
    /// A MarketOrder represents the creation of a Market Order in the user&#39;s account. A Market Order is an Order that is filled immediately at the current market price.
    /// </summary>
    [DataContract]
    public partial class MarketOrderRejectTransactionAllOf :  IEquatable<MarketOrderRejectTransactionAllOf>, IValidatableObject
    {
        /// <summary>
        /// Instrument name identifier. Used by clients to refer to an Instrument.
        /// </summary>
        /// <value>Instrument name identifier. Used by clients to refer to an Instrument.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentEnum
        {
            /// <summary>
            /// Enum AUDCAD for value: AUD_CAD
            /// </summary>
            [EnumMember(Value = "AUD_CAD")]
            AUDCAD = 1,

            /// <summary>
            /// Enum AUDCHF for value: AUD_CHF
            /// </summary>
            [EnumMember(Value = "AUD_CHF")]
            AUDCHF = 2,

            /// <summary>
            /// Enum AUDHKD for value: AUD_HKD
            /// </summary>
            [EnumMember(Value = "AUD_HKD")]
            AUDHKD = 3,

            /// <summary>
            /// Enum AUDJPY for value: AUD_JPY
            /// </summary>
            [EnumMember(Value = "AUD_JPY")]
            AUDJPY = 4,

            /// <summary>
            /// Enum AUDNZD for value: AUD_NZD
            /// </summary>
            [EnumMember(Value = "AUD_NZD")]
            AUDNZD = 5,

            /// <summary>
            /// Enum AUDSGD for value: AUD_SGD
            /// </summary>
            [EnumMember(Value = "AUD_SGD")]
            AUDSGD = 6,

            /// <summary>
            /// Enum AUDUSD for value: AUD_USD
            /// </summary>
            [EnumMember(Value = "AUD_USD")]
            AUDUSD = 7,

            /// <summary>
            /// Enum CADCHF for value: CAD_CHF
            /// </summary>
            [EnumMember(Value = "CAD_CHF")]
            CADCHF = 8,

            /// <summary>
            /// Enum CADHKD for value: CAD_HKD
            /// </summary>
            [EnumMember(Value = "CAD_HKD")]
            CADHKD = 9,

            /// <summary>
            /// Enum CADJPY for value: CAD_JPY
            /// </summary>
            [EnumMember(Value = "CAD_JPY")]
            CADJPY = 10,

            /// <summary>
            /// Enum CADSGD for value: CAD_SGD
            /// </summary>
            [EnumMember(Value = "CAD_SGD")]
            CADSGD = 11,

            /// <summary>
            /// Enum CHFHKD for value: CHF_HKD
            /// </summary>
            [EnumMember(Value = "CHF_HKD")]
            CHFHKD = 12,

            /// <summary>
            /// Enum CHFJPY for value: CHF_JPY
            /// </summary>
            [EnumMember(Value = "CHF_JPY")]
            CHFJPY = 13,

            /// <summary>
            /// Enum CHFZAR for value: CHF_ZAR
            /// </summary>
            [EnumMember(Value = "CHF_ZAR")]
            CHFZAR = 14,

            /// <summary>
            /// Enum EURAUD for value: EUR_AUD
            /// </summary>
            [EnumMember(Value = "EUR_AUD")]
            EURAUD = 15,

            /// <summary>
            /// Enum EURCAD for value: EUR_CAD
            /// </summary>
            [EnumMember(Value = "EUR_CAD")]
            EURCAD = 16,

            /// <summary>
            /// Enum EURCHF for value: EUR_CHF
            /// </summary>
            [EnumMember(Value = "EUR_CHF")]
            EURCHF = 17,

            /// <summary>
            /// Enum EURCZK for value: EUR_CZK
            /// </summary>
            [EnumMember(Value = "EUR_CZK")]
            EURCZK = 18,

            /// <summary>
            /// Enum EURDKK for value: EUR_DKK
            /// </summary>
            [EnumMember(Value = "EUR_DKK")]
            EURDKK = 19,

            /// <summary>
            /// Enum EURGBP for value: EUR_GBP
            /// </summary>
            [EnumMember(Value = "EUR_GBP")]
            EURGBP = 20,

            /// <summary>
            /// Enum EURHKD for value: EUR_HKD
            /// </summary>
            [EnumMember(Value = "EUR_HKD")]
            EURHKD = 21,

            /// <summary>
            /// Enum EURHUF for value: EUR_HUF
            /// </summary>
            [EnumMember(Value = "EUR_HUF")]
            EURHUF = 22,

            /// <summary>
            /// Enum EURJPY for value: EUR_JPY
            /// </summary>
            [EnumMember(Value = "EUR_JPY")]
            EURJPY = 23,

            /// <summary>
            /// Enum EURNOK for value: EUR_NOK
            /// </summary>
            [EnumMember(Value = "EUR_NOK")]
            EURNOK = 24,

            /// <summary>
            /// Enum EURNZD for value: EUR_NZD
            /// </summary>
            [EnumMember(Value = "EUR_NZD")]
            EURNZD = 25,

            /// <summary>
            /// Enum EURPLN for value: EUR_PLN
            /// </summary>
            [EnumMember(Value = "EUR_PLN")]
            EURPLN = 26,

            /// <summary>
            /// Enum EURSEK for value: EUR_SEK
            /// </summary>
            [EnumMember(Value = "EUR_SEK")]
            EURSEK = 27,

            /// <summary>
            /// Enum EURSGD for value: EUR_SGD
            /// </summary>
            [EnumMember(Value = "EUR_SGD")]
            EURSGD = 28,

            /// <summary>
            /// Enum EURTRY for value: EUR_TRY
            /// </summary>
            [EnumMember(Value = "EUR_TRY")]
            EURTRY = 29,

            /// <summary>
            /// Enum EURUSD for value: EUR_USD
            /// </summary>
            [EnumMember(Value = "EUR_USD")]
            EURUSD = 30,

            /// <summary>
            /// Enum EURZAR for value: EUR_ZAR
            /// </summary>
            [EnumMember(Value = "EUR_ZAR")]
            EURZAR = 31,

            /// <summary>
            /// Enum GBPAUD for value: GBP_AUD
            /// </summary>
            [EnumMember(Value = "GBP_AUD")]
            GBPAUD = 32,

            /// <summary>
            /// Enum GBPCAD for value: GBP_CAD
            /// </summary>
            [EnumMember(Value = "GBP_CAD")]
            GBPCAD = 33,

            /// <summary>
            /// Enum GBPCHF for value: GBP_CHF
            /// </summary>
            [EnumMember(Value = "GBP_CHF")]
            GBPCHF = 34,

            /// <summary>
            /// Enum GBPHKD for value: GBP_HKD
            /// </summary>
            [EnumMember(Value = "GBP_HKD")]
            GBPHKD = 35,

            /// <summary>
            /// Enum GBPJPY for value: GBP_JPY
            /// </summary>
            [EnumMember(Value = "GBP_JPY")]
            GBPJPY = 36,

            /// <summary>
            /// Enum GBPNZD for value: GBP_NZD
            /// </summary>
            [EnumMember(Value = "GBP_NZD")]
            GBPNZD = 37,

            /// <summary>
            /// Enum GBPPLN for value: GBP_PLN
            /// </summary>
            [EnumMember(Value = "GBP_PLN")]
            GBPPLN = 38,

            /// <summary>
            /// Enum GBPSGD for value: GBP_SGD
            /// </summary>
            [EnumMember(Value = "GBP_SGD")]
            GBPSGD = 39,

            /// <summary>
            /// Enum GBPUSD for value: GBP_USD
            /// </summary>
            [EnumMember(Value = "GBP_USD")]
            GBPUSD = 40,

            /// <summary>
            /// Enum GBPZAR for value: GBP_ZAR
            /// </summary>
            [EnumMember(Value = "GBP_ZAR")]
            GBPZAR = 41,

            /// <summary>
            /// Enum HKDJPY for value: HKD_JPY
            /// </summary>
            [EnumMember(Value = "HKD_JPY")]
            HKDJPY = 42,

            /// <summary>
            /// Enum NZDCAD for value: NZD_CAD
            /// </summary>
            [EnumMember(Value = "NZD_CAD")]
            NZDCAD = 43,

            /// <summary>
            /// Enum NZDCHF for value: NZD_CHF
            /// </summary>
            [EnumMember(Value = "NZD_CHF")]
            NZDCHF = 44,

            /// <summary>
            /// Enum NZDHKD for value: NZD_HKD
            /// </summary>
            [EnumMember(Value = "NZD_HKD")]
            NZDHKD = 45,

            /// <summary>
            /// Enum NZDJPY for value: NZD_JPY
            /// </summary>
            [EnumMember(Value = "NZD_JPY")]
            NZDJPY = 46,

            /// <summary>
            /// Enum NZDSGD for value: NZD_SGD
            /// </summary>
            [EnumMember(Value = "NZD_SGD")]
            NZDSGD = 47,

            /// <summary>
            /// Enum NZDUSD for value: NZD_USD
            /// </summary>
            [EnumMember(Value = "NZD_USD")]
            NZDUSD = 48,

            /// <summary>
            /// Enum SGDCHF for value: SGD_CHF
            /// </summary>
            [EnumMember(Value = "SGD_CHF")]
            SGDCHF = 49,

            /// <summary>
            /// Enum SGDHKD for value: SGD_HKD
            /// </summary>
            [EnumMember(Value = "SGD_HKD")]
            SGDHKD = 50,

            /// <summary>
            /// Enum SGDJPY for value: SGD_JPY
            /// </summary>
            [EnumMember(Value = "SGD_JPY")]
            SGDJPY = 51,

            /// <summary>
            /// Enum TRYJPY for value: TRY_JPY
            /// </summary>
            [EnumMember(Value = "TRY_JPY")]
            TRYJPY = 52,

            /// <summary>
            /// Enum USDCAD for value: USD_CAD
            /// </summary>
            [EnumMember(Value = "USD_CAD")]
            USDCAD = 53,

            /// <summary>
            /// Enum USDCHF for value: USD_CHF
            /// </summary>
            [EnumMember(Value = "USD_CHF")]
            USDCHF = 54,

            /// <summary>
            /// Enum USDCNH for value: USD_CNH
            /// </summary>
            [EnumMember(Value = "USD_CNH")]
            USDCNH = 55,

            /// <summary>
            /// Enum USDCZK for value: USD_CZK
            /// </summary>
            [EnumMember(Value = "USD_CZK")]
            USDCZK = 56,

            /// <summary>
            /// Enum USDDKK for value: USD_DKK
            /// </summary>
            [EnumMember(Value = "USD_DKK")]
            USDDKK = 57,

            /// <summary>
            /// Enum USDHKD for value: USD_HKD
            /// </summary>
            [EnumMember(Value = "USD_HKD")]
            USDHKD = 58,

            /// <summary>
            /// Enum USDHUF for value: USD_HUF
            /// </summary>
            [EnumMember(Value = "USD_HUF")]
            USDHUF = 59,

            /// <summary>
            /// Enum USDJPY for value: USD_JPY
            /// </summary>
            [EnumMember(Value = "USD_JPY")]
            USDJPY = 60,

            /// <summary>
            /// Enum USDMXN for value: USD_MXN
            /// </summary>
            [EnumMember(Value = "USD_MXN")]
            USDMXN = 61,

            /// <summary>
            /// Enum USDNOK for value: USD_NOK
            /// </summary>
            [EnumMember(Value = "USD_NOK")]
            USDNOK = 62,

            /// <summary>
            /// Enum USDPLN for value: USD_PLN
            /// </summary>
            [EnumMember(Value = "USD_PLN")]
            USDPLN = 63,

            /// <summary>
            /// Enum USDSAR for value: USD_SAR
            /// </summary>
            [EnumMember(Value = "USD_SAR")]
            USDSAR = 64,

            /// <summary>
            /// Enum USDSEK for value: USD_SEK
            /// </summary>
            [EnumMember(Value = "USD_SEK")]
            USDSEK = 65,

            /// <summary>
            /// Enum USDSGD for value: USD_SGD
            /// </summary>
            [EnumMember(Value = "USD_SGD")]
            USDSGD = 66,

            /// <summary>
            /// Enum USDTHB for value: USD_THB
            /// </summary>
            [EnumMember(Value = "USD_THB")]
            USDTHB = 67,

            /// <summary>
            /// Enum USDTRY for value: USD_TRY
            /// </summary>
            [EnumMember(Value = "USD_TRY")]
            USDTRY = 68,

            /// <summary>
            /// Enum USDZAR for value: USD_ZAR
            /// </summary>
            [EnumMember(Value = "USD_ZAR")]
            USDZAR = 69,

            /// <summary>
            /// Enum ZARJPY for value: ZAR_JPY
            /// </summary>
            [EnumMember(Value = "ZAR_JPY")]
            ZARJPY = 70

        }

        /// <summary>
        /// Instrument name identifier. Used by clients to refer to an Instrument.
        /// </summary>
        /// <value>Instrument name identifier. Used by clients to refer to an Instrument.</value>
        [DataMember(Name="instrument", EmitDefaultValue=false)]
        public InstrumentEnum? Instrument { get; set; }
        /// <summary>
        /// The time-in-force requested for the Market Order. Restricted to FOK or IOC for a MarketOrder.
        /// </summary>
        /// <value>The time-in-force requested for the Market Order. Restricted to FOK or IOC for a MarketOrder.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeInForceEnum
        {
            /// <summary>
            /// Enum FOK for value: FOK
            /// </summary>
            [EnumMember(Value = "FOK")]
            FOK = 1,

            /// <summary>
            /// Enum IOC for value: IOC
            /// </summary>
            [EnumMember(Value = "IOC")]
            IOC = 2

        }

        /// <summary>
        /// The time-in-force requested for the Market Order. Restricted to FOK or IOC for a MarketOrder.
        /// </summary>
        /// <value>The time-in-force requested for the Market Order. Restricted to FOK or IOC for a MarketOrder.</value>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Specification of how Positions in the Account are modified when the Order is filled.
        /// </summary>
        /// <value>Specification of how Positions in the Account are modified when the Order is filled.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PositionFillEnum
        {
            /// <summary>
            /// Enum OPENONLY for value: OPEN_ONLY
            /// </summary>
            [EnumMember(Value = "OPEN_ONLY")]
            OPENONLY = 1,

            /// <summary>
            /// Enum REDUCEFIRST for value: REDUCE_FIRST
            /// </summary>
            [EnumMember(Value = "REDUCE_FIRST")]
            REDUCEFIRST = 2,

            /// <summary>
            /// Enum REDUCEONLY for value: REDUCE_ONLY
            /// </summary>
            [EnumMember(Value = "REDUCE_ONLY")]
            REDUCEONLY = 3,

            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT = 4

        }

        /// <summary>
        /// Specification of how Positions in the Account are modified when the Order is filled.
        /// </summary>
        /// <value>Specification of how Positions in the Account are modified when the Order is filled.</value>
        [DataMember(Name="positionFill", EmitDefaultValue=false)]
        public PositionFillEnum? PositionFill { get; set; }
        /// <summary>
        /// The reason that the Market Order was created
        /// </summary>
        /// <value>The reason that the Market Order was created</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum CLIENTORDER for value: CLIENT_ORDER
            /// </summary>
            [EnumMember(Value = "CLIENT_ORDER")]
            CLIENTORDER = 1,

            /// <summary>
            /// Enum TRADECLOSE for value: TRADE_CLOSE
            /// </summary>
            [EnumMember(Value = "TRADE_CLOSE")]
            TRADECLOSE = 2,

            /// <summary>
            /// Enum POSITIONCLOSEOUT for value: POSITION_CLOSEOUT
            /// </summary>
            [EnumMember(Value = "POSITION_CLOSEOUT")]
            POSITIONCLOSEOUT = 3,

            /// <summary>
            /// Enum MARGINCLOSEOUT for value: MARGIN_CLOSEOUT
            /// </summary>
            [EnumMember(Value = "MARGIN_CLOSEOUT")]
            MARGINCLOSEOUT = 4,

            /// <summary>
            /// Enum DELAYEDTRADECLOSE for value: DELAYED_TRADE_CLOSE
            /// </summary>
            [EnumMember(Value = "DELAYED_TRADE_CLOSE")]
            DELAYEDTRADECLOSE = 5

        }

        /// <summary>
        /// The reason that the Market Order was created
        /// </summary>
        /// <value>The reason that the Market Order was created</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketOrderRejectTransactionAllOf" /> class.
        /// </summary>
        /// <param name="instrument">Instrument name identifier. Used by clients to refer to an Instrument..</param>
        /// <param name="units">The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order..</param>
        /// <param name="timeInForce">The time-in-force requested for the Market Order. Restricted to FOK or IOC for a MarketOrder..</param>
        /// <param name="priceBound">The worst price that the client is willing to have the Market Order filled at..</param>
        /// <param name="positionFill">Specification of how Positions in the Account are modified when the Order is filled..</param>
        /// <param name="tradeClose">tradeClose.</param>
        /// <param name="longPositionCloseout">longPositionCloseout.</param>
        /// <param name="shortPositionCloseout">shortPositionCloseout.</param>
        /// <param name="marginCloseout">marginCloseout.</param>
        /// <param name="delayedTradeClose">delayedTradeClose.</param>
        /// <param name="reason">The reason that the Market Order was created.</param>
        /// <param name="clientExtensions">clientExtensions.</param>
        /// <param name="takeProfitOnFill">takeProfitOnFill.</param>
        /// <param name="stopLossOnFill">stopLossOnFill.</param>
        /// <param name="trailingStopLossOnFill">trailingStopLossOnFill.</param>
        /// <param name="tradeClientExtensions">tradeClientExtensions.</param>
        public MarketOrderRejectTransactionAllOf(InstrumentEnum? instrument = default(InstrumentEnum?), double units = default(double), TimeInForceEnum? timeInForce = default(TimeInForceEnum?), double priceBound = default(double), PositionFillEnum? positionFill = default(PositionFillEnum?), MarketOrderTradeClose tradeClose = default(MarketOrderTradeClose), MarketOrderLongPositionCloseout longPositionCloseout = default(MarketOrderLongPositionCloseout), MarketOrderLongPositionCloseout shortPositionCloseout = default(MarketOrderLongPositionCloseout), MarketOrderMarginCloseout marginCloseout = default(MarketOrderMarginCloseout), MarketOrderDelayedTradeClose delayedTradeClose = default(MarketOrderDelayedTradeClose), ReasonEnum? reason = default(ReasonEnum?), InlineResponse2005ChangesClientExtensions clientExtensions = default(InlineResponse2005ChangesClientExtensions), AccountsAccountIDTradesTradeSpecifierOrdersTakeProfit takeProfitOnFill = default(AccountsAccountIDTradesTradeSpecifierOrdersTakeProfit), AccountsAccountIDTradesTradeSpecifierOrdersStopLoss stopLossOnFill = default(AccountsAccountIDTradesTradeSpecifierOrdersStopLoss), AccountsAccountIDTradesTradeSpecifierOrdersTrailingStopLoss trailingStopLossOnFill = default(AccountsAccountIDTradesTradeSpecifierOrdersTrailingStopLoss), InlineResponse2005ChangesClientExtensions tradeClientExtensions = default(InlineResponse2005ChangesClientExtensions))
        {
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
        /// The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.
        /// </summary>
        /// <value>The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public double Units { get; set; }

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
        public MarketOrderLongPositionCloseout LongPositionCloseout { get; set; }

        /// <summary>
        /// Gets or Sets ShortPositionCloseout
        /// </summary>
        [DataMember(Name="shortPositionCloseout", EmitDefaultValue=false)]
        public MarketOrderLongPositionCloseout ShortPositionCloseout { get; set; }

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
        public InlineResponse2005ChangesClientExtensions ClientExtensions { get; set; }

        /// <summary>
        /// Gets or Sets TakeProfitOnFill
        /// </summary>
        [DataMember(Name="takeProfitOnFill", EmitDefaultValue=false)]
        public AccountsAccountIDTradesTradeSpecifierOrdersTakeProfit TakeProfitOnFill { get; set; }

        /// <summary>
        /// Gets or Sets StopLossOnFill
        /// </summary>
        [DataMember(Name="stopLossOnFill", EmitDefaultValue=false)]
        public AccountsAccountIDTradesTradeSpecifierOrdersStopLoss StopLossOnFill { get; set; }

        /// <summary>
        /// Gets or Sets TrailingStopLossOnFill
        /// </summary>
        [DataMember(Name="trailingStopLossOnFill", EmitDefaultValue=false)]
        public AccountsAccountIDTradesTradeSpecifierOrdersTrailingStopLoss TrailingStopLossOnFill { get; set; }

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
            sb.Append("class MarketOrderRejectTransactionAllOf {\n");
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
            return this.Equals(input as MarketOrderRejectTransactionAllOf);
        }

        /// <summary>
        /// Returns true if MarketOrderRejectTransactionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketOrderRejectTransactionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketOrderRejectTransactionAllOf input)
        {
            if (input == null)
                return false;

            return 
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
                    this.TimeInForce.Equals(input.TimeInForce)
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
                hashCode = hashCode * 59 + this.Instrument.GetHashCode();
                hashCode = hashCode * 59 + this.Units.GetHashCode();
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
            yield break;
        }
    }

}