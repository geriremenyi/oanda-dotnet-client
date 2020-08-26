# GeriRemenyi.Oanda.V20.Model.OrderBookBucket
The order book data for a partition of the instrument's prices.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Price** | **double** | The lowest price (inclusive) covered by the bucket. The bucket covers the price range from the price to price + the order book&#39;s bucketWidth. | [optional] 
**LongCountPercent** | **double** | The percentage of the total number of orders represented by the long orders found in this bucket. | [optional] 
**ShortCountPercent** | **double** | The percentage of the total number of orders represented by the short orders found in this bucket. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

