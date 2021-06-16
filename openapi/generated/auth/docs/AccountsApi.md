# Dintero.OpenApiClient.Auth.Api.AccountsApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAccountsAidConnectionsEventsPost**](AccountsApi.md#aidaccountsaidconnectionseventspost) | **POST** /accounts/{oid}/management/accounts/{aid}/connections/{connection}/events | Update connection status
[**AidAccountsAidGet**](AccountsApi.md#aidaccountsaidget) | **GET** /accounts/{oid}/management/accounts/{aid} | Get Account
[**AidAccountsAidPut**](AccountsApi.md#aidaccountsaidput) | **PUT** /accounts/{oid}/management/accounts/{aid} | Update Account
[**AidMgmntAccountsAidDelete**](AccountsApi.md#aidmgmntaccountsaiddelete) | **DELETE** /accounts/{oid}/management/accounts/{aid} | Delete Account
[**AidMgmntAccountsEventsGet**](AccountsApi.md#aidmgmntaccountseventsget) | **GET** /accounts/{oid}/management/accounts/{aid}/events | Account events
[**AidMgmntAccountsEventsPost**](AccountsApi.md#aidmgmntaccountseventspost) | **POST** /accounts/{oid}/management/accounts/{aid}/events | Create Account Event
[**AidMgmntAccountsGet**](AccountsApi.md#aidmgmntaccountsget) | **GET** /accounts/{oid}/management/accounts | Accounts collection
[**AidMgmntAccountsPost**](AccountsApi.md#aidmgmntaccountspost) | **POST** /accounts/{oid}/management/accounts | Create Account


<a name="aidaccountsaidconnectionseventspost"></a>
# **AidAccountsAidConnectionsEventsPost**
> AccountConnectionEvent AidAccountsAidConnectionsEventsPost (string oid, string aid, string connection, AccountConnectionEvent data)

Update connection status

Update an account connection with new status  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountsAidConnectionsEventsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var connection = connection_example;  // string | The connection to update 
            var data = new AccountConnectionEvent(); // AccountConnectionEvent | 

            try
            {
                // Update connection status
                AccountConnectionEvent result = apiInstance.AidAccountsAidConnectionsEventsPost(oid, aid, connection, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.AidAccountsAidConnectionsEventsPost: " + e.Message );
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
 **aid** | **string**| An id that uniquely identifies the account.  | 
 **connection** | **string**| The connection to update  | 
 **data** | [**AccountConnectionEvent**](AccountConnectionEvent.md)|  | 

### Return type

[**AccountConnectionEvent**](AccountConnectionEvent.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | connection status updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsaidget"></a>
# **AidAccountsAidGet**
> ExtendedAccount AidAccountsAidGet (string oid, string aid)

Get Account

Get account details  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountsAidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Get Account
                ExtendedAccount result = apiInstance.AidAccountsAidGet(oid, aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.AidAccountsAidGet: " + e.Message );
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
 **aid** | **string**| An id that uniquely identifies the account.  | 

### Return type

[**ExtendedAccount**](ExtendedAccount.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidaccountsaidput"></a>
# **AidAccountsAidPut**
> ExtendedAccount AidAccountsAidPut (string oid, string aid, UNKNOWN_BASE_TYPE data)

Update Account

Update an account  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAccountsAidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Update Account
                ExtendedAccount result = apiInstance.AidAccountsAidPut(oid, aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.AidAccountsAidPut: " + e.Message );
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
 **aid** | **string**| An id that uniquely identifies the account.  | 
 **data** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**ExtendedAccount**](ExtendedAccount.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account updated |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidmgmntaccountsaiddelete"></a>
# **AidMgmntAccountsAidDelete**
> ExtendedAccount AidMgmntAccountsAidDelete (string oid, string aid)

Delete Account

Delete an account  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidMgmntAccountsAidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var aid = aid_example;  // string | An id that uniquely identifies the account. 

            try
            {
                // Delete Account
                ExtendedAccount result = apiInstance.AidMgmntAccountsAidDelete(oid, aid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.AidMgmntAccountsAidDelete: " + e.Message );
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
 **aid** | **string**| An id that uniquely identifies the account.  | 

### Return type

[**ExtendedAccount**](ExtendedAccount.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account deleted |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidmgmntaccountseventsget"></a>
# **AidMgmntAccountsEventsGet**
> List&lt;AccountEvent&gt; AidMgmntAccountsEventsGet (string oid, string aid, List<string> type = null, int? limit = null, string startingAfter = null)

Account events

Get list of account events  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidMgmntAccountsEventsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var type = type_example;  // List<string> | filter events by type  (optional) 
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional)  (default to 10)
            var startingAfter = startingAfter_example;  // string | cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with `obj_foo`, your subsequent call can include `starting_after=obj_foo` in order to fetch the next page of the list.  (optional) 

            try
            {
                // Account events
                List<AccountEvent> result = apiInstance.AidMgmntAccountsEventsGet(oid, aid, type, limit, startingAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.AidMgmntAccountsEventsGet: " + e.Message );
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
 **aid** | **string**| An id that uniquely identifies the account.  | 
 **type** | **List&lt;string&gt;**| filter events by type  | [optional] 
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  | [optional] [default to 10]
 **startingAfter** | **string**| cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  | [optional] 

### Return type

[**List&lt;AccountEvent&gt;**](AccountEvent.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account events |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidmgmntaccountseventspost"></a>
# **AidMgmntAccountsEventsPost**
> AccountEvent AidMgmntAccountsEventsPost (string oid, string aid, AccountEvent _event)

Create Account Event

Create an account event  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidMgmntAccountsEventsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var _event = new AccountEvent(); // AccountEvent | 

            try
            {
                // Create Account Event
                AccountEvent result = apiInstance.AidMgmntAccountsEventsPost(oid, aid, _event);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.AidMgmntAccountsEventsPost: " + e.Message );
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
 **aid** | **string**| An id that uniquely identifies the account.  | 
 **_event** | [**AccountEvent**](AccountEvent.md)|  | 

### Return type

[**AccountEvent**](AccountEvent.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account event created |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidmgmntaccountsget"></a>
# **AidMgmntAccountsGet**
> List&lt;ExtendedAccount&gt; AidMgmntAccountsGet (string oid, string search = null, List<string> progression = null, List<string> connections = null, List<string> connectionsProgression = null, List<string> services = null, List<string> servicesProgression = null, List<string> accountManager = null, int? limit = null, string startingAfter = null)

Accounts collection

Get list of accounts filtered by the partner account  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidMgmntAccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var search = search_example;  // string | lookup accounts where search term match account id  (optional) 
            var progression = progression_example;  // List<string> | filter account by progression  (optional) 
            var connections = new List<string>(); // List<string> | filter account by connections  (optional) 
            var connectionsProgression = connectionsProgression_example;  // List<string> | filter account by connections progression  (optional) 
            var services = new List<string>(); // List<string> | filter accounts by services registered  (optional) 
            var servicesProgression = servicesProgression_example;  // List<string> | filter account by services progression  (optional) 
            var accountManager = new List<string>(); // List<string> | filter account by account_manager  (optional) 
            var limit = 56;  // int? | A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional)  (default to 10)
            var startingAfter = startingAfter_example;  // string | cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with `obj_foo`, your subsequent call can include `starting_after=obj_foo` in order to fetch the next page of the list.  (optional) 

            try
            {
                // Accounts collection
                List<ExtendedAccount> result = apiInstance.AidMgmntAccountsGet(oid, search, progression, connections, connectionsProgression, services, servicesProgression, accountManager, limit, startingAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.AidMgmntAccountsGet: " + e.Message );
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
 **search** | **string**| lookup accounts where search term match account id  | [optional] 
 **progression** | **List&lt;string&gt;**| filter account by progression  | [optional] 
 **connections** | [**List&lt;string&gt;**](string.md)| filter account by connections  | [optional] 
 **connectionsProgression** | **List&lt;string&gt;**| filter account by connections progression  | [optional] 
 **services** | [**List&lt;string&gt;**](string.md)| filter accounts by services registered  | [optional] 
 **servicesProgression** | **List&lt;string&gt;**| filter account by services progression  | [optional] 
 **accountManager** | [**List&lt;string&gt;**](string.md)| filter account by account_manager  | [optional] 
 **limit** | **int?**| A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  | [optional] [default to 10]
 **startingAfter** | **string**| cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  | [optional] 

### Return type

[**List&lt;ExtendedAccount&gt;**](ExtendedAccount.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | accounts |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidmgmntaccountspost"></a>
# **AidMgmntAccountsPost**
> ExtendedAccount AidMgmntAccountsPost (string oid, UNKNOWN_BASE_TYPE data)

Create Account

Create an account from an partner account  scopes: - admin:accounts - write:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidMgmntAccountsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Create Account
                ExtendedAccount result = apiInstance.AidMgmntAccountsPost(oid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.AidMgmntAccountsPost: " + e.Message );
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
 **data** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**ExtendedAccount**](ExtendedAccount.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | account created |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

