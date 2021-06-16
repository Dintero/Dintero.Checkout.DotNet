# Dintero.OpenApiClient.Auth.Model.AccountAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applicant** | [**AccountApplicant**](AccountApplicant.md) | The individual completing the account registration | 
**Company** | [**AccountCompany**](AccountCompany.md) |  | 
**Billing** | [**AccountBilling**](AccountBilling.md) |  | 
**Subscription** | [**Subscription**](Subscription.md) |  | [optional] 
**AccountId** | **string** | The id that uniquely identifies the account. | [optional] [readonly] 
**PartnerId** | **string** | The id of the partner associated with the account | [optional] [readonly] 
**Livemode** | **bool** | Flag indicating whether the account exists in live mode and test mode.  | [optional] [default to false]
**Active** | **bool** | The account is active | [optional] [readonly] [default to false]
**LanguageCode** | **string** | The preferred language for the account as defined by &lt;a href&#x3D;\&quot;https://tools.ietf.org/html/bcp47\&quot;&gt;BCP 47&lt;/a&gt; (IETF BCP 47, \&quot;Tags for Identifying Languages\&quot;).  | [optional] 
**Connections** | [**AccountAllOfConnections**](AccountAllOfConnections.md) |  | [optional] 
**Services** | [**AccountAllOfServices**](AccountAllOfServices.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

