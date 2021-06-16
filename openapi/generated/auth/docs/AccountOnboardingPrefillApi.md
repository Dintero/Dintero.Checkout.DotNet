# Dintero.OpenApiClient.Auth.Api.AccountOnboardingPrefillApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsOidSignupPrefillAcceptPost**](AccountOnboardingPrefillApi.md#accountsoidsignupprefillacceptpost) | **POST** /accounts/{oid}/signup/prefill/{prefill_id} | Accept pre-filled sign up for a new Dintero Account
[**AccountsOidSignupPrefillGet**](AccountOnboardingPrefillApi.md#accountsoidsignupprefillget) | **GET** /accounts/{oid}/signup/prefill/{prefill_id} | Get pending pre-filled sign up for a new Dintero Account
[**AccountsOidSignupPrefillPost**](AccountOnboardingPrefillApi.md#accountsoidsignupprefillpost) | **POST** /accounts/{oid}/signup/prefill | Pre-fill a sign up for a new Dintero Account


<a name="accountsoidsignupprefillacceptpost"></a>
# **AccountsOidSignupPrefillAcceptPost**
> InlineResponse2007 AccountsOidSignupPrefillAcceptPost (string oid, string prefillId, AccountSignupPreFillRequest data, string authorize = null)

Accept pre-filled sign up for a new Dintero Account

Accept a prefilled a sign up form for a new Dintero Account  - An email will be sent after accepting the terms if no auhtorize query is included.   The email contains a link to the Backoffice as well as a password  scopes: - create:account 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AccountsOidSignupPrefillAcceptPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountOnboardingPrefillApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var prefillId = prefillId_example;  // string | 
            var data = new AccountSignupPreFillRequest(); // AccountSignupPreFillRequest | 
            var authorize = authorize_example;  // string | Request access tokens to be included in the response.  (optional) 

            try
            {
                // Accept pre-filled sign up for a new Dintero Account
                InlineResponse2007 result = apiInstance.AccountsOidSignupPrefillAcceptPost(oid, prefillId, data, authorize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountOnboardingPrefillApi.AccountsOidSignupPrefillAcceptPost: " + e.Message );
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
 **prefillId** | **string**|  | 
 **data** | [**AccountSignupPreFillRequest**](AccountSignupPreFillRequest.md)|  | 
 **authorize** | **string**| Request access tokens to be included in the response.  | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pre-filled sign up accepted by applicant |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsoidsignupprefillget"></a>
# **AccountsOidSignupPrefillGet**
> AccountSignupPreFillRequest AccountsOidSignupPrefillGet (string oid, string prefillId)

Get pending pre-filled sign up for a new Dintero Account

Get a prefilled a sign up form for a new Dintero Account by id, not yet accepted by the applicant.  scopes: - create:account 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AccountsOidSignupPrefillGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountOnboardingPrefillApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var prefillId = prefillId_example;  // string | 

            try
            {
                // Get pending pre-filled sign up for a new Dintero Account
                AccountSignupPreFillRequest result = apiInstance.AccountsOidSignupPrefillGet(oid, prefillId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountOnboardingPrefillApi.AccountsOidSignupPrefillGet: " + e.Message );
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
 **prefillId** | **string**|  | 

### Return type

[**AccountSignupPreFillRequest**](AccountSignupPreFillRequest.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pre-filled sign up ready to be accepted |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsoidsignupprefillpost"></a>
# **AccountsOidSignupPrefillPost**
> AccountSignupPreFillRequest AccountsOidSignupPrefillPost (string oid, AccountSignupPreFillRequest data)

Pre-fill a sign up for a new Dintero Account

Pre-fill a sign up form for a new Dintero Account  - An email verification request will be sent to the applicant,   that contains a link where the merchant can accept the terms and create a new account.    [POST /account/{oid}/signup/prefill/{prefill_id}](#operation/accounts_oid_signup_prefill_accept_post)  - An email will be sent after accepting the terms. The email contains a link to the Backoffice as well as a password  scopes: - create:applicant 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AccountsOidSignupPrefillPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountOnboardingPrefillApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new AccountSignupPreFillRequest(); // AccountSignupPreFillRequest | 

            try
            {
                // Pre-fill a sign up for a new Dintero Account
                AccountSignupPreFillRequest result = apiInstance.AccountsOidSignupPrefillPost(oid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountOnboardingPrefillApi.AccountsOidSignupPrefillPost: " + e.Message );
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
 **data** | [**AccountSignupPreFillRequest**](AccountSignupPreFillRequest.md)|  | 

### Return type

[**AccountSignupPreFillRequest**](AccountSignupPreFillRequest.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pre-fill form submitted |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

