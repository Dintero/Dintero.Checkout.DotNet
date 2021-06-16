# Dintero.OpenApiClient.Auth.Api.KeysApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAuthsKeysGet**](KeysApi.md#aidauthskeysget) | **GET** /accounts/{oid}/auth/keys | Get public keys


<a name="aidauthskeysget"></a>
# **AidAuthsKeysGet**
> List&lt;InlineResponse2004&gt; AidAuthsKeysGet (string oid)

Get public keys

Retrieve the JSON Web Key Set (JWKS) that can be used to validate `access_token`  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsKeysGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 

            try
            {
                // Get public keys
                List<InlineResponse2004> result = apiInstance.AidAuthsKeysGet(oid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KeysApi.AidAuthsKeysGet: " + e.Message );
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
 **oid** | **string**| An id that uniquely identifies the account or owner (partner)  | 

### Return type

[**List&lt;InlineResponse2004&gt;**](InlineResponse2004.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Keys Collection |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

