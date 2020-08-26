# GeriRemenyi.Oanda.V20.Model.AccountChanges
An AccountChanges Object is used to represent the changes to an Account's Orders, Trades and Positions since a specified Account TransactionID in the past.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrdersCreated** | [**List&lt;InlineResponse2005ChangesOrdersCreated&gt;**](InlineResponse2005ChangesOrdersCreated.md) | The Orders created. These Orders may have been filled, cancelled or triggered in the same period. | [optional] 
**OrdersCancelled** | [**List&lt;InlineResponse2005ChangesOrdersCreated&gt;**](InlineResponse2005ChangesOrdersCreated.md) | The Orders cancelled. | [optional] 
**OrdersFilled** | [**List&lt;InlineResponse2005ChangesOrdersCreated&gt;**](InlineResponse2005ChangesOrdersCreated.md) | The Orders filled. | [optional] 
**OrdersTriggered** | [**List&lt;InlineResponse2005ChangesOrdersCreated&gt;**](InlineResponse2005ChangesOrdersCreated.md) | The Orders triggered. | [optional] 
**TradesOpened** | [**List&lt;InlineResponse2005ChangesTradesOpened&gt;**](InlineResponse2005ChangesTradesOpened.md) | The Trades opened. | [optional] 
**TradesReduced** | [**List&lt;InlineResponse2005ChangesTradesOpened&gt;**](InlineResponse2005ChangesTradesOpened.md) | The Trades reduced. | [optional] 
**TradesClosed** | [**List&lt;InlineResponse2005ChangesTradesOpened&gt;**](InlineResponse2005ChangesTradesOpened.md) | The Trades closed. | [optional] 
**Positions** | [**List&lt;InlineResponse2005ChangesPositions&gt;**](InlineResponse2005ChangesPositions.md) | The Positions changed. | [optional] 
**Transactions** | [**List&lt;InlineResponse2005ChangesTransactions&gt;**](InlineResponse2005ChangesTransactions.md) | The Transactions that have been generated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

