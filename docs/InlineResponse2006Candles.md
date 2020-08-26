# GeriRemenyi.Oanda.V20.Model.InlineResponse2006Candles
The Candlestick representation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Time** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**Bid** | [**InlineResponse2006Bid**](InlineResponse2006Bid.md) |  | [optional] 
**Ask** | [**InlineResponse2006Bid**](InlineResponse2006Bid.md) |  | [optional] 
**Mid** | [**InlineResponse2006Bid**](InlineResponse2006Bid.md) |  | [optional] 
**Volume** | **int** | The number of prices created during the time-range represented by the candlestick. | [optional] 
**Complete** | **bool** | A flag indicating if the candlestick is complete. A complete candlestick is one whose ending time is not in the future. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

