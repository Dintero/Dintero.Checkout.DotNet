# Dintero.OpenApiClient.Auth.Model.PasswordLess

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Audience** | **string** | The unique identifier of the target API you want to access.  | 
**ClientId** | **string** |  | 
**Connection** | **string** | How to send the code to the user.  | 
**Email** | **string** | The user&#39;s email address  | [optional] 
**Type** | **string** | Passwordless for type company/customer requires that the email is registered to a customers users  | [optional] [default to TypeEnum.Customer]
**Send** | **string** | Use &#x60;code&#x60; to send a verification code.  | [optional] [default to SendEnum.Code]
**LoginSessionId** | **Guid** | Use &#x60;login_session_id&#x60; to resend the same verifcation code to an alternative connection.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

