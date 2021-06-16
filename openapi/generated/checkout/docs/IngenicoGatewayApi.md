# Dintero.OpenApiClient.Checkout.Api.IngenicoGatewayApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminCheckoutIdGwIngenicoPut**](IngenicoGatewayApi.md#admincheckoutidgwingenicoput) | **PUT** /admin/gateways/ingenico | Update Ingenico gateway


<a name="admincheckoutidgwingenicoput"></a>
# **AdminCheckoutIdGwIngenicoPut**
> void AdminCheckoutIdGwIngenicoPut (InlineObject3 configuration)

Update Ingenico gateway

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
    public class AdminCheckoutIdGwIngenicoPutExample
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

            var apiInstance = new IngenicoGatewayApi(config);
            var configuration = new InlineObject3(); // InlineObject3 | 

            try
            {
                // Update Ingenico gateway
                apiInstance.AdminCheckoutIdGwIngenicoPut(configuration);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngenicoGatewayApi.AdminCheckoutIdGwIngenicoPut: " + e.Message );
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
 **configuration** | [**InlineObject3**](InlineObject3.md)|  | 

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

