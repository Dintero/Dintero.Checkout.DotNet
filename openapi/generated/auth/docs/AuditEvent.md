# Dintero.OpenApiClient.Auth.Model.AuditEvent
Audit event, an **actor** takes an **action** on and **entity** within a **context** 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | An UUID that uniquely identifies the resource  | 
**CreatedAt** | **DateTime** | The date-time when the resource was created  | 
**Action** | **string** | Name of the action | 
**Actor** | **string** | User ID who initiated the action. | [optional] 
**Entity** | **string** | ID of the target entity of the action | 
**Context** | **Object** | Context for the event | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

