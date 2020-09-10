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
    /// OrderExtensionsBadRequestResponse
    /// </summary>
    [DataContract]
    public partial class OrderExtensionsBadRequestResponse :  IEquatable<OrderExtensionsBadRequestResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderExtensionsBadRequestResponse" /> class.
        /// </summary>
        /// <param name="orderClientExtensionsModifyRejectTransaction">orderClientExtensionsModifyRejectTransaction.</param>
        /// <param name="errorCode">The code of the error that has occurred. This field may not be returned for some errors..</param>
        /// <param name="errorMessage">The human-readable description of the error that has occurred..</param>
        /// <param name="lastTransactionID">The ID of the most recent Transaction created for the Account.</param>
        /// <param name="relatedTransactionIDs">The IDs of all Transactions that were created while satisfying the request..</param>
        public OrderExtensionsBadRequestResponse(OrderClientExtensionsModifyRejectTransaction orderClientExtensionsModifyRejectTransaction = default(OrderClientExtensionsModifyRejectTransaction), string errorCode = default(string), string errorMessage = default(string), int lastTransactionID = default(int), List<int> relatedTransactionIDs = default(List<int>))
        {
            this.OrderClientExtensionsModifyRejectTransaction = orderClientExtensionsModifyRejectTransaction;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.LastTransactionID = lastTransactionID;
            this.RelatedTransactionIDs = relatedTransactionIDs;
        }
        
        /// <summary>
        /// Gets or Sets OrderClientExtensionsModifyRejectTransaction
        /// </summary>
        [DataMember(Name="orderClientExtensionsModifyRejectTransaction", EmitDefaultValue=false)]
        public OrderClientExtensionsModifyRejectTransaction OrderClientExtensionsModifyRejectTransaction { get; set; }

        /// <summary>
        /// The code of the error that has occurred. This field may not be returned for some errors.
        /// </summary>
        /// <value>The code of the error that has occurred. This field may not be returned for some errors.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The human-readable description of the error that has occurred.
        /// </summary>
        /// <value>The human-readable description of the error that has occurred.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the most recent Transaction created for the Account
        /// </summary>
        /// <value>The ID of the most recent Transaction created for the Account</value>
        [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
        public int LastTransactionID { get; set; }

        /// <summary>
        /// The IDs of all Transactions that were created while satisfying the request.
        /// </summary>
        /// <value>The IDs of all Transactions that were created while satisfying the request.</value>
        [DataMember(Name="relatedTransactionIDs", EmitDefaultValue=true)]
        public List<int> RelatedTransactionIDs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderExtensionsBadRequestResponse {\n");
            sb.Append("  OrderClientExtensionsModifyRejectTransaction: ").Append(OrderClientExtensionsModifyRejectTransaction).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
            sb.Append("  RelatedTransactionIDs: ").Append(RelatedTransactionIDs).Append("\n");
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
            return this.Equals(input as OrderExtensionsBadRequestResponse);
        }

        /// <summary>
        /// Returns true if OrderExtensionsBadRequestResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderExtensionsBadRequestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderExtensionsBadRequestResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderClientExtensionsModifyRejectTransaction == input.OrderClientExtensionsModifyRejectTransaction ||
                    (this.OrderClientExtensionsModifyRejectTransaction != null &&
                    this.OrderClientExtensionsModifyRejectTransaction.Equals(input.OrderClientExtensionsModifyRejectTransaction))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.LastTransactionID == input.LastTransactionID ||
                    this.LastTransactionID.Equals(input.LastTransactionID)
                ) && 
                (
                    this.RelatedTransactionIDs == input.RelatedTransactionIDs ||
                    this.RelatedTransactionIDs != null &&
                    input.RelatedTransactionIDs != null &&
                    this.RelatedTransactionIDs.SequenceEqual(input.RelatedTransactionIDs)
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
                if (this.OrderClientExtensionsModifyRejectTransaction != null)
                    hashCode = hashCode * 59 + this.OrderClientExtensionsModifyRejectTransaction.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                hashCode = hashCode * 59 + this.LastTransactionID.GetHashCode();
                if (this.RelatedTransactionIDs != null)
                    hashCode = hashCode * 59 + this.RelatedTransactionIDs.GetHashCode();
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
