# Dintero.OpenApiClient.Checkout.Api.GenerateQRCodeApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QrLocationsLidPost**](GenerateQRCodeApi.md#qrlocationslidpost) | **POST** /locations/{location_id}/qr | QR Code for a Location.
[**QrSessionsSidPost**](GenerateQRCodeApi.md#qrsessionssidpost) | **POST** /sessions/{session_id}/qr | QR Code for a Session


<a name="qrlocationslidpost"></a>
# **QrLocationsLidPost**
> QRCode QrLocationsLidPost (string locationId, QROptions options)

QR Code for a Location.

Generate a QR Code that can be used statically, to enable payment on a location. The customer can scan the QR Code to retrive a checkout payment window. Payment is possible after a [Checkout](#operation/qr_locations_lid_checkout_sid_post) is requested on the location.  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class QrLocationsLidPostExample
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

            var apiInstance = new GenerateQRCodeApi(config);
            var locationId = locationId_example;  // string | The ID of the sale location, point of sale.
            var options = new QROptions(); // QROptions | 

            try
            {
                // QR Code for a Location.
                QRCode result = apiInstance.QrLocationsLidPost(locationId, options);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenerateQRCodeApi.QrLocationsLidPost: " + e.Message );
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
 **options** | [**QROptions**](QROptions.md)|  | 

### Return type

[**QRCode**](QRCode.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | QR Code |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="qrsessionssidpost"></a>
# **QrSessionsSidPost**
> QRCode QrSessionsSidPost (string sessionId, QROptions options)

QR Code for a Session

Generate a QR Code containing the URL for the Checkout Session. The QR Code can be displayed in POS to enable Checkout payment.  scopes: - admin:checkout - write:checkout 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class QrSessionsSidPostExample
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

            var apiInstance = new GenerateQRCodeApi(config);
            var sessionId = sessionId_example;  // string | The session ID
            var options = new QROptions(); // QROptions | 

            try
            {
                // QR Code for a Session
                QRCode result = apiInstance.QrSessionsSidPost(sessionId, options);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenerateQRCodeApi.QrSessionsSidPost: " + e.Message );
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
 **options** | [**QROptions**](QROptions.md)|  | 

### Return type

[**QRCode**](QRCode.md)

### Authorization

[JWT](../README.md#JWT), [adminKey](../README.md#adminKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | QR Code |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

