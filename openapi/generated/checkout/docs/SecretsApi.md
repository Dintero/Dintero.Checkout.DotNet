# Dintero.OpenApiClient.Checkout.Api.SecretsApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminSignatureGet**](SecretsApi.md#adminsignatureget) | **GET** /admin/signature | Get signature secret
[**AdminSignaturePost**](SecretsApi.md#adminsignaturepost) | **POST** /admin/signature | Create signature secret


<a name="adminsignatureget"></a>
# **AdminSignatureGet**
> SignatureV0 AdminSignatureGet ()

Get signature secret

Get the current signature secret Dintero uses when create the `Dintero-Signature` header included in requests it sends to your endpoints.  scopes: - admin:checkout - read:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class AdminSignatureGetExample
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

            var apiInstance = new SecretsApi(config);

            try
            {
                // Get signature secret
                SignatureV0 result = apiInstance.AdminSignatureGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecretsApi.AdminSignatureGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SignatureV0**](SignatureV0.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signature secret |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adminsignaturepost"></a>
# **AdminSignaturePost**
> SignatureV0 AdminSignaturePost ()

Create signature secret

Dintero can optionally sign all request it sends to your endpoints.  We do so by including a signature in the request `Dintero-Signature` header. This allows you to verify that the request was done by Dintero, not by a third party.  *`v0-hmac-sha256`*  ``` <timestamp>\\n<account_id>\\n<method>\\n<hostname>\\n<pathname>\\n<query> ```  ``` secret: 123 timestamp: 1582236537 account_id: P00000000 method: GET url: https://example.com/callback?B=123&A=992  Dintero-Signature: t=1582236537,     v0-hmac-sha256=6bed2ab1b919d460ef7465a20dc6c97260dca73fab6647106ca525f0908df64a ```  > The timestamp (`t`) in the Dintero-Signature, is included in the signature payload to > mitigate `replay attach`. If your signature is valid but the timestamp is too old, you > can have your application reject the request. We recommend that your application have > a tolerance of five minutes between the timestamp and the current time.  > *NOTE:* The query parameters must be sorted.  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class AdminSignaturePostExample
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

            var apiInstance = new SecretsApi(config);

            try
            {
                // Create signature secret
                SignatureV0 result = apiInstance.AdminSignaturePost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecretsApi.AdminSignaturePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SignatureV0**](SignatureV0.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signature secret |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

