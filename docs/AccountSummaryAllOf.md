# GeriRemenyi.Oanda.V20.Client.Model.AccountSummaryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The Account&#39;s identifier | [optional] 
**Alias** | **string** | Client-assigned alias for the Account. Only provided if the Account has an alias set | [optional] 
**Currency** | **AccountCurrency** |  | [optional] 
**Balance** | **double** | The current balance of the Account. | [optional] 
**CreatedByUserID** | **int** | ID of the user that created the Account. | [optional] 
**CreatedTime** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**GuaranteedStopLossOrderMode** | **AccountGuaranteedStopLossOrderMode** |  | [optional] 
**Pl** | **double** | The total profit/loss realized over the lifetime of the Account. | [optional] 
**ResettablePL** | **double** | The total realized profit/loss for the Account since it was last reset by the client. | [optional] 
**ResettablePLTime** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**Financing** | **double** | The total amount of financing paid/collected over the lifetime of the Account. | [optional] 
**Commission** | **double** | The total amount of commission paid over the lifetime of the Account. | [optional] 
**GuaranteedExecutionFees** | **double** | The total amount of fees charged over the lifetime of the Account for the execution of guaranteed Stop Loss Orders. | [optional] 
**MarginRate** | **double** | Client-provided margin rate override for the Account. The effective margin rate of the Account is the lesser of this value and the OANDA margin rate for the Account&#39;s division. This value is only provided if a margin rate override exists for the Account. | [optional] 
**MarginCallEnterTime** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**MarginCallExtensionCount** | **int** | The number of times that the Account&#39;s current margin call was extended. | [optional] 
**LastMarginCallExtensionTime** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**OpenTradeCount** | **int** | The number of Trades currently open in the Account. | [optional] 
**OpenPositionCount** | **int** | The number of Positions currently open in the Account. | [optional] 
**PendingOrderCount** | **int** | The number of Orders currently pending in the Account. | [optional] 
**HedgingEnabled** | **bool** | Flag indicating that the Account has hedging enabled. | [optional] 
**LastOrderFillTimestamp** | **string** | A date and time value using either RFC3339 or UNIX time representation. The RFC 3339 representation is a string conforming to https://tools.ietf.org/rfc/rfc3339.txt. The Unix representation is a string representing the number of seconds since the Unix Epoch (January 1st, 1970 at UTC). The value is a fractional number, where the fractional part represents a fraction of a second (up to nine decimal places). | [optional] 
**LastTransactionId** | **int** | The ID of the last Transaction created for the Account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

