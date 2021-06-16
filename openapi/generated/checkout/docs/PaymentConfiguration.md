# Dintero.OpenApiClient.Checkout.Model.PaymentConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoCapture** | **bool** | If &#x60;true&#x60; the transaction from the payment session will be captured automatically after the transaction has been &#x60;AUTHORIZED&#x60;. The checkout sessions &#x60;callback_url&#x60; will not be called until after the transaction has been &#x60;CAPTURED&#x60;.  If &#x60;auto_capture&#x60; is not specified it defaults to &#x60;false&#x60;.  A successful auto-capture of a transaction sometimes requires more than one capture attempt. This can be the case if the payment gateway is down or is experiencing heavy traffic.  Dintero will attempts capture retries for 48 hours, the &#x60;callback_url&#x60; will be invoked when capture succeeds.  Manual capture of a transaction that is pending auto-capture will stop the auto-capture process from completing the capture.  | [optional] 
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

