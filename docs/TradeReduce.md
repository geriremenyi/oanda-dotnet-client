# GeriRemenyi.Oanda.V20.Client.Model.TradeReduce
A TradeReduce object represents a Trade for an instrument that was reduced (either partially or fully) in an Account. It is found embedded in Transactions that affect the position of an instrument in the account, specifically the OrderFill Transaction.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TradeID** | **int** | The ID of the Trade that was reduced or closed | [optional] 
**Units** | **double** | The number of units that the Trade was reduced by | [optional] 
**Price** | **double** | The average price that the units were closed at. This price may be clamped for guaranteed Stop Loss Orders. | [optional] 
**RealizedPL** | **double** | The PL realized when reducing the Trade | [optional] 
**Financing** | **double** | The financing paid/collected when reducing the Trade | [optional] 
**GuaranteedExecutionFee** | **double** | This is the fee that is charged for closing the Trade if it has a guaranteed Stop Loss Order attached to it. | [optional] 
**HalfSpreadCost** | **double** | The half spread cost for the trade reduce/close. This can be apositive or negative value and is represented in the home currency of the Account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

