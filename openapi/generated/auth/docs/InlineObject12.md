# Dintero.OpenApiClient.Auth.Model.InlineObject12

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** |  | 
**Name** | **string** |  | [optional] 
**Scope** | **List&lt;string&gt;** |  | [optional] 
**AuthenticationType** | **string** | - &#x60;external&#x60;: authentication of the user will be done   externally, Dintero will not manage user password. Requires   the account to be configured with &#x60;jwks.uri&#x60;.  | [optional] 
**Roles** | [**List&lt;AccountsOidManagementUsersRoles&gt;**](AccountsOidManagementUsersRoles.md) | Create user with one or more roles. The authorization used to create the user must have access to use the role, i.e. have the same scopes as granted by the role.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

