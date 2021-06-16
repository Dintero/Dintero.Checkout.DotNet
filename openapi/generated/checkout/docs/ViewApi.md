# Dintero.OpenApiClient.Checkout.Api.ViewApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutSidHtmlGet**](ViewApi.md#checkoutsidhtmlget) | **GET** /view/{session_id} | Get the Checkout page
[**CheckoutSidJsonGet**](ViewApi.md#checkoutsidjsonget) | **GET** /view/{session_id}/session | Get checkout details
[**CheckoutSidJsonOrderAddressesPut**](ViewApi.md#checkoutsidjsonorderaddressesput) | **PUT** /view/{session_id}/session/order/addresses | Set Express Checkout addresses
[**CheckoutSidJsonOrderDiscountCodesPut**](ViewApi.md#checkoutsidjsonorderdiscountcodesput) | **PUT** /view/{session_id}/session/order/discount_codes | Set Express Checkout discount codes
[**CheckoutSidJsonOrderItemsShippingOptionPut**](ViewApi.md#checkoutsidjsonorderitemsshippingoptionput) | **PUT** /view/{session_id}/session/order/shipping_option | Set Express Checkout shipping option
[**CheckoutSidJsonOrderShippingAddressPut**](ViewApi.md#checkoutsidjsonordershippingaddressput) | **PUT** /view/{session_id}/session/order/shipping_address | Set Express Checkout shipping address
[**CheckoutSidLock**](ViewApi.md#checkoutsidlock) | **POST** /view/{session_id}/session/lock | Lock a checkout session
[**CheckoutSidPaymentsProductTypePost**](ViewApi.md#checkoutsidpaymentsproducttypepost) | **POST** /view/{session_id}/payments/{payment_product_type} | Get payment operations
[**CheckoutSidSendScc**](ViewApi.md#checkoutsidsendscc) | **POST** /view/{session_id}/session/publish/scc | Send a verification code to the customer
[**ViewSidSessionAbandonPost**](ViewApi.md#viewsidsessionabandonpost) | **POST** /view/{session_id}/session/abandon | Abandon a checkout payment


<a name="checkoutsidhtmlget"></a>
# **CheckoutSidHtmlGet**
> void CheckoutSidHtmlGet (string sessionId, string language = null, string ui = null, string scc = null)

Get the Checkout page

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidHtmlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var language = language_example;  // string |  (optional) 
            var ui = ui_example;  // string |  (optional) 
            var scc = scc_example;  // string | Optional query parameter. SMS-confirm-code. To verify the identity of the payee. (optional) 

            try
            {
                // Get the Checkout page
                apiInstance.CheckoutSidHtmlGet(sessionId, language, ui, scc);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.CheckoutSidHtmlGet: " + e.Message );
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
 **language** | **string**|  | [optional] 
 **ui** | **string**|  | [optional] 
 **scc** | **string**| Optional query parameter. SMS-confirm-code. To verify the identity of the payee. | [optional] 

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

<a name="checkoutsidjsonget"></a>
# **CheckoutSidJsonGet**
> InlineResponse20012 CheckoutSidJsonGet (string sessionId)

Get checkout details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidJsonGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewApi(config);
            var sessionId = sessionId_example;  // string | The session ID

            try
            {
                // Get checkout details
                InlineResponse20012 result = apiInstance.CheckoutSidJsonGet(sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.CheckoutSidJsonGet: " + e.Message );
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

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | checkout session |  -  |
| **404** | Session not found error |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidjsonorderaddressesput"></a>
# **CheckoutSidJsonOrderAddressesPut**
> InlineResponse20013 CheckoutSidJsonOrderAddressesPut (string sessionId, ViewSessionUpdateAddress options, string ifUnmodifiedSince = null)

Set Express Checkout addresses

Changes the `order.shipping_address` and `order.billing_address` submitted by end user in the Express Checkout flow.  If the _`express.shipping_address_callback_url`_ is set, the _`express.shipping_options`_ in the response will be updated to show the available shipping options for the updated address. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidJsonOrderAddressesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var options = new ViewSessionUpdateAddress(); // ViewSessionUpdateAddress | 
            var ifUnmodifiedSince = ifUnmodifiedSince_example;  // string | Optional header. The put request is discarded and a 412 is returned if the header does not match the `updated_at` property of the session. (optional) 

            try
            {
                // Set Express Checkout addresses
                InlineResponse20013 result = apiInstance.CheckoutSidJsonOrderAddressesPut(sessionId, options, ifUnmodifiedSince);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.CheckoutSidJsonOrderAddressesPut: " + e.Message );
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
 **options** | [**ViewSessionUpdateAddress**](ViewSessionUpdateAddress.md)|  | 
 **ifUnmodifiedSince** | **string**| Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | checkout session |  -  |
| **404** | Resource was not found |  -  |
| **412** | Precondition failed |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidjsonorderdiscountcodesput"></a>
# **CheckoutSidJsonOrderDiscountCodesPut**
> InlineResponse20013 CheckoutSidJsonOrderDiscountCodesPut (string sessionId, ViewSessionUpdateDiscountCodes options, string ifUnmodifiedSince = null)

Set Express Checkout discount codes

Changes the `order.discount_codes` submitted by end user in the Express Checkout flow.  If the _`express.discount_codes_callback_url`_ is set, the session will be updated with discount on the order and the shipping options. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidJsonOrderDiscountCodesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var options = new ViewSessionUpdateDiscountCodes(); // ViewSessionUpdateDiscountCodes | 
            var ifUnmodifiedSince = ifUnmodifiedSince_example;  // string | Optional header. The put request is discarded and a 412 is returned if the header does not match the `updated_at` property of the session. (optional) 

            try
            {
                // Set Express Checkout discount codes
                InlineResponse20013 result = apiInstance.CheckoutSidJsonOrderDiscountCodesPut(sessionId, options, ifUnmodifiedSince);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.CheckoutSidJsonOrderDiscountCodesPut: " + e.Message );
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
 **options** | [**ViewSessionUpdateDiscountCodes**](ViewSessionUpdateDiscountCodes.md)|  | 
 **ifUnmodifiedSince** | **string**| Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Session updated with discounts |  -  |
| **204** | No discounts |  -  |
| **404** | Resource was not found |  -  |
| **412** | Precondition failed |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidjsonorderitemsshippingoptionput"></a>
# **CheckoutSidJsonOrderItemsShippingOptionPut**
> InlineResponse20013 CheckoutSidJsonOrderItemsShippingOptionPut (string sessionId, ShippingOption options, string ifUnmodifiedSince = null)

Set Express Checkout shipping option

Changes the selected shipping_option, submitted by end user in the  Express Checkout flow. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidJsonOrderItemsShippingOptionPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var options = new ShippingOption(); // ShippingOption | 
            var ifUnmodifiedSince = ifUnmodifiedSince_example;  // string | Optional header. The put request is discarded and a 412 is returned if the header does not match the `updated_at` property of the session. (optional) 

            try
            {
                // Set Express Checkout shipping option
                InlineResponse20013 result = apiInstance.CheckoutSidJsonOrderItemsShippingOptionPut(sessionId, options, ifUnmodifiedSince);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.CheckoutSidJsonOrderItemsShippingOptionPut: " + e.Message );
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
 **options** | [**ShippingOption**](ShippingOption.md)|  | 
 **ifUnmodifiedSince** | **string**| Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | checkout session |  -  |
| **404** | Resource was not found |  -  |
| **412** | Precondition failed |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidjsonordershippingaddressput"></a>
# **CheckoutSidJsonOrderShippingAddressPut**
> InlineResponse20013 CheckoutSidJsonOrderShippingAddressPut (string sessionId, OrderAddress options, string ifUnmodifiedSince = null)

Set Express Checkout shipping address

Changes the order.shipping_address, submitted by end user in the Express Checkout flow.  If the _`express.shipping_address_callback_url`_ is set, the _`express.shipping_options`_ in the response will be updated to show the available shipping options for the updated address. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidJsonOrderShippingAddressPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var options = new OrderAddress(); // OrderAddress | 
            var ifUnmodifiedSince = ifUnmodifiedSince_example;  // string | Optional header. The put request is discarded and a 412 is returned if the header does not match the `updated_at` property of the session. (optional) 

            try
            {
                // Set Express Checkout shipping address
                InlineResponse20013 result = apiInstance.CheckoutSidJsonOrderShippingAddressPut(sessionId, options, ifUnmodifiedSince);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.CheckoutSidJsonOrderShippingAddressPut: " + e.Message );
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
 **options** | [**OrderAddress**](OrderAddress.md)|  | 
 **ifUnmodifiedSince** | **string**| Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | checkout session |  -  |
| **404** | Resource was not found |  -  |
| **412** | Precondition failed |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidlock"></a>
# **CheckoutSidLock**
> SessionLock CheckoutSidLock (string sessionId)

Lock a checkout session

When locked, the session can not be paid. Locking the session is only available when express is enabled. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidLockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewApi(config);
            var sessionId = sessionId_example;  // string | The session ID

            try
            {
                // Lock a checkout session
                SessionLock result = apiInstance.CheckoutSidLock(sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.CheckoutSidLock: " + e.Message );
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

[**SessionLock**](SessionLock.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Information about the lock |  -  |
| **400** | Bad / Invalid request |  -  |
| **412** | Precondition failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidpaymentsproducttypepost"></a>
# **CheckoutSidPaymentsProductTypePost**
> PaymentOperations CheckoutSidPaymentsProductTypePost (string sessionId, string paymentProductType, string language = null)

Get payment operations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidPaymentsProductTypePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var paymentProductType = paymentProductType_example;  // string | 
            var language = language_example;  // string | Preferred language to use in the payment operation. Example: `nb-NO`  (optional) 

            try
            {
                // Get payment operations
                PaymentOperations result = apiInstance.CheckoutSidPaymentsProductTypePost(sessionId, paymentProductType, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.CheckoutSidPaymentsProductTypePost: " + e.Message );
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
 **language** | **string**| Preferred language to use in the payment operation. Example: &#x60;nb-NO&#x60;  | [optional] 

### Return type

[**PaymentOperations**](PaymentOperations.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payment Operations |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidsendscc"></a>
# **CheckoutSidSendScc**
> void CheckoutSidSendScc (string sessionId)

Send a verification code to the customer

Send a SMS with a payment verification code 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSidSendSccExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewApi(config);
            var sessionId = sessionId_example;  // string | The session ID

            try
            {
                // Send a verification code to the customer
                apiInstance.CheckoutSidSendScc(sessionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.CheckoutSidSendScc: " + e.Message );
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Verification code sent |  -  |
| **202** | Verification code resent |  -  |
| **400** | Bad / Invalid request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsidsessionabandonpost"></a>
# **ViewSidSessionAbandonPost**
> void ViewSidSessionAbandonPost (string sessionId)

Abandon a checkout payment

Abandon a checkout payment before completing payment. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class ViewSidSessionAbandonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewApi(config);
            var sessionId = sessionId_example;  // string | The session ID

            try
            {
                // Abandon a checkout payment
                apiInstance.ViewSidSessionAbandonPost(sessionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.ViewSidSessionAbandonPost: " + e.Message );
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Rejected to session URL with status cancelled |  * Location - the URL to redirect to Vipps - &#x60;sid&#x60; will be used to find the approval url  <br>  |
| **404** | Resource was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

