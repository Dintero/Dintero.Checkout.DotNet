# Dintero.OpenApiClient.Checkout.Api.ViewPosApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ViewLocationLidDetailsPost**](ViewPosApi.md#viewlocationliddetailspost) | **GET** /view-location/{location_id}/details | Get location details
[**ViewLocationLidGet**](ViewPosApi.md#viewlocationlidget) | **GET** /view-location/{location_id} | Get the Location Checkout page
[**ViewLocationLidSessionRedirectGet**](ViewPosApi.md#viewlocationlidsessionredirectget) | **GET** /view-location/{location_id}/session/{redirect_ref} | Location redirect


<a name="viewlocationliddetailspost"></a>
# **ViewLocationLidDetailsPost**
> InlineResponse20011 ViewLocationLidDetailsPost (string authorization, string locationId)

Get location details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class ViewLocationLidDetailsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewPosApi(config);
            var authorization = authorization_example;  // string | Bearer authorization with `access_token` returned from [Location Page](#operation/view_location_lid_get)  Example: `Bearer {access_token}` 
            var locationId = locationId_example;  // string | The ID of the sale location, point of sale.

            try
            {
                // Get location details
                InlineResponse20011 result = apiInstance.ViewLocationLidDetailsPost(authorization, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewPosApi.ViewLocationLidDetailsPost: " + e.Message );
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
 **authorization** | **string**| Bearer authorization with &#x60;access_token&#x60; returned from [Location Page](#operation/view_location_lid_get)  Example: &#x60;Bearer {access_token}&#x60;  | 
 **locationId** | **string**| The ID of the sale location, point of sale. | 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Location details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewlocationlidget"></a>
# **ViewLocationLidGet**
> void ViewLocationLidGet (string locationId, string language = null, string ui = null)

Get the Location Checkout page

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class ViewLocationLidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewPosApi(config);
            var locationId = locationId_example;  // string | The ID of the sale location, point of sale.
            var language = language_example;  // string |  (optional) 
            var ui = ui_example;  // string |  (optional) 

            try
            {
                // Get the Location Checkout page
                apiInstance.ViewLocationLidGet(locationId, language, ui);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewPosApi.ViewLocationLidGet: " + e.Message );
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
 **locationId** | **string**| The ID of the sale location, point of sale. | 
 **language** | **string**|  | [optional] 
 **ui** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Location Checkout page |  * Location - the URL to redirect to Vipps - &#x60;sid&#x60; will be used to find the approval url  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewlocationlidsessionredirectget"></a>
# **ViewLocationLidSessionRedirectGet**
> void ViewLocationLidSessionRedirectGet (string locationId, string redirectRef)

Location redirect

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class ViewLocationLidSessionRedirectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ViewPosApi(config);
            var locationId = locationId_example;  // string | The ID of the sale location, point of sale.
            var redirectRef = redirectRef_example;  // string | 

            try
            {
                // Location redirect
                apiInstance.ViewLocationLidSessionRedirectGet(locationId, redirectRef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewPosApi.ViewLocationLidSessionRedirectGet: " + e.Message );
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
 **locationId** | **string**| The ID of the sale location, point of sale. | 
 **redirectRef** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Handle Location Redirect |  * Location - the URL to redirect to Vipps - &#x60;sid&#x60; will be used to find the approval url  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

