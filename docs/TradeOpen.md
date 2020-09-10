# GeriRemenyi.Oanda.V20.Client.Model.TradeOpen
A TradeOpen object represents a Trade for an instrument that was opened in an Account. It is found embedded in Transactions that affect the position of an instrument in the Account, specifically the OrderFill Transaction.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TradeID** | **int** | The ID of the Trade that was opened | [optional] 
**Units** | **double** | The number of units opened by the Trade | [optional] 
**Price** | **double** | The average price that the units were opened at. | [optional] 
**GuaranteedExecutionFee** | **double** | This is the fee charged for opening the trade if it has a guaranteed Stop Loss Order attached to it. | [optional] 
**ClientExtensions** | [**ClientExtensions**](ClientExtensions.md) |  | [optional] 
**HalfSpreadCost** | **double** | The half spread cost for the trade open. This can be a positive or negative value and is represented in the home currency of the Account. | [optional] 
**InitialMarginRequired** | **double** | The margin required at the time the Trade was created. Note, this is the &#39;pure&#39; margin required, it is not the &#39;effective&#39; margin used that factors in the trade risk if a GSLO is attached to the trade. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

