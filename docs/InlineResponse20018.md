# GeriRemenyi.Oanda.V20.Model.InlineResponse20018
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**To** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**PageSize** | **int** | The pageSize provided in the request | [optional] 
**Type** | **List&lt;string&gt;** | The Transaction-type filter provided in the request | [optional] 
**Count** | **int** | The number of Transactions that are contained in the pages returned | [optional] 
**Pages** | **List&lt;string&gt;** | The list of URLs that represent idrange queries providing the data for each page in the query results | [optional] 
**LastTransactionID** | **int** | The ID of the most recent Transaction created for the Account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

