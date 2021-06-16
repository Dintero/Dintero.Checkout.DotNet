# Dintero.OpenApiClient.Checkout.Model.TransactionCollectorAllOfMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectorInvoiceInvoiceStatus** | **decimal** | External status reported after adding invoice and activating invoice | [optional] 
**CollectorCorrelationId** | **string** | External request id  | [optional] 
**CollectorInvoicePaymentReference** | **string** | The payment identification number. This is the id the customer must use when they do a payment of an invoice.  | [optional] 
**CollectorInvoiceLowestAmountToPay** | **decimal** | The lowest amount to pay on the invoice. | [optional] 
**CollectorInvoiceTotalAmount** | **decimal** | The total amount to pay for the invoice. | [optional] 
**CollectorInvoiceDueDate** | **string** | The due date of the invoice. | [optional] 
**CollectorInvoiceInvoiceUrl** | **string** | The url to invoice in pdf format. | [optional] 
**CollectorInvoiceCurrentInvoiceNumber** | **string** | The invoice number of the invoice that this event belongs to. | [optional] 
**CollectorInvoiceNewInvoiceNumber** | **string** | The invoice number for the next capture. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

