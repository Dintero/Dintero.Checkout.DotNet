# Dintero.OpenApiClient.Checkout.Model.CollectorInvoiceB2BPreapprovedPaymentAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShippingAddress** | [**CollectorB2BAddress**](CollectorB2BAddress.md) |  | 
**Scc** | **string** | Optional query parameter. SMS-confirm-code. To verify the identity of the payee. | [optional] 
**CompanyId** | **string** | Id to represent the company being paid from | 
**RememberMe** | **bool** | If true will either make the backend add or update a signed cookie with customer data. If false the cookie will be removed. If not set, any existing cookie will remain unchanged  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

