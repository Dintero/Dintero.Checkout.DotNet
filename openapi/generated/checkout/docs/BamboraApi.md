# Dintero.OpenApiClient.Checkout.Api.BamboraApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckoutBamboraCallbackGet**](BamboraApi.md#checkoutbamboracallbackget) | **GET** /sessions/{session_id}/bambora/callback/{callback_ref} | Handle Bambora callback
[**CheckoutSidBamboraRedirectGet**](BamboraApi.md#checkoutsidbamboraredirectget) | **GET** /sessions/{session_id}/bambora/redirect/{redirect_ref} | Handle redirect from payment


<a name="checkoutbamboracallbackget"></a>
# **CheckoutBamboraCallbackGet**
> void CheckoutBamboraCallbackGet (string sessionId, string callbackRef, string txnid = null, string orderid = null, string reference = null, string amount = null, string currency = null, string date = null, string time = null, string feeid = null, string txnfee = null, string paymenttype = null, string walletname = null, string cardno = null, string expmonth = null, string expyear = null, string subscriptionid = null, string tokenid = null, string eci = null, string issuercountry = null, string hash = null)

Handle Bambora callback

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class CheckoutBamboraCallbackGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new BamboraApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var callbackRef = callbackRef_example;  // string | 
            var txnid = txnid_example;  // string |  (optional) 
            var orderid = orderid_example;  // string |  (optional) 
            var reference = reference_example;  // string |  (optional) 
            var amount = amount_example;  // string |  (optional) 
            var currency = currency_example;  // string |  (optional) 
            var date = date_example;  // string |  (optional) 
            var time = time_example;  // string |  (optional) 
            var feeid = feeid_example;  // string |  (optional) 
            var txnfee = txnfee_example;  // string |  (optional) 
            var paymenttype = paymenttype_example;  // string |  (optional) 
            var walletname = walletname_example;  // string |  (optional) 
            var cardno = cardno_example;  // string |  (optional) 
            var expmonth = expmonth_example;  // string |  (optional) 
            var expyear = expyear_example;  // string |  (optional) 
            var subscriptionid = subscriptionid_example;  // string |  (optional) 
            var tokenid = tokenid_example;  // string |  (optional) 
            var eci = eci_example;  // string |  (optional) 
            var issuercountry = issuercountry_example;  // string |  (optional) 
            var hash = hash_example;  // string |  (optional) 

            try
            {
                // Handle Bambora callback
                apiInstance.CheckoutBamboraCallbackGet(sessionId, callbackRef, txnid, orderid, reference, amount, currency, date, time, feeid, txnfee, paymenttype, walletname, cardno, expmonth, expyear, subscriptionid, tokenid, eci, issuercountry, hash);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BamboraApi.CheckoutBamboraCallbackGet: " + e.Message );
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
 **txnid** | **string**|  | [optional] 
 **orderid** | **string**|  | [optional] 
 **reference** | **string**|  | [optional] 
 **amount** | **string**|  | [optional] 
 **currency** | **string**|  | [optional] 
 **date** | **string**|  | [optional] 
 **time** | **string**|  | [optional] 
 **feeid** | **string**|  | [optional] 
 **txnfee** | **string**|  | [optional] 
 **paymenttype** | **string**|  | [optional] 
 **walletname** | **string**|  | [optional] 
 **cardno** | **string**|  | [optional] 
 **expmonth** | **string**|  | [optional] 
 **expyear** | **string**|  | [optional] 
 **subscriptionid** | **string**|  | [optional] 
 **tokenid** | **string**|  | [optional] 
 **eci** | **string**|  | [optional] 
 **issuercountry** | **string**|  | [optional] 
 **hash** | **string**|  | [optional] 

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
| **200** | callback handled |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkoutsidbamboraredirectget"></a>
# **CheckoutSidBamboraRedirectGet**
> void CheckoutSidBamboraRedirectGet (string sessionId, string redirectRef, string action = null, string txnid = null, string orderid = null, string reference = null, string amount = null, string currency = null, string date = null, string time = null, string feeid = null, string txnfee = null, string paymenttype = null, string walletname = null, string cardno = null, string expmonth = null, string expyear = null, string subscriptionid = null, string tokenid = null, string eci = null, string issuercountry = null, string hash = null)

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
    public class CheckoutSidBamboraRedirectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new BamboraApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var redirectRef = redirectRef_example;  // string | 
            var action = action_example;  // string |  (optional) 
            var txnid = txnid_example;  // string |  (optional) 
            var orderid = orderid_example;  // string |  (optional) 
            var reference = reference_example;  // string |  (optional) 
            var amount = amount_example;  // string |  (optional) 
            var currency = currency_example;  // string |  (optional) 
            var date = date_example;  // string |  (optional) 
            var time = time_example;  // string |  (optional) 
            var feeid = feeid_example;  // string |  (optional) 
            var txnfee = txnfee_example;  // string |  (optional) 
            var paymenttype = paymenttype_example;  // string |  (optional) 
            var walletname = walletname_example;  // string |  (optional) 
            var cardno = cardno_example;  // string |  (optional) 
            var expmonth = expmonth_example;  // string |  (optional) 
            var expyear = expyear_example;  // string |  (optional) 
            var subscriptionid = subscriptionid_example;  // string |  (optional) 
            var tokenid = tokenid_example;  // string |  (optional) 
            var eci = eci_example;  // string |  (optional) 
            var issuercountry = issuercountry_example;  // string |  (optional) 
            var hash = hash_example;  // string |  (optional) 

            try
            {
                // Handle redirect from payment
                apiInstance.CheckoutSidBamboraRedirectGet(sessionId, redirectRef, action, txnid, orderid, reference, amount, currency, date, time, feeid, txnfee, paymenttype, walletname, cardno, expmonth, expyear, subscriptionid, tokenid, eci, issuercountry, hash);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BamboraApi.CheckoutSidBamboraRedirectGet: " + e.Message );
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
 **action** | **string**|  | [optional] 
 **txnid** | **string**|  | [optional] 
 **orderid** | **string**|  | [optional] 
 **reference** | **string**|  | [optional] 
 **amount** | **string**|  | [optional] 
 **currency** | **string**|  | [optional] 
 **date** | **string**|  | [optional] 
 **time** | **string**|  | [optional] 
 **feeid** | **string**|  | [optional] 
 **txnfee** | **string**|  | [optional] 
 **paymenttype** | **string**|  | [optional] 
 **walletname** | **string**|  | [optional] 
 **cardno** | **string**|  | [optional] 
 **expmonth** | **string**|  | [optional] 
 **expyear** | **string**|  | [optional] 
 **subscriptionid** | **string**|  | [optional] 
 **tokenid** | **string**|  | [optional] 
 **eci** | **string**|  | [optional] 
 **issuercountry** | **string**|  | [optional] 
 **hash** | **string**|  | [optional] 

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

