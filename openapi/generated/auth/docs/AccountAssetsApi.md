# Dintero.OpenApiClient.Auth.Api.AccountAssetsApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAccountAssetsPost**](AccountAssetsApi.md#aidaccountassetspost) | **POST** /accounts/{aid}/management/assets | Create asset upload url


<a name="aidaccountassetspost"></a>
# **AidAccountAssetsPost**
> InlineResponse2002 AidAccountAssetsPost (string aid, InlineObject2 data)

Create asset upload url

Create an upload URL that can be used to transfere the asset  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountAssetsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountAssetsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new InlineObject2(); // InlineObject2 | 

            try
            {
                // Create asset upload url
                InlineResponse2002 result = apiInstance.AidAccountAssetsPost(aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountAssetsApi.AidAccountAssetsPost: " + e.Message );
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
 **aid** | **string**| An id that uniquely identifies the account.  | 
 **data** | [**InlineObject2**](InlineObject2.md)|  | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Upload URL |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

