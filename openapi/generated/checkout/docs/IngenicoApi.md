# Dintero.OpenApiClient.Checkout.Api.IngenicoApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutIngenicoWebhooksGet**](IngenicoApi.md#checkoutingenicowebhooksget) | **GET** /events/gateways/ingenico/transaction/hooks | Handle Ingenico webhooks url validation
[**CheckoutIngenicoWebhooksPost**](IngenicoApi.md#checkoutingenicowebhookspost) | **POST** /events/gateways/ingenico/transaction/hooks | Handle Ingenico webhooks
[**CheckoutSidIngenicoRedirectGet**](IngenicoApi.md#checkoutsidingenicoredirectget) | **GET** /sessions/{session_id}/ingenico/redirect/{redirect_ref} | Handle redirect from payment


<a name="checkoutingenicowebhooksget"></a>
# **CheckoutIngenicoWebhooksGet**
> void CheckoutIngenicoWebhooksGet (string xGCSWebhooksEndpointVerification)

Handle Ingenico webhooks url validation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutIngenicoWebhooksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new IngenicoApi(config);
            var xGCSWebhooksEndpointVerification = xGCSWebhooksEndpointVerification_example;  // string | 

            try
            {
                // Handle Ingenico webhooks url validation
                apiInstance.CheckoutIngenicoWebhooksGet(xGCSWebhooksEndpointVerification);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngenicoApi.CheckoutIngenicoWebhooksGet: " + e.Message );
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
 **xGCSWebhooksEndpointVerification** | **string**|  | 

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
| **200** | webhook validation handled |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutingenicowebhookspost"></a>
# **CheckoutIngenicoWebhooksPost**
> void CheckoutIngenicoWebhooksPost (string xGCSSignature, string xGCSKeyId, IngenicoWebhookEvent data)

Handle Ingenico webhooks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutIngenicoWebhooksPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new IngenicoApi(config);
            var xGCSSignature = xGCSSignature_example;  // string | 
            var xGCSKeyId = xGCSKeyId_example;  // string | 
            var data = new IngenicoWebhookEvent(); // IngenicoWebhookEvent | Content of webhook event

            try
            {
                // Handle Ingenico webhooks
                apiInstance.CheckoutIngenicoWebhooksPost(xGCSSignature, xGCSKeyId, data);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngenicoApi.CheckoutIngenicoWebhooksPost: " + e.Message );
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
 **xGCSSignature** | **string**|  | 
 **xGCSKeyId** | **string**|  | 
 **data** | [**IngenicoWebhookEvent**](IngenicoWebhookEvent.md)| Content of webhook event | 

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | webhook handled |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidingenicoredirectget"></a>
# **CheckoutSidIngenicoRedirectGet**
> void CheckoutSidIngenicoRedirectGet (string sessionId, string redirectRef, string RETURNMAC = null, string hostedCheckoutId = null)

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
    public class CheckoutSidIngenicoRedirectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new IngenicoApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var redirectRef = redirectRef_example;  // string | 
            var RETURNMAC = RETURNMAC_example;  // string |  (optional) 
            var hostedCheckoutId = hostedCheckoutId_example;  // string |  (optional) 

            try
            {
                // Handle redirect from payment
                apiInstance.CheckoutSidIngenicoRedirectGet(sessionId, redirectRef, RETURNMAC, hostedCheckoutId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngenicoApi.CheckoutSidIngenicoRedirectGet: " + e.Message );
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
 **redirectRef** | **string**|  | 
 **RETURNMAC** | **string**|  | [optional] 
 **hostedCheckoutId** | **string**|  | [optional] 

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
| **302** | Redirect to session accept/cancel URL on payment completed |  * Location - the URL to redirect to Vipps - &#x60;sid&#x60; will be used to find the approval url  <br>  |
| **404** | Resource was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

