# GeriRemenyi.Oanda.V20.Client.Model.DynamicOrderState
The dynamic state of an Order. This is only relevant to TrailingStopLoss Orders, as no other Order type has dynamic state.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The Order&#39;s ID. | [optional] 
**TrailingStopValue** | **double** | The Order&#39;s calculated trailing stop value. | [optional] 
**TriggerDistance** | **double** | The distance between the Trailing Stop Loss Order&#39;s trailingStopValue and the current Market Price. This represents the distance (in price units) of the Order from a triggering price. If the distance could not be determined, this value will not be set. | [optional] 
**IsTriggerDistanceExact** | **bool** | True if an exact trigger distance could be calculated. If false, it means the provided trigger distance is a best estimate. If the distance could not be determined, this value will not be set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

