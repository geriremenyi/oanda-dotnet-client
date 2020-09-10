# GeriRemenyi.Oanda.V20.Client.Api.PositionApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClosePosition**](PositionApi.md#closeposition) | **PUT** /accounts/{accountID}/positions/{instrument}/close | Close Position
[**GetInstrumentPosition**](PositionApi.md#getinstrumentposition) | **GET** /accounts/{accountID}/positions/{instrument} | Instrument Position
[**GetOpenPositions**](PositionApi.md#getopenpositions) | **GET** /accounts/{accountID}/openPositions | Open Positions
[**GetPositions**](PositionApi.md#getpositions) | **GET** /accounts/{accountID}/positions | List Positions


<a name="closeposition"></a>
# **ClosePosition**
> ClosePositionResponse ClosePosition (string accountID, InstrumentName instrument, ClosePositionRequest closePositionRequest, DateTimeFormat? acceptDatetimeFormat = null)

Close Position

Closeout the open Position for a specific instrument in an Account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class ClosePositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PositionApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var instrument = ;  // InstrumentName | Instrument name
            var closePositionRequest = new ClosePositionRequest(); // ClosePositionRequest | Representation of how to close the position
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 

            try
            {
                // Close Position
                ClosePositionResponse result = apiInstance.ClosePosition(accountID, instrument, closePositionRequest, acceptDatetimeFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PositionApi.ClosePosition: " + e.Message );
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
 **instrument** | **InstrumentName**| Instrument name | 
 **closePositionRequest** | [**ClosePositionRequest**](ClosePositionRequest.md)| Representation of how to close the position | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 

### Return type

[**ClosePositionResponse**](ClosePositionResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Position closeout request has been successfully processed. |  * Location -  <br>  * RequestID -  <br>  |
| **400** | The Parameters provided that describe the Position closeout are invalid. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** | The Account or one or more of the Positions specified does not exist. |  * RequestID -  <br>  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentposition"></a>
# **GetInstrumentPosition**
> InstrumentPositionResponse GetInstrumentPosition (string accountID, InstrumentName instrument)

Instrument Position

Get the details of a single Instrument's Position in an Account. The Position may by open or not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetInstrumentPositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PositionApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var instrument = ;  // InstrumentName | Instrument name

            try
            {
                // Instrument Position
                InstrumentPositionResponse result = apiInstance.GetInstrumentPosition(accountID, instrument);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PositionApi.GetInstrumentPosition: " + e.Message );
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
 **instrument** | **InstrumentName**| Instrument name | 

### Return type

[**InstrumentPositionResponse**](InstrumentPositionResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Position is provided. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getopenpositions"></a>
# **GetOpenPositions**
> OpenPositionsResponse GetOpenPositions (string accountID)

Open Positions

List all open Positions for an Account. An open Position is a Position in an Account that currently has a Trade opened for it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetOpenPositionsExample
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
                OpenPositionsResponse result = apiInstance.GetOpenPositions(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PositionApi.GetOpenPositions: " + e.Message );
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

[**OpenPositionsResponse**](OpenPositionsResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account&#39;s open Positions are provided. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpositions"></a>
# **GetPositions**
> PositionsResponse GetPositions (string accountID)

List Positions

List all Positions for an Account. The Positions returned are for every instrument that has had a position during the lifetime of an the Account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetPositionsExample
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
                PositionsResponse result = apiInstance.GetPositions(accountID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PositionApi.GetPositions: " + e.Message );
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

[**PositionsResponse**](PositionsResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Account&#39;s Positions are provided. |  * RequestID -  <br>  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

