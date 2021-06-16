# Dintero.OpenApiClient.Checkout.Api.NetaxeptGatewayApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminCheckoutIdGwNetaxeptPut**](NetaxeptGatewayApi.md#admincheckoutidgwnetaxeptput) | **PUT** /admin/gateways/netaxept | Update Netaxept gateway
[**AdminCheckoutIdGwOverrideNetaxeptPut**](NetaxeptGatewayApi.md#admincheckoutidgwoverridenetaxeptput) | **PUT** /admin/gateways/netaxept/override | Update overrides for Netaxept Gateway


<a name="admincheckoutidgwnetaxeptput"></a>
# **AdminCheckoutIdGwNetaxeptPut**
> void AdminCheckoutIdGwNetaxeptPut (InlineObject5 configuration)

Update Netaxept gateway

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
    public class AdminCheckoutIdGwNetaxeptPutExample
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

            var apiInstance = new NetaxeptGatewayApi(config);
            var configuration = new InlineObject5(); // InlineObject5 | 

            try
            {
                // Update Netaxept gateway
                apiInstance.AdminCheckoutIdGwNetaxeptPut(configuration);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetaxeptGatewayApi.AdminCheckoutIdGwNetaxeptPut: " + e.Message );
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
 **configuration** | [**InlineObject5**](InlineObject5.md)|  | 

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

<a name="admincheckoutidgwoverridenetaxeptput"></a>
# **AdminCheckoutIdGwOverrideNetaxeptPut**
> void AdminCheckoutIdGwOverrideNetaxeptPut (InlineObject6 configuration = null)

Update overrides for Netaxept Gateway

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
    public class AdminCheckoutIdGwOverrideNetaxeptPutExample
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

            var apiInstance = new NetaxeptGatewayApi(config);
            var configuration = new InlineObject6(); // InlineObject6 |  (optional) 

            try
            {
                // Update overrides for Netaxept Gateway
                apiInstance.AdminCheckoutIdGwOverrideNetaxeptPut(configuration);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetaxeptGatewayApi.AdminCheckoutIdGwOverrideNetaxeptPut: " + e.Message );
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
 **configuration** | [**InlineObject6**](InlineObject6.md)|  | [optional] 

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

