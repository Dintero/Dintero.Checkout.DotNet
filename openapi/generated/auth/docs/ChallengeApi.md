# Dintero.OpenApiClient.Auth.Api.ChallengeApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAuthMfaChallengePost**](ChallengeApi.md#aidauthmfachallengepost) | **POST** /accounts/{aid}/auth/mfa/challenge | Challenge request
[**AidAuthMfaRecoveryPost**](ChallengeApi.md#aidauthmfarecoverypost) | **POST** /accounts/{aid}/auth/mfa/recovery | Recovery


<a name="aidauthmfachallengepost"></a>
# **AidAuthMfaChallengePost**
> InlineResponse200 AidAuthMfaChallengePost (string aid, AuthChallenge data)

Challenge request

Request a challenge for multi-factor authentication (MFA) based on the challenge types supported by the user.  The challenge_type is how the user will get the challenge and prove possession. Supported challenge types include:    - `oob`: for SMS messages or out-of-band (OOB)  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with `grant_type=mfa_oob`  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthMfaChallengePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChallengeApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new AuthChallenge(); // AuthChallenge | 

            try
            {
                // Challenge request
                InlineResponse200 result = apiInstance.AidAuthMfaChallengePost(aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChallengeApi.AidAuthMfaChallengePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aid** | **string**| An id that uniquely identifies the account.  | 
 **data** | [**AuthChallenge**](AuthChallenge.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | challenge |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthmfarecoverypost"></a>
# **AidAuthMfaRecoveryPost**
> InlineResponse2001 AidAuthMfaRecoveryPost (string aid, UNKNOWN_BASE_TYPE data)

Recovery

Request a recovery for user with multi-factor authentication (MFA) enabled.  A recovery is done with two out-of-band (OOB) challenges over different channels.  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with `grant_type=mfa_oob`.  A `403 status` with `mfa_required` error will be returned on success, use the response to request a new challenge from the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthMfaRecoveryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChallengeApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Recovery
                InlineResponse2001 result = apiInstance.AidAuthMfaRecoveryPost(aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChallengeApi.AidAuthMfaRecoveryPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aid** | **string**| An id that uniquely identifies the account.  | 
 **data** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | challenge |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

