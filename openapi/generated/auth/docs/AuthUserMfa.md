# Dintero.OpenApiClient.Auth.Model.AuthUserMfa
Require Multi-factor authentication (MFA) for the user 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChallengeType** | **string** | The challenges types enabled (required) by the user.    enum: - oob  | 
**OobChannels** | **List&lt;string&gt;** | The supported channels to use for OOB. Can only be used if &#x60;channel_type&#x60; is &#x60;oob&#x60;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

