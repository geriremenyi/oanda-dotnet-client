# GeriRemenyi.Oanda.V20.Model.InlineResponse2007OrderBook
The representation of an instrument's order book at a point in time
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Instrument** | **string** | Instrument name identifier. Used by clients to refer to an Instrument. | [optional] 
**Time** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**Price** | **double** | The price (midpoint) for the order book&#39;s instrument at the time of the order book snapshot | [optional] 
**BucketWidth** | **double** | The price width for each bucket. Each bucket covers the price range from the bucket&#39;s price to the bucket&#39;s price + bucketWidth. | [optional] 
**Buckets** | [**List&lt;InlineResponse2007OrderBookBuckets&gt;**](InlineResponse2007OrderBookBuckets.md) | The partitioned order book, divided into buckets using a default bucket width. These buckets are only provided for price ranges which actually contain order or position data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

