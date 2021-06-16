# Dintero.OpenApiClient.Checkout.Model.SessionExpressExpress
### Present only for _Express Checkout_ sessions.  An _Express Checkout_ session is a session where the end user will submit a shipping address and then select a shipping option before the before a payment method is selected and the payment is initiated.  Endpoints used in the _Express Checkout_ flow. 1. [Set shipping address](/#operation/checkout_sid_json_order_shipping_address_put) 2. [Set shipping option](/#operation/checkout_sid_json_order_items_shipping_option_put) 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiscountCodes** | [**SessionExpressExpressDiscountCodes**](SessionExpressExpressDiscountCodes.md) |  | [optional] 
**ShippingAddressCallbackUrl** | **string** | URL that Checkout will POST to when the end user has submitted/changed a shipping address for an express-session.  Dintero will not attempt a retry after a failed delivery attempt. Following situations is considered as failed delivery  - HTTP status codes that are not 200. - A request timeout (60 seconds) - Any connection error such as connection timeout, bad certificate, etc  The response from the callback will be used to update the shipping options.  See [POST example/shipping_address_callback_url](#operation/example_shipping_address_callback_url) for details about the request and response.  | [optional] 
**ShippingOptions** | [**List&lt;ShippingOption&gt;**](ShippingOption.md) | Shipping options that will be presented to the end user after the end user has submitted a shipping address.  To dynamically update the shipping_options when the _&#x60;order.shipping_address&#x60;_ is changed by the end user in the checkout, use the _&#x60;url.shipping_address_callback_url&#x60;_.   If the merchant is not able to ship the order to the end users shipping address, use an empty array.   If there is only one option, a free delivery, the order still has to contain one option with a _&#x60;price.amount&#x60;_ of 0.  | 
**CustomerTypes** | **List&lt;string&gt;** | Limit the lind of customers that can be submitted via the address form in the express checkout.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

