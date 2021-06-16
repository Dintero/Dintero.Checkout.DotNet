# Dintero.OpenApiClient.Checkout.Model.TransactionSwish

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentProduct** | **string** | The payment product corresponding to this transaction  | 
**Amount** | **int** | Non-negative, minor units. Total amount of the transaction  | 
**Currency** | **string** | ISO 4217 transaction currency | 
**MerchantReference** | **string** | A reference specified by the merchant to identify the transaction  | [optional] 
**MerchantReference2** | **string** | A reference specified by the merchant to identify the transaction, can be updated after the transaction has been created  | [optional] 
**DynamicDescriptor** | **string** | A short reference / descriptor that will show up on the customers bank statement  | [optional] 
**SettlementStatus** | [**SettlementStatus**](SettlementStatus.md) |  | [optional] 
**Customer** | [**TransactionCustomer**](TransactionCustomer.md) |  | [optional] 
**CustomerIp** | **string** | The IP address of the customer | [optional] 
**UserAgent** | **string** | The full user agent string of the device the customer used to submit the transaction  | [optional] 
**ShippingAddress** | [**OrderAddress**](OrderAddress.md) |  | [optional] 
**ShippingOption** | [**ShippingOption**](ShippingOption.md) |  | [optional] 
**BillingAddress** | [**OrderAddress**](OrderAddress.md) |  | [optional] 
**Store** | [**Store**](Store.md) |  | [optional] 
**Status** | **string** | The current status of the transaction | [optional] [readonly] 
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | The applicable transaction items  | [optional] 
**Url** | [**TransactionUrl**](TransactionUrl.md) |  | [optional] 
**SessionId** | **string** | The session id for the transaction | [optional] 
**Session** | [**Session**](Session.md) |  | [optional] 
**UpdatedAt** | **DateTime** | When the transaction was last modified. | [optional] 
**Id** | **string** | An ID that uniquely identifies the resource  | [optional] 
**CreatedAt** | **DateTime** | The date-time when the resource was created  | [optional] 
**PaymentProductType** | **string** | The payment type corresponding to this transaction  | 
**Events** | [**List&lt;TransactionSwishAllOfEvents&gt;**](TransactionSwishAllOfEvents.md) |  | [optional] 
**Metadata** | [**TransactionSwishAllOfMetadata1**](TransactionSwishAllOfMetadata1.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

