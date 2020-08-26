# GeriRemenyi.Oanda.V20.Model.Trade
The specification of a Trade within an Account. This includes the full representation of the Trade's dependent Orders in addition to the IDs of those Orders.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The Trade&#39;s identifier, unique within the Trade&#39;s Account. | [optional] 
**Instrument** | **string** | Instrument name identifier. Used by clients to refer to an Instrument. | [optional] 
**Price** | **double** | The execution price of the Trade. | [optional] 
**OpenTime** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**State** | **string** | The current state of the Trade. | [optional] 
**InitialUnits** | **double** | The initial size of the Trade. Negative values indicate a short Trade, and positive values indicate a long Trade. | [optional] 
**InitialMarginRequired** | **double** | The margin required at the time the Trade was created. Note, this is the &#39;pure&#39; margin required, it is not the &#39;effective&#39; margin used that factors in the trade risk if a GSLO is attached to the trade. | [optional] 
**CurrentUnits** | **double** | The number of units currently open for the Trade. This value is reduced to 0.0 as the Trade is closed. | [optional] 
**RealizedPL** | **double** | The total profit/loss realized on the closed portion of the Trade. | [optional] 
**UnrealizedPL** | **double** | The unrealized profit/loss on the open portion of the Trade. | [optional] 
**MarginUsed** | **double** | Margin currently used by the Trade. | [optional] 
**AverageClosePrice** | **double** | The average closing price of the Trade. Only present if the Trade has been closed or reduced at least once. | [optional] 
**ClosingTransactionIDs** | **List&lt;int&gt;** | The IDs of the Transactions that have closed portions of this Trade. | [optional] 
**Financing** | **double** | The financing paid/collected for this Trade. | [optional] 
**CloseTime** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**ClientExtensions** | [**InlineResponse2005ChangesClientExtensions**](InlineResponse2005ChangesClientExtensions.md) |  | [optional] 
**TakeProfitOrder** | **Object** | A TakeProfitOrder is an order that is linked to an open Trade and created with a price threshold. The Order will be filled (closing the Trade) by the first price that is equal to or better than the threshold. A TakeProfitOrder cannot be used to open a new Position. | [optional] 
**StopLossOrder** | **Object** | A StopLossOrder is an order that is linked to an open Trade and created with a price threshold. The Order will be filled (closing the Trade) by the first price that is equal to or worse than the threshold. A StopLossOrder cannot be used to open a new Position. | [optional] 
**TrailingStopLossOrder** | **Object** | A TrailingStopLossOrder is an order that is linked to an open Trade and created with a price distance. The price distance is used to calculate a trailing stop value for the order that is in the losing direction from the market price at the time of the order&#39;s creation. The trailing stop value will follow the market price as it moves in the winning direction, and the order will filled (closing the Trade) by the first price that is equal to or worse than the trailing stop value. A TrailingStopLossOrder cannot be used to open a new Position. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

