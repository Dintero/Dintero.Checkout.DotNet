# Dintero.OpenApiClient.Checkout.Api.GatewaysApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminCheckoutGwTypeStatusPost**](GatewaysApi.md#admincheckoutgwtypestatuspost) | **POST** /admin/gateways/{gateway}/status | Check gateway status
[**EventsTransactionPost**](GatewaysApi.md#eventstransactionpost) | **POST** /events/transaction/{intent} | process transaction event


<a name="admincheckoutgwtypestatuspost"></a>
# **AdminCheckoutGwTypeStatusPost**
> InlineResponse2002 AdminCheckoutGwTypeStatusPost (string gateway)

Check gateway status

verify the gateway configuration  scopes: - admin:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class AdminCheckoutGwTypeStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: adminKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GatewaysApi(config);
            var gateway = gateway_example;  // string | 

            try
            {
                // Check gateway status
                InlineResponse2002 result = apiInstance.AdminCheckoutGwTypeStatusPost(gateway);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewaysApi.AdminCheckoutGwTypeStatusPost: " + e.Message );
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
 **gateway** | **string**|  | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Gateway status |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventstransactionpost"></a>
# **EventsTransactionPost**
> Transaction EventsTransactionPost (string intent, UNKNOWN_BASE_TYPE data)

process transaction event

Handle async update of transaction.  scopes: - admin:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class EventsTransactionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GatewaysApi(config);
            var intent = intent_example;  // string | **retry_auto_capture**  Retry the capture of a transaction that was created by a session with auto-capture enabled. A success is return if the transaction new state is captured.  **cancel_unknown**  Cancel a transaction that failed the athorization check done before the redirect to the merchant.  **sync_status**  Sync the status of a transaction that is not in sync with the status in the payment gateway  **poll_initiated**  Poll the status of a transaction with status `INITIATED` from the payment gateway. Trigger callback on transaction if the payment gateway status is no longer `INITIATED` > Intended for cases where expected callback from payment gateway > was never received 
            var data = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // process transaction event
                Transaction result = apiInstance.EventsTransactionPost(intent, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewaysApi.EventsTransactionPost: " + e.Message );
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
 **intent** | **string**| **retry_auto_capture**  Retry the capture of a transaction that was created by a session with auto-capture enabled. A success is return if the transaction new state is captured.  **cancel_unknown**  Cancel a transaction that failed the athorization check done before the redirect to the merchant.  **sync_status**  Sync the status of a transaction that is not in sync with the status in the payment gateway  **poll_initiated**  Poll the status of a transaction with status &#x60;INITIATED&#x60; from the payment gateway. Trigger callback on transaction if the payment gateway status is no longer &#x60;INITIATED&#x60; &gt; Intended for cases where expected callback from payment gateway &gt; was never received  | 
 **data** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transaction updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

