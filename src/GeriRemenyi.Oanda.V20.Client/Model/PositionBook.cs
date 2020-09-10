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
    /// The representation of an instrument&#39;s position book at a point in time
    /// </summary>
    [DataContract]
    public partial class PositionBook :  IEquatable<PositionBook>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Instrument
        /// </summary>
        [DataMember(Name="instrument", EmitDefaultValue=false)]
        public InstrumentName? Instrument { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PositionBook" /> class.
        /// </summary>
        /// <param name="instrument">instrument.</param>
        /// <param name="time">A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places)..</param>
        /// <param name="price">The price (midpoint) for the position book&#39;s instrument at the time of the position book snapshot.</param>
        /// <param name="bucketWidth">The price width for each bucket. Each bucket covers the price range from the bucket&#39;s price to the bucket&#39;s price + bucketWidth..</param>
        /// <param name="buckets">The partitioned position book, divided into buckets using a default bucket width. These buckets are only provided for price ranges which actually contain order or position data..</param>
        public PositionBook(InstrumentName? instrument = default(InstrumentName?), string time = default(string), double price = default(double), double bucketWidth = default(double), List<PositionBookBucket> buckets = default(List<PositionBookBucket>))
        {
            this.Instrument = instrument;
            this.Time = time;
            this.Price = price;
            this.BucketWidth = bucketWidth;
            this.Buckets = buckets;
        }
        
        /// <summary>
        /// A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).
        /// </summary>
        /// <value>A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places).</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// The price (midpoint) for the position book&#39;s instrument at the time of the position book snapshot
        /// </summary>
        /// <value>The price (midpoint) for the position book&#39;s instrument at the time of the position book snapshot</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double Price { get; set; }

        /// <summary>
        /// The price width for each bucket. Each bucket covers the price range from the bucket&#39;s price to the bucket&#39;s price + bucketWidth.
        /// </summary>
        /// <value>The price width for each bucket. Each bucket covers the price range from the bucket&#39;s price to the bucket&#39;s price + bucketWidth.</value>
        [DataMember(Name="bucketWidth", EmitDefaultValue=false)]
        public double BucketWidth { get; set; }

        /// <summary>
        /// The partitioned position book, divided into buckets using a default bucket width. These buckets are only provided for price ranges which actually contain order or position data.
        /// </summary>
        /// <value>The partitioned position book, divided into buckets using a default bucket width. These buckets are only provided for price ranges which actually contain order or position data.</value>
        [DataMember(Name="buckets", EmitDefaultValue=false)]
        public List<PositionBookBucket> Buckets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PositionBook {\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  BucketWidth: ").Append(BucketWidth).Append("\n");
            sb.Append("  Buckets: ").Append(Buckets).Append("\n");
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
            return this.Equals(input as PositionBook);
        }

        /// <summary>
        /// Returns true if PositionBook instances are equal
        /// </summary>
        /// <param name="input">Instance of PositionBook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PositionBook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Instrument == input.Instrument ||
                    this.Instrument.Equals(input.Instrument)
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.BucketWidth == input.BucketWidth ||
                    this.BucketWidth.Equals(input.BucketWidth)
                ) && 
                (
                    this.Buckets == input.Buckets ||
                    this.Buckets != null &&
                    input.Buckets != null &&
                    this.Buckets.SequenceEqual(input.Buckets)
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.BucketWidth.GetHashCode();
                if (this.Buckets != null)
                    hashCode = hashCode * 59 + this.Buckets.GetHashCode();
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

            yield break;
        }
    }

}