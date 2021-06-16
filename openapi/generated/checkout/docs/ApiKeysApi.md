# Dintero.OpenApiClient.Checkout.Api.ApiKeysApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminApiKeysApiKeyIdRotatePost**](ApiKeysApi.md#adminapikeysapikeyidrotatepost) | **POST** /admin/api-keys/{api_key_id}/rotate-api-key | Rotate api-key
[**AdminApiKeysGet**](ApiKeysApi.md#adminapikeysget) | **GET** /admin/api-keys | List api-keys
[**AdminApiKeysPost**](ApiKeysApi.md#adminapikeyspost) | **POST** /admin/api-keys | Create api-key
[**AdminParametersApiKeyDelete**](ApiKeysApi.md#adminparametersapikeydelete) | **DELETE** /admin/api-keys/{api_key_id} | Delete api-key


<a name="adminapikeysapikeyidrotatepost"></a>
# **AdminApiKeysApiKeyIdRotatePost**
> InlineResponse200 AdminApiKeysApiKeyIdRotatePost (string apiKeyId)

Rotate api-key

scopes: - admin:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class AdminApiKeysApiKeyIdRotatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: adminKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ApiKeysApi(config);
            var apiKeyId = apiKeyId_example;  // string | 

            try
            {
                // Rotate api-key
                InlineResponse200 result = apiInstance.AdminApiKeysApiKeyIdRotatePost(apiKeyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiKeysApi.AdminApiKeysApiKeyIdRotatePost: " + e.Message );
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
 **apiKeyId** | **string**|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | api-key |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminapikeysget"></a>
# **AdminApiKeysGet**
> List&lt;ApiKeyRead&gt; AdminApiKeysGet (bool? includeDeleted = null, int? limit = null, string startingAfter = null)

List api-keys

scopes: - admin:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class AdminApiKeysGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: adminKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ApiKeysApi(config);
            var includeDeleted = true;  // bool? | include deleted api-keys in the response  (optional)  (default to false)
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional)  (default to 10)
            var startingAfter = startingAfter_example;  // string | cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with `obj_foo`, your subsequent call can include `starting_after=obj_foo` in order to fetch the next page of the list.  (optional) 

            try
            {
                // List api-keys
                List<ApiKeyRead> result = apiInstance.AdminApiKeysGet(includeDeleted, limit, startingAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiKeysApi.AdminApiKeysGet: " + e.Message );
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
 **includeDeleted** | **bool?**| include deleted api-keys in the response  | [optional] [default to false]
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  | [optional] [default to 10]
 **startingAfter** | **string**| cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  | [optional] 

### Return type

[**List&lt;ApiKeyRead&gt;**](ApiKeyRead.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | api keys |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminapikeyspost"></a>
# **AdminApiKeysPost**
> InlineResponse200 AdminApiKeysPost (UNKNOWN_BASE_TYPE configuration)

Create api-key

scopes: - admin:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class AdminApiKeysPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: adminKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ApiKeysApi(config);
            var configuration = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Create api-key
                InlineResponse200 result = apiInstance.AdminApiKeysPost(configuration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiKeysApi.AdminApiKeysPost: " + e.Message );
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
 **configuration** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | api-key |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminparametersapikeydelete"></a>
# **AdminParametersApiKeyDelete**
> ApiKeyRead AdminParametersApiKeyDelete (string apiKeyId)

Delete api-key

scopes: - admin:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class AdminParametersApiKeyDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: adminKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ApiKeysApi(config);
            var apiKeyId = apiKeyId_example;  // string | 

            try
            {
                // Delete api-key
                ApiKeyRead result = apiInstance.AdminParametersApiKeyDelete(apiKeyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiKeysApi.AdminParametersApiKeyDelete: " + e.Message );
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
 **apiKeyId** | **string**|  | 

### Return type

[**ApiKeyRead**](ApiKeyRead.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | api-key |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

