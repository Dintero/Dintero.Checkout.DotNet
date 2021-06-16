# Dintero.OpenApiClient.Checkout.Model.OrderItem
details about order item 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID or SKU of the product on the line  | [optional] 
**Groups** | [**List&lt;OrderItemGroups&gt;**](OrderItemGroups.md) | The groups the product on the line belongs to  | [optional] 
**LineId** | **string** | the number of the line (or id), must be &#x60;unique&#x60; between all items. &#x60;required&#x60; when Instabank payment is configured.  | [optional] 
**Version** | **decimal** | The version where the item was added or last updated, see the events for the source.  | [optional] [readonly] 
**Description** | **string** | A short, localized description of the line item  | [optional] 
**Quantity** | **decimal** | The quantity of the product in the item line.  | [optional] 
**Amount** | **int** | The total monetary amount of the line item  In smallest unit for the currency, e.g. cents  | [optional] 
**VatAmount** | **int** | The VAT of the &#x60;amount&#x60; parameter. Only used for display purposes.  In smallest unit for the currency, e.g. cents  | [optional] 
**Vat** | **decimal** | The VAT percentage  | [optional] 
**UnitVolume** | **decimal** | The volume of one item in m³ (cubic meters)  | [optional] 
**UnitWeight** | **decimal** | The volume of one item in kg (kilo grams)  | [optional] 
**UnitDimensionalWeight** | **decimal** | The dimensional weight (also known as volumetric) value unit of one item. [Dimensional weight at Wikipedia](https://en.wikipedia.org/wiki/Dimensional_weight)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

