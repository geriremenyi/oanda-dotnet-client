# GeriRemenyi.Oanda.V20.Client.Model.HomeConversions
HomeConversions represents the factors to use to convert quantities of a given currency into the Account's home currency. The conversion factor depends on the scenario the conversion is required for.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | The currency to be converted into the home currency. A string containing an ISO 4217 currency (http://en.wikipedia.org/wiki/ISO_4217) | [optional] 
**AccountGain** | **double** | The factor used to convert any gains for an Account in the specified currency into the Account&#39;s home currency. This would include positive realized P/L and positive financing amounts. Conversion is performed by multiplying the positive P/L by the conversion factor. | [optional] 
**AccountLoss** | **double** | The string representation of a decimal number. | [optional] 
**PositionValue** | **double** | The factor used to convert a Position or Trade Value in the specified currency into the Account&#39;s home currency. Conversion is performed by multiplying the Position or Trade Value by the conversion factor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

