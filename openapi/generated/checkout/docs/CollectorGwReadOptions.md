# Dintero.OpenApiClient.Checkout.Model.CollectorGwReadOptions
configuration options for the gateway. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableOnHold** | **bool** | Create the collector transaction with status &#x60;ON_HOLD&#x60; and let the Collector callback update the transaction state from &#x60;ON_HOLD&#x60; to &#x60;AUTHORIZED&#x60; or &#x60;FAILED&#x60;.  A callback will be sent to the &#x60;callback_url&#x60; when the transaction changes state from &#x60;ON_HOLD&#x60; to any new state.  | [optional] [default to false]
**SettlementReferenceFields** | **string** | The field(s) used to populate the settlement reference. The &#x60;store_id&#x60; in this context is &#x60;order.store.id&#x60; from session, not to be confused with a store_id from Collector stores.  | [optional] [default to SettlementReferenceFieldsEnum.Id]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

