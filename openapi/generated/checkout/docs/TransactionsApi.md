# Dintero.OpenApiClient.Checkout.Api.TransactionsApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TransactionsEventsSettlementsPost**](TransactionsApi.md#transactionseventssettlementspost) | **POST** /transactions/events/settlements | Update transactions with settlements
[**TransactionsGet**](TransactionsApi.md#transactionsget) | **GET** /transactions | List all transactions
[**TransactionsIdCapturePost**](TransactionsApi.md#transactionsidcapturepost) | **POST** /transactions/{id}/capture | Capture a transaction
[**TransactionsIdGet**](TransactionsApi.md#transactionsidget) | **GET** /transactions/{id} | Get a transaction
[**TransactionsIdPut**](TransactionsApi.md#transactionsidput) | **PUT** /transactions/{id} | Update a transaction
[**TransactionsIdRefundPost**](TransactionsApi.md#transactionsidrefundpost) | **POST** /transactions/{id}/refund | Refund transaction
[**TransactionsIdVoidPost**](TransactionsApi.md#transactionsidvoidpost) | **POST** /transactions/{id}/void | Void transaction


<a name="transactionseventssettlementspost"></a>
# **TransactionsEventsSettlementsPost**
> List&lt;Transaction&gt; TransactionsEventsSettlementsPost (UNKNOWN_BASE_TYPE data)

Update transactions with settlements

Add settlement events to list of transactions  scopes: - admin:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class TransactionsEventsSettlementsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionsApi(config);
            var data = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Update transactions with settlements
                List<Transaction> result = apiInstance.TransactionsEventsSettlementsPost(data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionsEventsSettlementsPost: " + e.Message );
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
 **data** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**List&lt;Transaction&gt;**](Transaction.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transactions updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionsget"></a>
# **TransactionsGet**
> List&lt;Transaction&gt; TransactionsGet (List<string> id = null, int? limit = null, string startingAfter = null, List<string> status = null, List<string> paymentProduct = null, List<string> paymentProductType = null, List<string> cardBrand = null, string merchantReference = null, string merchantReference2 = null, List<string> sessionId = null, List<string> storeId = null, List<string> payoutCorrelationId = null, List<string> currency = null, int? amount = null, int? amountGte = null, int? amountLte = null, string createdAtGte = null, string createdAtLte = null, string capturedAtGte = null, string capturedAtLte = null, string refundedAtGte = null, string refundedAtLte = null, string search = null)

List all transactions

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
    public class TransactionsGetExample
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

            var apiInstance = new TransactionsApi(config);
            var id = new List<string>(); // List<string> | List of ids that should be included in the result. ?id=A&id=B&id=X  (optional) 
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional)  (default to 10)
            var startingAfter = startingAfter_example;  // string | cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with `obj_foo`, your subsequent call can include `starting_after=obj_foo` in order to fetch the next page of the list.  (optional) 
            var status = status_example;  // List<string> | The status of the transaction.  (optional) 
            var paymentProduct = new List<string>(); // List<string> | The type of payment product used (optional) 
            var paymentProductType = new List<string>(); // List<string> | The payment product type (optional) 
            var cardBrand = new List<string>(); // List<string> | The card brand for the payment (optional) 
            var merchantReference = merchantReference_example;  // string | The merchant reference used (optional) 
            var merchantReference2 = merchantReference2_example;  // string | The second merchant reference on the transaction (optional) 
            var sessionId = new List<string>(); // List<string> | The session id(s) associated with the transactions. ?session_id=A&session_id=B&session_id=X.  (optional) 
            var storeId = new List<string>(); // List<string> | The store_id that the transaction belongs to. ?store_id=A&store_id=B&store_id=X.  (optional) 
            var payoutCorrelationId = new List<string>(); // List<string> | Filter by the `payout_correlation_id`. Different format between payment providers. ?payout_correlation_id=A,B  (optional) 
            var currency = new List<string>(); // List<string> | The currency of the transaction. ?currency=NOK&currency=SEK.  (optional) 
            var amount = 56;  // int? | Exact transaction amount, amount authorized. (optional) 
            var amountGte = 56;  // int? | Lower limit for filtering on transaction amount, amount authorized. (optional) 
            var amountLte = 56;  // int? | Upper limit for filtering on transaction amount, amount authorized. (optional) 
            var createdAtGte = createdAtGte_example;  // string | Transaction created after (ISO 8601. We recommend using a localised ISO 8601 datetime like `2017-07-21T17:32:28Z`. If a timezone is not specified we assume UTC) (optional) 
            var createdAtLte = createdAtLte_example;  // string | Transaction created before a date (ISO 8601. We recommend using a localised ISO 8601 datetime like `2017-07-21T17:32:28Z`. If a timezone is not specified we assume UTC) (optional) 
            var capturedAtGte = capturedAtGte_example;  // string | Transaction captured after date (This param is subject to change in the future) (ISO 8601. We recommend using a localised ISO 8601 datetime like `2017-07-21T17:32:28Z`. If a timezone is not specified we assume UTC) (optional) 
            var capturedAtLte = capturedAtLte_example;  // string | Transaction captured before date (This param is subject to change in the future) (ISO 8601. We recommend using a localised ISO 8601 datetime like `2017-07-21T17:32:28Z`. If a timezone is not specified we assume UTC) (optional) 
            var refundedAtGte = refundedAtGte_example;  // string | Transaction refunded after date (This param is subject to change in the future) (ISO 8601. We recommend using a localised ISO 8601 datetime like `2017-07-21T17:32:28Z`. If a timezone is not specified we assume UTC) (optional) 
            var refundedAtLte = refundedAtLte_example;  // string | Transaction refunded before date (This param is subject to change in the future) (ISO 8601. We recommend using a localised ISO 8601 datetime like `2017-07-21T17:32:28Z`. If a timezone is not specified we assume UTC) (optional) 
            var search = search_example;  // string | Will try to match the search to either transaction_id, session_id or merchant_reference, merchant_reference_2, phone_number, email or the customer name using the format `{first_name} {last_name}`.  (optional) 

            try
            {
                // List all transactions
                List<Transaction> result = apiInstance.TransactionsGet(id, limit, startingAfter, status, paymentProduct, paymentProductType, cardBrand, merchantReference, merchantReference2, sessionId, storeId, payoutCorrelationId, currency, amount, amountGte, amountLte, createdAtGte, createdAtLte, capturedAtGte, capturedAtLte, refundedAtGte, refundedAtLte, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionsGet: " + e.Message );
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
 **id** | [**List&lt;string&gt;**](string.md)| List of ids that should be included in the result. ?id&#x3D;A&amp;id&#x3D;B&amp;id&#x3D;X  | [optional] 
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  | [optional] [default to 10]
 **startingAfter** | **string**| cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  | [optional] 
 **status** | **List&lt;string&gt;**| The status of the transaction.  | [optional] 
 **paymentProduct** | [**List&lt;string&gt;**](string.md)| The type of payment product used | [optional] 
 **paymentProductType** | [**List&lt;string&gt;**](string.md)| The payment product type | [optional] 
 **cardBrand** | [**List&lt;string&gt;**](string.md)| The card brand for the payment | [optional] 
 **merchantReference** | **string**| The merchant reference used | [optional] 
 **merchantReference2** | **string**| The second merchant reference on the transaction | [optional] 
 **sessionId** | [**List&lt;string&gt;**](string.md)| The session id(s) associated with the transactions. ?session_id&#x3D;A&amp;session_id&#x3D;B&amp;session_id&#x3D;X.  | [optional] 
 **storeId** | [**List&lt;string&gt;**](string.md)| The store_id that the transaction belongs to. ?store_id&#x3D;A&amp;store_id&#x3D;B&amp;store_id&#x3D;X.  | [optional] 
 **payoutCorrelationId** | [**List&lt;string&gt;**](string.md)| Filter by the &#x60;payout_correlation_id&#x60;. Different format between payment providers. ?payout_correlation_id&#x3D;A,B  | [optional] 
 **currency** | [**List&lt;string&gt;**](string.md)| The currency of the transaction. ?currency&#x3D;NOK&amp;currency&#x3D;SEK.  | [optional] 
 **amount** | **int?**| Exact transaction amount, amount authorized. | [optional] 
 **amountGte** | **int?**| Lower limit for filtering on transaction amount, amount authorized. | [optional] 
 **amountLte** | **int?**| Upper limit for filtering on transaction amount, amount authorized. | [optional] 
 **createdAtGte** | **string**| Transaction created after (ISO 8601. We recommend using a localised ISO 8601 datetime like &#x60;2017-07-21T17:32:28Z&#x60;. If a timezone is not specified we assume UTC) | [optional] 
 **createdAtLte** | **string**| Transaction created before a date (ISO 8601. We recommend using a localised ISO 8601 datetime like &#x60;2017-07-21T17:32:28Z&#x60;. If a timezone is not specified we assume UTC) | [optional] 
 **capturedAtGte** | **string**| Transaction captured after date (This param is subject to change in the future) (ISO 8601. We recommend using a localised ISO 8601 datetime like &#x60;2017-07-21T17:32:28Z&#x60;. If a timezone is not specified we assume UTC) | [optional] 
 **capturedAtLte** | **string**| Transaction captured before date (This param is subject to change in the future) (ISO 8601. We recommend using a localised ISO 8601 datetime like &#x60;2017-07-21T17:32:28Z&#x60;. If a timezone is not specified we assume UTC) | [optional] 
 **refundedAtGte** | **string**| Transaction refunded after date (This param is subject to change in the future) (ISO 8601. We recommend using a localised ISO 8601 datetime like &#x60;2017-07-21T17:32:28Z&#x60;. If a timezone is not specified we assume UTC) | [optional] 
 **refundedAtLte** | **string**| Transaction refunded before date (This param is subject to change in the future) (ISO 8601. We recommend using a localised ISO 8601 datetime like &#x60;2017-07-21T17:32:28Z&#x60;. If a timezone is not specified we assume UTC) | [optional] 
 **search** | **string**| Will try to match the search to either transaction_id, session_id or merchant_reference, merchant_reference_2, phone_number, email or the customer name using the format &#x60;{first_name} {last_name}&#x60;.  | [optional] 

### Return type

[**List&lt;Transaction&gt;**](Transaction.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transactions |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionsidcapturepost"></a>
# **TransactionsIdCapturePost**
> InlineResponse20010 TransactionsIdCapturePost (string id, InlineObject20 data = null)

Capture a transaction

Captures a transaction that was created with the Checkout endpoint with a `capture_now` value of `false`.  #### Capture Instabank transaction  Note that `items` is required when capturing a transaction with `payment_product=instabank`. The items must include the lines to Capture, with `line_id`, `quantity` and `amount`.  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class TransactionsIdCapturePostExample
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

            var apiInstance = new TransactionsApi(config);
            var id = id_example;  // string | The ID of the transaction
            var data = new InlineObject20(); // InlineObject20 |  (optional) 

            try
            {
                // Capture a transaction
                InlineResponse20010 result = apiInstance.TransactionsIdCapturePost(id, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionsIdCapturePost: " + e.Message );
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
 **data** | [**InlineObject20**](InlineObject20.md)|  | [optional] 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Capture created |  -  |
| **202** | Request accepted for processing.  |  * event-request-id - The request_id of the event that was accepted for processing. The transaction will be updated with a new event with &#x60;correlation_request_id&#x60; set when the operation completes.  <br>  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |
| **503** | Processor temporarily unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionsidget"></a>
# **TransactionsIdGet**
> InlineResponse20010 TransactionsIdGet (string id, List<string> includes = null)

Get a transaction

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
    public class TransactionsIdGetExample
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

            var apiInstance = new TransactionsApi(config);
            var id = id_example;  // string | The ID of the transaction
            var includes = includes_example;  // List<string> | Include aditional data that are by default excluded from the transaction details.  - **`card.payment_token`**: Include the payment_token generated from the transaction.   Only available for transaction with a session that enabled generate_payment_token. - **`session`** Include the session that the transaction resulted from  (optional) 

            try
            {
                // Get a transaction
                InlineResponse20010 result = apiInstance.TransactionsIdGet(id, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionsIdGet: " + e.Message );
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
 **includes** | **List&lt;string&gt;**| Include aditional data that are by default excluded from the transaction details.  - **&#x60;card.payment_token&#x60;**: Include the payment_token generated from the transaction.   Only available for transaction with a session that enabled generate_payment_token. - **&#x60;session&#x60;** Include the session that the transaction resulted from  | [optional] 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transaction |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |
| **503** | Processor temporarily unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionsidput"></a>
# **TransactionsIdPut**
> InlineResponse20010 TransactionsIdPut (string id, InlineObject19 data = null)

Update a transaction

scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class TransactionsIdPutExample
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

            var apiInstance = new TransactionsApi(config);
            var id = id_example;  // string | The ID of the transaction
            var data = new InlineObject19(); // InlineObject19 |  (optional) 

            try
            {
                // Update a transaction
                InlineResponse20010 result = apiInstance.TransactionsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionsIdPut: " + e.Message );
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
 **data** | [**InlineObject19**](InlineObject19.md)|  | [optional] 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transaction |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |
| **503** | Processor temporarily unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionsidrefundpost"></a>
# **TransactionsIdRefundPost**
> InlineResponse20010 TransactionsIdRefundPost (string id, InlineObject21 refunds)

Refund transaction

Once a transaction has been successfully captured, a refund operation is available. Like other operations, refund can be partial or total  #### Refund Instabank transaction  Note that `items` is required when refunding a transaction with `payment_product=instabank`. The items must include the lines to Refund, with `line_id`, `quantity` and `amount`.  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class TransactionsIdRefundPostExample
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

            var apiInstance = new TransactionsApi(config);
            var id = id_example;  // string | The ID of the transaction
            var refunds = new InlineObject21(); // InlineObject21 | 

            try
            {
                // Refund transaction
                InlineResponse20010 result = apiInstance.TransactionsIdRefundPost(id, refunds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionsIdRefundPost: " + e.Message );
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
 **refunds** | [**InlineObject21**](InlineObject21.md)|  | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refund created |  -  |
| **202** | Request accepted for processing.  |  * event-request-id - The request_id of the event that was accepted for processing. The transaction will be updated with a new event with &#x60;correlation_request_id&#x60; set when the operation completes.  <br>  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |
| **503** | Processor temporarily unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionsidvoidpost"></a>
# **TransactionsIdVoidPost**
> InlineResponse20010 TransactionsIdVoidPost (string id)

Void transaction

At any moment before capture of a transaction, it is possible to cancel an authorization. This operation is called voiding and can be performed by doing a POST to this endpoint  #### Void on part capture  Void after a part capture will cancel the difference between the capture amount and the authorization amount.  > Void on part capture is only supported on `payex.creditcard` > transactions  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class TransactionsIdVoidPostExample
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

            var apiInstance = new TransactionsApi(config);
            var id = id_example;  // string | The ID of the transaction

            try
            {
                // Void transaction
                InlineResponse20010 result = apiInstance.TransactionsIdVoidPost(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionsIdVoidPost: " + e.Message );
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

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[JWT](../README.md#JWT), [apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transaction voided |  -  |
| **202** | Request accepted for processing.  |  * event-request-id - The request_id of the event that was accepted for processing. The transaction will be updated with a new event with &#x60;correlation_request_id&#x60; set when the operation completes.  <br>  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |
| **503** | Processor temporarily unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

