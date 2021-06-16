# Dintero.OpenApiClient.Auth.Model.AuthUser
An user with password

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | An UUID that uniquely identifies the resource  | [optional] [readonly] 
**CreatedAt** | **DateTime** | The date-time when the resource was created  | [optional] [readonly] 
**CreatedBy** | **string** | The ID of the user/client created the resource  | [optional] [readonly] 
**UpdatedAt** | **DateTime** | The date-time when the resource was last updated  | [optional] [readonly] 
**DeletedBy** | **string** | The ID of the user/client created the resource  | [optional] [readonly] 
**DeletedAt** | **DateTime** |  | [optional] [readonly] 
**Username** | **string** | The user&#39;s username. | 
**Links** | **List&lt;Object&gt;** | Links to resources related to the user, links is required when MFA is enabled.  | [optional] 
**Mfa** | [**AuthUserMfa**](AuthUserMfa.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

