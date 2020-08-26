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
    /// The time-in-force requested for the Market Order. Restricted to FOK or IOC for a MarketOrder.
    /// </summary>
    /// <value>The time-in-force requested for the Market Order. Restricted to FOK or IOC for a MarketOrder.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MarketOrderTimeInForce
    {
        /// <summary>
        /// Enum FOK for value: FOK
        /// </summary>
        [EnumMember(Value = "FOK")]
        FOK = 1,

        /// <summary>
        /// Enum IOC for value: IOC
        /// </summary>
        [EnumMember(Value = "IOC")]
        IOC = 2

    }

}