# GeriRemenyi.Oanda.V20.Client.Model.Account
The full details of a client's Account. This includes full open Trade, open Position and pending Order representation.
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
**UnrealizedPL** | **double** | The total unrealized profit/loss for all Trades currently open in the Account. | [optional] 
**NAV** | **double** | The net asset value of the Account. Equal to Account balance unrealizedPL. | [optional] 
**MarginUsed** | **double** | Margin currently used for the Account. | [optional] 
**MarginAvailable** | **double** | Margin available for Account currency. | [optional] 
**PositionValue** | **double** | The value of the Account&#39;s open positions represented in the Account&#39;s home currency. | [optional] 
**MarginCloseoutUnrealizedPL** | **double** | The Account&#39;s margin closeout unrealized PL. | [optional] 
**MarginCloseoutNAV** | **double** | The Account&#39;s margin closeout NAV. | [optional] 
**MarginCloseoutMarginUsed** | **double** | The Account&#39;s margin closeout margin used. | [optional] 
**MarginCloseoutPercent** | **double** | The Account&#39;s margin closeout percentage. When this value is 1.0 or above the Account is in a margin closeout situation. | [optional] 
**MarginCloseoutPositionValue** | **double** | The value of the Account&#39;s open positions as used for margin closeout calculations represented in the Account&#39;s home currency. | [optional] 
**WithdrawalLimit** | **double** | The current WithdrawalLimit for the account which will be zero or a positive value indicating how much can be withdrawn from the account. | [optional] 
**MarginCallMarginUsed** | **double** | The Account&#39;s margin call margin used. | [optional] 
**MarginCallPercent** | **double** | The Account&#39;s margin call percentage. When this value is 1.0 or above the Account is in a margin call situation. | [optional] 
**Trades** | [**List&lt;TradeSummary&gt;**](TradeSummary.md) | The details of the Trades currently open in the Account. | [optional] 
**Positions** | [**List&lt;Position&gt;**](Position.md) | The details all Account Positions. | [optional] 
**Orders** | [**List&lt;Order&gt;**](Order.md) | The details of the Orders currently pending in the Account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

