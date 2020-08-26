# GeriRemenyi.Oanda.V20.Model.AccountChangesStateAllOf
An AccountState Object is used to represent an Account's current price-dependent state. Price-dependent Account state is dependent on OANDA's current Prices, and includes things like unrealized PL, NAV and Trailing Stop Loss Order state.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

