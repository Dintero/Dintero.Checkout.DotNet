# Dintero.OpenApiClient.Auth.Model.AccessToken

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_AccessToken** | **string** | A JWT access token | 
**TokenType** | **string** |  | 
**ExpiresIn** | **int** | The lifetime in seconds of the access token.  For example, the value \&quot;3600\&quot; denotes that the access token will expire in one hour from the time the response was generated.  | 
**RefreshToken** | **string** | Token that can be used to request new tokens when the existing Access Token expire.  You can only get a Refresh Token if the Access Token used in the request has scope:   - &#x60;create:accounts:auth:refresh_token&#x60;  and the &#x60;grant-type&#x60; is one of:   - &#x60;authorization_code&#x60;  - &#x60;password&#x60;  **NOTE**:  - A Single-Page Application should not ever receive a Refresh Token,    this information is sensitive and should not be exposed client-side    in a browser.  - Refresh token must be stored securely by an application since    they allow a user to remain authenticated essentially forever.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

