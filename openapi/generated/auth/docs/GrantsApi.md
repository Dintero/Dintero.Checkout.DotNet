# Dintero.OpenApiClient.Auth.Api.GrantsApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAuthsClientGrantsGet**](GrantsApi.md#aidauthsclientgrantsget) | **GET** /accounts/{oid}/auth/client-grants | Client grants collection
[**AidAuthsClientGrantsIdDelete**](GrantsApi.md#aidauthsclientgrantsiddelete) | **DELETE** /accounts/{oid}/auth/client-grants/{id} | Delete client grant 
[**AidAuthsClientGrantsPost**](GrantsApi.md#aidauthsclientgrantspost) | **POST** /accounts/{oid}/auth/client-grants | Create client grant


<a name="aidauthsclientgrantsget"></a>
# **AidAuthsClientGrantsGet**
> List&lt;Grant&gt; AidAuthsClientGrantsGet (string oid, string audience = null, string clientId = null)

Client grants collection

Manage your Client Grants (also called Client Credentials Grants). Using Client Grants, your Client can request an access token using its credentials (a Client ID and a Client Secret). The access token then represents your Client during API calls.  Use the Grant type to limit how the grant can be used when requesting an access token. A Grant with type `password` can only be used when requesting an access token with grant_type set to `password`.  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsClientGrantsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GrantsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var audience = audience_example;  // string | filter client grants by audience  (optional) 
            var clientId = clientId_example;  // string | filter client grants by client_id  (optional) 

            try
            {
                // Client grants collection
                List<Grant> result = apiInstance.AidAuthsClientGrantsGet(oid, audience, clientId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GrantsApi.AidAuthsClientGrantsGet: " + e.Message );
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
 **audience** | **string**| filter client grants by audience  | [optional] 
 **clientId** | **string**| filter client grants by client_id  | [optional] 

### Return type

[**List&lt;Grant&gt;**](Grant.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Grant Collection |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsclientgrantsiddelete"></a>
# **AidAuthsClientGrantsIdDelete**
> Grant AidAuthsClientGrantsIdDelete (string oid, string id)

Delete client grant 

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
    public class AidAuthsClientGrantsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GrantsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var id = id_example;  // string | The id of the client grant to delete 

            try
            {
                // Delete client grant 
                Grant result = apiInstance.AidAuthsClientGrantsIdDelete(oid, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GrantsApi.AidAuthsClientGrantsIdDelete: " + e.Message );
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
 **id** | **string**| The id of the client grant to delete  | 

### Return type

[**Grant**](Grant.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Grant Create |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsclientgrantspost"></a>
# **AidAuthsClientGrantsPost**
> Grant AidAuthsClientGrantsPost (string oid, Grant data)

Create client grant

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
    public class AidAuthsClientGrantsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GrantsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new Grant(); // Grant | 

            try
            {
                // Create client grant
                Grant result = apiInstance.AidAuthsClientGrantsPost(oid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GrantsApi.AidAuthsClientGrantsPost: " + e.Message );
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
 **data** | [**Grant**](Grant.md)|  | 

### Return type

[**Grant**](Grant.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Grant Create |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

