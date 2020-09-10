# GeriRemenyi.Oanda.V20.Client.Model.ClosePositionResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LongOrderCreateTransaction** | [**MarketOrderTransaction**](MarketOrderTransaction.md) |  | [optional] 
**LongOrderFillTransaction** | [**OrderFillTransaction**](OrderFillTransaction.md) |  | [optional] 
**LongOrderCancelTransaction** | [**OrderCancelTransaction**](OrderCancelTransaction.md) |  | [optional] 
**ShortOrderCreateTransaction** | [**MarketOrderTransaction**](MarketOrderTransaction.md) |  | [optional] 
**ShortOrderFillTransaction** | [**OrderFillTransaction**](OrderFillTransaction.md) |  | [optional] 
**ShortOrderCancelTransaction** | [**OrderCancelTransaction**](OrderCancelTransaction.md) |  | [optional] 
**LastTransactionID** | **int** | The ID of the most recent Transaction created for the Account | [optional] 
**RelatedTransactionIDs** | **List&lt;int&gt;** | The IDs of all Transactions that were created while satisfying the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

