# Dintero.OpenApiClient.Checkout.Api.PayexGatewayApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminCheckoutIdGwOverridePayexPut**](PayexGatewayApi.md#admincheckoutidgwoverridepayexput) | **PUT** /admin/gateways/payex/override | Update overrides for PayEx Gateway
[**AdminCheckoutIdGwPayexPut**](PayexGatewayApi.md#admincheckoutidgwpayexput) | **PUT** /admin/gateways/payex | Update PayEx gateway


<a name="admincheckoutidgwoverridepayexput"></a>
# **AdminCheckoutIdGwOverridePayexPut**
> void AdminCheckoutIdGwOverridePayexPut (bool? keepVersions = null, InlineObject8 configuration = null)

Update overrides for PayEx Gateway

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
    public class AdminCheckoutIdGwOverridePayexPutExample
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

            var apiInstance = new PayexGatewayApi(config);
            var keepVersions = true;  // bool? | keep existing override versions when updating the overridej  (optional)  (default to true)
            var configuration = new InlineObject8(); // InlineObject8 |  (optional) 

            try
            {
                // Update overrides for PayEx Gateway
                apiInstance.AdminCheckoutIdGwOverridePayexPut(keepVersions, configuration);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayexGatewayApi.AdminCheckoutIdGwOverridePayexPut: " + e.Message );
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
 **keepVersions** | **bool?**| keep existing override versions when updating the overridej  | [optional] [default to true]
 **configuration** | [**InlineObject8**](InlineObject8.md)|  | [optional] 

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

<a name="admincheckoutidgwpayexput"></a>
# **AdminCheckoutIdGwPayexPut**
> void AdminCheckoutIdGwPayexPut (InlineObject7 configuration, bool? keepOverrides = null, bool? keepVersions = null)

Update PayEx gateway

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
    public class AdminCheckoutIdGwPayexPutExample
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

            var apiInstance = new PayexGatewayApi(config);
            var configuration = new InlineObject7(); // InlineObject7 | 
            var keepOverrides = true;  // bool? | keep existing overrides when updating the gateway  (optional)  (default to true)
            var keepVersions = true;  // bool? | keep existing overrides when updating the gateway  (optional)  (default to true)

            try
            {
                // Update PayEx gateway
                apiInstance.AdminCheckoutIdGwPayexPut(configuration, keepOverrides, keepVersions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayexGatewayApi.AdminCheckoutIdGwPayexPut: " + e.Message );
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
 **configuration** | [**InlineObject7**](InlineObject7.md)|  | 
 **keepOverrides** | **bool?**| keep existing overrides when updating the gateway  | [optional] [default to true]
 **keepVersions** | **bool?**| keep existing overrides when updating the gateway  | [optional] [default to true]

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

