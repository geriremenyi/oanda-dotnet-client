# GeriRemenyi.Oanda.V20.Client.Api.TradeApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloseTrade**](TradeApi.md#closetrade) | **PUT** /accounts/{accountID}/trades/{tradeSpecifier}/close | Close Trade
[**GetOpenTrades**](TradeApi.md#getopentrades) | **GET** /accounts/{accountID}/openTrades | List Open Trades
[**GetTrade**](TradeApi.md#gettrade) | **GET** /accounts/{accountID}/trades/{tradeSpecifier} | Trade Details
[**GetTrades**](TradeApi.md#gettrades) | **GET** /accounts/{accountID}/trades | List Trades
[**SetTradeExtensions**](TradeApi.md#settradeextensions) | **PUT** /accounts/{accountID}/trades/{tradeSpecifier}/clientExtensions | Set Trade Client Extensions
[**SetTradeOrders**](TradeApi.md#settradeorders) | **PUT** /accounts/{accountID}/trades/{tradeSpecifier}/orders | Set Dependent Orders


<a name="closetrade"></a>
# **CloseTrade**
> CloseTradeResponse CloseTrade (string accountID, string tradeSpecifier, CloseTradeRequest closeTradeRequest, DateTimeFormat? acceptDatetimeFormat = null)

Close Trade

Close (partially or fully) a specific open Trade in an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class CloseTradeExample
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
            var closeTradeRequest = new CloseTradeRequest(); // CloseTradeRequest | Details of how much of the open Trade to close.
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Close Trade
                CloseTradeResponse result = apiInstance.CloseTrade(accountID, tradeSpecifier, closeTradeRequest, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.CloseTrade: " + e.Message );
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
 **closeTradeRequest** | [**CloseTradeRequest**](CloseTradeRequest.md)| Details of how much of the open Trade to close. | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**CloseTradeResponse**](CloseTradeResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Trade has been closed as requested |  * RequestID -  <br>  |
| **400** | The Trade cannot be closed as requested. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** | The Account or Trade specified does not exist. |  * RequestID -  <br>  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getopentrades"></a>
# **GetOpenTrades**
> OpenTradeResponse GetOpenTrades (string accountID, DateTimeFormat? acceptDatetimeFormat = null)

List Open Trades

Get the list of open Trades for an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetOpenTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // List Open Trades
                OpenTradeResponse result = apiInstance.GetOpenTrades(accountID, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.GetOpenTrades: " + e.Message );
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
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**OpenTradeResponse**](OpenTradeResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account&#39;s list of open Trades is provided |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrade"></a>
# **GetTrade**
> TradeResponse GetTrade (string accountID, string tradeSpecifier, DateTimeFormat? acceptDatetimeFormat = null)

Trade Details

Get the details of a specific Trade in an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetTradeExample
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
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Trade Details
                TradeResponse result = apiInstance.GetTrade(accountID, tradeSpecifier, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.GetTrade: " + e.Message );
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
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**TradeResponse**](TradeResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details for the requested Trade is provided |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrades"></a>
# **GetTrades**
> TradesResponse GetTrades (string accountID, DateTimeFormat? acceptDatetimeFormat = null, List<int> ids = null, string state = null, InstrumentName? instrument = null, int? count = null, int? beforeID = null)

List Trades

Get a list of Trades for an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TradeApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var ids = new List<int>(); // List<int> | List of Trade IDs to retrieve. (optional) 
            var state = state_example;  // string | The state to filter the requested Trades by. (optional) 
            var instrument = ;  // InstrumentName? | The instrument to filter the requested Trades by. (optional) 
            var count = 56;  // int? | The maximum number of Trades to return. (optional) 
            var beforeID = 56;  // int? | The maximum Trade ID to return. If not provided the most recent Trades in the Account are returned. (optional) 

            try
            {
                // List Trades
                TradesResponse result = apiInstance.GetTrades(accountID, acceptDatetimeFormat, ids, state, instrument, count, beforeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.GetTrades: " + e.Message );
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
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 
 **ids** | [**List&lt;int&gt;**](int.md)| List of Trade IDs to retrieve. | [optional] 
 **state** | **string**| The state to filter the requested Trades by. | [optional] 
 **instrument** | **InstrumentName?**| The instrument to filter the requested Trades by. | [optional] 
 **count** | **int?**| The maximum number of Trades to return. | [optional] 
 **beforeID** | **int?**| The maximum Trade ID to return. If not provided the most recent Trades in the Account are returned. | [optional] 

### Return type

[**TradesResponse**](TradesResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Trades requested |  * Link -  <br>  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settradeextensions"></a>
# **SetTradeExtensions**
> TradeExtensionsResponse SetTradeExtensions (string accountID, string tradeSpecifier, TradeExtensionsRequest tradeExtensionsRequest, DateTimeFormat? acceptDatetimeFormat = null)

Set Trade Client Extensions

Update the Client Extensions for a Trade. Do not add, update, or delete the Client Extensions if your account is associated with MT4.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class SetTradeExtensionsExample
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
            var tradeExtensionsRequest = new TradeExtensionsRequest(); // TradeExtensionsRequest | Details of how to modify the Trade's Client Extensions.
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Set Trade Client Extensions
                TradeExtensionsResponse result = apiInstance.SetTradeExtensions(accountID, tradeSpecifier, tradeExtensionsRequest, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.SetTradeExtensions: " + e.Message );
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
 **tradeExtensionsRequest** | [**TradeExtensionsRequest**](TradeExtensionsRequest.md)| Details of how to modify the Trade&#39;s Client Extensions. | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**TradeExtensionsResponse**](TradeExtensionsResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Trade&#39;s Client Extensions have been updated as requested. |  * RequestID -  <br>  |
| **400** | The Trade&#39;s Client Extensions cannot be modified as requested. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** | The Account or Trade specified does not exist. |  * RequestID -  <br>  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settradeorders"></a>
# **SetTradeOrders**
> DependentTradeOrdersResponse SetTradeOrders (string accountID, string tradeSpecifier, DependentTradeOrdersRequest dependentTradeOrdersRequest, DateTimeFormat? acceptDatetimeFormat = null)

Set Dependent Orders

Create, replace and cancel a Trade's dependent Orders (Take Profit, Stop Loss and Trailing Stop Loss) through the Trade itself

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class SetTradeOrdersExample
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
            var dependentTradeOrdersRequest = new DependentTradeOrdersRequest(); // DependentTradeOrdersRequest | Details of how to modify the Trade's dependent Orders.
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Set Dependent Orders
                DependentTradeOrdersResponse result = apiInstance.SetTradeOrders(accountID, tradeSpecifier, dependentTradeOrdersRequest, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradeApi.SetTradeOrders: " + e.Message );
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
 **dependentTradeOrdersRequest** | [**DependentTradeOrdersRequest**](DependentTradeOrdersRequest.md)| Details of how to modify the Trade&#39;s dependent Orders. | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**DependentTradeOrdersResponse**](DependentTradeOrdersResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Trade&#39;s dependent Orders have been modified as requested. |  * RequestID -  <br>  |
| **400** | The Trade&#39;s dependent Orders cannot be modified as requested. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

