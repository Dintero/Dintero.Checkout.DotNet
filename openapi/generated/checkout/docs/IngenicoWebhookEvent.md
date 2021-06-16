# Dintero.OpenApiClient.Checkout.Model.IngenicoWebhookEvent
Ingenico webhook event - see https://epayments.developer-ingenico.com/documentation/webhooks/

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiVersion** | **string** | The version of the REST API that is used for the structure of the object. | 
**Id** | **string** | The unique id of this event. You should use this id to verify that you did not already receive this event.  | 
**Created** | **string** | The date and time that the event occured in the yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ format  | 
**MerchantId** | **string** | The id of the merchant the event occurred on. | 
**Type** | **string** | One of the event names as listed on our webhooks event types page. Each type is of the following format: object.event, e.g. \&quot;payment.created\&quot; or \&quot;refund.captured\&quot;. See https://epayments.developer-ingenico.com/documentation/webhooks/event-types/  | 
**Payment** | [**IngenicoWebhookEventPayment**](IngenicoWebhookEventPayment.md) |  | [optional] 
**Refund** | [**IngenicoWebhookEventRefund**](IngenicoWebhookEventRefund.md) |  | [optional] 
**Payout** | [**IngenicoWebhookEventPayout**](IngenicoWebhookEventPayout.md) |  | [optional] 
**Token** | [**IngenicoWebhookEventToken**](IngenicoWebhookEventToken.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

