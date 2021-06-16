# Dintero.OpenApiClient.Checkout.Model.Session

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | [**SessionUrls**](SessionUrls.md) |  | 
**Customer** | [**SessionCustomer**](SessionCustomer.md) |  | [optional] 
**Order** | [**SessionOrder**](SessionOrder.md) |  | 
**ExpiresAt** | **DateTime** | The session expiration time after which the Checkout page wouldn&#39;t be available  | [optional] 
**Express** | [**SessionExpressExpress**](SessionExpressExpress.md) |  | [optional] 
**Configuration** | [**PaymentConfiguration**](PaymentConfiguration.md) |  | 
**Id** | **string** | The ID of the Checkout | [optional] 
**CreatedAt** | **DateTime** | Time when the Checkout was created | [optional] 
**UpdatedAt** | **DateTime** | Last time when the Checkout was updated | [optional] 
**CustomerIp** | **string** | The IP of the customer upon visiting the page. If the page is visited multiple times, the field is always updated with the last known value.  | [optional] 
**UserAgent** | **string** | The full user agent of the device the customer used when visiting the checkout page  | [optional] 
**Events** | [**List&lt;SessionMetaEvents&gt;**](SessionMetaEvents.md) | Checkout process events  | [optional] 
**TransactionId** | **string** | Transaction which has been created using the checkout.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

