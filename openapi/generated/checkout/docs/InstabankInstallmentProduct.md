# Dintero.OpenApiClient.Checkout.Model.InstabankInstallmentProduct
Payment product configuration 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MinimumAmount** | **int** | Minimum order amount for this product. The product option will be excluded in payments where the order amount is less than the minimum amount.  | [optional] 
**ProductCode** | **string** |  | 
**CreditTime** | **int** | Number of months  | 
**OriginationFee** | **int** | The startup fee for the payment product  | 
**NotificationFee** | **int** | The notification fee for the payment product  | 
**AnnualInterestRate** | **string** | The interest rate for the payment product.  | 
**EffectiveAnnualInterestRate** | **string** | The effective annual interest rate for the payment product  | [optional] [readonly] 
**TotalAmount** | **int** | The total amount to pay | [optional] [readonly] 
**MonthlyAmount** | **int** | The amount to pay pr month | [optional] [readonly] 
**FirstMonthlyAmount** | **int** | The amount to pay in the first invoice. Origantion fee is added to the first invoice.  | [optional] [readonly] 
**RequireApplicantAmount** | **int** | The limit for when instabank will require a full applicant during payment.  | [optional] 
**LoanExample** | [**InstabankFinanceProductLoanExample**](InstabankFinanceProductLoanExample.md) |  | [optional] 
**BrandingImageUrl** | **string** | Url for a custom branding image | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

