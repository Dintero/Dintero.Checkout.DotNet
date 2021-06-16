# Dintero.OpenApiClient.Checkout.Api.ExampleSessionCallbacksApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExampleDiscountCodesCallbackUrl**](ExampleSessionCallbacksApi.md#examplediscountcodescallbackurl) | **POST** /examples/discount_code_callback_url | Discount codes Update
[**ExampleShippingAddressCallbackUrl**](ExampleSessionCallbacksApi.md#exampleshippingaddresscallbackurl) | **POST** /examples/shipping_address_callback_url | Address Update


<a name="examplediscountcodescallbackurl"></a>
# **ExampleDiscountCodesCallbackUrl**
> InlineResponse2006 ExampleDiscountCodesCallbackUrl (UNKNOWN_BASE_TYPE options)

Discount codes Update

This API endpoint on the merchant side allows Dintero to get shipping_options and order with discounts based on the provided session that had its `order.discount_codes` updated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class ExampleDiscountCodesCallbackUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExampleSessionCallbacksApi(config);
            var options = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Discount codes Update
                InlineResponse2006 result = apiInstance.ExampleDiscountCodesCallbackUrl(options);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExampleSessionCallbacksApi.ExampleDiscountCodesCallbackUrl: " + e.Message );
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
 **options** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Session Discount update |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exampleshippingaddresscallbackurl"></a>
# **ExampleShippingAddressCallbackUrl**
> InlineResponse2007 ExampleShippingAddressCallbackUrl (UNKNOWN_BASE_TYPE options)

Address Update

This API endpoint on the merchant side allows Dintero to get shipping options based on the provided session after an address update 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class ExampleShippingAddressCallbackUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExampleSessionCallbacksApi(config);
            var options = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Address Update
                InlineResponse2007 result = apiInstance.ExampleShippingAddressCallbackUrl(options);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExampleSessionCallbacksApi.ExampleShippingAddressCallbackUrl: " + e.Message );
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
 **options** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Session shipping options update |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

