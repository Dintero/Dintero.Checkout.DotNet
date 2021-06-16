# Dintero.OpenApiClient.Checkout.Model.InstabankInvoiceProduct

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductCode** | **string** |  | 
**DueInDays** | **int** | Number of days before the payment is due. | 
**MinimumAmount** | **int** | Minimum order amount for this product. The product option will be excluded in payments where the order amount is less than the minimum amount.  | [optional] 
**InvoiceFee** | **int** | The fee for the payment product  | 
**RequireApplicantAmount** | **int** | The limit for when instabank will require a full applicant during payment.  | 
**BrandingImageUrl** | **string** | Url for a custom branding image | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

