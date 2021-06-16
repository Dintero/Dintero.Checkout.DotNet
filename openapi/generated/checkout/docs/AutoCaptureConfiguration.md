# Dintero.OpenApiClient.Checkout.Model.AutoCaptureConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoCapture** | **bool** | If &#x60;true&#x60; the transaction from the payment session will be captured automatically after the transaction has been &#x60;AUTHORIZED&#x60;. The checkout sessions &#x60;callback_url&#x60; will not be called until after the transaction has been &#x60;CAPTURED&#x60;.  If &#x60;auto_capture&#x60; is not specified it defaults to &#x60;false&#x60;.  A successful auto-capture of a transaction sometimes requires more than one capture attempt. This can be the case if the payment gateway is down or is experiencing heavy traffic.  Dintero will attempts capture retries for 48 hours, the &#x60;callback_url&#x60; will be invoked when capture succeeds.  Manual capture of a transaction that is pending auto-capture will stop the auto-capture process from completing the capture.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

