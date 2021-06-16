# Dintero.OpenApiClient.Checkout.Model.ShippingOption
A shipping option 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of this shipping option product.  The express checkout will group all products with the same id. Used for grouping delivery to the same address at different time slots, or for grouping deliveries to different pick up points.  | 
**LineId** | **string** | Unique id of the specific configuration of this shipping product  | 
**Countries** | **List&lt;string&gt;** | Countries where this shipping option can be used | [optional] 
**Amount** | **int** | The monetary amount of the shipping option  | 
**VatAmount** | **int** | The VAT of the &#x60;amount&#x60; parameter. Only used for display purposes.  | [optional] 
**Vat** | **decimal** | The VAT percentage  | [optional] 
**Title** | **string** | A shipping option title. Eg. \&quot;Standard\&quot;  | 
**Description** | **string** | A short description of the shipping option product  | [optional] 
**DeliveryMethod** | **string** |  | [optional] 
**Operator** | **string** | Name of company that provides shipping service  | 
**OperatorProductId** | **string** | The operators own id for this shipping product  | [optional] 
**Eta** | [**ShippingOptionEta**](ShippingOptionEta.md) |  | [optional] 
**TimeSlot** | [**ShippingOptionTimeSlot**](ShippingOptionTimeSlot.md) |  | [optional] 
**PickUpAddress** | [**OrderAddress**](OrderAddress.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

