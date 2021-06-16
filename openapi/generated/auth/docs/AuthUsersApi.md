# Dintero.OpenApiClient.Auth.Api.AuthUsersApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAuthUsersPost**](AuthUsersApi.md#aidauthuserspost) | **POST** /accounts/{aid}/auth/users | Create User
[**AidAuthUsersUsernameChangeUsernamePost**](AuthUsersApi.md#aidauthusersusernamechangeusernamepost) | **POST** /accounts/{aid}/auth/users/{username}/change_username | Change username
[**AidAuthUsersUsernameDelete**](AuthUsersApi.md#aidauthusersusernamedelete) | **DELETE** /accounts/{aid}/auth/users/{username} | Delete user
[**AidAuthUsersUsernamePut**](AuthUsersApi.md#aidauthusersusernameput) | **PUT** /accounts/{aid}/auth/users/{username} | Update user


<a name="aidauthuserspost"></a>
# **AidAuthUsersPost**
> AuthUser AidAuthUsersPost (string aid, UNKNOWN_BASE_TYPE data)

Create User

Create a new user  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthUsersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthUsersApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Create User
                AuthUser result = apiInstance.AidAuthUsersPost(aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthUsersApi.AidAuthUsersPost: " + e.Message );
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

[**AuthUser**](AuthUser.md)

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

<a name="aidauthusersusernamechangeusernamepost"></a>
# **AidAuthUsersUsernameChangeUsernamePost**
> AuthUser AidAuthUsersUsernameChangeUsernamePost (string aid, string username, UNKNOWN_BASE_TYPE data)

Change username

Update existing users username  scopes: - admin:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthUsersUsernameChangeUsernamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthUsersApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var username = username_example;  // string | Username identifying the user 
            var data = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Change username
                AuthUser result = apiInstance.AidAuthUsersUsernameChangeUsernamePost(aid, username, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthUsersApi.AidAuthUsersUsernameChangeUsernamePost: " + e.Message );
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
 **username** | **string**| Username identifying the user  | 
 **data** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**AuthUser**](AuthUser.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | user updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthusersusernamedelete"></a>
# **AidAuthUsersUsernameDelete**
> AuthUser AidAuthUsersUsernameDelete (string aid, string username)

Delete user

Delete existing user  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthUsersUsernameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthUsersApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var username = username_example;  // string | Username identifying the user 

            try
            {
                // Delete user
                AuthUser result = apiInstance.AidAuthUsersUsernameDelete(aid, username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthUsersApi.AidAuthUsersUsernameDelete: " + e.Message );
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
 **username** | **string**| Username identifying the user  | 

### Return type

[**AuthUser**](AuthUser.md)

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

<a name="aidauthusersusernameput"></a>
# **AidAuthUsersUsernamePut**
> AuthUser AidAuthUsersUsernamePut (string aid, string username, UNKNOWN_BASE_TYPE data)

Update user

Update existing user with new password  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthUsersUsernamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthUsersApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var username = username_example;  // string | Username identifying the user 
            var data = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Update user
                AuthUser result = apiInstance.AidAuthUsersUsernamePut(aid, username, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthUsersApi.AidAuthUsersUsernamePut: " + e.Message );
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
 **username** | **string**| Username identifying the user  | 
 **data** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**AuthUser**](AuthUser.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | user updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

