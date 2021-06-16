# Dintero.OpenApiClient.Checkout.Model.CheckoutConfigWriteConfigurationDetails
configuration details for the payment option 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableOnHold** | **bool** | Create the collector transaction with status &#x60;ON_HOLD&#x60; and let the Collector callback update the transaction state from &#x60;ON_HOLD&#x60; to &#x60;AUTHORIZED&#x60; or &#x60;FAILED&#x60;.  A callback will be sent to the &#x60;callback_url&#x60; when the transaction changes state from &#x60;ON_HOLD&#x60; to any new state.  This will override the gateway config &#x60;options.enable_on_hold&#x60;-setting.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

