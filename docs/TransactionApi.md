# GeriRemenyi.Oanda.V20.Api.TransactionApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsAccountIDTransactionsGet**](TransactionApi.md#accountsaccountidtransactionsget) | **GET** /accounts/{accountID}/transactions | List Transactions
[**AccountsAccountIDTransactionsIdrangeGet**](TransactionApi.md#accountsaccountidtransactionsidrangeget) | **GET** /accounts/{accountID}/transactions/idrange | Transaction ID Range
[**AccountsAccountIDTransactionsSinceidGet**](TransactionApi.md#accountsaccountidtransactionssinceidget) | **GET** /accounts/{accountID}/transactions/sinceid | Transactions Since ID
[**AccountsAccountIDTransactionsTransactionIDGet**](TransactionApi.md#accountsaccountidtransactionstransactionidget) | **GET** /accounts/{accountID}/transactions/{transactionID} | Transaction Details


<a name="accountsaccountidtransactionsget"></a>
# **AccountsAccountIDTransactionsGet**
> InlineResponse20018 AccountsAccountIDTransactionsGet (string accountID, string acceptDatetimeFormat = null, string from = null, string to = null, int? pageSize = null, List<string> type = null)

List Transactions

Get a list of Transactions pages that satisfy a time-based Transaction query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TransactionApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var from = from_example;  // string | The starting time (inclusive) of the time range for the Transactions being queried. (optional) 
            var to = to_example;  // string | The ending time (inclusive) of the time range for the Transactions being queried. (optional) 
            var pageSize = 56;  // int? | The number of Transactions to include in each page of the results. (optional) 
            var type = type_example;  // List<string> | A filter for restricting the types of Transactions to retreive. (optional) 

            try
            {
                // List Transactions
                InlineResponse20018 result = apiInstance.AccountsAccountIDTransactionsGet(accountID, acceptDatetimeFormat, from, to, pageSize, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.AccountsAccountIDTransactionsGet: " + e.Message );
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
 **from** | **string**| The starting time (inclusive) of the time range for the Transactions being queried. | [optional] 
 **to** | **string**| The ending time (inclusive) of the time range for the Transactions being queried. | [optional] 
 **pageSize** | **int?**| The number of Transactions to include in each page of the results. | [optional] 
 **type** | **List&lt;string&gt;**| A filter for restricting the types of Transactions to retreive. | [optional] 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested time range of Transaction pages are provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **403** | Forbidden. The client has provided a token that does not authorize them to perform the action implemented by the API endpoint. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |
| **416** | Range Not Satisfiable. The client has specified a range that is invalid or cannot be processed. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidtransactionsidrangeget"></a>
# **AccountsAccountIDTransactionsIdrangeGet**
> InlineResponse20020 AccountsAccountIDTransactionsIdrangeGet (string accountID, int from, int to, string acceptDatetimeFormat = null, List<string> type = null)

Transaction ID Range

Get a range of Transactions for an Account based on the Transaction IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDTransactionsIdrangeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TransactionApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var from = 56;  // int | The starting Transacion ID (inclusive) to fetch.
            var to = 56;  // int | The ending Transaction ID (inclusive) to fetch.
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var type = type_example;  // List<string> | The filter that restricts the types of Transactions to retreive. (optional) 

            try
            {
                // Transaction ID Range
                InlineResponse20020 result = apiInstance.AccountsAccountIDTransactionsIdrangeGet(accountID, from, to, acceptDatetimeFormat, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.AccountsAccountIDTransactionsIdrangeGet: " + e.Message );
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
 **from** | **int**| The starting Transacion ID (inclusive) to fetch. | 
 **to** | **int**| The ending Transaction ID (inclusive) to fetch. | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 
 **type** | **List&lt;string&gt;**| The filter that restricts the types of Transactions to retreive. | [optional] 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested time range of Transactions are provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |
| **416** | Range Not Satisfiable. The client has specified a range that is invalid or cannot be processed. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidtransactionssinceidget"></a>
# **AccountsAccountIDTransactionsSinceidGet**
> InlineResponse20020 AccountsAccountIDTransactionsSinceidGet (string accountID, int id, string acceptDatetimeFormat = null)

Transactions Since ID

Get a range of Transactions for an Account starting at (but not including) a provided Transaction ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDTransactionsSinceidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TransactionApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var id = 56;  // int | The ID of the last Transacion fetched. This query will return all Transactions newer than the TransactionID.
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Transactions Since ID
                InlineResponse20020 result = apiInstance.AccountsAccountIDTransactionsSinceidGet(accountID, id, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.AccountsAccountIDTransactionsSinceidGet: " + e.Message );
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
 **id** | **int**| The ID of the last Transacion fetched. This query will return all Transactions newer than the TransactionID. | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested time range of Transactions are provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |
| **416** | Range Not Satisfiable. The client has specified a range that is invalid or cannot be processed. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsaccountidtransactionstransactionidget"></a>
# **AccountsAccountIDTransactionsTransactionIDGet**
> InlineResponse20019 AccountsAccountIDTransactionsTransactionIDGet (string accountID, int transactionID, string acceptDatetimeFormat = null)

Transaction Details

Get the details of a single Account Transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class AccountsAccountIDTransactionsTransactionIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TransactionApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var transactionID = 56;  // int | A Transaction ID
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Transaction Details
                InlineResponse20019 result = apiInstance.AccountsAccountIDTransactionsTransactionIDGet(accountID, transactionID, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.AccountsAccountIDTransactionsTransactionIDGet: " + e.Message );
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
 **transactionID** | **int**| A Transaction ID | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the requested Transaction are provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

