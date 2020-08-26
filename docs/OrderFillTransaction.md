# GeriRemenyi.Oanda.V20.Model.OrderFillTransaction
An OrderFillTransaction represents the filling of an Order in the client's Account.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderID** | **int** | The ID of the Order filled. | [optional] 
**ClientOrderID** | **string** | The client Order ID of the Order filled (only provided if the client has assigned one). | [optional] 
**Instrument** | **string** | Instrument name identifier. Used by clients to refer to an Instrument. | [optional] 
**Units** | **double** | The number of units filled by the OrderFill. | [optional] 
**GainQuoteHomeConversionFactor** | **double** | This is the conversion factor in effect for the Account at the time of the OrderFill for converting any gains realized in Instrument quote units into units of the Account&#39;s home currency. | [optional] 
**LossQuoteHomeConversionFactor** | **double** | This is the conversion factor in effect for the Account at the time of the OrderFill for converting any losses realized in Instrument quote units into units of the Account&#39;s home currency. | [optional] 
**Price** | **double** | This field is now deprecated and should no longer be used. The individual tradesClosed, tradeReduced and tradeOpened fields contain the exact/official price each unit was filled at. | [optional] 
**FullVWAP** | **double** | The price that all of the units of the OrderFill should have been filled at, in the absence of guaranteed price execution. This factors in the Account&#39;s current ClientPrice, used liquidity and the units of the OrderFill only. If no Trades were closed with their price clamped for guaranteed stop loss enforcement, then this value will match the price fields of each Trade opened, closed, and reduced, and they will all be the exact same. | [optional] 
**FullPrice** | [**InlineResponse20021Prices**](InlineResponse20021Prices.md) |  | [optional] 
**Reason** | **string** | The reason that an Order was filled | [optional] 
**Pl** | **double** | The profit or loss incurred when the Order was filled. | [optional] 
**Financing** | **double** | The financing paid or collected when the Order was filled | [optional] 
**Commission** | **double** | The commission charged in the Account&#39;s home currency as a result of filling the Order. The commission is always represented as a positive quantity of the Account&#39;s home currency, however it reduces the balance in the Account. | [optional] 
**GuaranteedExecutionFee** | **double** | The total guaranteed execution fees charged for all Trades opened, closed or reduced with guaranteed Stop Loss Orders. | [optional] 
**AccountBalance** | **double** | The Account&#39;s balance after the Order was filled. | [optional] 
**TradeOpened** | [**OrderFillTransactionTradeOpened**](OrderFillTransactionTradeOpened.md) |  | [optional] 
**TradesClosed** | [**List&lt;OrderFillTransactionTradesClosed&gt;**](OrderFillTransactionTradesClosed.md) | The Trades that were closed when the Order was filled (only provided if filling the Order resulted in a closing open Trades). | [optional] 
**TradeReduced** | [**OrderFillTransactionTradesClosed**](OrderFillTransactionTradesClosed.md) |  | [optional] 
**HalfSpreadCost** | **double** | The half spread cost for the OrderFill, which is the sum of the halfSpreadCost values in the tradeOpened, tradesClosed and tradeReduced fields. This can be a positive or negative value and is represented in the home currency of the Account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

