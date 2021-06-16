# Dintero.OpenApiClient.Checkout.Model.OrderDiscountItem
Discount details for an order item

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EligibleForDiscount** | **bool** | The item is eligible for discount  | [optional] [default to false]
**IsChanged** | **bool** | Discount applied to amount  | [optional] 
**GrossAmount** | **decimal** | The origin item amount before any discount  | [optional] [readonly] 
**DiscountLines** | [**List&lt;DiscountItem&gt;**](DiscountItem.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

