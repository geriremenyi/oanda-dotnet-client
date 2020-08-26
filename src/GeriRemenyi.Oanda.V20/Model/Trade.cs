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
    /// The specification of a Trade within an Account. This includes the full representation of the Trade&#39;s dependent Orders in addition to the IDs of those Orders.
    /// </summary>
    [DataContract]
    public partial class Trade :  IEquatable<Trade>, IValidatableObject
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
        /// The current state of the Trade.
        /// </summary>
        /// <value>The current state of the Trade.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum OPEN for value: OPEN
            /// </summary>
            [EnumMember(Value = "OPEN")]
            OPEN = 1,

            /// <summary>
            /// Enum CLOSED for value: CLOSED
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED = 2,

            /// <summary>
            /// Enum CLOSEWHENTRADEABLE for value: CLOSE_WHEN_TRADEABLE
            /// </summary>
            [EnumMember(Value = "CLOSE_WHEN_TRADEABLE")]
            CLOSEWHENTRADEABLE = 3

        }

        /// <summary>
        /// The current state of the Trade.
        /// </summary>
        /// <value>The current state of the Trade.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Trade" /> class.
        /// </summary>
        /// <param name="id">The Trade&#39;s identifier, unique within the Trade&#39;s Account..</param>
        /// <param name="instrument">Instrument name identifier. Used by clients to refer to an Instrument..</param>
        /// <param name="price">The execution price of the Trade..</param>
        /// <param name="openTime">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        /// <param name="state">The current state of the Trade..</param>
        /// <param name="initialUnits">The initial size of the Trade. Negative values indicate a short Trade, and positive values indicate a long Trade..</param>
        /// <param name="initialMarginRequired">The margin required at the time the Trade was created. Note, this is the &#39;pure&#39; margin required, it is not the &#39;effective&#39; margin used that factors in the trade risk if a GSLO is attached to the trade..</param>
        /// <param name="currentUnits">The number of units currently open for the Trade. This value is reduced to 0.0 as the Trade is closed..</param>
        /// <param name="realizedPL">The total profit/loss realized on the closed portion of the Trade..</param>
        /// <param name="unrealizedPL">The unrealized profit/loss on the open portion of the Trade..</param>
        /// <param name="marginUsed">Margin currently used by the Trade..</param>
        /// <param name="averageClosePrice">The average closing price of the Trade. Only present if the Trade has been closed or reduced at least once..</param>
        /// <param name="closingTransactionIDs">The IDs of the Transactions that have closed portions of this Trade..</param>
        /// <param name="financing">The financing paid/collected for this Trade..</param>
        /// <param name="closeTime">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        /// <param name="clientExtensions">clientExtensions.</param>
        /// <param name="takeProfitOrder">A TakeProfitOrder is an order that is linked to an open Trade and created with a price threshold. The Order will be filled (closing the Trade) by the first price that is equal to or better than the threshold. A TakeProfitOrder cannot be used to open a new Position..</param>
        /// <param name="stopLossOrder">A StopLossOrder is an order that is linked to an open Trade and created with a price threshold. The Order will be filled (closing the Trade) by the first price that is equal to or worse than the threshold. A StopLossOrder cannot be used to open a new Position..</param>
        /// <param name="trailingStopLossOrder">A TrailingStopLossOrder is an order that is linked to an open Trade and created with a price distance. The price distance is used to calculate a trailing stop value for the order that is in the losing direction from the market price at the time of the order&#39;s creation. The trailing stop value will follow the market price as it moves in the winning direction, and the order will filled (closing the Trade) by the first price that is equal to or worse than the trailing stop value. A TrailingStopLossOrder cannot be used to open a new Position..</param>
        public Trade(int id = default(int), InstrumentEnum? instrument = default(InstrumentEnum?), double price = default(double), string openTime = default(string), StateEnum? state = default(StateEnum?), double initialUnits = default(double), double initialMarginRequired = default(double), double currentUnits = default(double), double realizedPL = default(double), double unrealizedPL = default(double), double marginUsed = default(double), double averageClosePrice = default(double), List<int> closingTransactionIDs = default(List<int>), double financing = default(double), string closeTime = default(string), InlineResponse2005ChangesClientExtensions clientExtensions = default(InlineResponse2005ChangesClientExtensions), Object takeProfitOrder = default(Object), Object stopLossOrder = default(Object), Object trailingStopLossOrder = default(Object))
        {
            this.Id = id;
            this.Instrument = instrument;
            this.Price = price;
            this.OpenTime = openTime;
            this.State = state;
            this.InitialUnits = initialUnits;
            this.InitialMarginRequired = initialMarginRequired;
            this.CurrentUnits = currentUnits;
            this.RealizedPL = realizedPL;
            this.UnrealizedPL = unrealizedPL;
            this.MarginUsed = marginUsed;
            this.AverageClosePrice = averageClosePrice;
            this.ClosingTransactionIDs = closingTransactionIDs;
            this.Financing = financing;
            this.CloseTime = closeTime;
            this.ClientExtensions = clientExtensions;
            this.TakeProfitOrder = takeProfitOrder;
            this.StopLossOrder = stopLossOrder;
            this.TrailingStopLossOrder = trailingStopLossOrder;
        }
        
        /// <summary>
        /// The Trade&#39;s identifier, unique within the Trade&#39;s Account.
        /// </summary>
        /// <value>The Trade&#39;s identifier, unique within the Trade&#39;s Account.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The execution price of the Trade.
        /// </summary>
        /// <value>The execution price of the Trade.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double Price { get; set; }

        /// <summary>
        /// A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).
        /// </summary>
        /// <value>A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).</value>
        [DataMember(Name="openTime", EmitDefaultValue=false)]
        public string OpenTime { get; set; }

        /// <summary>
        /// The initial size of the Trade. Negative values indicate a short Trade, and positive values indicate a long Trade.
        /// </summary>
        /// <value>The initial size of the Trade. Negative values indicate a short Trade, and positive values indicate a long Trade.</value>
        [DataMember(Name="initialUnits", EmitDefaultValue=false)]
        public double InitialUnits { get; set; }

        /// <summary>
        /// The margin required at the time the Trade was created. Note, this is the &#39;pure&#39; margin required, it is not the &#39;effective&#39; margin used that factors in the trade risk if a GSLO is attached to the trade.
        /// </summary>
        /// <value>The margin required at the time the Trade was created. Note, this is the &#39;pure&#39; margin required, it is not the &#39;effective&#39; margin used that factors in the trade risk if a GSLO is attached to the trade.</value>
        [DataMember(Name="initialMarginRequired", EmitDefaultValue=false)]
        public double InitialMarginRequired { get; set; }

        /// <summary>
        /// The number of units currently open for the Trade. This value is reduced to 0.0 as the Trade is closed.
        /// </summary>
        /// <value>The number of units currently open for the Trade. This value is reduced to 0.0 as the Trade is closed.</value>
        [DataMember(Name="currentUnits", EmitDefaultValue=false)]
        public double CurrentUnits { get; set; }

        /// <summary>
        /// The total profit/loss realized on the closed portion of the Trade.
        /// </summary>
        /// <value>The total profit/loss realized on the closed portion of the Trade.</value>
        [DataMember(Name="realizedPL", EmitDefaultValue=false)]
        public double RealizedPL { get; set; }

        /// <summary>
        /// The unrealized profit/loss on the open portion of the Trade.
        /// </summary>
        /// <value>The unrealized profit/loss on the open portion of the Trade.</value>
        [DataMember(Name="unrealizedPL", EmitDefaultValue=false)]
        public double UnrealizedPL { get; set; }

        /// <summary>
        /// Margin currently used by the Trade.
        /// </summary>
        /// <value>Margin currently used by the Trade.</value>
        [DataMember(Name="marginUsed", EmitDefaultValue=false)]
        public double MarginUsed { get; set; }

        /// <summary>
        /// The average closing price of the Trade. Only present if the Trade has been closed or reduced at least once.
        /// </summary>
        /// <value>The average closing price of the Trade. Only present if the Trade has been closed or reduced at least once.</value>
        [DataMember(Name="averageClosePrice", EmitDefaultValue=false)]
        public double AverageClosePrice { get; set; }

        /// <summary>
        /// The IDs of the Transactions that have closed portions of this Trade.
        /// </summary>
        /// <value>The IDs of the Transactions that have closed portions of this Trade.</value>
        [DataMember(Name="closingTransactionIDs", EmitDefaultValue=false)]
        public List<int> ClosingTransactionIDs { get; set; }

        /// <summary>
        /// The financing paid/collected for this Trade.
        /// </summary>
        /// <value>The financing paid/collected for this Trade.</value>
        [DataMember(Name="financing", EmitDefaultValue=false)]
        public double Financing { get; set; }

        /// <summary>
        /// A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).
        /// </summary>
        /// <value>A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).</value>
        [DataMember(Name="closeTime", EmitDefaultValue=false)]
        public string CloseTime { get; set; }

        /// <summary>
        /// Gets or Sets ClientExtensions
        /// </summary>
        [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
        public InlineResponse2005ChangesClientExtensions ClientExtensions { get; set; }

        /// <summary>
        /// A TakeProfitOrder is an order that is linked to an open Trade and created with a price threshold. The Order will be filled (closing the Trade) by the first price that is equal to or better than the threshold. A TakeProfitOrder cannot be used to open a new Position.
        /// </summary>
        /// <value>A TakeProfitOrder is an order that is linked to an open Trade and created with a price threshold. The Order will be filled (closing the Trade) by the first price that is equal to or better than the threshold. A TakeProfitOrder cannot be used to open a new Position.</value>
        [DataMember(Name="takeProfitOrder", EmitDefaultValue=false)]
        public Object TakeProfitOrder { get; set; }

        /// <summary>
        /// A StopLossOrder is an order that is linked to an open Trade and created with a price threshold. The Order will be filled (closing the Trade) by the first price that is equal to or worse than the threshold. A StopLossOrder cannot be used to open a new Position.
        /// </summary>
        /// <value>A StopLossOrder is an order that is linked to an open Trade and created with a price threshold. The Order will be filled (closing the Trade) by the first price that is equal to or worse than the threshold. A StopLossOrder cannot be used to open a new Position.</value>
        [DataMember(Name="stopLossOrder", EmitDefaultValue=false)]
        public Object StopLossOrder { get; set; }

        /// <summary>
        /// A TrailingStopLossOrder is an order that is linked to an open Trade and created with a price distance. The price distance is used to calculate a trailing stop value for the order that is in the losing direction from the market price at the time of the order&#39;s creation. The trailing stop value will follow the market price as it moves in the winning direction, and the order will filled (closing the Trade) by the first price that is equal to or worse than the trailing stop value. A TrailingStopLossOrder cannot be used to open a new Position.
        /// </summary>
        /// <value>A TrailingStopLossOrder is an order that is linked to an open Trade and created with a price distance. The price distance is used to calculate a trailing stop value for the order that is in the losing direction from the market price at the time of the order&#39;s creation. The trailing stop value will follow the market price as it moves in the winning direction, and the order will filled (closing the Trade) by the first price that is equal to or worse than the trailing stop value. A TrailingStopLossOrder cannot be used to open a new Position.</value>
        [DataMember(Name="trailingStopLossOrder", EmitDefaultValue=false)]
        public Object TrailingStopLossOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trade {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  OpenTime: ").Append(OpenTime).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  InitialUnits: ").Append(InitialUnits).Append("\n");
            sb.Append("  InitialMarginRequired: ").Append(InitialMarginRequired).Append("\n");
            sb.Append("  CurrentUnits: ").Append(CurrentUnits).Append("\n");
            sb.Append("  RealizedPL: ").Append(RealizedPL).Append("\n");
            sb.Append("  UnrealizedPL: ").Append(UnrealizedPL).Append("\n");
            sb.Append("  MarginUsed: ").Append(MarginUsed).Append("\n");
            sb.Append("  AverageClosePrice: ").Append(AverageClosePrice).Append("\n");
            sb.Append("  ClosingTransactionIDs: ").Append(ClosingTransactionIDs).Append("\n");
            sb.Append("  Financing: ").Append(Financing).Append("\n");
            sb.Append("  CloseTime: ").Append(CloseTime).Append("\n");
            sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
            sb.Append("  TakeProfitOrder: ").Append(TakeProfitOrder).Append("\n");
            sb.Append("  StopLossOrder: ").Append(StopLossOrder).Append("\n");
            sb.Append("  TrailingStopLossOrder: ").Append(TrailingStopLossOrder).Append("\n");
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
            return this.Equals(input as Trade);
        }

        /// <summary>
        /// Returns true if Trade instances are equal
        /// </summary>
        /// <param name="input">Instance of Trade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trade input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Instrument == input.Instrument ||
                    this.Instrument.Equals(input.Instrument)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.OpenTime == input.OpenTime ||
                    (this.OpenTime != null &&
                    this.OpenTime.Equals(input.OpenTime))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.InitialUnits == input.InitialUnits ||
                    this.InitialUnits.Equals(input.InitialUnits)
                ) && 
                (
                    this.InitialMarginRequired == input.InitialMarginRequired ||
                    this.InitialMarginRequired.Equals(input.InitialMarginRequired)
                ) && 
                (
                    this.CurrentUnits == input.CurrentUnits ||
                    this.CurrentUnits.Equals(input.CurrentUnits)
                ) && 
                (
                    this.RealizedPL == input.RealizedPL ||
                    this.RealizedPL.Equals(input.RealizedPL)
                ) && 
                (
                    this.UnrealizedPL == input.UnrealizedPL ||
                    this.UnrealizedPL.Equals(input.UnrealizedPL)
                ) && 
                (
                    this.MarginUsed == input.MarginUsed ||
                    this.MarginUsed.Equals(input.MarginUsed)
                ) && 
                (
                    this.AverageClosePrice == input.AverageClosePrice ||
                    this.AverageClosePrice.Equals(input.AverageClosePrice)
                ) && 
                (
                    this.ClosingTransactionIDs == input.ClosingTransactionIDs ||
                    this.ClosingTransactionIDs != null &&
                    input.ClosingTransactionIDs != null &&
                    this.ClosingTransactionIDs.SequenceEqual(input.ClosingTransactionIDs)
                ) && 
                (
                    this.Financing == input.Financing ||
                    this.Financing.Equals(input.Financing)
                ) && 
                (
                    this.CloseTime == input.CloseTime ||
                    (this.CloseTime != null &&
                    this.CloseTime.Equals(input.CloseTime))
                ) && 
                (
                    this.ClientExtensions == input.ClientExtensions ||
                    (this.ClientExtensions != null &&
                    this.ClientExtensions.Equals(input.ClientExtensions))
                ) && 
                (
                    this.TakeProfitOrder == input.TakeProfitOrder ||
                    (this.TakeProfitOrder != null &&
                    this.TakeProfitOrder.Equals(input.TakeProfitOrder))
                ) && 
                (
                    this.StopLossOrder == input.StopLossOrder ||
                    (this.StopLossOrder != null &&
                    this.StopLossOrder.Equals(input.StopLossOrder))
                ) && 
                (
                    this.TrailingStopLossOrder == input.TrailingStopLossOrder ||
                    (this.TrailingStopLossOrder != null &&
                    this.TrailingStopLossOrder.Equals(input.TrailingStopLossOrder))
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
                hashCode = hashCode * 59 + this.Instrument.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.OpenTime != null)
                    hashCode = hashCode * 59 + this.OpenTime.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.InitialUnits.GetHashCode();
                hashCode = hashCode * 59 + this.InitialMarginRequired.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentUnits.GetHashCode();
                hashCode = hashCode * 59 + this.RealizedPL.GetHashCode();
                hashCode = hashCode * 59 + this.UnrealizedPL.GetHashCode();
                hashCode = hashCode * 59 + this.MarginUsed.GetHashCode();
                hashCode = hashCode * 59 + this.AverageClosePrice.GetHashCode();
                if (this.ClosingTransactionIDs != null)
                    hashCode = hashCode * 59 + this.ClosingTransactionIDs.GetHashCode();
                hashCode = hashCode * 59 + this.Financing.GetHashCode();
                if (this.CloseTime != null)
                    hashCode = hashCode * 59 + this.CloseTime.GetHashCode();
                if (this.ClientExtensions != null)
                    hashCode = hashCode * 59 + this.ClientExtensions.GetHashCode();
                if (this.TakeProfitOrder != null)
                    hashCode = hashCode * 59 + this.TakeProfitOrder.GetHashCode();
                if (this.StopLossOrder != null)
                    hashCode = hashCode * 59 + this.StopLossOrder.GetHashCode();
                if (this.TrailingStopLossOrder != null)
                    hashCode = hashCode * 59 + this.TrailingStopLossOrder.GetHashCode();
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
            // OpenTime (string) pattern
            Regex regexOpenTime = new Regex(@"^(?:(?:\\d+(?:\\.\\d{1,9})?)|(?:[1-9]\\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)T(?:[01]\\d|2[0-3]):[0-5]\\d:[0-5]\\d(?:\\.\\d{1,9})?(?:Z|[+-][01]\\d:[0-5]\\d))$", RegexOptions.CultureInvariant);
            if (false == regexOpenTime.Match(this.OpenTime).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OpenTime, must match a pattern of " + regexOpenTime, new [] { "OpenTime" });
            }

            // CloseTime (string) pattern
            Regex regexCloseTime = new Regex(@"^(?:(?:\\d+(?:\\.\\d{1,9})?)|(?:[1-9]\\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)T(?:[01]\\d|2[0-3]):[0-5]\\d:[0-5]\\d(?:\\.\\d{1,9})?(?:Z|[+-][01]\\d:[0-5]\\d))$", RegexOptions.CultureInvariant);
            if (false == regexCloseTime.Match(this.CloseTime).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CloseTime, must match a pattern of " + regexCloseTime, new [] { "CloseTime" });
            }

            yield break;
        }
    }

}
