# Dintero.OpenApiClient.Checkout.Api.SantanderGatewayApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminCheckoutIdGwOverrideSantanderPut**](SantanderGatewayApi.md#admincheckoutidgwoverridesantanderput) | **PUT** /admin/gateways/santander/override | Update store override for Santander gateway
[**AdminCheckoutIdGwSantanderPut**](SantanderGatewayApi.md#admincheckoutidgwsantanderput) | **PUT** /admin/gateways/santander | Update Santander gateway


<a name="admincheckoutidgwoverridesantanderput"></a>
# **AdminCheckoutIdGwOverrideSantanderPut**
> void AdminCheckoutIdGwOverrideSantanderPut (InlineObject10 configuration = null)

Update store override for Santander gateway

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
    public class AdminCheckoutIdGwOverrideSantanderPutExample
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

            var apiInstance = new SantanderGatewayApi(config);
            var configuration = new InlineObject10(); // InlineObject10 |  (optional) 

            try
            {
                // Update store override for Santander gateway
                apiInstance.AdminCheckoutIdGwOverrideSantanderPut(configuration);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SantanderGatewayApi.AdminCheckoutIdGwOverrideSantanderPut: " + e.Message );
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
 **configuration** | [**InlineObject10**](InlineObject10.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Gateway updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="admincheckoutidgwsantanderput"></a>
# **AdminCheckoutIdGwSantanderPut**
> void AdminCheckoutIdGwSantanderPut (InlineObject9 configuration)

Update Santander gateway

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
    public class AdminCheckoutIdGwSantanderPutExample
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

            var apiInstance = new SantanderGatewayApi(config);
            var configuration = new InlineObject9(); // InlineObject9 | 

            try
            {
                // Update Santander gateway
                apiInstance.AdminCheckoutIdGwSantanderPut(configuration);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SantanderGatewayApi.AdminCheckoutIdGwSantanderPut: " + e.Message );
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
 **configuration** | [**InlineObject9**](InlineObject9.md)|  | 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Gateway updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

