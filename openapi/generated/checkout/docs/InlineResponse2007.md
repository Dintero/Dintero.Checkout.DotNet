# Dintero.OpenApiClient.Checkout.Model.InlineResponse2007

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShippingOptions** | [**List&lt;ShippingOption&gt;**](ShippingOption.md) | Shipping options that will be presented to the end user after the callback  - If the merchant is not able to ship the order to the end users   shipping address, use an empty array. - If there is only one option, a free delivery, the order still   has to contain one option with a _&#x60;price.amount&#x60;_ of 0.  | 
**Order** | [**ShippingAddressCallbackSessionOrderUpdate**](ShippingAddressCallbackSessionOrderUpdate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

