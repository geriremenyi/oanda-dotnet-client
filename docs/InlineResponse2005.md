# GeriRemenyi.Oanda.V20.Model.InlineResponse2005
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Changes** | [**InlineResponse2005Changes**](InlineResponse2005Changes.md) |  | [optional] 
**State** | **Object** | An AccountChangesState Object is used to represent an Account&#39;s current price-dependent state. Price-dependent Account state is dependent on OANDA&#39;s current Prices, and includes things like unrealized PL, NAV and Trailing Stop Loss Order state. | [optional] 
**LastTransactionID** | **string** | The ID of the last Transaction created for the Account. This Transaction ID should be used for future poll requests, as the client has already observed all changes up to and including it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

