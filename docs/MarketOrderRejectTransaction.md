# GeriRemenyi.Oanda.V20.Client.Model.MarketOrderRejectTransaction
A MarketOrderRejectTransaction represents the rejection of the creation of a Market Order.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The Transaction&#39;s Identifier. | [optional] 
**Time** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**UserID** | **int** | The ID of the user that initiated the creation of the Transaction. | [optional] 
**AccountID** | **string** | The Account&#39;s identifier | [optional] 
**BatchID** | **int** | The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously. | [optional] 
**RequestID** | **string** | The Request ID of the request which generated the transaction. | [optional] 
**Type** | **TransactionType** |  | [optional] 
**RejectReason** | **string** | The reason that the Reject Transaction was created | [optional] 
**Instrument** | **InstrumentName** |  | [optional] 
**Units** | **double** | The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order. | [optional] 
**TimeInForce** | [**MarketOrderTradeClose**](MarketOrderTradeClose.md) |  | [optional] 
**PriceBound** | **double** | The worst price that the client is willing to have the Market Order filled at. | [optional] 
**PositionFill** | **MarketOrderPositionFill** |  | [optional] 
**TradeClose** | [**MarketOrderTradeClose**](MarketOrderTradeClose.md) |  | [optional] 
**LongPositionCloseout** | [**MarketOrderPositionCloseout**](MarketOrderPositionCloseout.md) |  | [optional] 
**ShortPositionCloseout** | [**MarketOrderPositionCloseout**](MarketOrderPositionCloseout.md) |  | [optional] 
**MarginCloseout** | [**MarketOrderMarginCloseout**](MarketOrderMarginCloseout.md) |  | [optional] 
**DelayedTradeClose** | [**MarketOrderDelayedTradeClose**](MarketOrderDelayedTradeClose.md) |  | [optional] 
**Reason** | **MarketOrderReason** |  | [optional] 
**ClientExtensions** | [**ClientExtensions**](ClientExtensions.md) |  | [optional] 
**TakeProfitOnFill** | [**TakeProfitDetails**](TakeProfitDetails.md) |  | [optional] 
**StopLossOnFill** | [**StopLossDetails**](StopLossDetails.md) |  | [optional] 
**TrailingStopLossOnFill** | [**TrailingStopLossDetails**](TrailingStopLossDetails.md) |  | [optional] 
**TradeClientExtensions** | [**ClientExtensions**](ClientExtensions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

