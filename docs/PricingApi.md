# GeriRemenyi.Oanda.V20.Client.Api.PricingApi

All URIs are relative to *https://api-fxpractice.oanda.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPricing**](PricingApi.md#getpricing) | **GET** /accounts/{accountID}/pricing | Current Account Prices


<a name="getpricing"></a>
# **GetPricing**
> PricingResponse GetPricing (string accountID, List<InstrumentName> instruments, DateTimeFormat? acceptDatetimeFormat = null, string since = null, bool? includeUnitsAvailable = null, bool? includeHomeConversions = null)

Current Account Prices

Get pricing information for a specified list of Instruments within an Account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GeriRemenyi.Oanda.V20.Client.Api;
using GeriRemenyi.Oanda.V20.Client.Client;
using GeriRemenyi.Oanda.V20.Client.Model;

namespace Example
{
    public class GetPricingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-fxpractice.oanda.com/v3";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PricingApi(config);
            var accountID = accountID_example;  // string | Account identifier
            var instruments = new List<InstrumentName>(); // List<InstrumentName> | List of Instruments to get pricing for.
            var acceptDatetimeFormat = ;  // DateTimeFormat? | Format of DateTime fields in the request and response. (optional) 
            var since = since_example;  // string | Date/Time filter to apply to the response. Only prices and home conversions (if requested) with a time later than this filter (i.e. the price has changed after the since time) will be provided, and are filtered independently. (optional) 
            var includeUnitsAvailable = true;  // bool? | Flag that enables the inclusion of the unitsAvailable field in the returned Price objects. (optional) 
            var includeHomeConversions = true;  // bool? | Flag that enables the inclusion of the homeConversions field in the returned response. An entry will be returned for each currency in the set of all base and quote currencies present in the requested instruments list. (optional) 

            try
            {
                // Current Account Prices
                PricingResponse result = apiInstance.GetPricing(accountID, instruments, acceptDatetimeFormat, since, includeUnitsAvailable, includeHomeConversions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PricingApi.GetPricing: " + e.Message );
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
 **instruments** | [**List&lt;InstrumentName&gt;**](InstrumentName.md)| List of Instruments to get pricing for. | 
 **acceptDatetimeFormat** | **DateTimeFormat?**| Format of DateTime fields in the request and response. | [optional] 
 **since** | **string**| Date/Time filter to apply to the response. Only prices and home conversions (if requested) with a time later than this filter (i.e. the price has changed after the since time) will be provided, and are filtered independently. | [optional] 
 **includeUnitsAvailable** | **bool?**| Flag that enables the inclusion of the unitsAvailable field in the returned Price objects. | [optional] 
 **includeHomeConversions** | **bool?**| Flag that enables the inclusion of the homeConversions field in the returned response. An entry will be returned for each currency in the set of all base and quote currencies present in the requested instruments list. | [optional] 

### Return type

[**PricingResponse**](PricingResponse.md)

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

