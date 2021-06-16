# Dintero.OpenApiClient.Checkout.Model.ShippingAddressCallbackSessionOrderUpdate
Updates to session order. If the amount and the sum of the items.amount are not  equal a correction item will be added to the items. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | The amount to authorize/capture including VAT and discounts. In smallest unit for the currency, e.g. cents  | 
**Currency** | **string** | The three-character ISO-4217 currency. https://en.wikipedia.org/wiki/ISO_4217 | [optional] 
**VatAmount** | **int** | The VAT of the &#x60;amount&#x60; parameter. Only used for display purposes.  In smallest unit for the currency, e.g. cents  | [optional] 
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | Details about the order items.  #### Instabank &#x60;required&#x60; if Instabank payment is configured in and partial_payment is false. All items must include a unique &#x60;line_id&#x60;, quantity and amount  #### Collector Bank &#x60;required&#x60; if Collector Bank payment is configured in and partial_payment is false. All items must include a unique &#x60;line_id&#x60;, quantity and amount  | [optional] 
**DiscountCodes** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

