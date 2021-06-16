# Dintero.OpenApiClient.Checkout.Api.SwishApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutSidSwishGet**](SwishApi.md#checkoutsidswishget) | **GET** /view/{session_id}/swish/{payment_request_id}/status | Get status about the Swish session. 
[**CheckoutSidSwishRedirectGet**](SwishApi.md#checkoutsidswishredirectget) | **GET** /sessions/{session_id}/swish/redirect/{redirect_ref} | Handle redirect from payment
[**CheckoutSwishPaymentCallbackPost**](SwishApi.md#checkoutswishpaymentcallbackpost) | **POST** /events/gateways/swish/transaction/payment/{session_id}/{callback_ref} | Handle Swish payment callback
[**CheckoutSwishRefundCallbackPost**](SwishApi.md#checkoutswishrefundcallbackpost) | **POST** /events/gateways/swish/transaction/refund/{id}/{callback_ref} | Handle Swish refund callback


<a name="checkoutsidswishget"></a>
# **CheckoutSidSwishGet**
> SwishPollStatus CheckoutSidSwishGet (string sessionId, string paymentRequestId)

Get status about the Swish session. 

Get status about the Swish session. Will check if the session contains a transaction_id, and if the transaction is paid with the given Swish payment_request_id. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidSwishGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SwishApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var paymentRequestId = paymentRequestId_example;  // string | 

            try
            {
                // Get status about the Swish session. 
                SwishPollStatus result = apiInstance.CheckoutSidSwishGet(sessionId, paymentRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SwishApi.CheckoutSidSwishGet: " + e.Message );
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
 **paymentRequestId** | **string**|  | 

### Return type

[**SwishPollStatus**](SwishPollStatus.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Swish payment completed, go to next step. |  -  |
| **202** | Swish payment not completed, keep polling. |  -  |
| **404** | Swish payment not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidswishredirectget"></a>
# **CheckoutSidSwishRedirectGet**
> void CheckoutSidSwishRedirectGet (string sessionId, string redirectRef)

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
    public class CheckoutSidSwishRedirectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SwishApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var redirectRef = redirectRef_example;  // string | 

            try
            {
                // Handle redirect from payment
                apiInstance.CheckoutSidSwishRedirectGet(sessionId, redirectRef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SwishApi.CheckoutSidSwishRedirectGet: " + e.Message );
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

<a name="checkoutswishpaymentcallbackpost"></a>
# **CheckoutSwishPaymentCallbackPost**
> void CheckoutSwishPaymentCallbackPost (string sessionId, string callbackRef, SwishPaymentCallback data)

Handle Swish payment callback

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSwishPaymentCallbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SwishApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var callbackRef = callbackRef_example;  // string | 
            var data = new SwishPaymentCallback(); // SwishPaymentCallback | Content of payment callback

            try
            {
                // Handle Swish payment callback
                apiInstance.CheckoutSwishPaymentCallbackPost(sessionId, callbackRef, data);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SwishApi.CheckoutSwishPaymentCallbackPost: " + e.Message );
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
 **callbackRef** | **string**|  | 
 **data** | [**SwishPaymentCallback**](SwishPaymentCallback.md)| Content of payment callback | 

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

<a name="checkoutswishrefundcallbackpost"></a>
# **CheckoutSwishRefundCallbackPost**
> void CheckoutSwishRefundCallbackPost (string id, string callbackRef, SwishRefundCallback data)

Handle Swish refund callback

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSwishRefundCallbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SwishApi(config);
            var id = id_example;  // string | The ID of the transaction
            var callbackRef = callbackRef_example;  // string | 
            var data = new SwishRefundCallback(); // SwishRefundCallback | Content of refund callback

            try
            {
                // Handle Swish refund callback
                apiInstance.CheckoutSwishRefundCallbackPost(id, callbackRef, data);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SwishApi.CheckoutSwishRefundCallbackPost: " + e.Message );
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
 **id** | **string**| The ID of the transaction | 
 **callbackRef** | **string**|  | 
 **data** | [**SwishRefundCallback**](SwishRefundCallback.md)| Content of refund callback | 

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
| **200** | callback handled |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

