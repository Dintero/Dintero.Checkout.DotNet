# Dintero.OpenApiClient.Auth.Model.AuthorizationCodeAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentType** | **string** |  | 
**Ident** | **string** | The email that was use when requesting &#x60;verification_code&#x60; from [POST /v1/accounts/{oid}/auth/passwordless](#operation/aid_auth_account_passwordless_post)  | 
**VerificationCode** | **string** | The one-time Passwordless verification-code to exchange for a access token | 
**Audience** | **string** | The unique identifier of the target API you want to access. The audience must be a grant associated with the client  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

