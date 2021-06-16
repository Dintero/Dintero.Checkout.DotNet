# Dintero.OpenApiClient.Checkout.Api.NetaxeptApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutNetaxeptWebhooksPost**](NetaxeptApi.md#checkoutnetaxeptwebhookspost) | **POST** /events/gateways/netaxept/transaction/hooks | Handle Netaxept callback
[**CheckoutSidNetaxeptHtmlGet**](NetaxeptApi.md#checkoutsidnetaxepthtmlget) | **GET** /view/{session_id}/netaxept | Redirect to Netaxept hosted payment window
[**CheckoutSidNetaxeptRedirectGet**](NetaxeptApi.md#checkoutsidnetaxeptredirectget) | **GET** /sessions/{session_id}/netaxept/redirect/{redirect_ref} | Handle redirect from payment


<a name="checkoutnetaxeptwebhookspost"></a>
# **CheckoutNetaxeptWebhooksPost**
> void CheckoutNetaxeptWebhooksPost (InlineObject16 data)

Handle Netaxept callback

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutNetaxeptWebhooksPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new NetaxeptApi(config);
            var data = new InlineObject16(); // InlineObject16 | 

            try
            {
                // Handle Netaxept callback
                apiInstance.CheckoutNetaxeptWebhooksPost(data);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetaxeptApi.CheckoutNetaxeptWebhooksPost: " + e.Message );
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
 **data** | [**InlineObject16**](InlineObject16.md)|  | 

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

<a name="checkoutsidnetaxepthtmlget"></a>
# **CheckoutSidNetaxeptHtmlGet**
> void CheckoutSidNetaxeptHtmlGet (string sessionId, string language = null)

Redirect to Netaxept hosted payment window

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidNetaxeptHtmlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new NetaxeptApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var language = language_example;  // string | Indicates which language is used in the Netaxept hosted payment window  (optional)  (default to no_NO)

            try
            {
                // Redirect to Netaxept hosted payment window
                apiInstance.CheckoutSidNetaxeptHtmlGet(sessionId, language);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetaxeptApi.CheckoutSidNetaxeptHtmlGet: " + e.Message );
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
 **language** | **string**| Indicates which language is used in the Netaxept hosted payment window  | [optional] [default to no_NO]

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Netaxept hosted payment window |  * Location - the URL to redirect to Vipps - &#x60;sid&#x60; will be used to find the approval url  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidnetaxeptredirectget"></a>
# **CheckoutSidNetaxeptRedirectGet**
> void CheckoutSidNetaxeptRedirectGet (string sessionId, string redirectRef, string transactionId = null, string responseCode = null)

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
    public class CheckoutSidNetaxeptRedirectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new NetaxeptApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var redirectRef = redirectRef_example;  // string | 
            var transactionId = transactionId_example;  // string |  (optional) 
            var responseCode = responseCode_example;  // string |  (optional) 

            try
            {
                // Handle redirect from payment
                apiInstance.CheckoutSidNetaxeptRedirectGet(sessionId, redirectRef, transactionId, responseCode);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetaxeptApi.CheckoutSidNetaxeptRedirectGet: " + e.Message );
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
 **transactionId** | **string**|  | [optional] 
 **responseCode** | **string**|  | [optional] 

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

