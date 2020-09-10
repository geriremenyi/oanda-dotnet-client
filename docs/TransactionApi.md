# GeriRemenyi.Oanda.V20.Client.Api.TransactionApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTransaction**](TransactionApi.md#gettransaction) | **GET** /accounts/{accountID}/transactions/{transactionID} | Transaction Details
[**GetTransactionIdRange**](TransactionApi.md#gettransactionidrange) | **GET** /accounts/{accountID}/transactions/idrange | Transaction ID Range
[**GetTransactions**](TransactionApi.md#gettransactions) | **GET** /accounts/{accountID}/transactions | List Transactions
[**GetTransactionsSince**](TransactionApi.md#gettransactionssince) | **GET** /accounts/{accountID}/transactions/sinceid | Transactions Since ID


<a name="gettransaction"></a>
# **GetTransaction**
> TransactionResponse GetTransaction (string accountID, int transactionID, DateTimeFormat? acceptDatetimeFormat = null)

Transaction Details

Get the details of a single Account Transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetTransactionExample
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
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Transaction Details
                TransactionResponse result = apiInstance.GetTransaction(accountID, transactionID, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.GetTransaction: " + e.Message );
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
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the requested Transaction are provided. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionidrange"></a>
# **GetTransactionIdRange**
> TransactionIdRangeResponse GetTransactionIdRange (string accountID, int from, int to, DateTimeFormat? acceptDatetimeFormat = null, List<TransactionType> type = null)

Transaction ID Range

Get a range of Transactions for an Account based on the Transaction IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetTransactionIdRangeExample
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
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var type = new List<TransactionType>(); // List<TransactionType> | The filter that restricts the types of Transactions to retreive. (optional) 

            try
            {
                // Transaction ID Range
                TransactionIdRangeResponse result = apiInstance.GetTransactionIdRange(accountID, from, to, acceptDatetimeFormat, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.GetTransactionIdRange: " + e.Message );
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
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 
 **type** | [**List&lt;TransactionType&gt;**](TransactionType.md)| The filter that restricts the types of Transactions to retreive. | [optional] 

### Return type

[**TransactionIdRangeResponse**](TransactionIdRangeResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested time range of Transactions are provided. |  * RequestID -  <br>  |
| **400** |  |  -  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |
| **416** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactions"></a>
# **GetTransactions**
> TransactionsResponse GetTransactions (string accountID, DateTimeFormat? acceptDatetimeFormat = null, string from = null, string to = null, int? pageSize = null, List<TransactionType> type = null)

List Transactions

Get a list of Transactions pages that satisfy a time-based Transaction query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TransactionApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var from = from_example;  // string | The starting time (inclusive) of the time range for the Transactions being queried. (optional) 
            var to = to_example;  // string | The ending time (inclusive) of the time range for the Transactions being queried. (optional) 
            var pageSize = 56;  // int? | The number of Transactions to include in each page of the results. (optional) 
            var type = new List<TransactionType>(); // List<TransactionType> | A filter for restricting the types of Transactions to retreive. (optional) 

            try
            {
                // List Transactions
                TransactionsResponse result = apiInstance.GetTransactions(accountID, acceptDatetimeFormat, from, to, pageSize, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.GetTransactions: " + e.Message );
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
 **from** | **string**| The starting time (inclusive) of the time range for the Transactions being queried. | [optional] 
 **to** | **string**| The ending time (inclusive) of the time range for the Transactions being queried. | [optional] 
 **pageSize** | **int?**| The number of Transactions to include in each page of the results. | [optional] 
 **type** | [**List&lt;TransactionType&gt;**](TransactionType.md)| A filter for restricting the types of Transactions to retreive. | [optional] 

### Return type

[**TransactionsResponse**](TransactionsResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested time range of Transaction pages are provided. |  * RequestID -  <br>  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |
| **416** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionssince"></a>
# **GetTransactionsSince**
> TransactionSinceIdResponse GetTransactionsSince (string accountID, int id, DateTimeFormat? acceptDatetimeFormat = null)

Transactions Since ID

Get a range of Transactions for an Account starting at (but not including) a provided Transaction ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetTransactionsSinceExample
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
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Transactions Since ID
                TransactionSinceIdResponse result = apiInstance.GetTransactionsSince(accountID, id, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.GetTransactionsSince: " + e.Message );
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
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**TransactionSinceIdResponse**](TransactionSinceIdResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested time range of Transactions are provided. |  * RequestID -  <br>  |
| **400** |  |  -  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |
| **416** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

