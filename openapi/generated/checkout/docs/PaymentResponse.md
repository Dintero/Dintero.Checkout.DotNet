# Dintero.OpenApiClient.Checkout.Model.PaymentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | the payment was accepted | 
**Actions** | [**List&lt;PaymentResponseActions&gt;**](PaymentResponseActions.md) |  | 
**RedirectUrl** | **string** | redirect url to complete payment, will not be included if the payment failed with &#x60;Rejected&#x60; error as payment can be completed by choosing alternative payment option.  | [optional] 
**PollUrl** | **Object** | poll_url to check the status of the payment. Will be included if the payment is dependent on 3rd party apps, such as Swish.  | [optional] 
**Error** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

