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
    /// The reason that an Order was filled
    /// </summary>
    /// <value>The reason that an Order was filled</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OrderFillReason
    {
        /// <summary>
        /// Enum LIMITORDER for value: LIMIT_ORDER
        /// </summary>
        [EnumMember(Value = "LIMIT_ORDER")]
        LIMITORDER = 1,

        /// <summary>
        /// Enum STOPORDER for value: STOP_ORDER
        /// </summary>
        [EnumMember(Value = "STOP_ORDER")]
        STOPORDER = 2,

        /// <summary>
        /// Enum MARKETIFTOUCHEDORDER for value: MARKET_IF_TOUCHED_ORDER
        /// </summary>
        [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER")]
        MARKETIFTOUCHEDORDER = 3,

        /// <summary>
        /// Enum TAKEPROFITORDER for value: TAKE_PROFIT_ORDER
        /// </summary>
        [EnumMember(Value = "TAKE_PROFIT_ORDER")]
        TAKEPROFITORDER = 4,

        /// <summary>
        /// Enum STOPLOSSORDER for value: STOP_LOSS_ORDER
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ORDER")]
        STOPLOSSORDER = 5,

        /// <summary>
        /// Enum TRAILINGSTOPLOSSORDER for value: TRAILING_STOP_LOSS_ORDER
        /// </summary>
        [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER")]
        TRAILINGSTOPLOSSORDER = 6,

        /// <summary>
        /// Enum MARKETORDER for value: MARKET_ORDER
        /// </summary>
        [EnumMember(Value = "MARKET_ORDER")]
        MARKETORDER = 7,

        /// <summary>
        /// Enum MARKETORDERTRADECLOSE for value: MARKET_ORDER_TRADE_CLOSE
        /// </summary>
        [EnumMember(Value = "MARKET_ORDER_TRADE_CLOSE")]
        MARKETORDERTRADECLOSE = 8,

        /// <summary>
        /// Enum MARKETORDERPOSITIONCLOSEOUT for value: MARKET_ORDER_POSITION_CLOSEOUT
        /// </summary>
        [EnumMember(Value = "MARKET_ORDER_POSITION_CLOSEOUT")]
        MARKETORDERPOSITIONCLOSEOUT = 9,

        /// <summary>
        /// Enum MARKETORDERMARGINCLOSEOUT for value: MARKET_ORDER_MARGIN_CLOSEOUT
        /// </summary>
        [EnumMember(Value = "MARKET_ORDER_MARGIN_CLOSEOUT")]
        MARKETORDERMARGINCLOSEOUT = 10,

        /// <summary>
        /// Enum MARKETORDERDELAYEDTRADECLOSE for value: MARKET_ORDER_DELAYED_TRADE_CLOSE
        /// </summary>
        [EnumMember(Value = "MARKET_ORDER_DELAYED_TRADE_CLOSE")]
        MARKETORDERDELAYEDTRADECLOSE = 11

    }

}