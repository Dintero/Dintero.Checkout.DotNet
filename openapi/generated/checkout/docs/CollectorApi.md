# Dintero.OpenApiClient.Checkout.Api.CollectorApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutSidCollectorCallbackPost**](CollectorApi.md#checkoutsidcollectorcallbackpost) | **GET** /callbacks/collector/antifraud | Handle Collector Anti-fraud callback after an update
[**CheckoutSidCollectorRedirectGet**](CollectorApi.md#checkoutsidcollectorredirectget) | **GET** /sessions/{session_id}/collector/redirect | Handle redirect from payment


<a name="checkoutsidcollectorcallbackpost"></a>
# **CheckoutSidCollectorCallbackPost**
> void CheckoutSidCollectorCallbackPost (string invoiceNo, string orderNo, int invoiceStatus)

Handle Collector Anti-fraud callback after an update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidCollectorCallbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CollectorApi(config);
            var invoiceNo = invoiceNo_example;  // string | 
            var orderNo = orderNo_example;  // string | 
            var invoiceStatus = 56;  // int | 

            try
            {
                // Handle Collector Anti-fraud callback after an update
                apiInstance.CheckoutSidCollectorCallbackPost(invoiceNo, orderNo, invoiceStatus);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectorApi.CheckoutSidCollectorCallbackPost: " + e.Message );
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
 **invoiceNo** | **string**|  | 
 **orderNo** | **string**|  | 
 **invoiceStatus** | **int**|  | 

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | callback handled |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidcollectorredirectget"></a>
# **CheckoutSidCollectorRedirectGet**
> void CheckoutSidCollectorRedirectGet (string sessionId)

Handle redirect from payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidCollectorRedirectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CollectorApi(config);
            var sessionId = sessionId_example;  // string | The session ID

            try
            {
                // Handle redirect from payment
                apiInstance.CheckoutSidCollectorRedirectGet(sessionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectorApi.CheckoutSidCollectorRedirectGet: " + e.Message );
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
 **sessionId** | **string**| The session ID | 

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Redirect to session URL on payment completed |  * Location - the URL to redirect to Vipps - &#x60;sid&#x60; will be used to find the approval url  <br>  |
| **404** | Resource was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

