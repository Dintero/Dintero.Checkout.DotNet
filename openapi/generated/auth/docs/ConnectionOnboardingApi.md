# Dintero.OpenApiClient.Auth.Api.ConnectionOnboardingApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAccountSettingsConnectionsBamboraPost**](ConnectionOnboardingApi.md#aidaccountsettingsconnectionsbamborapost) | **POST** /accounts/{aid}/management/settings/connections/bambora | Bambora signup
[**AidAccountSettingsConnectionsCollectorPost**](ConnectionOnboardingApi.md#aidaccountsettingsconnectionscollectorpost) | **POST** /accounts/{aid}/management/settings/connections/collector | Collector Bank signup
[**AidAccountSettingsConnectionsCommonPost**](ConnectionOnboardingApi.md#aidaccountsettingsconnectionscommonpost) | **POST** /accounts/{aid}/management/settings/connections/common | Common signup
[**AidAccountSettingsConnectionsInstabankPost**](ConnectionOnboardingApi.md#aidaccountsettingsconnectionsinstabankpost) | **POST** /accounts/{aid}/management/settings/connections/instabank | Instabank signup
[**AidAccountSettingsConnectionsPayexPost**](ConnectionOnboardingApi.md#aidaccountsettingsconnectionspayexpost) | **POST** /accounts/{aid}/management/settings/connections/payex/{payment_product_type} | PayEx signup
[**AidAccountSettingsConnectionsSwishPost**](ConnectionOnboardingApi.md#aidaccountsettingsconnectionsswishpost) | **POST** /accounts/{aid}/management/settings/connections/swish | Swish signup
[**AidAccountSettingsConnectionsVippsPost**](ConnectionOnboardingApi.md#aidaccountsettingsconnectionsvippspost) | **POST** /accounts/{aid}/management/settings/connections/vipps | Vipps signup
[**AidAccountSettingsConnectionsVippsPut**](ConnectionOnboardingApi.md#aidaccountsettingsconnectionsvippsput) | **PUT** /accounts/{aid}/management/settings/connections/vipps | Vipps signup


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

            var apiInstance = new ConnectionOnboardingApi(config);
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
                Debug.Print("Exception when calling ConnectionOnboardingApi.AidAccountSettingsConnectionsBamboraPost: " + e.Message );
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

            var apiInstance = new ConnectionOnboardingApi(config);
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
                Debug.Print("Exception when calling ConnectionOnboardingApi.AidAccountSettingsConnectionsCollectorPost: " + e.Message );
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

            var apiInstance = new ConnectionOnboardingApi(config);
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
                Debug.Print("Exception when calling ConnectionOnboardingApi.AidAccountSettingsConnectionsCommonPost: " + e.Message );
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

            var apiInstance = new ConnectionOnboardingApi(config);
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
                Debug.Print("Exception when calling ConnectionOnboardingApi.AidAccountSettingsConnectionsInstabankPost: " + e.Message );
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

            var apiInstance = new ConnectionOnboardingApi(config);
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
                Debug.Print("Exception when calling ConnectionOnboardingApi.AidAccountSettingsConnectionsPayexPost: " + e.Message );
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

            var apiInstance = new ConnectionOnboardingApi(config);
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
                Debug.Print("Exception when calling ConnectionOnboardingApi.AidAccountSettingsConnectionsSwishPost: " + e.Message );
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

            var apiInstance = new ConnectionOnboardingApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Vipps signup
                VippsConnection result = apiInstance.AidAccountSettingsConnectionsVippsPost(aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionOnboardingApi.AidAccountSettingsConnectionsVippsPost: " + e.Message );
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

            var apiInstance = new ConnectionOnboardingApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Vipps signup
                VippsConnection result = apiInstance.AidAccountSettingsConnectionsVippsPut(aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionOnboardingApi.AidAccountSettingsConnectionsVippsPut: " + e.Message );
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

