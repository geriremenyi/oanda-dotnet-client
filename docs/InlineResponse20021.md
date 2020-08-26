# GeriRemenyi.Oanda.V20.Model.InlineResponse20021
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prices** | [**List&lt;InlineResponse20021Prices&gt;**](InlineResponse20021Prices.md) | The list of Price objects requested. | [optional] 
**HomeConversions** | [**List&lt;InlineResponse20021HomeConversions&gt;**](InlineResponse20021HomeConversions.md) | The list of home currency conversion factors requested. This field will only be present if includeHomeConversions was set to true in the request. | [optional] 
**Time** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

