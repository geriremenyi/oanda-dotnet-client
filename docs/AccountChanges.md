# GeriRemenyi.Oanda.V20.Client.Model.AccountChanges
An AccountChanges Object is used to represent the changes to an Account's Orders, Trades and Positions since a specified Account TransactionID in the past.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrdersCreated** | [**List&lt;Order&gt;**](Order.md) | The Orders created. These Orders may have been filled, cancelled or triggered in the same period. | [optional] 
**OrdersCancelled** | [**List&lt;Order&gt;**](Order.md) | The Orders cancelled. | [optional] 
**OrdersFilled** | [**List&lt;Order&gt;**](Order.md) | The Orders filled. | [optional] 
**OrdersTriggered** | [**List&lt;Order&gt;**](Order.md) | The Orders triggered. | [optional] 
**TradesOpened** | [**List&lt;TradeSummary&gt;**](TradeSummary.md) | The Trades opened. | [optional] 
**TradesReduced** | [**List&lt;TradeSummary&gt;**](TradeSummary.md) | The Trades reduced. | [optional] 
**TradesClosed** | [**List&lt;TradeSummary&gt;**](TradeSummary.md) | The Trades closed. | [optional] 
**Positions** | [**List&lt;Position&gt;**](Position.md) | The Positions changed. | [optional] 
**Transactions** | [**List&lt;Transaction&gt;**](Transaction.md) | The Transactions that have been generated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

