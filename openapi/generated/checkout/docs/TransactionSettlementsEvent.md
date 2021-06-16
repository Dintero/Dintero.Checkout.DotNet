# Dintero.OpenApiClient.Checkout.Model.TransactionSettlementsEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SettlementId** | **string** | Id of the settlement this was paid in  | 
**ProviderReference** | **string** | The providers reference for the settlement  | 
**EventCorrelationId** | **string** | Id for matching to transaction event  | [optional] 
**Amount** | **decimal** | The amount paid out in this settlement  | 
**Capture** | **decimal** | Amount captured in this settlement  | [optional] 
**Refund** | **decimal** | Amount refunded in this settlement  | [optional] 
**Fee** | **decimal** | Fee of the capture in this settlement  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

