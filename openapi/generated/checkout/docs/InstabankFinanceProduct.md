# Dintero.OpenApiClient.Checkout.Model.InstabankFinanceProduct

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductCode** | **string** |  | 
**MinimumMonthlyBalanceRate** | **string** | The minimum monthly installment basis as a percentage of the account balance.  | 
**AnnualInterestRate** | **string** | The interest rate for the payment product.  | [optional] 
**EffectiveAnnualInterestRate** | **string** | The effective annual interest rate for the payment product  | [optional] [readonly] 
**OriginationFee** | **int** | The startup fee for the payment product.  | 
**NotificationFee** | **int** | The notification fee for the payment product.  | 
**MinimumAmount** | **int** | Minimum order amount for this product. The product option will be excluded in payments where the order amount is less than the minimum amount.  | [optional] 
**LoanExample** | [**InstabankFinanceProductLoanExample**](InstabankFinanceProductLoanExample.md) |  | 
**BrandingImageUrl** | **string** | Url for a custom branding image | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

