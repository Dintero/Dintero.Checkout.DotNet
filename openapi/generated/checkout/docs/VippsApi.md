# Dintero.OpenApiClient.Checkout.Api.VippsApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutSidHtmlVippsGet**](VippsApi.md#checkoutsidhtmlvippsget) | **GET** /view/{session_id}/vipps | Get the Vipps push notification page
[**CheckoutSidVippsPaymentsOrderidPost**](VippsApi.md#checkoutsidvippspaymentsorderidpost) | **POST** /sessions/{session_id}/vipps/v2/payments/{order_id} | Handle Vipps callback after the payment request


<a name="checkoutsidhtmlvippsget"></a>
# **CheckoutSidHtmlVippsGet**
> void CheckoutSidHtmlVippsGet (string sessionId)

Get the Vipps push notification page

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidHtmlVippsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VippsApi(config);
            var sessionId = sessionId_example;  // string | The session ID

            try
            {
                // Get the Vipps push notification page
                apiInstance.CheckoutSidHtmlVippsGet(sessionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VippsApi.CheckoutSidHtmlVippsGet: " + e.Message );
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
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Checkout page |  * Location - the URL to redirect to Vipps - &#x60;sid&#x60; will be used to find the approval url  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidvippspaymentsorderidpost"></a>
# **CheckoutSidVippsPaymentsOrderidPost**
> void CheckoutSidVippsPaymentsOrderidPost (string sessionId, string orderId, UNKNOWN_BASE_TYPE callback)

Handle Vipps callback after the payment request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidVippsPaymentsOrderidPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VippsApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var orderId = orderId_example;  // string | 
            var callback = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Handle Vipps callback after the payment request
                apiInstance.CheckoutSidVippsPaymentsOrderidPost(sessionId, orderId, callback);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VippsApi.CheckoutSidVippsPaymentsOrderidPost: " + e.Message );
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
 **orderId** | **string**|  | 
 **callback** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

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

