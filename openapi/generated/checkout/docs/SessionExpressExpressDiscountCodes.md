# Dintero.OpenApiClient.Checkout.Model.SessionExpressExpressDiscountCodes
Enable discount codes for Express Checkout 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxCount** | **decimal** | Limit how many discount codes can be added by the customer  | [optional] 
**CallbackUrl** | **string** | URL that Checkout will POST to when the user has submitted/changed the discount codes for an express session.  Dintero will not attempt a retry after a failed delivery attempt. Following situations is considered as failed delivery  - HTTP status codes that are not 200. - A request timeout (60 seconds) - Any connection error such as connection timeout, bad certificate, etc  The response from the callback will be used to update the order amount, items discount_lines and shipping options.  See [POST example/discount_codes_callback_url](#operation/example_discount_codes_callback_url) for details about the request and response.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

