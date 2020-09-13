# GeriRemenyi.Oanda.V20.Client.Api.OrderApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsAccountIDOrdersOrderSpecifierPut**](OrderApi.md#accountsaccountidordersorderspecifierput) | **PUT** /accounts/{accountID}/orders/{orderSpecifier} | Replace Order
[**CancelOrder**](OrderApi.md#cancelorder) | **PUT** /accounts/{accountID}/orders/{orderSpecifier}/cancel | Cancel Order
[**CreateOrder**](OrderApi.md#createorder) | **POST** /accounts/{accountID}/orders | Create Order
[**GetOrder**](OrderApi.md#getorder) | **GET** /accounts/{accountID}/orders/{orderSpecifier} | Get Order
[**GetOrders**](OrderApi.md#getorders) | **GET** /accounts/{accountID}/orders | List Orders
[**GetPendingOrders**](OrderApi.md#getpendingorders) | **GET** /accounts/{accountID}/pendingOrders | Pending Orders
[**SetOrderExtensions**](OrderApi.md#setorderextensions) | **PUT** /accounts/{accountID}/orders/{orderSpecifier}/clientExtensions | Set Order Extensions


<a name="accountsaccountidordersorderspecifierput"></a>
# **AccountsAccountIDOrdersOrderSpecifierPut**
> ReplaceOrderResponse AccountsAccountIDOrdersOrderSpecifierPut (string accountID, string orderSpecifier, ReplaceOrderRequest replaceOrderRequest, DateTimeFormat? acceptDatetimeFormat = null, string clientRequestID = null)

Replace Order

Replace an Order in an Account by simultaneously cancelling it and creating a replacement Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class AccountsAccountIDOrdersOrderSpecifierPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var orderSpecifier = orderSpecifier_example;  // string | The Order Specifier
            var replaceOrderRequest = new ReplaceOrderRequest(); // ReplaceOrderRequest | Specification of the replacing Order. The replacing order must have the same type as the replaced Order.
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var clientRequestID = clientRequestID_example;  // string | Client specified RequestID to be sent with request. (optional) 

            try
            {
                // Replace Order
                ReplaceOrderResponse result = apiInstance.AccountsAccountIDOrdersOrderSpecifierPut(accountID, orderSpecifier, replaceOrderRequest, acceptDatetimeFormat, clientRequestID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.AccountsAccountIDOrdersOrderSpecifierPut: " + e.Message );
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
 **orderSpecifier** | **string**| The Order Specifier | 
 **replaceOrderRequest** | [**ReplaceOrderRequest**](ReplaceOrderRequest.md)| Specification of the replacing Order. The replacing order must have the same type as the replaced Order. | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 
 **clientRequestID** | **string**| Client specified RequestID to be sent with request. | [optional] 

### Return type

[**ReplaceOrderResponse**](ReplaceOrderResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Order was successfully cancelled and replaced |  * Location -  <br>  * RequestID -  <br>  |
| **400** | The Order specification was invalid |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** | The Account or Order specified does not exist. |  * RequestID -  <br>  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelorder"></a>
# **CancelOrder**
> CancelOrderResponse CancelOrder (string accountID, string orderSpecifier, DateTimeFormat? acceptDatetimeFormat = null, string clientRequestID = null)

Cancel Order

Cancel a pending Order in an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class CancelOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var orderSpecifier = orderSpecifier_example;  // string | The Order Specifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var clientRequestID = clientRequestID_example;  // string | Client specified RequestID to be sent with request. (optional) 

            try
            {
                // Cancel Order
                CancelOrderResponse result = apiInstance.CancelOrder(accountID, orderSpecifier, acceptDatetimeFormat, clientRequestID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CancelOrder: " + e.Message );
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
 **orderSpecifier** | **string**| The Order Specifier | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 
 **clientRequestID** | **string**| Client specified RequestID to be sent with request. | [optional] 

### Return type

[**CancelOrderResponse**](CancelOrderResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Order was cancelled as specified |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** | The Account or Order specified does not exist. |  * RequestID -  <br>  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorder"></a>
# **CreateOrder**
> CreateOrderResponse CreateOrder (string accountID, CreateOrderRequest createOrderRequest, DateTimeFormat? acceptDatetimeFormat = null)

Create Order

Create an Order for an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var createOrderRequest = new CreateOrderRequest(); // CreateOrderRequest | 
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Create Order
                CreateOrderResponse result = apiInstance.CreateOrder(accountID, createOrderRequest, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreateOrder: " + e.Message );
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
 **createOrderRequest** | [**CreateOrderRequest**](CreateOrderRequest.md)|  | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**CreateOrderResponse**](CreateOrderResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Order was created as specified |  * Location -  <br>  * RequestID -  <br>  |
| **400** | The Order specification was invalid |  * RequestID -  <br>  |
| **401** |  |  -  |
| **403** | Forbidden. The client has provided a token that does not authorize them to perform the action implemented by the API endpoint. |  * RequestID -  <br>  |
| **404** | The Order or Account specified does not exist. |  * RequestID -  <br>  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorder"></a>
# **GetOrder**
> OrderResponse GetOrder (string accountID, string orderSpecifier, DateTimeFormat? acceptDatetimeFormat = null)

Get Order

Get details for a single Order in an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var orderSpecifier = orderSpecifier_example;  // string | The Order Specifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Get Order
                OrderResponse result = apiInstance.GetOrder(accountID, orderSpecifier, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrder: " + e.Message );
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
 **orderSpecifier** | **string**| The Order Specifier | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the Order requested |  * Link -  <br>  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorders"></a>
# **GetOrders**
> OrdersResponse GetOrders (string accountID, DateTimeFormat? acceptDatetimeFormat = null, List<int> ids = null, string state = null, InstrumentName? instrument = null, int? count = null, int? beforeID = null)

List Orders

Get a list of Orders for an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var ids = new List<int>(); // List<int> | List of Order IDs to retrieve (optional) 
            var state = state_example;  // string | The state to filter the requested Orders by (optional) 
            var instrument = ;  // InstrumentName? | The instrument to filter the requested orders by (optional) 
            var count = 56;  // int? | The maximum number of Orders to return (optional) 
            var beforeID = 56;  // int? | The maximum Order ID to return. If not provided the most recent Orders in the Account are returned (optional) 

            try
            {
                // List Orders
                OrdersResponse result = apiInstance.GetOrders(accountID, acceptDatetimeFormat, ids, state, instrument, count, beforeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrders: " + e.Message );
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
 **ids** | [**List&lt;int&gt;**](int.md)| List of Order IDs to retrieve | [optional] 
 **state** | **string**| The state to filter the requested Orders by | [optional] 
 **instrument** | **InstrumentName?**| The instrument to filter the requested orders by | [optional] 
 **count** | **int?**| The maximum number of Orders to return | [optional] 
 **beforeID** | **int?**| The maximum Order ID to return. If not provided the most recent Orders in the Account are returned | [optional] 

### Return type

[**OrdersResponse**](OrdersResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Orders requested |  * Link -  <br>  * RequestID -  <br>  |
| **400** |  |  -  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID -  <br>  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpendingorders"></a>
# **GetPendingOrders**
> PendingOrdersResponse GetPendingOrders (string accountID, DateTimeFormat? acceptDatetimeFormat = null)

Pending Orders

List all pending Orders in an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetPendingOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Pending Orders
                PendingOrdersResponse result = apiInstance.GetPendingOrders(accountID, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetPendingOrders: " + e.Message );
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

[**PendingOrdersResponse**](PendingOrdersResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of pending Orders for the Account |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setorderextensions"></a>
# **SetOrderExtensions**
> OrderExtensionsResponse SetOrderExtensions (string accountID, string orderSpecifier, OrderExtensionsRequest orderExtensionsRequest, DateTimeFormat? acceptDatetimeFormat = null)

Set Order Extensions

Update the Client Extensions for an Order in an Account. Do notset, modify, or delete clientExtensions if your account is associated with MT4.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class SetOrderExtensionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var orderSpecifier = orderSpecifier_example;  // string | The Order Specifier
            var orderExtensionsRequest = new OrderExtensionsRequest(); // OrderExtensionsRequest | Representation of the replacing Order
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Set Order Extensions
                OrderExtensionsResponse result = apiInstance.SetOrderExtensions(accountID, orderSpecifier, orderExtensionsRequest, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.SetOrderExtensions: " + e.Message );
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
 **orderSpecifier** | **string**| The Order Specifier | 
 **orderExtensionsRequest** | [**OrderExtensionsRequest**](OrderExtensionsRequest.md)| Representation of the replacing Order | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**OrderExtensionsResponse**](OrderExtensionsResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Order&#39;s Client Extensions were successfully modified |  * RequestID -  <br>  |
| **400** | The Order Client Extensions specification was invalid |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** | The Account or Order specified does not exist. |  * RequestID -  <br>  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

