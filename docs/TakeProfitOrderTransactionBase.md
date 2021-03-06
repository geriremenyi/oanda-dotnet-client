# GeriRemenyi.Oanda.V20.Client.Model.TakeProfitOrderTransactionBase
A TakeProfitOrder represents the creation of a TakeProfit Order.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TradeID** | **int** | The ID of the Trade to close when the price threshold is breached. | [optional] 
**ClientTradeID** | **string** | The client ID of the Trade to be closed when the price threshold is breached. | [optional] 
**Price** | **double** | The price threshold specified for the Stop Loss Order. If the guaranteed flag is false, the associated Trade will be closed by a market price that is equal to or worse than this threshold. If the flag is true the associated Trade will be closed at this price. | [optional] 
**TimeInForce** | **TradeOrderTimeInForce** |  | [optional] 
**GtdTime** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**TriggerCondition** | **TradeOrderTriggerCondition** |  | [optional] 
**Reason** | **TradeOrderTransactionReason** |  | [optional] 
**ClientExtensions** | [**ClientExtensions**](ClientExtensions.md) |  | [optional] 
**OrderFillTransactionID** | **int** | The ID of the OrderFill Transaction that caused this Order to be created (only provided if this Order was created automatically when another Order was filled). | [optional] 
**ReplacesOrderID** | **int** | The ID of the Order that this Order replaces (only provided if this Order replaces an existing Order). | [optional] 
**CancellingTransactionID** | **int** | The ID of the Transaction that cancels the replaced Order (only provided if this Order replaces an existing Order). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

