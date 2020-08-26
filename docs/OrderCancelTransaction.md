# GeriRemenyi.Oanda.V20.Model.OrderCancelTransaction
An OrderCancelTransaction represents the cancellation of an Order in the client's Account.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The Transaction&#39;s Identifier. | [optional] 
**Time** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**UserID** | **int** | The ID of the user that initiated the creation of the Transaction. | [optional] 
**AccountID** | **string** | The Account&#39;s identifier | [optional] 
**BatchID** | **int** | The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously. | [optional] 
**RequestID** | **string** | The Request ID of the request which generated the transaction. | [optional] 
**Type** | **string** | The Type of the Transaction. | [optional] 
**OrderID** | **int** | The ID of the Order cancelled | [optional] 
**ClientOrderID** | **string** | The client ID of the Order cancelled (only provided if the Order has a client Order ID). | [optional] 
**Reason** | **string** | The reason that the Order was cancelled. | [optional] 
**ReplacedByOrderID** | **int** | The ID of the Order that replaced this Order (only provided if this Order was cancelled for replacement). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

