# GeriRemenyi.Oanda.V20.Client.Api.AccountApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigureAccount**](AccountApi.md#configureaccount) | **PATCH** /accounts/{accountID}/configuration | Configure Account
[**GetAccount**](AccountApi.md#getaccount) | **GET** /accounts/{accountID} | Account Details
[**GetAccountChanges**](AccountApi.md#getaccountchanges) | **GET** /accounts/{accountID}/changes | Poll Account Updates
[**GetAccountInstruments**](AccountApi.md#getaccountinstruments) | **GET** /accounts/{accountID}/instruments | Account Instruments
[**GetAccountSummary**](AccountApi.md#getaccountsummary) | **GET** /accounts/{accountID}/summary | Account Summary
[**GetAccounts**](AccountApi.md#getaccounts) | **GET** /accounts | List Accounts


<a name="configureaccount"></a>
# **ConfigureAccount**
> AccountConfigurationResponse ConfigureAccount (string accountID, DateTimeFormat? acceptDatetimeFormat = null, AccountConfigurationRequest accountConfigurationRequest = null)

Configure Account

Set the client-configurable portions of an Account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class ConfigureAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var accountConfigurationRequest = new AccountConfigurationRequest(); // AccountConfigurationRequest | Representation of the Account configuration to set (optional) 

            try
            {
                // Configure Account
                AccountConfigurationResponse result = apiInstance.ConfigureAccount(accountID, acceptDatetimeFormat, accountConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ConfigureAccount: " + e.Message );
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
 **accountConfigurationRequest** | [**AccountConfigurationRequest**](AccountConfigurationRequest.md)| Representation of the Account configuration to set | [optional] 

### Return type

[**AccountConfigurationResponse**](AccountConfigurationResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account was configured successfully. |  * RequestID -  <br>  |
| **400** | The configuration specification was invalid. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **403** | The configuration operation was forbidden on the Account. |  * RequestID -  <br>  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccount"></a>
# **GetAccount**
> AccountResponse GetAccount (string accountID, DateTimeFormat? acceptDatetimeFormat = null)

Account Details

Get the full details for a single Account that a client has access to. Full pending Order, open Trade and open Position representations are provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Account Details
                AccountResponse result = apiInstance.GetAccount(accountID, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccount: " + e.Message );
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

[**AccountResponse**](AccountResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The full Account details are provided |  * RequestID -  <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountchanges"></a>
# **GetAccountChanges**
> AccountChangesResponse GetAccountChanges (string accountID, DateTimeFormat? acceptDatetimeFormat = null, int? sinceTransactionID = null)

Poll Account Updates

Endpoint used to poll an Account for its current state and changes since a specified TransactionID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetAccountChangesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var sinceTransactionID = 56;  // int? | ID of the Transaction to get Account changes since. (optional) 

            try
            {
                // Poll Account Updates
                AccountChangesResponse result = apiInstance.GetAccountChanges(accountID, acceptDatetimeFormat, sinceTransactionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountChanges: " + e.Message );
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
 **sinceTransactionID** | **int?**| ID of the Transaction to get Account changes since. | [optional] 

### Return type

[**AccountChangesResponse**](AccountChangesResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account state and changes are provided. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |
| **416** | Range Not Satisfiable. The client has specified a range that is invalid or cannot be processed. |  * RequestID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountinstruments"></a>
# **GetAccountInstruments**
> InlineResponse2002 GetAccountInstruments (string accountID, List<InstrumentName> instruments = null)

Account Instruments

Get the list of tradeable instruments for the given Account. The list of tradeable instruments is dependent on the regulatory division that the Account is located in, thus should be the same for all Accounts owned by a single user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetAccountInstrumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var instruments = new List<InstrumentName>(); // List<InstrumentName> | List of instruments to query specifically. (optional) 

            try
            {
                // Account Instruments
                InlineResponse2002 result = apiInstance.GetAccountInstruments(accountID, instruments);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountInstruments: " + e.Message );
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
 **instruments** | [**List&lt;InstrumentName&gt;**](InstrumentName.md)| List of instruments to query specifically. | [optional] 

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
| **200** | The list of tradeable instruments for the Account has been provided. |  * RequestID -  <br>  |
| **400** |  |  -  |
| **401** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountsummary"></a>
# **GetAccountSummary**
> InlineResponse2001 GetAccountSummary (string accountID, DateTimeFormat? acceptDatetimeFormat = null)

Account Summary

Get a summary for a single Account that a client has access to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetAccountSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Account Summary
                InlineResponse2001 result = apiInstance.GetAccountSummary(accountID, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountSummary: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account summary are provided |  * RequestID -  <br>  |
| **400** |  |  -  |
| **401** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccounts"></a>
# **GetAccounts**
> InlineResponse200 GetAccounts ()

List Accounts

Get a list of all Accounts authorized for the provided token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetAccountsExample
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
                InlineResponse200 result = apiInstance.GetAccounts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccounts: " + e.Message );
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
| **200** | The list of authorized Accounts has been provided. |  * RequestID -  <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID -  <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

