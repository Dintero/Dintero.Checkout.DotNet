# Dintero.OpenApiClient.Auth.Api.AccountOnboardingApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsOidSignupPost**](AccountOnboardingApi.md#accountsoidsignuppost) | **POST** /accounts/{oid}/signup | Signup to Dintero Account
[**AccountsOidSignupVerifyPost**](AccountOnboardingApi.md#accountsoidsignupverifypost) | **POST** /accounts/{oid}/signup/verify | Verify signup


<a name="accountsoidsignuppost"></a>
# **AccountsOidSignupPost**
> void AccountsOidSignupPost (string oid, AccountSignupRequest data)

Signup to Dintero Account

Initiate a signup for Dintero Account  - An email verification request will be sent to the applicant,   that contains a code that must be sent to   [POST /account/{oid}/signup/verify](#operation/accounts_oid_signup_verify_post)  - A welcome email will be sent after verification of the applicant email   is completed. The email contains links to Backoffice  scopes: - create:account 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AccountsOidSignupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountOnboardingApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new AccountSignupRequest(); // AccountSignupRequest | 

            try
            {
                // Signup to Dintero Account
                apiInstance.AccountsOidSignupPost(oid, data);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountOnboardingApi.AccountsOidSignupPost: " + e.Message );
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
 **oid** | **string**| An id that uniquely identifies the account or owner (partner)  | 
 **data** | [**AccountSignupRequest**](AccountSignupRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsoidsignupverifypost"></a>
# **AccountsOidSignupVerifyPost**
> EmailAuthorizedUser AccountsOidSignupVerifyPost (string oid, string verificationCode, string authorize = null)

Verify signup

Complete the signup for a Dintero Account by sending the verification code sent to the applicant  scopes: - create:account 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AccountsOidSignupVerifyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountOnboardingApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var verificationCode = verificationCode_example;  // string | Verification code sent to the applicant email when requesting a signup [POST /accounts/{oid}/signup](#operation/accounts_oid_signup_post) 
            var authorize = authorize_example;  // string | Request access tokens to be included in the response.  (optional) 

            try
            {
                // Verify signup
                EmailAuthorizedUser result = apiInstance.AccountsOidSignupVerifyPost(oid, verificationCode, authorize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountOnboardingApi.AccountsOidSignupVerifyPost: " + e.Message );
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
 **oid** | **string**| An id that uniquely identifies the account or owner (partner)  | 
 **verificationCode** | **string**| Verification code sent to the applicant email when requesting a signup [POST /accounts/{oid}/signup](#operation/accounts_oid_signup_post)  | 
 **authorize** | **string**| Request access tokens to be included in the response.  | [optional] 

### Return type

[**EmailAuthorizedUser**](EmailAuthorizedUser.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Authorized |  -  |
| **202** | Accepted |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

