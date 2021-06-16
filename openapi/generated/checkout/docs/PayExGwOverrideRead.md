# Dintero.OpenApiClient.Checkout.Model.PayExGwOverrideRead
Override configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**CreatedBy** | **string** |  | [optional] [readonly] 
**Url** | **string** | The base URIs of the eCommerce APIs:  - **test**: https://api.externalintegration.payex.com - **prod**: https://api.payex.com  | [optional] 
**PayeeId** | **string** | Unique id that identifies the payee for the account (like merchant) set by PayEx.  | [optional] 
**Subsite** | **string** | The subsite field can be used to perform split settlements on payments. The subsites must be resolved with PayEx reconciliation before being used.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

