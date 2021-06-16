# Dintero.OpenApiClient.Auth.Model.EmailAuthorizedUser

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | Account ID for the account created from completing the signup  | [optional] 
**AccessToken** | **string** | Applicant user access token with &#x60;openid&#x60; scope  | [optional] 
**ExpiresIn** | **int** | The lifetime in seconds of the access token.  | [optional] 
**TokenType** | **string** |  | [optional] 
**RefreshToken** | **string** |  | [optional] 
**Email** | **string** | The email for the user that verified the account  | [optional] 
**PreviousPasswordToken** | **string** | A token that can be used as &#x60;previous_password&#x60;value when changing the password for the user via [PUT /v1/accounts/{aid}/account/user/password](#operation/account_user_password_put). Only included in the response if the signup created a new account user.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

