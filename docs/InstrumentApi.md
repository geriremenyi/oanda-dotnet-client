# GeriRemenyi.Oanda.V20.Client.Api.InstrumentApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInstrumentCandles**](InstrumentApi.md#getinstrumentcandles) | **GET** /instruments/{instrument}/candles | Get Candlesticks
[**GetInstrumentOrderBook**](InstrumentApi.md#getinstrumentorderbook) | **GET** /instruments/{instrument}/orderBook | Get Order Book
[**GetInstrumentPositionBook**](InstrumentApi.md#getinstrumentpositionbook) | **GET** /instruments/{instrument}/positionBook | Get Position Book


<a name="getinstrumentcandles"></a>
# **GetInstrumentCandles**
> CandlesResponse GetInstrumentCandles (InstrumentName instrument, DateTimeFormat? acceptDatetimeFormat = null, string price = null, CandlestickGranularity? granularity = null, int? count = null, string from = null, string to = null, bool? smooth = null, bool? includeFirst = null, int? dailyAlignment = null, string alignmentTimezone = null, string weeklyAlignment = null)

Get Candlesticks

Fetch candlestick data for an instrument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetInstrumentCandlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var instrument = ;  // InstrumentName | Instrument name
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var price = price_example;  // string | The Price component(s) to get candlestick data for. Can contain any combination of the characters \"M\" (midpoint candles) \"B\" (bid candles) and \"A\" (ask candles). (optional) 
            var granularity = ;  // CandlestickGranularity? | The granularity of the candlesticks to fetch (optional) 
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
                CandlesResponse result = apiInstance.GetInstrumentCandles(instrument, acceptDatetimeFormat, price, granularity, count, from, to, smooth, includeFirst, dailyAlignment, alignmentTimezone, weeklyAlignment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.GetInstrumentCandles: " + e.Message );
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
 **instrument** | **InstrumentName**| Instrument name | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 
 **price** | **string**| The Price component(s) to get candlestick data for. Can contain any combination of the characters \&quot;M\&quot; (midpoint candles) \&quot;B\&quot; (bid candles) and \&quot;A\&quot; (ask candles). | [optional] 
 **granularity** | **CandlestickGranularity?**| The granularity of the candlesticks to fetch | [optional] 
 **count** | **int?**| The number of candlesticks to return in the reponse. Count should not be specified if both the start and end parameters are provided, as the time range combined with the graularity will determine the number of candlesticks to return. | [optional] 
 **from** | **string**| The start of the time range to fetch candlesticks for. | [optional] 
 **to** | **string**| The end of the time range to fetch candlesticks for. | [optional] 
 **smooth** | **bool?**| A flag that controls whether the candlestick is \&quot;smoothed\&quot; or not.  A smoothed candlestick uses the previous candle&#39;s close price as its open price, while an unsmoothed candlestick uses the first price from its time range as its open price. | [optional] 
 **includeFirst** | **bool?**| A flag that controls whether the candlestick that is covered by the from time should be included in the results. This flag enables clients to use the timestamp of the last completed candlestick received to poll for future candlesticks but avoid receiving the previous candlestick repeatedly. | [optional] 
 **dailyAlignment** | **int?**| The hour of the day (in the specified timezone) to use for granularities that have daily alignments. | [optional] 
 **alignmentTimezone** | **string**| The timezone to use for the dailyAlignment parameter. Candlesticks with daily alignment will be aligned to the dailyAlignment hour within the alignmentTimezone.  Note that the returned times will still be represented in UTC. | [optional] 
 **weeklyAlignment** | **string**| The day of the week used for granularities that have weekly alignment. | [optional] 

### Return type

[**CandlesResponse**](CandlesResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pricing information has been successfully provided. |  * RequestID -  <br>  |
| **400** |  |  -  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentorderbook"></a>
# **GetInstrumentOrderBook**
> InstrumentOrderBookResponse GetInstrumentOrderBook (InstrumentName instrument, DateTimeFormat? acceptDatetimeFormat = null, string time = null)

Get Order Book

Fetch an order book for an instrument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetInstrumentOrderBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var instrument = ;  // InstrumentName | Instrument name
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var time = time_example;  // string | The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched. (optional) 

            try
            {
                // Get Order Book
                InstrumentOrderBookResponse result = apiInstance.GetInstrumentOrderBook(instrument, acceptDatetimeFormat, time);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.GetInstrumentOrderBook: " + e.Message );
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
 **instrument** | **InstrumentName**| Instrument name | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 
 **time** | **string**| The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched. | [optional] 

### Return type

[**InstrumentOrderBookResponse**](InstrumentOrderBookResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The order book has been successfully provided. |  * Content-Encoding -  <br>  * Link -  <br>  * RequestID -  <br>  |
| **400** |  |  -  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentpositionbook"></a>
# **GetInstrumentPositionBook**
> InstrumentPositionBookResponse GetInstrumentPositionBook (InstrumentName instrument, DateTimeFormat? acceptDatetimeFormat = null, string time = null)

Get Position Book

Fetch a position book for an instrument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetInstrumentPositionBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new InstrumentApi(config);
            var instrument = ;  // InstrumentName | Instrument name
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var time = time_example;  // string | The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched. (optional) 

            try
            {
                // Get Position Book
                InstrumentPositionBookResponse result = apiInstance.GetInstrumentPositionBook(instrument, acceptDatetimeFormat, time);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentApi.GetInstrumentPositionBook: " + e.Message );
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
 **instrument** | **InstrumentName**| Instrument name | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 
 **time** | **string**| The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched. | [optional] 

### Return type

[**InstrumentPositionBookResponse**](InstrumentPositionBookResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The position book has been successfully provided. |  * Content-Encoding -  <br>  * Link -  <br>  * RequestID -  <br>  |
| **400** |  |  -  |
| **401** |  |  -  |
| **404** |  |  -  |
| **405** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

