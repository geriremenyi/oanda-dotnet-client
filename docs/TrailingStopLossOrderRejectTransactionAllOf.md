# GeriRemenyi.Oanda.V20.Model.TrailingStopLossOrderRejectTransactionAllOf
A TrailingStopLossOrder represents the creation of a TrailingStopLoss Order in the user's Account.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TradeID** | **int** | The ID of the Trade to close when the price threshold is breached. | [optional] 
**ClientTradeID** | **string** | The client ID of the Trade to be closed when the price threshold is breached. | [optional] 
**Distance** | **double** | Specifies the distance (in price units) from the Account&#39;s current price to use as the Stop Loss Order price. If the Trade is short the Instrument&#39;s bid price is used, and for long Trades the ask is used. | [optional] 
**TimeInForce** | **string** | The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD. | [optional] 
**GtdTime** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**TriggerCondition** | **string** | Specification of which price component should be used when determining if an Order should be triggered and filled. This allows Orders to be triggered based on the bid, ask, mid, default (ask for buy, bid for sell) or inverse (ask for sell, bid for buy) price depending on the desired behaviour. Orders are always filled using their default price component. A special restriction applies when creating a guaranteed Stop Loss Order. In this case the TriggerCondition value must either be \&quot;DEFAULT\&quot;, or the \&quot;natural\&quot; trigger side \&quot;DEFAULT\&quot; results in. So for a Stop Loss Order for a long trade valid values are \&quot;DEFAULT\&quot; and \&quot;BID\&quot;, and for short trades \&quot;DEFAULT\&quot; and \&quot;ASK\&quot; are valid. | [optional] 
**Reason** | **string** | The reason that the Stop Loss Order was initiated | [optional] 
**ClientExtensions** | [**InlineResponse2005ChangesClientExtensions**](InlineResponse2005ChangesClientExtensions.md) |  | [optional] 
**OrderFillTransactionID** | **int** | The ID of the OrderFill Transaction that caused this Order to be created (only provided if this Order was created automatically when another Order was filled). | [optional] 
**ReplacesOrderID** | **int** | The ID of the Order that this Order replaces (only provided if this Order replaces an existing Order). | [optional] 
**CancellingTransactionID** | **int** | The ID of the Transaction that cancels the replaced Order (only provided if this Order replaces an existing Order). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

