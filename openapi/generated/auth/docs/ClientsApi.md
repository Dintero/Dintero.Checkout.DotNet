# Dintero.OpenApiClient.Auth.Api.ClientsApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAuthClientsGet**](ClientsApi.md#aidauthclientsget) | **GET** /accounts/{oid}/auth/clients | Clients collection
[**AidAuthClientsPost**](ClientsApi.md#aidauthclientspost) | **POST** /accounts/{oid}/auth/clients | Create Client
[**AidAuthsClientsIdDelete**](ClientsApi.md#aidauthsclientsiddelete) | **DELETE** /accounts/{oid}/auth/clients/{id} | Delete Client
[**AidAuthsClientsIdGet**](ClientsApi.md#aidauthsclientsidget) | **GET** /accounts/{oid}/auth/clients/{id} | Get Client
[**AidAuthsClientsIdRotatePost**](ClientsApi.md#aidauthsclientsidrotatepost) | **POST** /accounts/{oid}/auth/clients/{id}/rotate-secret | Rotate a client secret.


<a name="aidauthclientsget"></a>
# **AidAuthClientsGet**
> List&lt;ModelClient&gt; AidAuthClientsGet (string oid)

Clients collection

Retrieve a list of all client applications  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthClientsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 

            try
            {
                // Clients collection
                List<ModelClient> result = apiInstance.AidAuthClientsGet(oid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.AidAuthClientsGet: " + e.Message );
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

### Return type

[**List&lt;ModelClient&gt;**](ModelClient.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client Collection |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthclientspost"></a>
# **AidAuthClientsPost**
> InlineResponse2003 AidAuthClientsPost (string oid, ModelClient data)

Create Client

Creates a new client application.  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthClientsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new ModelClient(); // ModelClient | 

            try
            {
                // Create Client
                InlineResponse2003 result = apiInstance.AidAuthClientsPost(oid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.AidAuthClientsPost: " + e.Message );
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
 **data** | [**ModelClient**](ModelClient.md)|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client Created |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsclientsiddelete"></a>
# **AidAuthsClientsIdDelete**
> ModelClient AidAuthsClientsIdDelete (string oid, string id)

Delete Client

Deletes a client and all its related assets  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsClientsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var id = id_example;  // string | The id of the client 

            try
            {
                // Delete Client
                ModelClient result = apiInstance.AidAuthsClientsIdDelete(oid, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.AidAuthsClientsIdDelete: " + e.Message );
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
 **id** | **string**| The id of the client  | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client Deleted |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsclientsidget"></a>
# **AidAuthsClientsIdGet**
> ModelClient AidAuthsClientsIdGet (string oid, string id)

Get Client

Retrieves a client by its id.  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsClientsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var id = id_example;  // string | The id of the client 

            try
            {
                // Get Client
                ModelClient result = apiInstance.AidAuthsClientsIdGet(oid, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.AidAuthsClientsIdGet: " + e.Message );
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
 **id** | **string**| The id of the client  | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsclientsidrotatepost"></a>
# **AidAuthsClientsIdRotatePost**
> InlineResponse2003 AidAuthsClientsIdRotatePost (string oid, string id)

Rotate a client secret.

Rotate a client secret.  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsClientsIdRotatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var id = id_example;  // string | The id of the client 

            try
            {
                // Rotate a client secret.
                InlineResponse2003 result = apiInstance.AidAuthsClientsIdRotatePost(oid, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.AidAuthsClientsIdRotatePost: " + e.Message );
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
 **id** | **string**| The id of the client  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client with new client_secret |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

