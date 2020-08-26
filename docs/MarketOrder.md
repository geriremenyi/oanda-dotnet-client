# GeriRemenyi.Oanda.V20.Model.MarketOrder
A MarketOrder represents the creation of a Market Order in the user's account. A Market Order is an Order that is filled immediately at the current market price.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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

