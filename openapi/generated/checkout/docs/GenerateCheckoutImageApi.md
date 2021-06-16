# Dintero.OpenApiClient.Checkout.Api.GenerateCheckoutImageApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BrandingLogoframe**](GenerateCheckoutImageApi.md#brandinglogoframe) | **GET** /branding/logos/{logos}/variant/{variant}/color/{color}/width/{width}/{template} | Get payment logos image
[**BrandingProfile**](GenerateCheckoutImageApi.md#brandingprofile) | **GET** /branding/profiles/{profile_id}/variant/{variant}/color/{color}/width/{width}/{template} | Get checkout profile image


<a name="brandinglogoframe"></a>
# **BrandingLogoframe**
> void BrandingLogoframe (string logos, string variant, string color, string width, string template)

Get payment logos image

Endpoint that returns an svg that can be used to show the world your payment options. [Go to the documentation for the checkout branding endpoints.](/docs/checkout-branding)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class BrandingLogoframeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GenerateCheckoutImageApi(config);
            var logos = logos_example;  // string | logos for payment types separated by underscore eg. `visa_mastercard_vipps_swish_instabank` 
            var variant = variant_example;  // string | Image variant, multi-colors or mono-colored. 
            var color = color_example;  // string | rgb hex color without the \\# character or an rbg() or rgba() color code. 
            var width = width_example;  // string | width of image 
            var template = template_example;  // string | Template for branding image 

            try
            {
                // Get payment logos image
                apiInstance.BrandingLogoframe(logos, variant, color, width, template);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenerateCheckoutImageApi.BrandingLogoframe: " + e.Message );
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
 **logos** | **string**| logos for payment types separated by underscore eg. &#x60;visa_mastercard_vipps_swish_instabank&#x60;  | 
 **variant** | **string**| Image variant, multi-colors or mono-colored.  | 
 **color** | **string**| rgb hex color without the \\# character or an rbg() or rgba() color code.  | 
 **width** | **string**| width of image  | 
 **template** | **string**| Template for branding image  | 

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
| **200** | An svg image |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandingprofile"></a>
# **BrandingProfile**
> void BrandingProfile (string profileId, string variant, string color, string width, string template)

Get checkout profile image

Endpoint that returns an svg that can be used to show the world your payment options. [Go to the documentation for the checkout branding endpoints.](/docs/checkout-branding)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class BrandingProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GenerateCheckoutImageApi(config);
            var profileId = profileId_example;  // string | Profile Id like `P00112233.abc123def321aAabBb9z9cccDdd` 
            var variant = variant_example;  // string | Image variant, multi-colors or mono-colored. 
            var color = color_example;  // string | rgb hex color without the \\# character or an rbg() or rgba() color code 
            var width = width_example;  // string | width of image 
            var template = template_example;  // string | Template for branding image 

            try
            {
                // Get checkout profile image
                apiInstance.BrandingProfile(profileId, variant, color, width, template);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenerateCheckoutImageApi.BrandingProfile: " + e.Message );
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
 **profileId** | **string**| Profile Id like &#x60;P00112233.abc123def321aAabBb9z9cccDdd&#x60;  | 
 **variant** | **string**| Image variant, multi-colors or mono-colored.  | 
 **color** | **string**| rgb hex color without the \\# character or an rbg() or rgba() color code  | 
 **width** | **string**| width of image  | 
 **template** | **string**| Template for branding image  | 

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
| **200** | svg image |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

