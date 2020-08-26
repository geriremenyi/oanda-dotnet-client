# GeriRemenyi.Oanda.V20.Api.TradeApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsAccountIDOpenTradesGet**](TradeApi.md#accountsaccountidopentradesget) | **GET** /accounts/{accountID}/openTrades | List Open Trades
[**AccountsAccountIDTradesGet**](TradeApi.md#accountsaccountidtradesget) | **GET** /accounts/{accountID}/trades | List Trades
[**AccountsAccountIDTradesTradeSpecifierClientExtensionsPut**](TradeApi.md#accountsaccountidtradestradespecifierclientextensionsput) | **PUT** /accounts/{accountID}/trades/{tradeSpecifier}/clientExtensions | Set Trade Client Extensions
[**AccountsAccountIDTradesTradeSpecifierClosePut**](TradeApi.md#accountsaccountidtradestradespecifiercloseput) | **PUT** /accounts/{accountID}/trades/{tradeSpecifier}/close | Close Trade
[**AccountsAccountIDTradesTradeSpecifierGet**](TradeApi.md#accountsaccountidtradestradespecifierget) | **GET** /accounts/{accountID}/trades/{tradeSpecifier} | Trade Details
[**AccountsAccountIDTradesTradeSpecifierOrdersPut**](TradeApi.md#accountsaccountidtradestradespecifierordersput) | **PUT** /accounts/{accountID}/trades/{tradeSpecifier}/orders | Set Dependent Orders


<a name="accountsaccountidopentradesget"></a>
# **AccountsAccountIDOpenTradesGet**
> InlineResponse20013 AccountsAccountIDOpenTradesGet (string accountID, string acceptDatetimeFormat = null)

List Open Trades

Get the list of open Trades for an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDOpenTradesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // List Open Trades
                InlineResponse20013 result = apiInstance.AccountsAccountIDOpenTradesGet(accountID, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.AccountsAccountIDOpenTradesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountID** | **string**| Account identifier | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account&#39;s list of open Trades is provided |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidtradesget"></a>
# **AccountsAccountIDTradesGet**
> InlineResponse20012 AccountsAccountIDTradesGet (string accountID, string acceptDatetimeFormat = null, List<int> ids = null, string state = null, string instrument = null, int? count = null, int? beforeID = null)

List Trades

Get a list of Trades for an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDTradesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var ids = new List<int>(); // List<int> | List of Trade IDs to retrieve. (optional) 
            var state = state_example;  // string | The state to filter the requested Trades by. (optional) 
            var instrument = instrument_example;  // string | The instrument to filter the requested Trades by. (optional) 
            var count = 56;  // int? | The maximum number of Trades to return. (optional) 
            var beforeID = 56;  // int? | The maximum Trade ID to return. If not provided the most recent Trades in the Account are returned. (optional) 

            try
            {
                // List Trades
                InlineResponse20012 result = apiInstance.AccountsAccountIDTradesGet(accountID, acceptDatetimeFormat, ids, state, instrument, count, beforeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.AccountsAccountIDTradesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountID** | **string**| Account identifier | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 
 **ids** | [**List&lt;int&gt;**](int.md)| List of Trade IDs to retrieve. | [optional] 
 **state** | **string**| The state to filter the requested Trades by. | [optional] 
 **instrument** | **string**| The instrument to filter the requested Trades by. | [optional] 
 **count** | **int?**| The maximum number of Trades to return. | [optional] 
 **beforeID** | **int?**| The maximum Trade ID to return. If not provided the most recent Trades in the Account are returned. | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Trades requested |  * Link - A link to the next/previous page. <br>  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidtradestradespecifierclientextensionsput"></a>
# **AccountsAccountIDTradesTradeSpecifierClientExtensionsPut**
> Object AccountsAccountIDTradesTradeSpecifierClientExtensionsPut (string accountID, string tradeSpecifier, InlineObject5 inlineObject5, string acceptDatetimeFormat = null)

Set Trade Client Extensions

Update the Client Extensions for a Trade. Do not add, update, or delete the Client Extensions if your account is associated with MT4.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDTradesTradeSpecifierClientExtensionsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var tradeSpecifier = tradeSpecifier_example;  // string | Specifier for the Trade
            var inlineObject5 = new InlineObject5(); // InlineObject5 | 
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Set Trade Client Extensions
                Object result = apiInstance.AccountsAccountIDTradesTradeSpecifierClientExtensionsPut(accountID, tradeSpecifier, inlineObject5, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.AccountsAccountIDTradesTradeSpecifierClientExtensionsPut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountID** | **string**| Account identifier | 
 **tradeSpecifier** | **string**| Specifier for the Trade | 
 **inlineObject5** | [**InlineObject5**](InlineObject5.md)|  | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 

### Return type

**Object**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Trade&#39;s Client Extensions have been updated as requested. |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | The Trade&#39;s Client Extensions cannot be modified as requested. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | The Account or Trade specified does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidtradestradespecifiercloseput"></a>
# **AccountsAccountIDTradesTradeSpecifierClosePut**
> Object AccountsAccountIDTradesTradeSpecifierClosePut (string accountID, string tradeSpecifier, InlineObject4 inlineObject4, string acceptDatetimeFormat = null)

Close Trade

Close (partially or fully) a specific open Trade in an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDTradesTradeSpecifierClosePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var tradeSpecifier = tradeSpecifier_example;  // string | Specifier for the Trade
            var inlineObject4 = new InlineObject4(); // InlineObject4 | 
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Close Trade
                Object result = apiInstance.AccountsAccountIDTradesTradeSpecifierClosePut(accountID, tradeSpecifier, inlineObject4, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.AccountsAccountIDTradesTradeSpecifierClosePut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountID** | **string**| Account identifier | 
 **tradeSpecifier** | **string**| Specifier for the Trade | 
 **inlineObject4** | [**InlineObject4**](InlineObject4.md)|  | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 

### Return type

**Object**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Trade has been closed as requested |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | The Trade cannot be closed as requested. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | The Account or Trade specified does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidtradestradespecifierget"></a>
# **AccountsAccountIDTradesTradeSpecifierGet**
> InlineResponse20014 AccountsAccountIDTradesTradeSpecifierGet (string accountID, string tradeSpecifier, string acceptDatetimeFormat = null)

Trade Details

Get the details of a specific Trade in an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDTradesTradeSpecifierGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var tradeSpecifier = tradeSpecifier_example;  // string | Specifier for the Trade
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Trade Details
                InlineResponse20014 result = apiInstance.AccountsAccountIDTradesTradeSpecifierGet(accountID, tradeSpecifier, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.AccountsAccountIDTradesTradeSpecifierGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountID** | **string**| Account identifier | 
 **tradeSpecifier** | **string**| Specifier for the Trade | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details for the requested Trade is provided |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidtradestradespecifierordersput"></a>
# **AccountsAccountIDTradesTradeSpecifierOrdersPut**
> Object AccountsAccountIDTradesTradeSpecifierOrdersPut (string accountID, string tradeSpecifier, InlineObject6 inlineObject6, string acceptDatetimeFormat = null)

Set Dependent Orders

Create, replace and cancel a Trade's dependent Orders (Take Profit, Stop Loss and Trailing Stop Loss) through the Trade itself

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDTradesTradeSpecifierOrdersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var tradeSpecifier = tradeSpecifier_example;  // string | Specifier for the Trade
            var inlineObject6 = new InlineObject6(); // InlineObject6 | 
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Set Dependent Orders
                Object result = apiInstance.AccountsAccountIDTradesTradeSpecifierOrdersPut(accountID, tradeSpecifier, inlineObject6, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.AccountsAccountIDTradesTradeSpecifierOrdersPut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountID** | **string**| Account identifier | 
 **tradeSpecifier** | **string**| Specifier for the Trade | 
 **inlineObject6** | [**InlineObject6**](InlineObject6.md)|  | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 

### Return type

**Object**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Trade&#39;s dependent Orders have been modified as requested. |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | The Trade&#39;s dependent Orders cannot be modified as requested. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

