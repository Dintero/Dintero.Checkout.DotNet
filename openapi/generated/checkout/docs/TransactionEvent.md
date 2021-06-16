# Dintero.OpenApiClient.Checkout.Model.TransactionEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] [readonly] 
**TransactionStatus** | **string** | The transaction state after this event  | [optional] 
**Event** | **string** | the event type | [optional] 
**Success** | **bool** | The event operation completed with success  | [optional] 
**Correction** | [**TransactionEventCorrection**](TransactionEventCorrection.md) |  | [optional] 
**Error** | [**TransactionEventError**](TransactionEventError.md) |  | [optional] 
**Amount** | **decimal** | Amount captured or refunded  | [optional] 
**CalculatedVatAmount** | **decimal** | Best-effort calculation of the VAT amount in this transaction  | [optional] 
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | The applicable event items | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**CreatedBy** | **string** |  | [optional] 
**RequestId** | **Guid** |  | [optional] 
**Metadata** | **Object** | Additional details about the event  | [optional] 
**CorrelationRequestId** | **Guid** | The event correlation to existing event. The property will be set if the event is an CAPTURE or REFUND of correlated INITIATE_CAPTURE or INITIATE_REFUND event.  | [optional] 
**EventReference** | **string** | Reference for the transaction event provided by the merchant.  - For captures, this is &#x60;capture_reference&#x60; - For refunds, this is &#x60;refund_reference&#x60;  When relevant, it will be visible on the Dintero settlement report.  | [optional] 
**Settlements** | [**TransactionSettlementsRead**](TransactionSettlementsRead.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

