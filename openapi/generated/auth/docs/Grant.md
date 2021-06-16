# Dintero.OpenApiClient.Auth.Model.Grant

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | An UUID that uniquely identifies the resource  | [optional] [readonly] 
**CreatedAt** | **DateTime** | The date-time when the resource was created  | [optional] [readonly] 
**CreatedBy** | **string** | The ID of the user/client created the resource  | [optional] [readonly] 
**UpdatedAt** | **DateTime** | The date-time when the resource was last updated  | [optional] [readonly] 
**DeletedBy** | **string** | The ID of the user/client created the resource  | [optional] [readonly] 
**DeletedAt** | **DateTime** |  | [optional] [readonly] 
**ClientId** | **string** |  | 
**Audience** | **string** |  | 
**Scope** | **List&lt;string&gt;** |  | 
**Type** | **string** | Limit the usage of the grant. A grant with grant_types set to only &#x60;authorization_code&#x60; cannot be used in [Get Token](#operation/aid_auths_oauth_token_post) when calling the endpoint with &#x60;grant_type&#x3D;client_credentials&#x60;  | [optional] [default to TypeEnum.Any]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

