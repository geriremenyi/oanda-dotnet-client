# GeriRemenyi.Oanda.V20.Model.MarketOrderTransaction
A MarketOrderTransaction represents the creation of a Market Order in the user's account. A Market Order is an Order that is filled immediately at the current market price.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The Transaction&#39;s Identifier. | [optional] 
**Time** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**UserID** | **int** | The ID of the user that initiated the creation of the Transaction. | [optional] 
**AccountID** | **string** | The Account&#39;s identifier | [optional] 
**BatchID** | **int** | The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously. | [optional] 
**RequestID** | **string** | The Request ID of the request which generated the transaction. | [optional] 
**Type** | **string** | The Type of the Transaction. | [optional] 
**Instrument** | **string** | Instrument name identifier. Used by clients to refer to an Instrument. | [optional] 
**Units** | **double** | The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order. | [optional] 
**TimeInForce** | **string** | The time-in-force requested for the Market Order. Restricted to FOK or IOC for a MarketOrder. | [optional] 
**PriceBound** | **double** | The worst price that the client is willing to have the Market Order filled at. | [optional] 
**PositionFill** | **string** | Specification of how Positions in the Account are modified when the Order is filled. | [optional] 
**TradeClose** | [**MarketOrderTradeClose**](MarketOrderTradeClose.md) |  | [optional] 
**LongPositionCloseout** | [**MarketOrderLongPositionCloseout**](MarketOrderLongPositionCloseout.md) |  | [optional] 
**ShortPositionCloseout** | [**MarketOrderLongPositionCloseout**](MarketOrderLongPositionCloseout.md) |  | [optional] 
**MarginCloseout** | [**MarketOrderMarginCloseout**](MarketOrderMarginCloseout.md) |  | [optional] 
**DelayedTradeClose** | [**MarketOrderDelayedTradeClose**](MarketOrderDelayedTradeClose.md) |  | [optional] 
**Reason** | **string** | The reason that the Market Order was created | [optional] 
**ClientExtensions** | [**InlineResponse2005ChangesClientExtensions**](InlineResponse2005ChangesClientExtensions.md) |  | [optional] 
**TakeProfitOnFill** | [**AccountsAccountIDTradesTradeSpecifierOrdersTakeProfit**](AccountsAccountIDTradesTradeSpecifierOrdersTakeProfit.md) |  | [optional] 
**StopLossOnFill** | [**AccountsAccountIDTradesTradeSpecifierOrdersStopLoss**](AccountsAccountIDTradesTradeSpecifierOrdersStopLoss.md) |  | [optional] 
**TrailingStopLossOnFill** | [**AccountsAccountIDTradesTradeSpecifierOrdersTrailingStopLoss**](AccountsAccountIDTradesTradeSpecifierOrdersTrailingStopLoss.md) |  | [optional] 
**TradeClientExtensions** | [**InlineResponse2005ChangesClientExtensions**](InlineResponse2005ChangesClientExtensions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

