# Dintero.OpenApiClient.Checkout.Model.PaymentConfigurationAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Channel** | **string** | ### in_app  The &#x60;in_app&#x60; channel is intended for payments done from mobile devices where &#x60;url.return_url&#x60; can be set to the application&#39;s appswitch URL.  #### Session deeplink URL  The session URL will be an appswitch deeplink URL to the payment application if the session enables a single payment option that supports appswitch deeplink payments (Vipps)  &gt; &#x60;in_app&#x60; is currently not supported when express is enabled  &gt; &#x60;in_app&#x60; with deeplink URL is not supported if &#x60;publish&#x60; is enabled  ### in_store  The &#x60;in_store&#x60; channel is intended for payments done in physical stores.  Depending on the payment_type, choosing &#x60;in_store&#x60; will change the behaviour of the payment.  | [optional] 
**Publish** | **List&lt;Object&gt;** | Publish checkout message to the customer.  | [optional] 
**DefaultPaymentType** | **string** | Configure the default payment type, the selected payment when loading the checkout window. The value must be an enabled payment type.  | [optional] 
**Bambora** | [**BamboraConfiguration**](BamboraConfiguration.md) |  | [optional] 
**Ingenico** | [**IngenicoConfiguration**](IngenicoConfiguration.md) |  | [optional] 
**Instabank** | [**InstabankConfiguration**](InstabankConfiguration.md) |  | [optional] 
**Netaxept** | [**NetaxeptConfiguration**](NetaxeptConfiguration.md) |  | [optional] 
**Payex** | [**PayExConfiguration**](PayExConfiguration.md) |  | [optional] 
**Vipps** | [**VippsConfiguration**](VippsConfiguration.md) |  | [optional] 
**Collector** | [**CollectorConfiguration**](CollectorConfiguration.md) |  | [optional] 
**Santander** | [**SantanderConfiguration**](SantanderConfiguration.md) |  | [optional] 
**Swish** | [**SwishConfiguration**](SwishConfiguration.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

