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
    /// QuoteHomeConversionFactors represents the factors that can be used used to convert quantities of a Price&#39;s Instrument&#39;s quote currency into the Account&#39;s home currency.
    /// </summary>
    [DataContract]
    public partial class QuoteHomeConversionFactors :  IEquatable<QuoteHomeConversionFactors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteHomeConversionFactors" /> class.
        /// </summary>
        /// <param name="positiveUnits">The factor used to convert a positive amount of the Price&#39;s Instrument&#39;s quote currency into a positive amount of the Account&#39;s home currency.  Conversion is performed by multiplying the quote units by the conversion factor..</param>
        /// <param name="negativeUnits">The factor used to convert a negative amount of the Price&#39;s Instrument&#39;s quote currency into a negative amount of the Account&#39;s home currency.  Conversion is performed by multiplying the quote units by the conversion factor..</param>
        public QuoteHomeConversionFactors(double positiveUnits = default(double), double negativeUnits = default(double))
        {
            this.PositiveUnits = positiveUnits;
            this.NegativeUnits = negativeUnits;
        }
        
        /// <summary>
        /// The factor used to convert a positive amount of the Price&#39;s Instrument&#39;s quote currency into a positive amount of the Account&#39;s home currency.  Conversion is performed by multiplying the quote units by the conversion factor.
        /// </summary>
        /// <value>The factor used to convert a positive amount of the Price&#39;s Instrument&#39;s quote currency into a positive amount of the Account&#39;s home currency.  Conversion is performed by multiplying the quote units by the conversion factor.</value>
        [DataMember(Name="positiveUnits", EmitDefaultValue=false)]
        public double PositiveUnits { get; set; }

        /// <summary>
        /// The factor used to convert a negative amount of the Price&#39;s Instrument&#39;s quote currency into a negative amount of the Account&#39;s home currency.  Conversion is performed by multiplying the quote units by the conversion factor.
        /// </summary>
        /// <value>The factor used to convert a negative amount of the Price&#39;s Instrument&#39;s quote currency into a negative amount of the Account&#39;s home currency.  Conversion is performed by multiplying the quote units by the conversion factor.</value>
        [DataMember(Name="negativeUnits", EmitDefaultValue=false)]
        public double NegativeUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuoteHomeConversionFactors {\n");
            sb.Append("  PositiveUnits: ").Append(PositiveUnits).Append("\n");
            sb.Append("  NegativeUnits: ").Append(NegativeUnits).Append("\n");
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
            return this.Equals(input as QuoteHomeConversionFactors);
        }

        /// <summary>
        /// Returns true if QuoteHomeConversionFactors instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteHomeConversionFactors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteHomeConversionFactors input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PositiveUnits == input.PositiveUnits ||
                    this.PositiveUnits.Equals(input.PositiveUnits)
                ) && 
                (
                    this.NegativeUnits == input.NegativeUnits ||
                    this.NegativeUnits.Equals(input.NegativeUnits)
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
                hashCode = hashCode * 59 + this.PositiveUnits.GetHashCode();
                hashCode = hashCode * 59 + this.NegativeUnits.GetHashCode();
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