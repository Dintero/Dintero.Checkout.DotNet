# Dintero.OpenApiClient.Checkout.Api.PayexApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutSidCallbackPost**](PayexApi.md#checkoutsidcallbackpost) | **POST** /sessions/{session_id}/payex/callback/{payment_product_type} | Handle Payex callback after a change or update 
[**CheckoutSidPayexRedirectGet**](PayexApi.md#checkoutsidpayexredirectget) | **GET** /sessions/{session_id}/payex/redirect/{action}/{payment_product_type} | Handle redirect from payment


<a name="checkoutsidcallbackpost"></a>
# **CheckoutSidCallbackPost**
> void CheckoutSidCallbackPost (string sessionId, string paymentProductType, UNKNOWN_BASE_TYPE callback, string token = null)

Handle Payex callback after a change or update 

Creates a transaction from the session with status determined by the payment status provided by Payex. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidCallbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PayexApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var paymentProductType = paymentProductType_example;  // string | 
            var callback = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
            var token = token_example;  // string |  (optional) 

            try
            {
                // Handle Payex callback after a change or update 
                apiInstance.CheckoutSidCallbackPost(sessionId, paymentProductType, callback, token);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayexApi.CheckoutSidCallbackPost: " + e.Message );
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
 **paymentProductType** | **string**|  | 
 **callback** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 
 **token** | **string**|  | [optional] 

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
| **202** | callback handled |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidpayexredirectget"></a>
# **CheckoutSidPayexRedirectGet**
> void CheckoutSidPayexRedirectGet (string sessionId, string action, string paymentProductType)

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
    public class CheckoutSidPayexRedirectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PayexApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var action = action_example;  // string | 
            var paymentProductType = paymentProductType_example;  // string | 

            try
            {
                // Handle redirect from payment
                apiInstance.CheckoutSidPayexRedirectGet(sessionId, action, paymentProductType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayexApi.CheckoutSidPayexRedirectGet: " + e.Message );
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
 **action** | **string**|  | 
 **paymentProductType** | **string**|  | 

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

