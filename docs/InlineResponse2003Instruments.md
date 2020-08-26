# GeriRemenyi.Oanda.V20.Model.InlineResponse2003Instruments
Full specification of an Instrument.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Instrument name identifier. Used by clients to refer to an Instrument. | [optional] 
**Type** | **string** | The type of the Instrument | [optional] 
**DisplayName** | **string** | The display name of the Instrument | [optional] 
**PipLocation** | **int** | The location of the \&quot;pip\&quot; for this instrument. The decimal position of the pip in this Instrument&#39;s price can be found at 10 ^ pipLocation (e.g. -4 pipLocation results in a decimal pip position of 10 ^ -4 &#x3D; 0.0001). | [optional] 
**DisplayPrecision** | **int** | The number of decimal places that should be used to display prices for this instrument. (e.g. a displayPrecision of 5 would result in a price of \&quot;1\&quot; being displayed as \&quot;1.00000\&quot;) | [optional] 
**TradeUnitsPrecision** | **int** | The amount of decimal places that may be provided when specifying the number of units traded for this instrument. | [optional] 
**MinimumTradeSize** | **double** | The smallest number of units allowed to be traded for this instrument. | [optional] 
**MaximumTrailingStopDistance** | **double** | The maximum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units. | [optional] 
**MinimumTrailingStopDistance** | **double** | The minimum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units. | [optional] 
**MaximumPositionSize** | **double** | The maximum position size allowed for this instrument. Specified in units. | [optional] 
**MaximumOrderUnits** | **double** | The maximum units allowed for an Order placed for this instrument. Specified in units. | [optional] 
**MarginRate** | **double** | The margin rate for this instrument. | [optional] 
**Commission** | [**InlineResponse2003Commission**](InlineResponse2003Commission.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

