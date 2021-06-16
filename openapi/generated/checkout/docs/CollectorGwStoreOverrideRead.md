# Dintero.OpenApiClient.Checkout.Model.CollectorGwStoreOverrideRead
Override for sales location for Collector GW 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**Url** | **string** |  | 
**Username** | **string** | Merchant&#39;s username at Collector Bank | 
**StoreId** | **decimal** | Default store_id for gateway | 
**Country** | **string** | Default country for gateway | 
**Options** | [**CollectorGwReadOptions**](CollectorGwReadOptions.md) |  | [optional] 
**Stores** | [**List&lt;CollectorGwReadStores&gt;**](CollectorGwReadStores.md) | Configured stores in the Collector Partner Portal | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

