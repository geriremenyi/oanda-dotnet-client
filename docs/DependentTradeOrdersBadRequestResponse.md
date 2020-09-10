# GeriRemenyi.Oanda.V20.Client.Model.DependentTradeOrdersBadRequestResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TakeProfitOrderCancelRejectTransaction** | [**OrderCancelRejectTransaction**](OrderCancelRejectTransaction.md) |  | [optional] 
**TakeProfitOrderRejectTransaction** | [**TakeProfitOrderRejectTransaction**](TakeProfitOrderRejectTransaction.md) |  | [optional] 
**StopLossOrderCancelRejectTransaction** | [**OrderCancelRejectTransaction**](OrderCancelRejectTransaction.md) |  | [optional] 
**StopLossOrderRejectTransaction** | [**StopLossOrderRejectTransaction**](StopLossOrderRejectTransaction.md) |  | [optional] 
**TrailingStopLossOrderCancelRejectTransaction** | [**OrderCancelRejectTransaction**](OrderCancelRejectTransaction.md) |  | [optional] 
**TrailingStopLossOrderRejectTransaction** | [**TrailingStopLossOrderRejectTransaction**](TrailingStopLossOrderRejectTransaction.md) |  | [optional] 
**ErrorCode** | **string** | The code of the error that has occurred. This field may not be returned for some errors. | [optional] 
**ErrorMessage** | **string** | The human-readable description of the error that has occurred. | [optional] 
**LastTransactionID** | **int** | The ID of the most recent Transaction created for the Account | [optional] 
**RelatedTransactionIDs** | **List&lt;int&gt;** | The IDs of all Transactions that were created while satisfying the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

