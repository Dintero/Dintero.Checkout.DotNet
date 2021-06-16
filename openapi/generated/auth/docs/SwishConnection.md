# Dintero.OpenApiClient.Auth.Model.SwishConnection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** | The date-time when the resource was created  | [optional] [readonly] 
**CreatedBy** | **string** | The ID of the user/client created the resource  | [optional] [readonly] 
**UpdatedAt** | **DateTime** | The date-time when the resource was last updated  | [optional] [readonly] 
**Metadata** | **Object** | A set of key/value pairs that you can attach to a subscription object. It can be useful for storing additional information about the subscription in a structured format.  | [optional] 
**Status** | **string** | The status of the connection  | [optional] 
**Events** | [**List&lt;AccountConnectionEvent&gt;**](AccountConnectionEvent.md) | List of events recorded, an event is created when the connection is updated with new status  | [optional] 
**Configuration** | [**SwishConnectionConfiguration**](SwishConnectionConfiguration.md) |  | [optional] 
**Signup** | [**SwishConnectionSignup**](SwishConnectionSignup.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

