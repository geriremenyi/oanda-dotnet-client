# GeriRemenyi.Oanda.V20.Api.InstrumentApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InstrumentsInstrumentCandlesGet**](InstrumentApi.md#instrumentsinstrumentcandlesget) | **GET** /instruments/{instrument}/candles | Get Candlesticks
[**InstrumentsInstrumentOrderBookGet**](InstrumentApi.md#instrumentsinstrumentorderbookget) | **GET** /instruments/{instrument}/orderBook | Get Order Book
[**InstrumentsInstrumentPositionBookGet**](InstrumentApi.md#instrumentsinstrumentpositionbookget) | **GET** /instruments/{instrument}/positionBook | Get Position Book


<a name="instrumentsinstrumentcandlesget"></a>
# **InstrumentsInstrumentCandlesGet**
> InlineResponse2006 InstrumentsInstrumentCandlesGet (string instrument, string acceptDatetimeFormat = null, string price = null, string granularity = null, int? count = null, string from = null, string to = null, bool? smooth = null, bool? includeFirst = null, int? dailyAlignment = null, string alignmentTimezone = null, string weeklyAlignment = null)

Get Candlesticks

Fetch candlestick data for an instrument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class InstrumentsInstrumentCandlesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var instrument = instrument_example;  // string | Instrument name
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var price = price_example;  // string | The Price component(s) to get candlestick data for. Can contain any combination of the characters \"M\" (midpoint candles) \"B\" (bid candles) and \"A\" (ask candles). (optional) 
            var granularity = granularity_example;  // string | The granularity of the candlesticks to fetch (optional) 
            var count = 56;  // int? | The number of candlesticks to return in the reponse. Count should not be specified if both the start and end parameters are provided, as the time range combined with the graularity will determine the number of candlesticks to return. (optional) 
            var from = from_example;  // string | The start of the time range to fetch candlesticks for. (optional) 
            var to = to_example;  // string | The end of the time range to fetch candlesticks for. (optional) 
            var smooth = true;  // bool? | A flag that controls whether the candlestick is \"smoothed\" or not.  A smoothed candlestick uses the previous candle's close price as its open price, while an unsmoothed candlestick uses the first price from its time range as its open price. (optional) 
            var includeFirst = true;  // bool? | A flag that controls whether the candlestick that is covered by the from time should be included in the results. This flag enables clients to use the timestamp of the last completed candlestick received to poll for future candlesticks but avoid receiving the previous candlestick repeatedly. (optional) 
            var dailyAlignment = 56;  // int? | The hour of the day (in the specified timezone) to use for granularities that have daily alignments. (optional) 
            var alignmentTimezone = alignmentTimezone_example;  // string | The timezone to use for the dailyAlignment parameter. Candlesticks with daily alignment will be aligned to the dailyAlignment hour within the alignmentTimezone.  Note that the returned times will still be represented in UTC. (optional) 
            var weeklyAlignment = weeklyAlignment_example;  // string | The day of the week used for granularities that have weekly alignment. (optional) 

            try
            {
                // Get Candlesticks
                InlineResponse2006 result = apiInstance.InstrumentsInstrumentCandlesGet(instrument, acceptDatetimeFormat, price, granularity, count, from, to, smooth, includeFirst, dailyAlignment, alignmentTimezone, weeklyAlignment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.InstrumentsInstrumentCandlesGet: " + e.Message );
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
 **instrument** | **string**| Instrument name | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 
 **price** | **string**| The Price component(s) to get candlestick data for. Can contain any combination of the characters \&quot;M\&quot; (midpoint candles) \&quot;B\&quot; (bid candles) and \&quot;A\&quot; (ask candles). | [optional] 
 **granularity** | **string**| The granularity of the candlesticks to fetch | [optional] 
 **count** | **int?**| The number of candlesticks to return in the reponse. Count should not be specified if both the start and end parameters are provided, as the time range combined with the graularity will determine the number of candlesticks to return. | [optional] 
 **from** | **string**| The start of the time range to fetch candlesticks for. | [optional] 
 **to** | **string**| The end of the time range to fetch candlesticks for. | [optional] 
 **smooth** | **bool?**| A flag that controls whether the candlestick is \&quot;smoothed\&quot; or not.  A smoothed candlestick uses the previous candle&#39;s close price as its open price, while an unsmoothed candlestick uses the first price from its time range as its open price. | [optional] 
 **includeFirst** | **bool?**| A flag that controls whether the candlestick that is covered by the from time should be included in the results. This flag enables clients to use the timestamp of the last completed candlestick received to poll for future candlesticks but avoid receiving the previous candlestick repeatedly. | [optional] 
 **dailyAlignment** | **int?**| The hour of the day (in the specified timezone) to use for granularities that have daily alignments. | [optional] 
 **alignmentTimezone** | **string**| The timezone to use for the dailyAlignment parameter. Candlesticks with daily alignment will be aligned to the dailyAlignment hour within the alignmentTimezone.  Note that the returned times will still be represented in UTC. | [optional] 
 **weeklyAlignment** | **string**| The day of the week used for granularities that have weekly alignment. | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pricing information has been successfully provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="instrumentsinstrumentorderbookget"></a>
# **InstrumentsInstrumentOrderBookGet**
> InlineResponse2007 InstrumentsInstrumentOrderBookGet (string instrument, string acceptDatetimeFormat = null, string time = null)

Get Order Book

Fetch an order book for an instrument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class InstrumentsInstrumentOrderBookGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var instrument = instrument_example;  // string | Instrument name
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var time = time_example;  // string | The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched. (optional) 

            try
            {
                // Get Order Book
                InlineResponse2007 result = apiInstance.InstrumentsInstrumentOrderBookGet(instrument, acceptDatetimeFormat, time);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.InstrumentsInstrumentOrderBookGet: " + e.Message );
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
 **instrument** | **string**| Instrument name | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 
 **time** | **string**| The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched. | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The order book has been successfully provided. |  * Content-Encoding - Value will be \&quot;gzip\&quot; regardless of provided Accept-Encoding header <br>  * Link - A link to the next/previous page. <br>  * RequestID - The unique identifier generated for the request <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="instrumentsinstrumentpositionbookget"></a>
# **InstrumentsInstrumentPositionBookGet**
> InlineResponse2008 InstrumentsInstrumentPositionBookGet (string instrument, string acceptDatetimeFormat = null, string time = null)

Get Position Book

Fetch a position book for an instrument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Api;
using GeriRemenyi.Oanda.V20.Client;
using GeriRemenyi.Oanda.V20.Model;

namespace Example
{
    public class InstrumentsInstrumentPositionBookGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var instrument = instrument_example;  // string | Instrument name
            var acceptDatetimeFormat = acceptDatetimeFormat_example;  // string | Format of DateTime fields in the request and response. (optional) 
            var time = time_example;  // string | The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched. (optional) 

            try
            {
                // Get Position Book
                InlineResponse2008 result = apiInstance.InstrumentsInstrumentPositionBookGet(instrument, acceptDatetimeFormat, time);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.InstrumentsInstrumentPositionBookGet: " + e.Message );
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
 **instrument** | **string**| Instrument name | 
 **acceptDatetimeFormat** | **string**| Format of DateTime fields in the request and response. | [optional] 
 **time** | **string**| The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched. | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The position book has been successfully provided. |  * Content-Encoding - Value will be \&quot;gzip\&quot; regardless of provided Accept-Encoding header <br>  * Link - A link to the next/previous page. <br>  * RequestID - The unique identifier generated for the request <br>  |
| **400** | Bad Request. The client has provided invalid data to be processed by the server. |  * RequestID - The unique identifier generated for the request <br>  |
| **401** | Unauthorized. The endpoint being access required the client to authenticated, however the the authentication token is invalid or has not been provided. |  * RequestID - The unique identifier generated for the request <br>  |
| **404** | Not Found. The client has attempted to access an entity that does not exist. |  * RequestID - The unique identifier generated for the request <br>  |
| **405** | Method Not Allowed. The client has attempted to access an endpoint using an HTTP method that is not supported. |  * RequestID - The unique identifier generated for the request <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

