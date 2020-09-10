# GeriRemenyi.Oanda.V20.Client.Model.MarketOrder
A MarketOrder represents the creation of a Market Order in the user's account. A Market Order is an Order that is filled immediately at the current market price.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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

