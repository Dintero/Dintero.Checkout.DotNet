# Dintero.OpenApiClient.Checkout.Model.CountryConfigurationCountries
Country preferences 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PreferredCountry** | **string** | Country to use as default in address and phone country code  | [optional] 
**AllowCountries** | **List&lt;string&gt;** | List of countries where the customer is allowed to set their address. If empty, all countries are allowed, except for the ones in &#x60;deny_countries&#x60;.  A country can not be in both &#x60;allow_countries&#x60; and &#x60;deny_countries&#x60;.  | [optional] 
**DenyCountries** | **List&lt;string&gt;** | List of countries where the customer is not allowed to set their address.  A country can not be in both &#x60;allow_countries&#x60; and &#x60;deny_countries&#x60;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

