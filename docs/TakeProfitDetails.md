# GeriRemenyi.Oanda.V20.Model.TakeProfitDetails
TakeProfitDetails specifies the details of a Take Profit Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Take Profit, or when a Trade's dependent Take Profit Order is modified directly through the Trade.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Price** | **double** | The price that the Take Profit Order will be triggered at. Only one of the price and distance fields may be specified. | [optional] 
**TimeInForce** | **string** | The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD. | [optional] 
**GtdTime** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**ClientExtensions** | [**InlineResponse2005ChangesClientExtensions**](InlineResponse2005ChangesClientExtensions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

