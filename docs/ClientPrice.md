# GeriRemenyi.Oanda.V20.Client.Model.ClientPrice
The specification of an Account-specific Price.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The string \&quot;PRICE\&quot;. Used to identify the a Price object when found in a stream. | [optional] 
**Instrument** | **InstrumentName** |  | [optional] 
**Time** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**Status** | **PriceStatus** |  | [optional] 
**Tradeable** | **bool** | Flag indicating if the Price is tradeable or not | [optional] 
**Bids** | [**List&lt;PriceBucket&gt;**](PriceBucket.md) | The list of prices and liquidity available on the Instrument&#39;s bid side. It is possible for this list to be empty if there is no bid liquidity currently available for the Instrument in the Account. | [optional] 
**Asks** | [**List&lt;PriceBucket&gt;**](PriceBucket.md) | The list of prices and liquidity available on the Instrument&#39;s ask side. It is possible for this list to be empty if there is no ask liquidity currently available for the Instrument in the Account. | [optional] 
**CloseoutBid** | **double** | The closeout bid Price. This Price is used when a bid is required to closeout a Position (margin closeout or manual) yet there is no bid liquidity. The closeout bid is never used to open a new position. | [optional] 
**CloseoutAsk** | **double** | The closeout ask Price. This Price is used when a ask is required to closeout a Position (margin closeout or manual) yet there is no ask liquidity. The closeout ask is never used to open a new position. | [optional] 
**QuoteHomeConversionFactors** | [**QuoteHomeConversionFactors**](QuoteHomeConversionFactors.md) |  | [optional] 
**UnitsAvailable** | [**UnitsAvailable**](UnitsAvailable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

