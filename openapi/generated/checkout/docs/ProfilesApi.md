# Dintero.OpenApiClient.Checkout.Api.ProfilesApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminSessionProfileDetailsDelete**](ProfilesApi.md#adminsessionprofiledetailsdelete) | **DELETE** /admin/session/profiles/{profile_id} | Delete session profile
[**AdminSessionProfileDetailsGet**](ProfilesApi.md#adminsessionprofiledetailsget) | **GET** /admin/session/profiles/{profile_id} | Get session profile details
[**AdminSessionProfileDetailsPut**](ProfilesApi.md#adminsessionprofiledetailsput) | **PUT** /admin/session/profiles/{profile_id} | Update session profile
[**AdminSessionProfileGet**](ProfilesApi.md#adminsessionprofileget) | **GET** /admin/session/profiles | List profiles
[**AdminSessionProfilePost**](ProfilesApi.md#adminsessionprofilepost) | **POST** /admin/session/profiles | Create session profile


<a name="adminsessionprofiledetailsdelete"></a>
# **AdminSessionProfileDetailsDelete**
> InlineResponse2003 AdminSessionProfileDetailsDelete (string profileId)

Delete session profile

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
    public class AdminSessionProfileDetailsDeleteExample
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

            var apiInstance = new ProfilesApi(config);
            var profileId = profileId_example;  // string | 

            try
            {
                // Delete session profile
                InlineResponse2003 result = apiInstance.AdminSessionProfileDetailsDelete(profileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AdminSessionProfileDetailsDelete: " + e.Message );
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
 **profileId** | **string**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Session profile |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminsessionprofiledetailsget"></a>
# **AdminSessionProfileDetailsGet**
> InlineResponse2003 AdminSessionProfileDetailsGet (string profileId)

Get session profile details

scopes: - admin:checkout - read:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class AdminSessionProfileDetailsGetExample
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

            var apiInstance = new ProfilesApi(config);
            var profileId = profileId_example;  // string | 

            try
            {
                // Get session profile details
                InlineResponse2003 result = apiInstance.AdminSessionProfileDetailsGet(profileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AdminSessionProfileDetailsGet: " + e.Message );
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
 **profileId** | **string**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Session profile |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminsessionprofiledetailsput"></a>
# **AdminSessionProfileDetailsPut**
> InlineResponse2004 AdminSessionProfileDetailsPut (string profileId, UNKNOWN_BASE_TYPE configuration)

Update session profile

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
    public class AdminSessionProfileDetailsPutExample
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

            var apiInstance = new ProfilesApi(config);
            var profileId = profileId_example;  // string | 
            var configuration = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Update session profile
                InlineResponse2004 result = apiInstance.AdminSessionProfileDetailsPut(profileId, configuration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AdminSessionProfileDetailsPut: " + e.Message );
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
 **profileId** | **string**|  | 
 **configuration** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Session profile |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminsessionprofileget"></a>
# **AdminSessionProfileGet**
> List&lt;Id&gt; AdminSessionProfileGet (int? limit = null, string startingAfter = null)

List profiles

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
    public class AdminSessionProfileGetExample
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

            var apiInstance = new ProfilesApi(config);
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional)  (default to 10)
            var startingAfter = startingAfter_example;  // string | cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with `obj_foo`, your subsequent call can include `starting_after=obj_foo` in order to fetch the next page of the list.  (optional) 

            try
            {
                // List profiles
                List<Id> result = apiInstance.AdminSessionProfileGet(limit, startingAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AdminSessionProfileGet: " + e.Message );
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
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  | [optional] [default to 10]
 **startingAfter** | **string**| cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  | [optional] 

### Return type

[**List&lt;Id&gt;**](Id.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payment configuration |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminsessionprofilepost"></a>
# **AdminSessionProfilePost**
> InlineResponse2003 AdminSessionProfilePost (UNKNOWN_BASE_TYPE configuration)

Create session profile

scopes: - admin:checkout - read:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class AdminSessionProfilePostExample
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

            var apiInstance = new ProfilesApi(config);
            var configuration = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Create session profile
                InlineResponse2003 result = apiInstance.AdminSessionProfilePost(configuration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AdminSessionProfilePost: " + e.Message );
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

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Session profile |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

