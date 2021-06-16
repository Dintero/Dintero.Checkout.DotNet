# Dintero.OpenApiClient.Checkout.Model.DiscountsConfigurationDiscountsOrder
Configure discounts calculation on the session order. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Enable discount calculation on order items eligible for discount  - A session that has the &#x60;customer.customer_id&#x60; set will have   its discounts calculated when the session is created.  - A session with no customer_id will only have the discounts   calculated when the customer is identified by the checkout   page.  - The autorized amount will be the net amount from the   original session amount specified when the session was   created.  | [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

