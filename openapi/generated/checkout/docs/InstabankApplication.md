# Dintero.OpenApiClient.Checkout.Model.InstabankApplication

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OwnsHouse** | **bool** | The consumer owns their house  | 
**MonthlyHouseRental** | **int** | Monthly housing cost in smallest unit for the currency. e.g. $1.5 &#x3D; 150 **Required** if &#x60;owns_house&#x60; is &#x60;false&#x60;  | [optional] 
**MaritalStatus** | **string** |  | 
**TotalIncome** | **int** | **Deprecated** in favour of the top-level &#x60;total_income&#x60;.  income received by person from all source in smallest unit for the currency. e.g. $1.5 &#x3D; 150.  | [optional] 
**MortgageDebt** | **int** | amount of money in smallest unit for the currency.  | [optional] 
**ConsumerDebt** | **int** | amount of money in smallest unit for the currency. (credit card, consumer finances)  | [optional] 
**StudentDebt** | **int** | amount of money in smallest unit for the currency.  | [optional] 
**OtherSecuredDebt** | **int** | amount of money in smallest unit for the currency. (car, boat, MC)  | [optional] 
**NumberOfChildren** | **int** | number of children below the age of 18 in the household  | 
**Debt** | [**List&lt;InstabankApplicationDebt&gt;**](InstabankApplicationDebt.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

