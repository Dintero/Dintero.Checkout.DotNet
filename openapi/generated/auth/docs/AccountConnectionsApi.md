# Dintero.OpenApiClient.Auth.Api.AccountConnectionsApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAccountSettingsConnectionsBamboraCallbackPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionsbamboracallbackpost) | **POST** /accounts/{aid}/management/settings/connections/bambora/{callback_reference} | Bambora Callback
[**AidAccountSettingsConnectionsBamboraGet**](AccountConnectionsApi.md#aidaccountsettingsconnectionsbamboraget) | **GET** /accounts/{aid}/management/settings/connections/bambora | Get Bambora signup status
[**AidAccountSettingsConnectionsBamboraPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionsbamborapost) | **POST** /accounts/{aid}/management/settings/connections/bambora | Bambora signup
[**AidAccountSettingsConnectionsCollectorCallbackPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionscollectorcallbackpost) | **POST** /accounts/{aid}/management/settings/connections/collector/{callback_reference} | Collector Bank Callback
[**AidAccountSettingsConnectionsCollectorGet**](AccountConnectionsApi.md#aidaccountsettingsconnectionscollectorget) | **GET** /accounts/{aid}/management/settings/connections/collector | Get Collector Bank signup status
[**AidAccountSettingsConnectionsCollectorPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionscollectorpost) | **POST** /accounts/{aid}/management/settings/connections/collector | Collector Bank signup
[**AidAccountSettingsConnectionsCommonGet**](AccountConnectionsApi.md#aidaccountsettingsconnectionscommonget) | **GET** /accounts/{aid}/management/settings/connections/common | Get Common signup status
[**AidAccountSettingsConnectionsCommonPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionscommonpost) | **POST** /accounts/{aid}/management/settings/connections/common | Common signup
[**AidAccountSettingsConnectionsInstabankCallbackPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionsinstabankcallbackpost) | **POST** /accounts/{aid}/management/settings/connections/instabank/{callback_reference} | Instabank Callback
[**AidAccountSettingsConnectionsInstabankGet**](AccountConnectionsApi.md#aidaccountsettingsconnectionsinstabankget) | **GET** /accounts/{aid}/management/settings/connections/instabank | Get Instabank signup status
[**AidAccountSettingsConnectionsInstabankPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionsinstabankpost) | **POST** /accounts/{aid}/management/settings/connections/instabank | Instabank signup
[**AidAccountSettingsConnectionsPayexCallbackPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionspayexcallbackpost) | **POST** /accounts/{aid}/management/settings/connections/payex/{payment_product_type}/{callback_reference} | PayEx Callback
[**AidAccountSettingsConnectionsPayexGet**](AccountConnectionsApi.md#aidaccountsettingsconnectionspayexget) | **GET** /accounts/{aid}/management/settings/connections/payex/{payment_product_type} | Get PayEx signup status
[**AidAccountSettingsConnectionsPayexPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionspayexpost) | **POST** /accounts/{aid}/management/settings/connections/payex/{payment_product_type} | PayEx signup
[**AidAccountSettingsConnectionsSwishCallbackPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionsswishcallbackpost) | **POST** /accounts/{aid}/management/settings/connections/swish/{callback_reference} | Swish Callback
[**AidAccountSettingsConnectionsSwishGet**](AccountConnectionsApi.md#aidaccountsettingsconnectionsswishget) | **GET** /accounts/{aid}/management/settings/connections/swish | Get Swish signup status
[**AidAccountSettingsConnectionsSwishPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionsswishpost) | **POST** /accounts/{aid}/management/settings/connections/swish | Swish signup
[**AidAccountSettingsConnectionsVippsCallbackPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionsvippscallbackpost) | **POST** /accounts/{aid}/management/settings/connections/vipps/{callback_reference} | Vipps Callback
[**AidAccountSettingsConnectionsVippsGet**](AccountConnectionsApi.md#aidaccountsettingsconnectionsvippsget) | **GET** /accounts/{aid}/management/settings/connections/vipps | Get Vipps signup status
[**AidAccountSettingsConnectionsVippsPost**](AccountConnectionsApi.md#aidaccountsettingsconnectionsvippspost) | **POST** /accounts/{aid}/management/settings/connections/vipps | Vipps signup
[**AidAccountSettingsConnectionsVippsPut**](AccountConnectionsApi.md#aidaccountsettingsconnectionsvippsput) | **PUT** /accounts/{aid}/management/settings/connections/vipps | Vipps signup


<a name="aidaccountsettingsconnectionsbamboracallbackpost"></a>
# **AidAccountSettingsConnectionsBamboraCallbackPost**
> Object AidAccountSettingsConnectionsBamboraCallbackPost (string aid, string callbackReference, BamboraConnectionCallback callback)

Bambora Callback

Handle callback from Bambora signup  Completes the Bambora signup, enables Bambora for Checkout  scopes: - write:accounts:/management/settings/connections/bambora - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsBamboraCallbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var callbackReference = callbackReference_example;  // string | 
            var callback = new BamboraConnectionCallback(); // BamboraConnectionCallback | 

            try
            {
                // Bambora Callback
                Object result = apiInstance.AidAccountSettingsConnectionsBamboraCallbackPost(aid, callbackReference, callback);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsBamboraCallbackPost: " + e.Message );
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
 **callbackReference** | **string**|  | 
 **callback** | [**BamboraConnectionCallback**](BamboraConnectionCallback.md)|  | 

### Return type

**Object**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsbamboraget"></a>
# **AidAccountSettingsConnectionsBamboraGet**
> BamboraConnection AidAccountSettingsConnectionsBamboraGet (string aid)

Get Bambora signup status

Get details about the Bambora configuration  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsBamboraGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Get Bambora signup status
                BamboraConnection result = apiInstance.AidAccountSettingsConnectionsBamboraGet(aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsBamboraGet: " + e.Message );
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

### Return type

[**BamboraConnection**](BamboraConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bambora connection |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsbamborapost"></a>
# **AidAccountSettingsConnectionsBamboraPost**
> BamboraConnection AidAccountSettingsConnectionsBamboraPost (string aid, InlineObject4 data)

Bambora signup

Initialize Bambora signup  Requires the account company to be configured with `organization_number` [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsBamboraPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new InlineObject4(); // InlineObject4 | 

            try
            {
                // Bambora signup
                BamboraConnection result = apiInstance.AidAccountSettingsConnectionsBamboraPost(aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsBamboraPost: " + e.Message );
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
 **data** | [**InlineObject4**](InlineObject4.md)|  | 

### Return type

[**BamboraConnection**](BamboraConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionscollectorcallbackpost"></a>
# **AidAccountSettingsConnectionsCollectorCallbackPost**
> Object AidAccountSettingsConnectionsCollectorCallbackPost (string aid, string callbackReference, CollectorConnectionCallback callback)

Collector Bank Callback

Handle callback from Collector Bank signup  Completes the Collector Bank signup, enables Collector Bank for Checkout  scopes: - write:accounts:/management/settings/connections/collector - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsCollectorCallbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var callbackReference = callbackReference_example;  // string | 
            var callback = new CollectorConnectionCallback(); // CollectorConnectionCallback | 

            try
            {
                // Collector Bank Callback
                Object result = apiInstance.AidAccountSettingsConnectionsCollectorCallbackPost(aid, callbackReference, callback);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsCollectorCallbackPost: " + e.Message );
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
 **callbackReference** | **string**|  | 
 **callback** | [**CollectorConnectionCallback**](CollectorConnectionCallback.md)|  | 

### Return type

**Object**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionscollectorget"></a>
# **AidAccountSettingsConnectionsCollectorGet**
> CollectorConnection AidAccountSettingsConnectionsCollectorGet (string aid)

Get Collector Bank signup status

Get details about the Collector Bank configuration  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsCollectorGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Get Collector Bank signup status
                CollectorConnection result = apiInstance.AidAccountSettingsConnectionsCollectorGet(aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsCollectorGet: " + e.Message );
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

### Return type

[**CollectorConnection**](CollectorConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Collector Bank connection |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionscollectorpost"></a>
# **AidAccountSettingsConnectionsCollectorPost**
> CollectorConnection AidAccountSettingsConnectionsCollectorPost (string aid, InlineObject5 data)

Collector Bank signup

Initialize Collector Bank signup  Requires the account company to be configured with `organization_number` [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsCollectorPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new InlineObject5(); // InlineObject5 | 

            try
            {
                // Collector Bank signup
                CollectorConnection result = apiInstance.AidAccountSettingsConnectionsCollectorPost(aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsCollectorPost: " + e.Message );
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
 **data** | [**InlineObject5**](InlineObject5.md)|  | 

### Return type

[**CollectorConnection**](CollectorConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionscommonget"></a>
# **AidAccountSettingsConnectionsCommonGet**
> CommonConnection AidAccountSettingsConnectionsCommonGet (string aid)

Get Common signup status

Get details about the Common configuration  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsCommonGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Get Common signup status
                CommonConnection result = apiInstance.AidAccountSettingsConnectionsCommonGet(aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsCommonGet: " + e.Message );
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

### Return type

[**CommonConnection**](CommonConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Common connection |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionscommonpost"></a>
# **AidAccountSettingsConnectionsCommonPost**
> CommonConnection AidAccountSettingsConnectionsCommonPost (string aid, InlineObject6 data)

Common signup

Initialize Common signup  Requires the account company to be configured with `organization_number` [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsCommonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new InlineObject6(); // InlineObject6 | 

            try
            {
                // Common signup
                CommonConnection result = apiInstance.AidAccountSettingsConnectionsCommonPost(aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsCommonPost: " + e.Message );
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
 **data** | [**InlineObject6**](InlineObject6.md)|  | 

### Return type

[**CommonConnection**](CommonConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsinstabankcallbackpost"></a>
# **AidAccountSettingsConnectionsInstabankCallbackPost**
> void AidAccountSettingsConnectionsInstabankCallbackPost (string aid, string callbackReference, InstabankConnectionCallback data)

Instabank Callback

Handle callback from Instabank signup  Completes the Instabank signup, enables Instabank for Checkout  scopes: - write:accounts:/management/settings/connections/instabank 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsInstabankCallbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var callbackReference = callbackReference_example;  // string | 
            var data = new InstabankConnectionCallback(); // InstabankConnectionCallback | 

            try
            {
                // Instabank Callback
                apiInstance.AidAccountSettingsConnectionsInstabankCallbackPost(aid, callbackReference, data);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsInstabankCallbackPost: " + e.Message );
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
 **callbackReference** | **string**|  | 
 **data** | [**InstabankConnectionCallback**](InstabankConnectionCallback.md)|  | 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | callback handled |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsinstabankget"></a>
# **AidAccountSettingsConnectionsInstabankGet**
> InstabankConnection AidAccountSettingsConnectionsInstabankGet (string aid)

Get Instabank signup status

Get details about the Instabank  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsInstabankGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Get Instabank signup status
                InstabankConnection result = apiInstance.AidAccountSettingsConnectionsInstabankGet(aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsInstabankGet: " + e.Message );
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

### Return type

[**InstabankConnection**](InstabankConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instabank connection |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsinstabankpost"></a>
# **AidAccountSettingsConnectionsInstabankPost**
> InstabankConnection AidAccountSettingsConnectionsInstabankPost (string aid, InlineObject7 data)

Instabank signup

Initialize Instabank signup  Requires the account company to be configured with `organization_number` [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsInstabankPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new InlineObject7(); // InlineObject7 | 

            try
            {
                // Instabank signup
                InstabankConnection result = apiInstance.AidAccountSettingsConnectionsInstabankPost(aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsInstabankPost: " + e.Message );
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
 **data** | [**InlineObject7**](InlineObject7.md)|  | 

### Return type

[**InstabankConnection**](InstabankConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionspayexcallbackpost"></a>
# **AidAccountSettingsConnectionsPayexCallbackPost**
> Object AidAccountSettingsConnectionsPayexCallbackPost (string aid, string paymentProductType, string callbackReference, PayExConnectionCallback callback)

PayEx Callback

Handle callback from PayEx signup  Completes the PayEx signup, enables PayEx for Checkout  scopes: - write:accounts:/management/settings/connections/payex - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsPayexCallbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var paymentProductType = paymentProductType_example;  // string | 
            var callbackReference = callbackReference_example;  // string | 
            var callback = new PayExConnectionCallback(); // PayExConnectionCallback | 

            try
            {
                // PayEx Callback
                Object result = apiInstance.AidAccountSettingsConnectionsPayexCallbackPost(aid, paymentProductType, callbackReference, callback);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsPayexCallbackPost: " + e.Message );
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
 **paymentProductType** | **string**|  | 
 **callbackReference** | **string**|  | 
 **callback** | [**PayExConnectionCallback**](PayExConnectionCallback.md)|  | 

### Return type

**Object**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionspayexget"></a>
# **AidAccountSettingsConnectionsPayexGet**
> PayExConnection AidAccountSettingsConnectionsPayexGet (string aid, string paymentProductType)

Get PayEx signup status

Get details about the Vipps  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsPayexGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var paymentProductType = paymentProductType_example;  // string | 

            try
            {
                // Get PayEx signup status
                PayExConnection result = apiInstance.AidAccountSettingsConnectionsPayexGet(aid, paymentProductType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsPayexGet: " + e.Message );
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
 **paymentProductType** | **string**|  | 

### Return type

[**PayExConnection**](PayExConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | PayEx connection |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionspayexpost"></a>
# **AidAccountSettingsConnectionsPayexPost**
> PayExConnection AidAccountSettingsConnectionsPayexPost (string aid, string paymentProductType, InlineObject8 data)

PayEx signup

Initialize PayEx signup  Requires the account company to be configured with `organization_number` [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsPayexPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var paymentProductType = paymentProductType_example;  // string | 
            var data = new InlineObject8(); // InlineObject8 | 

            try
            {
                // PayEx signup
                PayExConnection result = apiInstance.AidAccountSettingsConnectionsPayexPost(aid, paymentProductType, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsPayexPost: " + e.Message );
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
 **paymentProductType** | **string**|  | 
 **data** | [**InlineObject8**](InlineObject8.md)|  | 

### Return type

[**PayExConnection**](PayExConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsswishcallbackpost"></a>
# **AidAccountSettingsConnectionsSwishCallbackPost**
> Object AidAccountSettingsConnectionsSwishCallbackPost (string aid, string callbackReference, SwishConnectionCallback callback)

Swish Callback

Handle callback from Swish signup  Completes the Swish signup, enables Swish for Checkout  scopes: - write:accounts:/management/settings/connections/swish - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsSwishCallbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var callbackReference = callbackReference_example;  // string | 
            var callback = new SwishConnectionCallback(); // SwishConnectionCallback | 

            try
            {
                // Swish Callback
                Object result = apiInstance.AidAccountSettingsConnectionsSwishCallbackPost(aid, callbackReference, callback);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsSwishCallbackPost: " + e.Message );
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
 **callbackReference** | **string**|  | 
 **callback** | [**SwishConnectionCallback**](SwishConnectionCallback.md)|  | 

### Return type

**Object**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsswishget"></a>
# **AidAccountSettingsConnectionsSwishGet**
> SwishConnection AidAccountSettingsConnectionsSwishGet (string aid)

Get Swish signup status

Get details about the Swish configuration  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsSwishGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Get Swish signup status
                SwishConnection result = apiInstance.AidAccountSettingsConnectionsSwishGet(aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsSwishGet: " + e.Message );
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

### Return type

[**SwishConnection**](SwishConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Swish connection |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsswishpost"></a>
# **AidAccountSettingsConnectionsSwishPost**
> SwishConnection AidAccountSettingsConnectionsSwishPost (string aid, InlineObject9 data)

Swish signup

Initialize Swish signup  Requires the account company to be configured with `organization_number` [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsSwishPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new InlineObject9(); // InlineObject9 | 

            try
            {
                // Swish signup
                SwishConnection result = apiInstance.AidAccountSettingsConnectionsSwishPost(aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsSwishPost: " + e.Message );
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
 **data** | [**InlineObject9**](InlineObject9.md)|  | 

### Return type

[**SwishConnection**](SwishConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsvippscallbackpost"></a>
# **AidAccountSettingsConnectionsVippsCallbackPost**
> Object AidAccountSettingsConnectionsVippsCallbackPost (string aid, string callbackReference, InlineObject10 callback)

Vipps Callback

Handle callback from Vipps signup  Completes the Vipps signup, enables Vipps for Checkout  scopes: - write:accounts:/management/settings/connections/vipps 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsVippsCallbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var callbackReference = callbackReference_example;  // string | 
            var callback = new InlineObject10(); // InlineObject10 | 

            try
            {
                // Vipps Callback
                Object result = apiInstance.AidAccountSettingsConnectionsVippsCallbackPost(aid, callbackReference, callback);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsVippsCallbackPost: " + e.Message );
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
 **callbackReference** | **string**|  | 
 **callback** | [**InlineObject10**](InlineObject10.md)|  | 

### Return type

**Object**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsvippsget"></a>
# **AidAccountSettingsConnectionsVippsGet**
> VippsConnection AidAccountSettingsConnectionsVippsGet (string aid)

Get Vipps signup status

Get details about the Vipps  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsVippsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Get Vipps signup status
                VippsConnection result = apiInstance.AidAccountSettingsConnectionsVippsGet(aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsVippsGet: " + e.Message );
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

### Return type

[**VippsConnection**](VippsConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vipps connection |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsvippspost"></a>
# **AidAccountSettingsConnectionsVippsPost**
> VippsConnection AidAccountSettingsConnectionsVippsPost (string aid)

Vipps signup

Initialize Vipps signup  Requires the account company to be configured with `organization_number` [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsVippsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Vipps signup
                VippsConnection result = apiInstance.AidAccountSettingsConnectionsVippsPost(aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsVippsPost: " + e.Message );
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

### Return type

[**VippsConnection**](VippsConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsettingsconnectionsvippsput"></a>
# **AidAccountSettingsConnectionsVippsPut**
> VippsConnection AidAccountSettingsConnectionsVippsPut (string aid)

Vipps signup

Reinitialize Vipps signup if connection is not enabled.  Requires the account company to be configured with `organization_number` [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountSettingsConnectionsVippsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountConnectionsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Vipps signup
                VippsConnection result = apiInstance.AidAccountSettingsConnectionsVippsPut(aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountConnectionsApi.AidAccountSettingsConnectionsVippsPut: " + e.Message );
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

### Return type

[**VippsConnection**](VippsConnection.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signup |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

