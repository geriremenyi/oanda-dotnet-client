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
    /// A MarketOrderPositionCloseout specifies the extensions to a Market Order when it has been created to closeout a specific Position.
    /// </summary>
    [DataContract]
    public partial class MarketOrderLongPositionCloseout :  IEquatable<MarketOrderLongPositionCloseout>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="MarketOrderLongPositionCloseout" /> class.
        /// </summary>
        /// <param name="instrument">Instrument name identifier. Used by clients to refer to an Instrument..</param>
        /// <param name="units">Either \&quot;ALL\&quot;, or a positive DecimalNumber reflection a partial unit.</param>
        public MarketOrderLongPositionCloseout(InstrumentEnum? instrument = default(InstrumentEnum?), string units = default(string))
        {
            this.Instrument = instrument;
            this.Units = units;
        }
        
        /// <summary>
        /// Either \&quot;ALL\&quot;, or a positive DecimalNumber reflection a partial unit
        /// </summary>
        /// <value>Either \&quot;ALL\&quot;, or a positive DecimalNumber reflection a partial unit</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public string Units { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketOrderLongPositionCloseout {\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
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
            return this.Equals(input as MarketOrderLongPositionCloseout);
        }

        /// <summary>
        /// Returns true if MarketOrderLongPositionCloseout instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketOrderLongPositionCloseout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketOrderLongPositionCloseout input)
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
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
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
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
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
            // Units (string) pattern
            Regex regexUnits = new Regex(@"^(?:(?:ALL)|(?:\\d+(?:\\.\\d+)?))$", RegexOptions.CultureInvariant);
            if (false == regexUnits.Match(this.Units).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Units, must match a pattern of " + regexUnits, new [] { "Units" });
            }

            yield break;
        }
    }

}
