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
    /// An AccountChangesState Object is used to represent an Account&#39;s current price-dependent state. Price-dependent Account state is dependent on OANDA&#39;s current Prices, and includes things like unrealized PL, NAV and Trailing Stop Loss Order state.
    /// </summary>
    [DataContract]
    public partial class AccountChangesState :  IEquatable<AccountChangesState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountChangesState" /> class.
        /// </summary>
        /// <param name="unrealizedPL">The total unrealized profit/loss for all Trades currently open in the Account..</param>
        /// <param name="nAV">The net asset value of the Account. Equal to Account balance unrealizedPL..</param>
        /// <param name="marginUsed">Margin currently used for the Account..</param>
        /// <param name="marginAvailable">Margin available for Account currency..</param>
        /// <param name="positionValue">The value of the Account&#39;s open positions represented in the Account&#39;s home currency..</param>
        /// <param name="marginCloseoutUnrealizedPL">The Account&#39;s margin closeout unrealized PL..</param>
        /// <param name="marginCloseoutNAV">The Account&#39;s margin closeout NAV..</param>
        /// <param name="marginCloseoutMarginUsed">The Account&#39;s margin closeout margin used..</param>
        /// <param name="marginCloseoutPercent">The Account&#39;s margin closeout percentage. When this value is 1.0 or above the Account is in a margin closeout situation..</param>
        /// <param name="marginCloseoutPositionValue">The value of the Account&#39;s open positions as used for margin closeout calculations represented in the Account&#39;s home currency..</param>
        /// <param name="withdrawalLimit">The current WithdrawalLimit for the account which will be zero or a positive value indicating how much can be withdrawn from the account..</param>
        /// <param name="marginCallMarginUsed">The Account&#39;s margin call margin used..</param>
        /// <param name="marginCallPercent">The Account&#39;s margin call percentage. When this value is 1.0 or above the Account is in a margin call situation..</param>
        /// <param name="orders">The price-dependent state of each pending Order in the Account..</param>
        /// <param name="trades">The price-dependent state for each open Trade in the Account..</param>
        /// <param name="positions">The price-dependent state for each open Position in the Account..</param>
        public AccountChangesState(double unrealizedPL = default(double), double nAV = default(double), double marginUsed = default(double), double marginAvailable = default(double), double positionValue = default(double), double marginCloseoutUnrealizedPL = default(double), double marginCloseoutNAV = default(double), double marginCloseoutMarginUsed = default(double), double marginCloseoutPercent = default(double), double marginCloseoutPositionValue = default(double), double withdrawalLimit = default(double), double marginCallMarginUsed = default(double), double marginCallPercent = default(double), List<AccountChangesStateAllOf1Orders> orders = default(List<AccountChangesStateAllOf1Orders>), List<AccountChangesStateAllOf1Trades> trades = default(List<AccountChangesStateAllOf1Trades>), List<AccountChangesStateAllOf1Positions> positions = default(List<AccountChangesStateAllOf1Positions>))
        {
            this.UnrealizedPL = unrealizedPL;
            this.NAV = nAV;
            this.MarginUsed = marginUsed;
            this.MarginAvailable = marginAvailable;
            this.PositionValue = positionValue;
            this.MarginCloseoutUnrealizedPL = marginCloseoutUnrealizedPL;
            this.MarginCloseoutNAV = marginCloseoutNAV;
            this.MarginCloseoutMarginUsed = marginCloseoutMarginUsed;
            this.MarginCloseoutPercent = marginCloseoutPercent;
            this.MarginCloseoutPositionValue = marginCloseoutPositionValue;
            this.WithdrawalLimit = withdrawalLimit;
            this.MarginCallMarginUsed = marginCallMarginUsed;
            this.MarginCallPercent = marginCallPercent;
            this.Orders = orders;
            this.Trades = trades;
            this.Positions = positions;
        }
        
        /// <summary>
        /// The total unrealized profit/loss for all Trades currently open in the Account.
        /// </summary>
        /// <value>The total unrealized profit/loss for all Trades currently open in the Account.</value>
        [DataMember(Name="unrealizedPL", EmitDefaultValue=false)]
        public double UnrealizedPL { get; set; }

        /// <summary>
        /// The net asset value of the Account. Equal to Account balance unrealizedPL.
        /// </summary>
        /// <value>The net asset value of the Account. Equal to Account balance unrealizedPL.</value>
        [DataMember(Name="NAV", EmitDefaultValue=false)]
        public double NAV { get; set; }

        /// <summary>
        /// Margin currently used for the Account.
        /// </summary>
        /// <value>Margin currently used for the Account.</value>
        [DataMember(Name="marginUsed", EmitDefaultValue=false)]
        public double MarginUsed { get; set; }

        /// <summary>
        /// Margin available for Account currency.
        /// </summary>
        /// <value>Margin available for Account currency.</value>
        [DataMember(Name="marginAvailable", EmitDefaultValue=false)]
        public double MarginAvailable { get; set; }

        /// <summary>
        /// The value of the Account&#39;s open positions represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>The value of the Account&#39;s open positions represented in the Account&#39;s home currency.</value>
        [DataMember(Name="positionValue", EmitDefaultValue=false)]
        public double PositionValue { get; set; }

        /// <summary>
        /// The Account&#39;s margin closeout unrealized PL.
        /// </summary>
        /// <value>The Account&#39;s margin closeout unrealized PL.</value>
        [DataMember(Name="marginCloseoutUnrealizedPL", EmitDefaultValue=false)]
        public double MarginCloseoutUnrealizedPL { get; set; }

        /// <summary>
        /// The Account&#39;s margin closeout NAV.
        /// </summary>
        /// <value>The Account&#39;s margin closeout NAV.</value>
        [DataMember(Name="marginCloseoutNAV", EmitDefaultValue=false)]
        public double MarginCloseoutNAV { get; set; }

        /// <summary>
        /// The Account&#39;s margin closeout margin used.
        /// </summary>
        /// <value>The Account&#39;s margin closeout margin used.</value>
        [DataMember(Name="marginCloseoutMarginUsed", EmitDefaultValue=false)]
        public double MarginCloseoutMarginUsed { get; set; }

        /// <summary>
        /// The Account&#39;s margin closeout percentage. When this value is 1.0 or above the Account is in a margin closeout situation.
        /// </summary>
        /// <value>The Account&#39;s margin closeout percentage. When this value is 1.0 or above the Account is in a margin closeout situation.</value>
        [DataMember(Name="marginCloseoutPercent", EmitDefaultValue=false)]
        public double MarginCloseoutPercent { get; set; }

        /// <summary>
        /// The value of the Account&#39;s open positions as used for margin closeout calculations represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>The value of the Account&#39;s open positions as used for margin closeout calculations represented in the Account&#39;s home currency.</value>
        [DataMember(Name="marginCloseoutPositionValue", EmitDefaultValue=false)]
        public double MarginCloseoutPositionValue { get; set; }

        /// <summary>
        /// The current WithdrawalLimit for the account which will be zero or a positive value indicating how much can be withdrawn from the account.
        /// </summary>
        /// <value>The current WithdrawalLimit for the account which will be zero or a positive value indicating how much can be withdrawn from the account.</value>
        [DataMember(Name="withdrawalLimit", EmitDefaultValue=false)]
        public double WithdrawalLimit { get; set; }

        /// <summary>
        /// The Account&#39;s margin call margin used.
        /// </summary>
        /// <value>The Account&#39;s margin call margin used.</value>
        [DataMember(Name="marginCallMarginUsed", EmitDefaultValue=false)]
        public double MarginCallMarginUsed { get; set; }

        /// <summary>
        /// The Account&#39;s margin call percentage. When this value is 1.0 or above the Account is in a margin call situation.
        /// </summary>
        /// <value>The Account&#39;s margin call percentage. When this value is 1.0 or above the Account is in a margin call situation.</value>
        [DataMember(Name="marginCallPercent", EmitDefaultValue=false)]
        public double MarginCallPercent { get; set; }

        /// <summary>
        /// The price-dependent state of each pending Order in the Account.
        /// </summary>
        /// <value>The price-dependent state of each pending Order in the Account.</value>
        [DataMember(Name="orders", EmitDefaultValue=false)]
        public List<AccountChangesStateAllOf1Orders> Orders { get; set; }

        /// <summary>
        /// The price-dependent state for each open Trade in the Account.
        /// </summary>
        /// <value>The price-dependent state for each open Trade in the Account.</value>
        [DataMember(Name="trades", EmitDefaultValue=false)]
        public List<AccountChangesStateAllOf1Trades> Trades { get; set; }

        /// <summary>
        /// The price-dependent state for each open Position in the Account.
        /// </summary>
        /// <value>The price-dependent state for each open Position in the Account.</value>
        [DataMember(Name="positions", EmitDefaultValue=false)]
        public List<AccountChangesStateAllOf1Positions> Positions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountChangesState {\n");
            sb.Append("  UnrealizedPL: ").Append(UnrealizedPL).Append("\n");
            sb.Append("  NAV: ").Append(NAV).Append("\n");
            sb.Append("  MarginUsed: ").Append(MarginUsed).Append("\n");
            sb.Append("  MarginAvailable: ").Append(MarginAvailable).Append("\n");
            sb.Append("  PositionValue: ").Append(PositionValue).Append("\n");
            sb.Append("  MarginCloseoutUnrealizedPL: ").Append(MarginCloseoutUnrealizedPL).Append("\n");
            sb.Append("  MarginCloseoutNAV: ").Append(MarginCloseoutNAV).Append("\n");
            sb.Append("  MarginCloseoutMarginUsed: ").Append(MarginCloseoutMarginUsed).Append("\n");
            sb.Append("  MarginCloseoutPercent: ").Append(MarginCloseoutPercent).Append("\n");
            sb.Append("  MarginCloseoutPositionValue: ").Append(MarginCloseoutPositionValue).Append("\n");
            sb.Append("  WithdrawalLimit: ").Append(WithdrawalLimit).Append("\n");
            sb.Append("  MarginCallMarginUsed: ").Append(MarginCallMarginUsed).Append("\n");
            sb.Append("  MarginCallPercent: ").Append(MarginCallPercent).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
            sb.Append("  Trades: ").Append(Trades).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
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
            return this.Equals(input as AccountChangesState);
        }

        /// <summary>
        /// Returns true if AccountChangesState instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountChangesState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountChangesState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnrealizedPL == input.UnrealizedPL ||
                    this.UnrealizedPL.Equals(input.UnrealizedPL)
                ) && 
                (
                    this.NAV == input.NAV ||
                    this.NAV.Equals(input.NAV)
                ) && 
                (
                    this.MarginUsed == input.MarginUsed ||
                    this.MarginUsed.Equals(input.MarginUsed)
                ) && 
                (
                    this.MarginAvailable == input.MarginAvailable ||
                    this.MarginAvailable.Equals(input.MarginAvailable)
                ) && 
                (
                    this.PositionValue == input.PositionValue ||
                    this.PositionValue.Equals(input.PositionValue)
                ) && 
                (
                    this.MarginCloseoutUnrealizedPL == input.MarginCloseoutUnrealizedPL ||
                    this.MarginCloseoutUnrealizedPL.Equals(input.MarginCloseoutUnrealizedPL)
                ) && 
                (
                    this.MarginCloseoutNAV == input.MarginCloseoutNAV ||
                    this.MarginCloseoutNAV.Equals(input.MarginCloseoutNAV)
                ) && 
                (
                    this.MarginCloseoutMarginUsed == input.MarginCloseoutMarginUsed ||
                    this.MarginCloseoutMarginUsed.Equals(input.MarginCloseoutMarginUsed)
                ) && 
                (
                    this.MarginCloseoutPercent == input.MarginCloseoutPercent ||
                    this.MarginCloseoutPercent.Equals(input.MarginCloseoutPercent)
                ) && 
                (
                    this.MarginCloseoutPositionValue == input.MarginCloseoutPositionValue ||
                    this.MarginCloseoutPositionValue.Equals(input.MarginCloseoutPositionValue)
                ) && 
                (
                    this.WithdrawalLimit == input.WithdrawalLimit ||
                    this.WithdrawalLimit.Equals(input.WithdrawalLimit)
                ) && 
                (
                    this.MarginCallMarginUsed == input.MarginCallMarginUsed ||
                    this.MarginCallMarginUsed.Equals(input.MarginCallMarginUsed)
                ) && 
                (
                    this.MarginCallPercent == input.MarginCallPercent ||
                    this.MarginCallPercent.Equals(input.MarginCallPercent)
                ) && 
                (
                    this.Orders == input.Orders ||
                    this.Orders != null &&
                    input.Orders != null &&
                    this.Orders.SequenceEqual(input.Orders)
                ) && 
                (
                    this.Trades == input.Trades ||
                    this.Trades != null &&
                    input.Trades != null &&
                    this.Trades.SequenceEqual(input.Trades)
                ) && 
                (
                    this.Positions == input.Positions ||
                    this.Positions != null &&
                    input.Positions != null &&
                    this.Positions.SequenceEqual(input.Positions)
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
                hashCode = hashCode * 59 + this.UnrealizedPL.GetHashCode();
                hashCode = hashCode * 59 + this.NAV.GetHashCode();
                hashCode = hashCode * 59 + this.MarginUsed.GetHashCode();
                hashCode = hashCode * 59 + this.MarginAvailable.GetHashCode();
                hashCode = hashCode * 59 + this.PositionValue.GetHashCode();
                hashCode = hashCode * 59 + this.MarginCloseoutUnrealizedPL.GetHashCode();
                hashCode = hashCode * 59 + this.MarginCloseoutNAV.GetHashCode();
                hashCode = hashCode * 59 + this.MarginCloseoutMarginUsed.GetHashCode();
                hashCode = hashCode * 59 + this.MarginCloseoutPercent.GetHashCode();
                hashCode = hashCode * 59 + this.MarginCloseoutPositionValue.GetHashCode();
                hashCode = hashCode * 59 + this.WithdrawalLimit.GetHashCode();
                hashCode = hashCode * 59 + this.MarginCallMarginUsed.GetHashCode();
                hashCode = hashCode * 59 + this.MarginCallPercent.GetHashCode();
                if (this.Orders != null)
                    hashCode = hashCode * 59 + this.Orders.GetHashCode();
                if (this.Trades != null)
                    hashCode = hashCode * 59 + this.Trades.GetHashCode();
                if (this.Positions != null)
                    hashCode = hashCode * 59 + this.Positions.GetHashCode();
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
