# Dintero.OpenApiClient.Checkout.Model.CollectorInstallmentPayment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SocialSecurityNumber** | **string** | The social security number of the customer. For Norway, the length is 11. For Sweden, it&#39;s either 10 or 12 digits.  | 
**PaymentProductType** | **string** | The payment product type corresponding to this transaction  | 
**Product** | [**CollectorInstallmentB2BPreapprovedPaymentAllOfProduct**](CollectorInstallmentB2BPreapprovedPaymentAllOfProduct.md) |  | 
**ShippingAddress** | [**CollectorAddress**](CollectorAddress.md) |  | 
**BillingAddress** | [**CollectorAddress**](CollectorAddress.md) |  | 
**RememberMe** | **bool** | If true will either make the backend add or update a signed cookie with customer data. If false the cookie will be removed. If not set, any existing cookie will remain unchanged  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

