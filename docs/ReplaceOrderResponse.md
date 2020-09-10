# GeriRemenyi.Oanda.V20.Client.Model.ReplaceOrderResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderCancelTransaction** | [**OrderCancelTransaction**](OrderCancelTransaction.md) |  | [optional] 
**OrderCreateTransaction** | [**Transaction**](Transaction.md) |  | [optional] 
**OrderFillTransaction** | [**OrderFillTransaction**](OrderFillTransaction.md) |  | [optional] 
**OrderReissueTransaction** | [**Transaction**](Transaction.md) |  | [optional] 
**OrderReissueRejectTransaction** | [**Transaction**](Transaction.md) |  | [optional] 
**ReplacingOrderCancelTransaction** | [**OrderCancelTransaction**](OrderCancelTransaction.md) |  | [optional] 
**ErrorCode** | **string** | The code of the error that has occurred. This field may not be returned for some errors. | [optional] 
**ErrorMessage** | **string** | The human-readable description of the error that has occurred. | [optional] 
**LastTransactionID** | **int** | The ID of the most recent Transaction created for the Account | [optional] 
**RelatedTransactionIDs** | **List&lt;int&gt;** | The IDs of all Transactions that were created while satisfying the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

