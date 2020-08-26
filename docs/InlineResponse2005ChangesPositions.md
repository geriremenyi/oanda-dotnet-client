# GeriRemenyi.Oanda.V20.Model.InlineResponse2005ChangesPositions
The specification of a Position within an Account.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Instrument** | **string** | Instrument name identifier. Used by clients to refer to an Instrument. | [optional] 
**Pl** | **double** | Profit/loss realized by the Position over the lifetime of the Account. | [optional] 
**UnrealizedPL** | **double** | The unrealized profit/loss of all open Trades that contribute to this Position. | [optional] 
**MarginUsed** | **double** | Margin currently used by the Position. | [optional] 
**ResettablePL** | **double** | Profit/loss realized by the Position since the Account&#39;s resettablePL was last reset by the client. | [optional] 
**Financing** | **double** | The total amount of financing paid/collected for this instrument over the lifetime of the Account. | [optional] 
**Commission** | **double** | The total amount of commission paid for this instrument over the lifetime of the Account. | [optional] 
**GuaranteedExecutionFees** | **double** | The total amount of fees charged over the lifetime of the Account for the execution of guaranteed Stop Loss Orders for this instrument. | [optional] 
**Long** | [**InlineResponse2005ChangesLong**](InlineResponse2005ChangesLong.md) |  | [optional] 
**Short** | [**InlineResponse2005ChangesLong**](InlineResponse2005ChangesLong.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

