# GeriRemenyi.Oanda.V20.Api.OrderApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsAccountIDOrdersGet**](OrderApi.md#accountsaccountidordersget) | **GET** /accounts/{accountID}/orders | List Orders
[**AccountsAccountIDOrdersOrderSpecifierCancelPut**](OrderApi.md#accountsaccountidordersorderspecifiercancelput) | **PUT** /accounts/{accountID}/orders/{orderSpecifier}/cancel | Cancel Order
[**AccountsAccountIDOrdersOrderSpecifierClientExtensionsPut**](OrderApi.md#accountsaccountidordersorderspecifierclientextensionsput) | **PUT** /accounts/{accountID}/orders/{orderSpecifier}/clientExtensions | Set Order Extensions
[**AccountsAccountIDOrdersOrderSpecifierGet**](OrderApi.md#accountsaccountidordersorderspecifierget) | **GET** /accounts/{accountID}/orders/{orderSpecifier} | Get Order
[**AccountsAccountIDOrdersOrderSpecifierPut**](OrderApi.md#accountsaccountidordersorderspecifierput) | **PUT** /accounts/{accountID}/orders/{orderSpecifier} | Replace Order
[**AccountsAccountIDOrdersPost**](OrderApi.md#accountsaccountidorderspost) | **POST** /accounts/{accountID}/orders | Create Order
[**AccountsAccountIDPendingOrdersGet**](OrderApi.md#accountsaccountidpendingordersget) | **GET** /accounts/{accountID}/pendingOrders | Pending Orders


<a name="accountsaccountidordersget"></a>
# **AccountsAccountIDOrdersGet**
> InlineResponse2009 AccountsAccountIDOrdersGet (string accountID, string acceptDatetimeFormat = null, List<int> ids = null, string state = null, string instrument = null, int? count = null, int? beforeID = null)

List Orders

Get a list of Orders for an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDOrdersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var ids = new List<int>(); // List<int> | List of Order IDs to retrieve (optional) 
            var state = state_example;  // string | The state to filter the requested Orders by (optional) 
            var instrument = instrument_example;  // string | The instrument to filter the requested orders by (optional) 
            var count = 56;  // int? | The maximum number of Orders to return (optional) 
            var beforeID = 56;  // int? | The maximum Order ID to return. If not provided the most recent Orders in the Account are returned (optional) 

            try
            {
                // List Orders
                InlineResponse2009 result = apiInstance.AccountsAccountIDOrdersGet(accountID, acceptDatetimeFormat, ids, state, instrument, count, beforeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.AccountsAccountIDOrdersGet: " + e.Message );
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
 **ids** | [**List&lt;int&gt;**](int.md)| List of Order IDs to retrieve | [optional] 
 **state** | **string**| The state to filter the requested Orders by | [optional] 
 **instrument** | **string**| The instrument to filter the requested orders by | [optional] 
 **count** | **int?**| The maximum number of Orders to return | [optional] 
 **beforeID** | **int?**| The maximum Order ID to return. If not provided the most recent Orders in the Account are returned | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Orders requested |  * Link - A link to the next/previous page. <br>  * RequestID - The unique identifier generated for the request <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidordersorderspecifiercancelput"></a>
# **AccountsAccountIDOrdersOrderSpecifierCancelPut**
> Object AccountsAccountIDOrdersOrderSpecifierCancelPut (string accountID, string orderSpecifier, string acceptDatetimeFormat = null, string clientRequestID = null)

Cancel Order

Cancel a pending Order in an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDOrdersOrderSpecifierCancelPutExample
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
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var clientRequestID = clientRequestID_example;  // string | Client specified RequestID to be sent with request. (optional) 

            try
            {
                // Cancel Order
                Object result = apiInstance.AccountsAccountIDOrdersOrderSpecifierCancelPut(accountID, orderSpecifier, acceptDatetimeFormat, clientRequestID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.AccountsAccountIDOrdersOrderSpecifierCancelPut: " + e.Message );
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
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 
 **clientRequestID** | **string**| Client specified RequestID to be sent with request. | [optional] 

### Return type

**Object**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Order was cancelled as specified |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | The Account or Order specified does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidordersorderspecifierclientextensionsput"></a>
# **AccountsAccountIDOrdersOrderSpecifierClientExtensionsPut**
> Object AccountsAccountIDOrdersOrderSpecifierClientExtensionsPut (string accountID, string orderSpecifier, InlineObject3 inlineObject3, string acceptDatetimeFormat = null)

Set Order Extensions

Update the Client Extensions for an Order in an Account. Do notset, modify, or delete clientExtensions if your account is associated with MT4.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDOrdersOrderSpecifierClientExtensionsPutExample
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
            var inlineObject3 = new InlineObject3(); // InlineObject3 | 
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Set Order Extensions
                Object result = apiInstance.AccountsAccountIDOrdersOrderSpecifierClientExtensionsPut(accountID, orderSpecifier, inlineObject3, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.AccountsAccountIDOrdersOrderSpecifierClientExtensionsPut: " + e.Message );
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
 **inlineObject3** | [**InlineObject3**](InlineObject3.md)|  | 
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
| **200** | The Order&#39;s Client Extensions were successfully modified |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | The Order Client Extensions specification was invalid |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | The Account or Order specified does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidordersorderspecifierget"></a>
# **AccountsAccountIDOrdersOrderSpecifierGet**
> InlineResponse20011 AccountsAccountIDOrdersOrderSpecifierGet (string accountID, string orderSpecifier, string acceptDatetimeFormat = null)

Get Order

Get details for a single Order in an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDOrdersOrderSpecifierGetExample
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
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Get Order
                InlineResponse20011 result = apiInstance.AccountsAccountIDOrdersOrderSpecifierGet(accountID, orderSpecifier, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.AccountsAccountIDOrdersOrderSpecifierGet: " + e.Message );
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
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the Order requested |  * Link - A link to the next/previous page. <br>  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidordersorderspecifierput"></a>
# **AccountsAccountIDOrdersOrderSpecifierPut**
> Object AccountsAccountIDOrdersOrderSpecifierPut (string accountID, string orderSpecifier, InlineObject2 inlineObject2, string acceptDatetimeFormat = null, string clientRequestID = null)

Replace Order

Replace an Order in an Account by simultaneously cancelling it and creating a replacement Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

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
            var inlineObject2 = new InlineObject2(); // InlineObject2 | 
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var clientRequestID = clientRequestID_example;  // string | Client specified RequestID to be sent with request. (optional) 

            try
            {
                // Replace Order
                Object result = apiInstance.AccountsAccountIDOrdersOrderSpecifierPut(accountID, orderSpecifier, inlineObject2, acceptDatetimeFormat, clientRequestID);
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
 **inlineObject2** | [**InlineObject2**](InlineObject2.md)|  | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 
 **clientRequestID** | **string**| Client specified RequestID to be sent with request. | [optional] 

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
| **201** | The Order was successfully cancelled and replaced |  * Location - A link to the newly created entity <br>  * RequestID - The unique identifier generated for the request <br>  |
| **400** | The Order specification was invalid |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | The Account or Order specified does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidorderspost"></a>
# **AccountsAccountIDOrdersPost**
> Object AccountsAccountIDOrdersPost (string accountID, InlineObject1 inlineObject1, string acceptDatetimeFormat = null)

Create Order

Create an Order for an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDOrdersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var inlineObject1 = new InlineObject1(); // InlineObject1 | 
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Create Order
                Object result = apiInstance.AccountsAccountIDOrdersPost(accountID, inlineObject1, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.AccountsAccountIDOrdersPost: " + e.Message );
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
 **inlineObject1** | [**InlineObject1**](InlineObject1.md)|  | 
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
| **201** | The Order was created as specified |  * Location - A link to the newly created entity <br>  * RequestID - The unique identifier generated for the request <br>  |
| **400** | The Order specification was invalid |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **403** | Forbidden. The client has provided a token that does not authorize them to perform the action implemented by the API endpoint. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | The Order or Account specified does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidpendingordersget"></a>
# **AccountsAccountIDPendingOrdersGet**
> InlineResponse20010 AccountsAccountIDPendingOrdersGet (string accountID, string acceptDatetimeFormat = null)

Pending Orders

List all pending Orders in an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDPendingOrdersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Pending Orders
                InlineResponse20010 result = apiInstance.AccountsAccountIDPendingOrdersGet(accountID, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.AccountsAccountIDPendingOrdersGet: " + e.Message );
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

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of pending Orders for the Account |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

