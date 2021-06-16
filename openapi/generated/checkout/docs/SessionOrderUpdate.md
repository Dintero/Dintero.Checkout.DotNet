# Dintero.OpenApiClient.Checkout.Model.SessionOrderUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | The amount to authorize/capture including VAT and discounts. In smallest unit for the currency, e.g. cents  | [optional] 
**Currency** | **string** | The three-character ISO-4217 currency. https://en.wikipedia.org/wiki/ISO_4217 | [optional] 
**VatAmount** | **int** | The VAT of the &#x60;amount&#x60; parameter. Only used for display purposes.  In smallest unit for the currency, e.g. cents  | [optional] 
**MerchantReference2** | **string** | A reference by the merchant to identify the corresponding order for the Checkout Session  | [optional] 
**ShippingAddress** | [**OrderAddress**](OrderAddress.md) |  | [optional] 
**BillingAddress** | [**OrderAddress**](OrderAddress.md) |  | [optional] 
**PartialPayment** | **bool** | This is a partial payment where the &#x60;order.amount&#x60; can be lower or equal to the sum of &#x60;order.items.amount&#x60;  | [optional] [default to false]
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | Details about the order items.  #### Instabank &#x60;required&#x60; if Instabank payment is configured in and partial_payment is false. All items must include a unique &#x60;line_id&#x60;, quantity and amount  #### Collector Bank &#x60;required&#x60; if Collector Bank payment is configured in and partial_payment is false. All items must include a unique &#x60;line_id&#x60;, quantity and amount  | [optional] 
**GrossAmount** | **decimal** | The origin amount to authorize/capture including VAT before any discount, only set if the session was updated when calculating discounts.  In smallest unit for the currency, e.g. cents  | [optional] [readonly] 
**IsChanged** | **bool** | The original order amount was changed by discount given.  | [optional] [readonly] 
**ShippingOption** | [**ShippingOption**](ShippingOption.md) |  | [optional] 
**Store** | [**Store**](Store.md) |  | [optional] 
**DiscountLines** | [**List&lt;DiscountItem&gt;**](DiscountItem.md) | Discounts given, additions to any items discount_lines.  | [optional] 
**DiscountCodes** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

