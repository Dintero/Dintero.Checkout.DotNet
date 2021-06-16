# Dintero.OpenApiClient.Auth.Model.ExtendedAccount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | An UUID that uniquely identifies the resource  | [optional] [readonly] 
**CreatedAt** | **DateTime** | The date-time when the resource was created  | [optional] [readonly] 
**CreatedBy** | **string** | The ID of the user/client created the resource  | [optional] [readonly] 
**UpdatedAt** | **DateTime** | The date-time when the resource was last updated  | [optional] [readonly] 
**DeletedBy** | **string** | The ID of the user/client created the resource  | [optional] [readonly] 
**DeletedAt** | **DateTime** |  | [optional] [readonly] 
**Jwks** | [**AccountJwksJwks**](AccountJwksJwks.md) |  | [optional] 
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
**Progression** | **string** | Status assigned to the account by the account partner &gt; value is not visible for the merchant.  | [optional] 
**ResellerId** | **string** | Reseller id assigned by the account partner &gt; value is not visible for the merchant  | [optional] 
**AccountManager** | [**AccountPrivateDetailsAccountManager**](AccountPrivateDetailsAccountManager.md) |  | [optional] 
**Statistics** | [**AccountPrivateDetailsStatistics**](AccountPrivateDetailsStatistics.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

