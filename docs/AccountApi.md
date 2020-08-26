# GeriRemenyi.Oanda.V20.Api.AccountApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsAccountIDChangesGet**](AccountApi.md#accountsaccountidchangesget) | **GET** /accounts/{accountID}/changes | Poll Account Updates
[**AccountsAccountIDConfigurationPatch**](AccountApi.md#accountsaccountidconfigurationpatch) | **PATCH** /accounts/{accountID}/configuration | Configure Account
[**AccountsAccountIDGet**](AccountApi.md#accountsaccountidget) | **GET** /accounts/{accountID} | Account Details
[**AccountsAccountIDInstrumentsGet**](AccountApi.md#accountsaccountidinstrumentsget) | **GET** /accounts/{accountID}/instruments | Account Instruments
[**AccountsAccountIDSummaryGet**](AccountApi.md#accountsaccountidsummaryget) | **GET** /accounts/{accountID}/summary | Account Summary
[**AccountsGet**](AccountApi.md#accountsget) | **GET** /accounts | List Accounts


<a name="accountsaccountidchangesget"></a>
# **AccountsAccountIDChangesGet**
> InlineResponse2005 AccountsAccountIDChangesGet (string accountID, string acceptDatetimeFormat = null, int? sinceTransactionID = null)

Poll Account Updates

Endpoint used to poll an Account for its current state and changes since a specified TransactionID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDChangesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var sinceTransactionID = 56;  // int? | ID of the Transaction to get Account changes since. (optional) 

            try
            {
                // Poll Account Updates
                InlineResponse2005 result = apiInstance.AccountsAccountIDChangesGet(accountID, acceptDatetimeFormat, sinceTransactionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountsAccountIDChangesGet: " + e.Message );
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
 **sinceTransactionID** | **int?**| ID of the Transaction to get Account changes since. | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account state and changes are provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |
| **416** | Range Not Satisfiable. The client has specified a range that is invalid or cannot be processed. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidconfigurationpatch"></a>
# **AccountsAccountIDConfigurationPatch**
> InlineResponse2004 AccountsAccountIDConfigurationPatch (string accountID, string acceptDatetimeFormat = null, InlineObject inlineObject = null)

Configure Account

Set the client-configurable portions of an Account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDConfigurationPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var inlineObject = new InlineObject(); // InlineObject |  (optional) 

            try
            {
                // Configure Account
                InlineResponse2004 result = apiInstance.AccountsAccountIDConfigurationPatch(accountID, acceptDatetimeFormat, inlineObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountsAccountIDConfigurationPatch: " + e.Message );
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
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account was configured successfully. |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | The configuration specification was invalid. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **403** | The configuration operation was forbidden on the Account. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidget"></a>
# **AccountsAccountIDGet**
> InlineResponse2001 AccountsAccountIDGet (string accountID, string acceptDatetimeFormat = null)

Account Details

Get the full details for a single Account that a client has access to. Full pending Order, open Trade and open Position representations are provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Account Details
                InlineResponse2001 result = apiInstance.AccountsAccountIDGet(accountID, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountsAccountIDGet: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The full Account details are provided |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidinstrumentsget"></a>
# **AccountsAccountIDInstrumentsGet**
> InlineResponse2003 AccountsAccountIDInstrumentsGet (string accountID, List<string> instruments = null)

Account Instruments

Get the list of tradeable instruments for the given Account. The list of tradeable instruments is dependent on the regulatory division that the Account is located in, thus should be the same for all Accounts owned by a single user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDInstrumentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var instruments = instruments_example;  // List<string> | List of instruments to query specifically. (optional) 

            try
            {
                // Account Instruments
                InlineResponse2003 result = apiInstance.AccountsAccountIDInstrumentsGet(accountID, instruments);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountsAccountIDInstrumentsGet: " + e.Message );
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
 **instruments** | **List&lt;string&gt;**| List of instruments to query specifically. | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of tradeable instruments for the Account has been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidsummaryget"></a>
# **AccountsAccountIDSummaryGet**
> InlineResponse2002 AccountsAccountIDSummaryGet (string accountID, string acceptDatetimeFormat = null)

Account Summary

Get a summary for a single Account that a client has access to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDSummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Account Summary
                InlineResponse2002 result = apiInstance.AccountsAccountIDSummaryGet(accountID, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountsAccountIDSummaryGet: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account summary are provided |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsget"></a>
# **AccountsGet**
> InlineResponse200 AccountsGet ()

List Accounts

Get a list of all Accounts authorized for the provided token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // List Accounts
                InlineResponse200 result = apiInstance.AccountsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of authorized Accounts has been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

