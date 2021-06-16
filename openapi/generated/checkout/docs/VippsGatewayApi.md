# Dintero.OpenApiClient.Checkout.Api.VippsGatewayApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminCheckoutIdGwOverrideVippsPut**](VippsGatewayApi.md#admincheckoutidgwoverridevippsput) | **PUT** /admin/gateways/vipps/override | Update overrides for Vipps Gateway
[**AdminCheckoutIdGwVippsPut**](VippsGatewayApi.md#admincheckoutidgwvippsput) | **PUT** /admin/gateways/vipps | Update Vipps gateway


<a name="admincheckoutidgwoverridevippsput"></a>
# **AdminCheckoutIdGwOverrideVippsPut**
> void AdminCheckoutIdGwOverrideVippsPut (InlineObject14 configuration = null)

Update overrides for Vipps Gateway

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
    public class AdminCheckoutIdGwOverrideVippsPutExample
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

            var apiInstance = new VippsGatewayApi(config);
            var configuration = new InlineObject14(); // InlineObject14 |  (optional) 

            try
            {
                // Update overrides for Vipps Gateway
                apiInstance.AdminCheckoutIdGwOverrideVippsPut(configuration);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VippsGatewayApi.AdminCheckoutIdGwOverrideVippsPut: " + e.Message );
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
 **configuration** | [**InlineObject14**](InlineObject14.md)|  | [optional] 

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

<a name="admincheckoutidgwvippsput"></a>
# **AdminCheckoutIdGwVippsPut**
> void AdminCheckoutIdGwVippsPut (InlineObject13 configuration)

Update Vipps gateway

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
    public class AdminCheckoutIdGwVippsPutExample
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

            var apiInstance = new VippsGatewayApi(config);
            var configuration = new InlineObject13(); // InlineObject13 | 

            try
            {
                // Update Vipps gateway
                apiInstance.AdminCheckoutIdGwVippsPut(configuration);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VippsGatewayApi.AdminCheckoutIdGwVippsPut: " + e.Message );
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
 **configuration** | [**InlineObject13**](InlineObject13.md)|  | 

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

