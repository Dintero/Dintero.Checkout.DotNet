# Dintero.OpenApiClient.Auth.Api.AccountUsersApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountUserGet**](AccountUsersApi.md#accountuserget) | **GET** /account/user | Authenticated User
[**AccountUserMfaSmsPut**](AccountUsersApi.md#accountusermfasmsput) | **PUT** /account/user/mfa/sms | Configure SMS MFA
[**AccountUserPasswordPut**](AccountUsersApi.md#accountuserpasswordput) | **POST** /account/user/password | Change User password
[**AidAccountsAidMgmntUsersActivitiesGet**](AccountUsersApi.md#aidaccountsaidmgmntusersactivitiesget) | **GET** /accounts/{oid}/management/users/{uid}/activities | Get user activity log
[**AidAccountsAidMgmntUsersDelete**](AccountUsersApi.md#aidaccountsaidmgmntusersdelete) | **DELETE** /accounts/{oid}/management/users/{uid} | Delete User
[**AidAccountsAidMgmntUsersGet**](AccountUsersApi.md#aidaccountsaidmgmntusersget) | **GET** /accounts/{oid}/management/users | Users Collection
[**AidAccountsAidMgmntUsersPost**](AccountUsersApi.md#aidaccountsaidmgmntuserspost) | **POST** /accounts/{oid}/management/users | Create User
[**AidAccountsAidMgmntUsersPut**](AccountUsersApi.md#aidaccountsaidmgmntusersput) | **PUT** /accounts/{oid}/management/users/{uid} | Update User


<a name="accountuserget"></a>
# **AccountUserGet**
> AuthenticatedAccountUser AccountUserGet ()

Authenticated User

Get public and private profile information when authenticated through Bearer auth  > Use ID token as Bearer token if the user was authenticated > externally. The ID token must include a `email` claim that > identifies the account user.  scopes: - openid - aws.cognito.signin.user.admin 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AccountUserGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountUsersApi(config);

            try
            {
                // Authenticated User
                AuthenticatedAccountUser result = apiInstance.AccountUserGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountUsersApi.AccountUserGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AuthenticatedAccountUser**](AuthenticatedAccountUser.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | user accounts |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountusermfasmsput"></a>
# **AccountUserMfaSmsPut**
> void AccountUserMfaSmsPut (InlineObject data)

Configure SMS MFA

Update the user SMS MFA configuration 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AccountUserMfaSmsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountUsersApi(config);
            var data = new InlineObject(); // InlineObject | 

            try
            {
                // Configure SMS MFA
                apiInstance.AccountUserMfaSmsPut(data);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountUsersApi.AccountUserMfaSmsPut: " + e.Message );
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
 **data** | [**InlineObject**](InlineObject.md)|  | 

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
| **201** | Accepted |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountuserpasswordput"></a>
# **AccountUserPasswordPut**
> void AccountUserPasswordPut (InlineObject1 body = null)

Change User password

Change the password for the account user  scopes: - openid 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AccountUserPasswordPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountUsersApi(config);
            var body = new InlineObject1(); // InlineObject1 |  (optional) 

            try
            {
                // Change User password
                apiInstance.AccountUserPasswordPut(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountUsersApi.AccountUserPasswordPut: " + e.Message );
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
 **body** | [**InlineObject1**](InlineObject1.md)|  | [optional] 

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
| **201** | Accepted |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  * Retry-After - Indicates how long the user agent should wait in seconds before making a follow-up request.  <br>  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsaidmgmntusersactivitiesget"></a>
# **AidAccountsAidMgmntUsersActivitiesGet**
> List&lt;AuditEvent&gt; AidAccountsAidMgmntUsersActivitiesGet (string oid, string uid)

Get user activity log

Get activities for User  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountsAidMgmntUsersActivitiesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountUsersApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var uid = uid_example;  // string | Id identifying the user 

            try
            {
                // Get user activity log
                List<AuditEvent> result = apiInstance.AidAccountsAidMgmntUsersActivitiesGet(oid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountUsersApi.AidAccountsAidMgmntUsersActivitiesGet: " + e.Message );
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
 **uid** | **string**| Id identifying the user  | 

### Return type

[**List&lt;AuditEvent&gt;**](AuditEvent.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account created |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsaidmgmntusersdelete"></a>
# **AidAccountsAidMgmntUsersDelete**
> AccountUserResponse AidAccountsAidMgmntUsersDelete (string oid, string uid, List<string> expand = null)

Delete User

Delete an user from an account  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountsAidMgmntUsersDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountUsersApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var uid = uid_example;  // string | Id identifying the user 
            var expand = expand_example;  // List<string> | Expand properties in the response  (optional) 

            try
            {
                // Delete User
                AccountUserResponse result = apiInstance.AidAccountsAidMgmntUsersDelete(oid, uid, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountUsersApi.AidAccountsAidMgmntUsersDelete: " + e.Message );
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
 **uid** | **string**| Id identifying the user  | 
 **expand** | **List&lt;string&gt;**| Expand properties in the response  | [optional] 

### Return type

[**AccountUserResponse**](AccountUserResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | user deleted |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsaidmgmntusersget"></a>
# **AidAccountsAidMgmntUsersGet**
> List&lt;AccountUserResponse&gt; AidAccountsAidMgmntUsersGet (string oid, List<string> expand = null)

Users Collection

Get list of all users with access to the account  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountsAidMgmntUsersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountUsersApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var expand = expand_example;  // List<string> | Expand properties in the response  (optional) 

            try
            {
                // Users Collection
                List<AccountUserResponse> result = apiInstance.AidAccountsAidMgmntUsersGet(oid, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountUsersApi.AidAccountsAidMgmntUsersGet: " + e.Message );
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
 **expand** | **List&lt;string&gt;**| Expand properties in the response  | [optional] 

### Return type

[**List&lt;AccountUserResponse&gt;**](AccountUserResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | user collection |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsaidmgmntuserspost"></a>
# **AidAccountsAidMgmntUsersPost**
> AccountUserResponse AidAccountsAidMgmntUsersPost (string oid, InlineObject12 data, List<string> expand = null)

Create User

Create and grant user access to the account  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountsAidMgmntUsersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountUsersApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new InlineObject12(); // InlineObject12 | 
            var expand = expand_example;  // List<string> | Expand properties in the response  (optional) 

            try
            {
                // Create User
                AccountUserResponse result = apiInstance.AidAccountsAidMgmntUsersPost(oid, data, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountUsersApi.AidAccountsAidMgmntUsersPost: " + e.Message );
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
 **data** | [**InlineObject12**](InlineObject12.md)|  | 
 **expand** | **List&lt;string&gt;**| Expand properties in the response  | [optional] 

### Return type

[**AccountUserResponse**](AccountUserResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | user created |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsaidmgmntusersput"></a>
# **AidAccountsAidMgmntUsersPut**
> AccountUserResponse AidAccountsAidMgmntUsersPut (string oid, string uid, UNKNOWN_BASE_TYPE data, List<string> expand = null)

Update User

Update user  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountsAidMgmntUsersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountUsersApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var uid = uid_example;  // string | Id identifying the user 
            var data = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
            var expand = expand_example;  // List<string> | Expand properties in the response  (optional) 

            try
            {
                // Update User
                AccountUserResponse result = apiInstance.AidAccountsAidMgmntUsersPut(oid, uid, data, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountUsersApi.AidAccountsAidMgmntUsersPut: " + e.Message );
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
 **uid** | **string**| Id identifying the user  | 
 **data** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 
 **expand** | **List&lt;string&gt;**| Expand properties in the response  | [optional] 

### Return type

[**AccountUserResponse**](AccountUserResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

