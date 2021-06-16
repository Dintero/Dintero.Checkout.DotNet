# Dintero.OpenApiClient.Checkout.Api.SessionApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutPaymentTokenSessionPost**](SessionApi.md#checkoutpaymenttokensessionpost) | **POST** /sessions/payment-token | Payment token session
[**CheckoutSessionCancelPost**](SessionApi.md#checkoutsessioncancelpost) | **POST** /sessions/{session_id}/cancel | Cancel session
[**CheckoutSessionGet**](SessionApi.md#checkoutsessionget) | **GET** /sessions/{session_id} | Get checkout session details
[**CheckoutSessionPost**](SessionApi.md#checkoutsessionpost) | **POST** /sessions | Create a checkout session
[**CheckoutSessionProfilePost**](SessionApi.md#checkoutsessionprofilepost) | **POST** /sessions-profile | Create checkout session from profile
[**CheckoutSessionPut**](SessionApi.md#checkoutsessionput) | **PUT** /sessions/{session_id} | Update checkout session details
[**CheckoutSessionsGet**](SessionApi.md#checkoutsessionsget) | **GET** /sessions | List checkout sessions


<a name="checkoutpaymenttokensessionpost"></a>
# **CheckoutPaymentTokenSessionPost**
> InlineResponse2008 CheckoutPaymentTokenSessionPost (InlineObject18 options, bool? includeSession = null)

Payment token session

 This endpoint lets you create payment tokens without reserving or charging any amount.  The URL returned by this endpoint opens a web site where the customer can enter their payment details, e.g. card information.  The payment details will be validated and a transaction with a payment token will be created on success containing the payment token created from the customer payment details.  - [GET /v1/transactions/{id}?includes=card.payment_token](#operation/transactions_id_get)  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutPaymentTokenSessionPostExample
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

            var apiInstance = new SessionApi(config);
            var options = new InlineObject18(); // InlineObject18 | 
            var includeSession = true;  // bool? | Include all details about the session created  (optional) 

            try
            {
                // Payment token session
                InlineResponse2008 result = apiInstance.CheckoutPaymentTokenSessionPost(options, includeSession);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionApi.CheckoutPaymentTokenSessionPost: " + e.Message );
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
 **options** | [**InlineObject18**](InlineObject18.md)|  | 
 **includeSession** | **bool?**| Include all details about the session created  | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | checkout session created |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsessioncancelpost"></a>
# **CheckoutSessionCancelPost**
> InlineResponse2009 CheckoutSessionCancelPost (string sessionId)

Cancel session

 Cancel a session  The session transaction will be voided in case where it is initialized or authorized.  Cancel is not allowed in case where the current transaction state is not initialized or authorized.  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSessionCancelPostExample
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

            var apiInstance = new SessionApi(config);
            var sessionId = sessionId_example;  // string | The session ID

            try
            {
                // Cancel session
                InlineResponse2009 result = apiInstance.CheckoutSessionCancelPost(sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionApi.CheckoutSessionCancelPost: " + e.Message );
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

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | checkout session |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsessionget"></a>
# **CheckoutSessionGet**
> InlineResponse2009 CheckoutSessionGet (string sessionId)

Get checkout session details

scopes: - admin:checkout - read:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSessionGetExample
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

            var apiInstance = new SessionApi(config);
            var sessionId = sessionId_example;  // string | The session ID

            try
            {
                // Get checkout session details
                InlineResponse2009 result = apiInstance.CheckoutSessionGet(sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionApi.CheckoutSessionGet: " + e.Message );
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

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | checkout session |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsessionpost"></a>
# **CheckoutSessionPost**
> InlineResponse2008 CheckoutSessionPost (UNKNOWN_BASE_TYPE options, bool? includeSession = null)

Create a checkout session

Create a corresponding Checkout Session for an order placed in your system  #### Session with Instabank  Note that `items` is a required property when creating a session with Instabank configured.  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSessionPostExample
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

            var apiInstance = new SessionApi(config);
            var options = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
            var includeSession = true;  // bool? | Include all details about the session created  (optional) 

            try
            {
                // Create a checkout session
                InlineResponse2008 result = apiInstance.CheckoutSessionPost(options, includeSession);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionApi.CheckoutSessionPost: " + e.Message );
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
 **includeSession** | **bool?**| Include all details about the session created  | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | checkout session created |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsessionprofilepost"></a>
# **CheckoutSessionProfilePost**
> InlineResponse2008 CheckoutSessionProfilePost (UNKNOWN_BASE_TYPE options, bool? includeSession = null)

Create checkout session from profile

Create a corresponding Checkout Session for an order placed in your system using predefined session profile  #### Session with Instabank  Note that `items` is a required property when creating a session with Instabank configured.  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSessionProfilePostExample
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

            var apiInstance = new SessionApi(config);
            var options = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
            var includeSession = true;  // bool? | Include all details about the session created  (optional) 

            try
            {
                // Create checkout session from profile
                InlineResponse2008 result = apiInstance.CheckoutSessionProfilePost(options, includeSession);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionApi.CheckoutSessionProfilePost: " + e.Message );
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
 **includeSession** | **bool?**| Include all details about the session created  | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | checkout session created |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsessionput"></a>
# **CheckoutSessionPut**
> InlineResponse2009 CheckoutSessionPut (string sessionId, UNKNOWN_BASE_TYPE options)

Update checkout session details

Session must be locked for paying before updating.  scopes: - admin:checkout - read:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSessionPutExample
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

            var apiInstance = new SessionApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var options = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Update checkout session details
                InlineResponse2009 result = apiInstance.CheckoutSessionPut(sessionId, options);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionApi.CheckoutSessionPut: " + e.Message );
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
 **options** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | checkout session |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsessionsget"></a>
# **CheckoutSessionsGet**
> List&lt;Id&gt; CheckoutSessionsGet (int? limit = null, string startingAfter = null, List<string> id = null, string search = null, List<string> transactionId = null, string createdAtGte = null, string createdAtLte = null, List<string> storeId = null)

List checkout sessions

List all Checkout sessions scopes: - admin:checkout - read:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutSessionsGetExample
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

            var apiInstance = new SessionApi(config);
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional)  (default to 10)
            var startingAfter = startingAfter_example;  // string | cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with `obj_foo`, your subsequent call can include `starting_after=obj_foo` in order to fetch the next page of the list.  (optional) 
            var id = new List<string>(); // List<string> | List of ids that should be included in the result. ?id=A&id=B&id=X  (optional) 
            var search = search_example;  // string | Will try to match the search to either merchant_reference, merchant_reference_2, or the customer name using the format `{first_name} {last_name}`.  (optional) 
            var transactionId = new List<string>(); // List<string> | The id(s) of the transaction(s) that should be included in the result (optional) 
            var createdAtGte = createdAtGte_example;  // string | Session created after (ISO 8601. We recommend using a localised ISO 8601 datetime like `2017-07-21T17:32:28Z`. If a timezone is not specified we assume UTC) (optional) 
            var createdAtLte = createdAtLte_example;  // string | Session created before a date (ISO 8601. We recommend using a localised ISO 8601 datetime like `2017-07-21T17:32:28Z`. If a timezone is not specified we assume UTC) (optional) 
            var storeId = new List<string>(); // List<string> | The store_id that the session relates to. ?store_id=A&store_id=B&store_id=X.  (optional) 

            try
            {
                // List checkout sessions
                List<Id> result = apiInstance.CheckoutSessionsGet(limit, startingAfter, id, search, transactionId, createdAtGte, createdAtLte, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionApi.CheckoutSessionsGet: " + e.Message );
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
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  | [optional] [default to 10]
 **startingAfter** | **string**| cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  | [optional] 
 **id** | [**List&lt;string&gt;**](string.md)| List of ids that should be included in the result. ?id&#x3D;A&amp;id&#x3D;B&amp;id&#x3D;X  | [optional] 
 **search** | **string**| Will try to match the search to either merchant_reference, merchant_reference_2, or the customer name using the format &#x60;{first_name} {last_name}&#x60;.  | [optional] 
 **transactionId** | [**List&lt;string&gt;**](string.md)| The id(s) of the transaction(s) that should be included in the result | [optional] 
 **createdAtGte** | **string**| Session created after (ISO 8601. We recommend using a localised ISO 8601 datetime like &#x60;2017-07-21T17:32:28Z&#x60;. If a timezone is not specified we assume UTC) | [optional] 
 **createdAtLte** | **string**| Session created before a date (ISO 8601. We recommend using a localised ISO 8601 datetime like &#x60;2017-07-21T17:32:28Z&#x60;. If a timezone is not specified we assume UTC) | [optional] 
 **storeId** | [**List&lt;string&gt;**](string.md)| The store_id that the session relates to. ?store_id&#x3D;A&amp;store_id&#x3D;B&amp;store_id&#x3D;X.  | [optional] 

### Return type

[**List&lt;Id&gt;**](Id.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list checkout sessions |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

