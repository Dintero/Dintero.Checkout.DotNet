# Dintero.OpenApiClient.Checkout.Model.InstabankInstallmentPayment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | The email address of a person or an organisation  | 
**SocialSecurityNumber** | **string** | The social security number of the customer. Only supported for NO. | 
**PhoneNumber** | **string** | mobile number of a person / company, ITU/E.123 format with international prefix (+PPNNNNNNNNN...)  | 
**TotalIncome** | **int** | income received by person from all source in smallest unit for the currency. e.g. $1.5 &#x3D; 150. **Required**.  | 
**PaymentProductType** | **string** | The payment product type corresponding to this transaction  | 
**ProductCode** | **string** |  | 
**Applicant** | [**InstabankApplication**](InstabankApplication.md) |  | [optional] 
**RememberMe** | **bool** | If true will either make the backend add or update a signed cookie with customer data. If false the cookie will be removed. If not set, any existing cookie will remain unchanged  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

