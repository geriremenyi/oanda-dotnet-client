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
    /// Representation of how many units of an Instrument are available to be traded by an Order depending on its postionFill option.
    /// </summary>
    [DataContract]
    public partial class UnitsAvailable :  IEquatable<UnitsAvailable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitsAvailable" /> class.
        /// </summary>
        /// <param name="_default">_default.</param>
        /// <param name="reduceFirst">reduceFirst.</param>
        /// <param name="reduceOnly">reduceOnly.</param>
        /// <param name="openOnly">openOnly.</param>
        public UnitsAvailable(InlineResponse20021UnitsAvailableDefault _default = default(InlineResponse20021UnitsAvailableDefault), InlineResponse20021UnitsAvailableDefault reduceFirst = default(InlineResponse20021UnitsAvailableDefault), InlineResponse20021UnitsAvailableDefault reduceOnly = default(InlineResponse20021UnitsAvailableDefault), InlineResponse20021UnitsAvailableDefault openOnly = default(InlineResponse20021UnitsAvailableDefault))
        {
            this.Default = _default;
            this.ReduceFirst = reduceFirst;
            this.ReduceOnly = reduceOnly;
            this.OpenOnly = openOnly;
        }
        
        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public InlineResponse20021UnitsAvailableDefault Default { get; set; }

        /// <summary>
        /// Gets or Sets ReduceFirst
        /// </summary>
        [DataMember(Name="reduceFirst", EmitDefaultValue=false)]
        public InlineResponse20021UnitsAvailableDefault ReduceFirst { get; set; }

        /// <summary>
        /// Gets or Sets ReduceOnly
        /// </summary>
        [DataMember(Name="reduceOnly", EmitDefaultValue=false)]
        public InlineResponse20021UnitsAvailableDefault ReduceOnly { get; set; }

        /// <summary>
        /// Gets or Sets OpenOnly
        /// </summary>
        [DataMember(Name="openOnly", EmitDefaultValue=false)]
        public InlineResponse20021UnitsAvailableDefault OpenOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnitsAvailable {\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  ReduceFirst: ").Append(ReduceFirst).Append("\n");
            sb.Append("  ReduceOnly: ").Append(ReduceOnly).Append("\n");
            sb.Append("  OpenOnly: ").Append(OpenOnly).Append("\n");
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
            return this.Equals(input as UnitsAvailable);
        }

        /// <summary>
        /// Returns true if UnitsAvailable instances are equal
        /// </summary>
        /// <param name="input">Instance of UnitsAvailable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnitsAvailable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.ReduceFirst == input.ReduceFirst ||
                    (this.ReduceFirst != null &&
                    this.ReduceFirst.Equals(input.ReduceFirst))
                ) && 
                (
                    this.ReduceOnly == input.ReduceOnly ||
                    (this.ReduceOnly != null &&
                    this.ReduceOnly.Equals(input.ReduceOnly))
                ) && 
                (
                    this.OpenOnly == input.OpenOnly ||
                    (this.OpenOnly != null &&
                    this.OpenOnly.Equals(input.OpenOnly))
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
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.ReduceFirst != null)
                    hashCode = hashCode * 59 + this.ReduceFirst.GetHashCode();
                if (this.ReduceOnly != null)
                    hashCode = hashCode * 59 + this.ReduceOnly.GetHashCode();
                if (this.OpenOnly != null)
                    hashCode = hashCode * 59 + this.OpenOnly.GetHashCode();
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
