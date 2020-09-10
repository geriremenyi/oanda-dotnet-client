# GeriRemenyi.Oanda.V20.Client.Model.DependentTradeOrdersResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TakeProfitOrderCancelTransaction** | [**OrderCancelTransaction**](OrderCancelTransaction.md) |  | [optional] 
**TakeProfitOrderTransaction** | [**TakeProfitOrderTransaction**](TakeProfitOrderTransaction.md) |  | [optional] 
**TakeProfitOrderFillTransaction** | [**OrderFillTransaction**](OrderFillTransaction.md) |  | [optional] 
**TakeProfitOrderCreatedCancelTransaction** | [**OrderCancelTransaction**](OrderCancelTransaction.md) |  | [optional] 
**StopLossOrderCancelTransaction** | [**OrderCancelTransaction**](OrderCancelTransaction.md) |  | [optional] 
**StopLossOrderTransaction** | [**StopLossOrderTransaction**](StopLossOrderTransaction.md) |  | [optional] 
**StopLossOrderFillTransaction** | [**OrderFillTransaction**](OrderFillTransaction.md) |  | [optional] 
**StopLossOrderCreatedCancelTransaction** | [**OrderCancelTransaction**](OrderCancelTransaction.md) |  | [optional] 
**TrailingStopLossOrderCancelTransaction** | [**OrderCancelTransaction**](OrderCancelTransaction.md) |  | [optional] 
**TrailingStopLossOrderTransaction** | [**TrailingStopLossOrderTransaction**](TrailingStopLossOrderTransaction.md) |  | [optional] 
**LastTransactionID** | **int** | The ID of the most recent Transaction created for the Account | [optional] 
**RelatedTransactionIDs** | **List&lt;int&gt;** | The IDs of all Transactions that were created while satisfying the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

