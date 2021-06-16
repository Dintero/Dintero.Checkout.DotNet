# Dintero.OpenApiClient.Checkout.Model.InlineObject20

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | The amount to be captured | 
**CaptureReference** | **string** | A reference specified by the merchant to identify the transaction  | [optional] 
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | Info about the captured order items  #### Instabank &#x60;required&#x60; if the transaction &#x60;payment_product&#x60; is *instabank*. The capture will then be applied to the items included.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

