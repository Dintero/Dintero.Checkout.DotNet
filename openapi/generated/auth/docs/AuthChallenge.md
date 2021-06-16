# Dintero.OpenApiClient.Auth.Model.AuthChallenge
multi-factor authentication (MFA) challenge

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChallengeType** | **string** | The challenge type accepted by your application  | 
**OobChannel** | **string** | The channel to use for OOB. Can only be provided when &#x60;challenge_type&#x60; is oob.  | [optional] [default to OobChannelEnum.Sms]
**MfaToken** | **string** | The token received from &#x60;mfa_required&#x60; error.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

