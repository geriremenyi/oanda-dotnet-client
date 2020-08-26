# GeriRemenyi.Oanda.V20.Api.PositionApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsAccountIDOpenPositionsGet**](PositionApi.md#accountsaccountidopenpositionsget) | **GET** /accounts/{accountID}/openPositions | Open Positions
[**AccountsAccountIDPositionsGet**](PositionApi.md#accountsaccountidpositionsget) | **GET** /accounts/{accountID}/positions | List Positions
[**AccountsAccountIDPositionsInstrumentClosePut**](PositionApi.md#accountsaccountidpositionsinstrumentcloseput) | **PUT** /accounts/{accountID}/positions/{instrument}/close | Close Position
[**AccountsAccountIDPositionsInstrumentGet**](PositionApi.md#accountsaccountidpositionsinstrumentget) | **GET** /accounts/{accountID}/positions/{instrument} | Instrument Position


<a name="accountsaccountidopenpositionsget"></a>
# **AccountsAccountIDOpenPositionsGet**
> InlineResponse20016 AccountsAccountIDOpenPositionsGet (string accountID)

Open Positions

List all open Positions for an Account. An open Position is a Position in an Account that currently has a Trade opened for it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDOpenPositionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PositionApi(config);
            var accountID = accountID_example;  // string | Account identifier

            try
            {
                // Open Positions
                InlineResponse20016 result = apiInstance.AccountsAccountIDOpenPositionsGet(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PositionApi.AccountsAccountIDOpenPositionsGet: " + e.Message );
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

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account&#39;s open Positions are provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidpositionsget"></a>
# **AccountsAccountIDPositionsGet**
> InlineResponse20015 AccountsAccountIDPositionsGet (string accountID)

List Positions

List all Positions for an Account. The Positions returned are for every instrument that has had a position during the lifetime of an the Account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDPositionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PositionApi(config);
            var accountID = accountID_example;  // string | Account identifier

            try
            {
                // List Positions
                InlineResponse20015 result = apiInstance.AccountsAccountIDPositionsGet(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PositionApi.AccountsAccountIDPositionsGet: " + e.Message );
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

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account&#39;s Positions are provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidpositionsinstrumentcloseput"></a>
# **AccountsAccountIDPositionsInstrumentClosePut**
> Object AccountsAccountIDPositionsInstrumentClosePut (string accountID, string instrument, InlineObject7 inlineObject7, string acceptDatetimeFormat = null)

Close Position

Closeout the open Position for a specific instrument in an Account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDPositionsInstrumentClosePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PositionApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var instrument = instrument_example;  // string | Instrument name
            var inlineObject7 = new InlineObject7(); // InlineObject7 | 
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Close Position
                Object result = apiInstance.AccountsAccountIDPositionsInstrumentClosePut(accountID, instrument, inlineObject7, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PositionApi.AccountsAccountIDPositionsInstrumentClosePut: " + e.Message );
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
 **instrument** | **string**| Instrument name | 
 **inlineObject7** | [**InlineObject7**](InlineObject7.md)|  | 
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
| **200** | The Position closeout request has been successfully processed. |  * Location - A link to the newly created entity <br>  * RequestID - The unique identifier generated for the request <br>  |
| **400** | The Parameters provided that describe the Position closeout are invalid. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | The Account or one or more of the Positions specified does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidpositionsinstrumentget"></a>
# **AccountsAccountIDPositionsInstrumentGet**
> InlineResponse20017 AccountsAccountIDPositionsInstrumentGet (string accountID, string instrument)

Instrument Position

Get the details of a single Instrument's Position in an Account. The Position may by open or not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDPositionsInstrumentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PositionApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var instrument = instrument_example;  // string | Instrument name

            try
            {
                // Instrument Position
                InlineResponse20017 result = apiInstance.AccountsAccountIDPositionsInstrumentGet(accountID, instrument);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PositionApi.AccountsAccountIDPositionsInstrumentGet: " + e.Message );
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
 **instrument** | **string**| Instrument name | 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Position is provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

