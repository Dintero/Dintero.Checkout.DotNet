# Dintero.OpenApiClient.Checkout.Api.PaymentApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutSessionPayPost**](PaymentApi.md#checkoutsessionpaypost) | **POST** /sessions/pay | Create and pay merchant initiated session
[**CheckoutSidPayPost**](PaymentApi.md#checkoutsidpaypost) | **POST** /sessions/{session_id}/pay | Initiate a checkout payment
[**CheckoutSidRedirectGet**](PaymentApi.md#checkoutsidredirectget) | **GET** /sessions/{session_id}/redirect/{redirect_ref} | Handle redirect from payment
[**CheckoutSidSantanderRedirectGet**](PaymentApi.md#checkoutsidsantanderredirectget) | **GET** /sessions/{session_id}/santander/redirect | Handle redirect from payment


<a name="checkoutsessionpaypost"></a>
# **CheckoutSessionPayPost**
> Transaction CheckoutSessionPayPost (InlineObject17 options)

Create and pay merchant initiated session

For merchant initiated payments, where the customer is not involved.  Receives a session and pays it with the given card token.  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSessionPayPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PaymentApi(config);
            var options = new InlineObject17(); // InlineObject17 | 

            try
            {
                // Create and pay merchant initiated session
                Transaction result = apiInstance.CheckoutSessionPayPost(options);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentApi.CheckoutSessionPayPost: " + e.Message );
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
 **options** | [**InlineObject17**](InlineObject17.md)|  | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transaction created |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidpaypost"></a>
# **CheckoutSidPayPost**
> PaymentResponse CheckoutSidPayPost (string sessionId, Payment payment, string ifUnmodifiedSince = null)

Initiate a checkout payment

For Express Checkout sessions, the _`order.shipping_address`_ must be set on the session, and a _`order.items.shipping_option` item is required if the session has either an _`express.shipping_address_callback_url`_ or the session has at least one option in _`express.shipping_options`_. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidPayPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PaymentApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var payment = new Payment(); // Payment | 
            var ifUnmodifiedSince = ifUnmodifiedSince_example;  // string | Optional header. The put request is discarded and a 412 is returned if the header does not match the `updated_at` property of the session. (optional) 

            try
            {
                // Initiate a checkout payment
                PaymentResponse result = apiInstance.CheckoutSidPayPost(sessionId, payment, ifUnmodifiedSince);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentApi.CheckoutSidPayPost: " + e.Message );
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
 **payment** | [**Payment**](Payment.md)|  | 
 **ifUnmodifiedSince** | **string**| Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. | [optional] 

### Return type

[**PaymentResponse**](PaymentResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | response from payment |  -  |
| **202** | response from payment |  -  |
| **400** | Bad / Invalid request |  -  |
| **412** | Precondition failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidredirectget"></a>
# **CheckoutSidRedirectGet**
> void CheckoutSidRedirectGet (string sessionId, string redirectRef)

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
    public class CheckoutSidRedirectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PaymentApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var redirectRef = redirectRef_example;  // string | 

            try
            {
                // Handle redirect from payment
                apiInstance.CheckoutSidRedirectGet(sessionId, redirectRef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentApi.CheckoutSidRedirectGet: " + e.Message );
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

<a name="checkoutsidsantanderredirectget"></a>
# **CheckoutSidSantanderRedirectGet**
> void CheckoutSidSantanderRedirectGet (string sessionId)

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
    public class CheckoutSidSantanderRedirectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PaymentApi(config);
            var sessionId = sessionId_example;  // string | The session ID

            try
            {
                // Handle redirect from payment
                apiInstance.CheckoutSidSantanderRedirectGet(sessionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentApi.CheckoutSidSantanderRedirectGet: " + e.Message );
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

