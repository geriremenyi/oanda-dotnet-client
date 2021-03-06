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
    /// A TradeClientExtensionsModifyTransaction represents the modification of a Trade&#39;s Client Extensions.
    /// </summary>
    [DataContract]
    public partial class TradeClientExtensionsModify :  IEquatable<TradeClientExtensionsModify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeClientExtensionsModify" /> class.
        /// </summary>
        /// <param name="tradeID">The ID of the Trade who&#39;s client extensions are to be modified..</param>
        /// <param name="clientTradeID">The original Client ID of the Trade who&#39;s client extensions are to be modified..</param>
        /// <param name="tradeClientExtensionsModify">tradeClientExtensionsModify.</param>
        public TradeClientExtensionsModify(int tradeID = default(int), string clientTradeID = default(string), ClientExtensions tradeClientExtensionsModify = default(ClientExtensions))
        {
            this.TradeID = tradeID;
            this.ClientTradeID = clientTradeID;
            this._TradeClientExtensionsModify = tradeClientExtensionsModify;
        }
        
        /// <summary>
        /// The ID of the Trade who&#39;s client extensions are to be modified.
        /// </summary>
        /// <value>The ID of the Trade who&#39;s client extensions are to be modified.</value>
        [DataMember(Name="tradeID", EmitDefaultValue=false)]
        public int TradeID { get; set; }

        /// <summary>
        /// The original Client ID of the Trade who&#39;s client extensions are to be modified.
        /// </summary>
        /// <value>The original Client ID of the Trade who&#39;s client extensions are to be modified.</value>
        [DataMember(Name="clientTradeID", EmitDefaultValue=false)]
        public string ClientTradeID { get; set; }

        /// <summary>
        /// Gets or Sets _TradeClientExtensionsModify
        /// </summary>
        [DataMember(Name="tradeClientExtensionsModify", EmitDefaultValue=false)]
        public ClientExtensions _TradeClientExtensionsModify { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradeClientExtensionsModify {\n");
            sb.Append("  TradeID: ").Append(TradeID).Append("\n");
            sb.Append("  ClientTradeID: ").Append(ClientTradeID).Append("\n");
            sb.Append("  _TradeClientExtensionsModify: ").Append(_TradeClientExtensionsModify).Append("\n");
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
            return this.Equals(input as TradeClientExtensionsModify);
        }

        /// <summary>
        /// Returns true if TradeClientExtensionsModify instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeClientExtensionsModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeClientExtensionsModify input)
        {
            if (input == null)
                return false;

            return 
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
                    this._TradeClientExtensionsModify == input._TradeClientExtensionsModify ||
                    (this._TradeClientExtensionsModify != null &&
                    this._TradeClientExtensionsModify.Equals(input._TradeClientExtensionsModify))
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
                hashCode = hashCode * 59 + this.TradeID.GetHashCode();
                if (this.ClientTradeID != null)
                    hashCode = hashCode * 59 + this.ClientTradeID.GetHashCode();
                if (this._TradeClientExtensionsModify != null)
                    hashCode = hashCode * 59 + this._TradeClientExtensionsModify.GetHashCode();
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
