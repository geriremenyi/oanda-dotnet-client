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
    /// PositionsResponse
    /// </summary>
    [DataContract]
    public partial class PositionsResponse :  IEquatable<PositionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PositionsResponse" /> class.
        /// </summary>
        /// <param name="positions">The list of Account Positions..</param>
        /// <param name="lastTransactionID">he ID of the most recent Transaction created for the Account.</param>
        public PositionsResponse(List<Position> positions = default(List<Position>), int lastTransactionID = default(int))
        {
            this.Positions = positions;
            this.LastTransactionID = lastTransactionID;
        }
        
        /// <summary>
        /// The list of Account Positions.
        /// </summary>
        /// <value>The list of Account Positions.</value>
        [DataMember(Name="positions", EmitDefaultValue=false)]
        public List<Position> Positions { get; set; }

        /// <summary>
        /// he ID of the most recent Transaction created for the Account
        /// </summary>
        /// <value>he ID of the most recent Transaction created for the Account</value>
        [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
        public int LastTransactionID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PositionsResponse {\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
            sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
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
            return this.Equals(input as PositionsResponse);
        }

        /// <summary>
        /// Returns true if PositionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PositionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PositionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Positions == input.Positions ||
                    this.Positions != null &&
                    input.Positions != null &&
                    this.Positions.SequenceEqual(input.Positions)
                ) && 
                (
                    this.LastTransactionID == input.LastTransactionID ||
                    this.LastTransactionID.Equals(input.LastTransactionID)
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
                if (this.Positions != null)
                    hashCode = hashCode * 59 + this.Positions.GetHashCode();
                hashCode = hashCode * 59 + this.LastTransactionID.GetHashCode();
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