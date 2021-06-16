# Dintero.OpenApiClient.Checkout.Model.DiscountCodesOrderUpdate
Order updated with discount given by discount_code. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiscountCodes** | **List&lt;string&gt;** |  | [optional] 
**Amount** | **decimal** | The amount to authorize/capture including VAT and discounts. In smallest unit for the currency, e.g. cents  | 
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | Items with discount lines.   - The list must include all items in the session order  - **Required** if the session order has any items.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

