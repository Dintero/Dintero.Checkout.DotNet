# Dintero.OpenApiClient.Auth.Model.SwishConnectionCallback

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SwishNumber** | **string** | The merchant&#39;s Swish number | 
**Cert** | **string** | Base 64 encoded string of the certificate. Can be in PEM or P12 format. If PEM, key and ca are required.  | [optional] 
**Key** | **string** | Base 64 encoded string of the public key | [optional] 
**Passphrase** | **string** | The passphrase for the certificate | [optional] 
**Ca** | **string** | Base 64 encoded string of the CA of the certificate | [optional] 
**PaymentOptions** | [**List&lt;SwishConnectionCallbackPaymentOptions&gt;**](SwishConnectionCallbackPaymentOptions.md) | Payment options to enable for this connection  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

