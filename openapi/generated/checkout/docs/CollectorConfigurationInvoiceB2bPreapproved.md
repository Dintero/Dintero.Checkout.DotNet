# Dintero.OpenApiClient.Checkout.Model.CollectorConfigurationInvoiceB2bPreapproved
Invoice for pre-approved B2B-customers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Denotes what kind of config parameter this is | [optional] [default to TypeEnum.PaymentProductType]
**Payability** | **SessionPayability** |  | [optional] 
**Enabled** | **bool** | enable Collector Bank Invoice Payment B2B | 
**Countries** | **List&lt;string&gt;** |  | [optional] 
**Accounts** | [**List&lt;CollectorConfigurationInvoiceB2bPreapprovedAccounts&gt;**](CollectorConfigurationInvoiceB2bPreapprovedAccounts.md) | All Collector B2B accounts configured for the customer&#39;s phone number at the merchant.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

