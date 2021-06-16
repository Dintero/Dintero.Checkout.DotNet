# Dintero.OpenApiClient.Auth.Model.GrantAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** |  | 
**Audience** | **string** |  | 
**Scope** | **List&lt;string&gt;** |  | 
**Type** | **string** | Limit the usage of the grant. A grant with grant_types set to only &#x60;authorization_code&#x60; cannot be used in [Get Token](#operation/aid_auths_oauth_token_post) when calling the endpoint with &#x60;grant_type&#x3D;client_credentials&#x60;  | [optional] [default to TypeEnum.Any]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

