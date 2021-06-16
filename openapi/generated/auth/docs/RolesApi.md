# Dintero.OpenApiClient.Auth.Api.RolesApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAuthsRolesGet**](RolesApi.md#aidauthsrolesget) | **GET** /accounts/{oid}/auth/roles | Roles collection
[**AidAuthsRolesIdDelete**](RolesApi.md#aidauthsrolesiddelete) | **DELETE** /accounts/{oid}/auth/roles/{role_id} | Delete role 
[**AidAuthsRolesIdGet**](RolesApi.md#aidauthsrolesidget) | **GET** /accounts/{oid}/auth/roles/{role_id} | Get role 
[**AidAuthsRolesIdPut**](RolesApi.md#aidauthsrolesidput) | **PUT** /accounts/{oid}/auth/roles/{role_id} | Update role 
[**AidAuthsRolesPost**](RolesApi.md#aidauthsrolespost) | **POST** /accounts/{oid}/auth/roles | Create a role


<a name="aidauthsrolesget"></a>
# **AidAuthsRolesGet**
> List&lt;AuthRole&gt; AidAuthsRolesGet (string oid, string search = null, string name = null, bool? includeDeleted = null, int? limit = null, string startingAfter = null)

Roles collection

Retrieve filtered list of roles that can be assigned to users.  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsRolesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RolesApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var search = search_example;  // string | lookup roles matching id, name and description  (optional) 
            var name = name_example;  // string | lookup roles by name  (optional) 
            var includeDeleted = true;  // bool? | include deleted roles in the response  (optional)  (default to false)
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional)  (default to 10)
            var startingAfter = startingAfter_example;  // string | cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with `obj_foo`, your subsequent call can include `starting_after=obj_foo` in order to fetch the next page of the list.  (optional) 

            try
            {
                // Roles collection
                List<AuthRole> result = apiInstance.AidAuthsRolesGet(oid, search, name, includeDeleted, limit, startingAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.AidAuthsRolesGet: " + e.Message );
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
 **search** | **string**| lookup roles matching id, name and description  | [optional] 
 **name** | **string**| lookup roles by name  | [optional] 
 **includeDeleted** | **bool?**| include deleted roles in the response  | [optional] [default to false]
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  | [optional] [default to 10]
 **startingAfter** | **string**| cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  | [optional] 

### Return type

[**List&lt;AuthRole&gt;**](AuthRole.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Role Collection |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsrolesiddelete"></a>
# **AidAuthsRolesIdDelete**
> AuthRole AidAuthsRolesIdDelete (string oid, string roleId)

Delete role 

scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsRolesIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RolesApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var roleId = roleId_example;  // string | The id of the rule to delete 

            try
            {
                // Delete role 
                AuthRole result = apiInstance.AidAuthsRolesIdDelete(oid, roleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.AidAuthsRolesIdDelete: " + e.Message );
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
 **roleId** | **string**| The id of the rule to delete  | 

### Return type

[**AuthRole**](AuthRole.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Role deleted |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsrolesidget"></a>
# **AidAuthsRolesIdGet**
> AuthRole AidAuthsRolesIdGet (string oid, string roleId)

Get role 

 scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsRolesIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RolesApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var roleId = roleId_example;  // string | The id of the rule to delete 

            try
            {
                // Get role 
                AuthRole result = apiInstance.AidAuthsRolesIdGet(oid, roleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.AidAuthsRolesIdGet: " + e.Message );
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
 **roleId** | **string**| The id of the rule to delete  | 

### Return type

[**AuthRole**](AuthRole.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Role details |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsrolesidput"></a>
# **AidAuthsRolesIdPut**
> AuthRole AidAuthsRolesIdPut (string oid, string roleId, AuthRole data)

Update role 

 scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsRolesIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RolesApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var roleId = roleId_example;  // string | The id of the rule to delete 
            var data = new AuthRole(); // AuthRole | 

            try
            {
                // Update role 
                AuthRole result = apiInstance.AidAuthsRolesIdPut(oid, roleId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.AidAuthsRolesIdPut: " + e.Message );
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
 **roleId** | **string**| The id of the rule to delete  | 
 **data** | [**AuthRole**](AuthRole.md)|  | 

### Return type

[**AuthRole**](AuthRole.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Role updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsrolespost"></a>
# **AidAuthsRolesPost**
> AuthRole AidAuthsRolesPost (string oid, AuthRole data)

Create a role

 scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsRolesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RolesApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new AuthRole(); // AuthRole | 

            try
            {
                // Create a role
                AuthRole result = apiInstance.AidAuthsRolesPost(oid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.AidAuthsRolesPost: " + e.Message );
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
 **data** | [**AuthRole**](AuthRole.md)|  | 

### Return type

[**AuthRole**](AuthRole.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Role Create |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

