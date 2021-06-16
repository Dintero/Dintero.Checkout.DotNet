# Dintero.OpenApiClient.Checkout.Model.PayExConfigurationCreditcard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | enable Credit Card Payment | 
**Payability** | **SessionPayability** |  | [optional] 
**GeneratePaymentToken** | **bool** | generate payment token to use for future payments  The generated payment token will be made available from the transaction details.  | [optional] [default to false]
**NoCvc** | **bool** | Disable the CVC field for payments where payment token is used. &gt; To use this feature it has to be enabled on the contract with Swedbank Pay.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

