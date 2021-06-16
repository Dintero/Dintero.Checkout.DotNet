# Dintero.OpenApiClient.Checkout - the C# library for the Checkout API

# Changelog
All notable changes to the API.

## 2021-06-01

> new: Support `bambora.mobilepay` payment product type. Extend configuration on
> gateway and session to enable MobilePay payment via Bambora Wallet service. The
> payment type must be enabled by Bambora.
> - [PUT /v1/admin/checkout](#operation/admin_checkout_id_put)
> - [POST /v1/session-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions/{session_id}/pay](#operation/checkout_sid_pay_post)

> doc: Fix documentation for payment-token session endpoint. `session` and
> `payment_token` are required when creating payment-token session.
> - [POST /v1/sessions/payment-token](#operation/checkout_payment_token_session_post)

> new: Support `enable_on_hold`-configuration on session configuration and in checkout configuration
> - [POST /v1/session-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [PUT /v1/admin/checkout](#operation/admin_checkout_id_put)

## 2021-05-01

> new: Support `bambora.vipps` payment product type. Extend configuration on
> gateway and session to enable Vipps payment via Bambora Wallet service. The
> payment type must be enabled by Bambora.
> - [PUT /v1/admin/gateways/bambora](#operation/admin_checkout_id_gw_bambora_put)
> - [PUT /v1/admin/checkout](#operation/admin_checkout_id_put)
> - [POST /v1/session-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions/{session_id}/pay](#operation/checkout_sid_pay_post)

> **new**: Support session profile configuration when creating payment-token session
> - [POST /v1/sessions/payment-token](#operation/checkout_payment_token_session_post)

> **new**: Extend  shipping_address_callback response with support for updating 
> the checkout session in addition to returning available shipping options. This will allow
> the callback endpoint to update the content of the order, like changing amount, or
> currency or update the items in the order.
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST examples/shipping_address_callback_url](#operation/example_shipping_address_callback_url)


## 2021-04-01

> **change**: Add support for void on part capture. Void can be used to release
> the remaining authorization on a part captured transaction. The support is
> limited to `payex.creditcard` transactions.
> - [POST /v1/transactions/{id}/void](#operation/transactions_id_void_post)

> **change**: Add support for `language` query parameter when getting payment
> operations
> - [POST /v1/view/{session_id}/payments/{payment_product_type}](#operation/checkout_sid_payments_product_type_post)

> **change**: Add support Bambora creditcard payment.
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)

> **change**: Add support for bypassing the Dintero redirect for in_app-payments, and
> redirect from app to app.
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)

## 2021-03-01
> **change** Add support for includes query parameter in session url.callback_url.
> `includes` set to session will enable the sessions url.callback_url to include session data in the body.
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)

## 2021-02-01

> **new**: It is now possible to use full ISO 8601 compliant datetimes in date range queries.
> Note: If timezone isn't specified, UTC is assumed
> Note: To keep things backwards compatible, end-dates with the \"yyyy-mm-dd\" format will be 
> shifted forward by a day.
> - [GET /v1/transactions](#operation/transactions_get)
> - [GET /v1/sessions](#operation/checkout_sessions_get)

> **new**: Add possibility to create myDintero-user in address change 
> - [POST /v1/view/{session_id}/session/order/addresses](#operation/checkout_sid_json_order_addresses_put)

> **new**: Extend transaction data with embedded session data
> `includes` now supports 'session'
>  - [GET /v1/transactions/{id}](#operation/transactions_id_get)

> **new**: Extend Vipps transaction metadata with
> `vipps:merchantInfo.merchantSerialNumber`, the Merchant Serial Number
> (MSN) that was used when the transaction was initiated.

> **new** Add support for setting settlements on a transaction, one event
> per payout to a bank account
> - [POST /v1/transactions/events/payout](#operation/transactions_events_payout_post)

> **new**: Version support when updating PayEx gateway configuration. The
> new option allows the gateway to be configured with multiple merchant
> agreements
> - [PUT /v1/admin/gateways/payex](#operation/admin_checkout_id_gw_payex_put)
> - [PUT /v1/admin/gateways/payex/override](#operation/admin_checkout_id_gw_override_payex_put)

> **change**: Add support for additional query parameters.
> `search` will match on merchant reference's and customer name
> `transaction_id` will filter results to include only sessions associated with the provided transaction ids
> `created_at.gte` will exclude all sessions created before provided date
> `created_at.lte` will exclude all sessions created after provided date
> - [GET /v1/sessions](#operation/checkout_sessions_get)

## 2021-01-01

> **new**: Endpoint for initiating MIT payments
> - [POST /v1/sessions/pay](#operation/checkout_session_pay_post)

> **new**: Checkout sessions and profiles supports theming via `configuration.theme`
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST /admin/session/profiles](#operation/admin_session_profile_post)

## 2020-12-01

> **new**: Add support for using external discount codes in Express checkout.
> A session can be configured with a `express.discount_code_callback_url` that will be
> invoked when the session is updated with a promotion code. The response from
> the callback will then be used to adjust the order and shipping options
> available.
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST examples/discount_code_callback_url](#operation/example_discount_code_callback_url)

> **new**: Add support for an advance credit check of Collector B2B customers
> - [POST /v1/creditchecks](#operation/creditchecks_post)


## 2020-11-01

> **new**: Add support for overriding Collector gateway settings
> - [PUT /v1/admin/gateways/collector/override](#operation/admin_checkout_id_gw_override_collector_put)

> **new** Add support for `collector.invoice_b2b_preapproved` and `collector.installment_b2b_preapproved` payment

> **new** Async transaction operations. The response status from
> capture, refund or void can now be `202` if the request was accepted
> but the processing has not been completed.
>
> The transaction with an operation that was accepted will receive a
> update later when the processing completes.
> The event that completes the operation will include an
> `initiate_request_id` property.
> You can use the `callback_url` to receive a callback when the
> processing completes.
>
> The status of the transaction will remain unchanged until the processing
> of the operation completes.
>
> - [POST /v1/transactions/{id}/capture](#operation/transactions_id_capture_post)
> - [POST /v1/transactions/{id}/refund](#operation/transactions_id_refund_post)
> - [POST /v1/transactions/{id}/void](#operation/transactions_id_void_post)

> **new** Add support for callback when transaction is updated. You can now
> receive callbacks on captures, refunds and void by including
> `report_event=<event>` query parameter in the `callback_url`.
>
>     https://example.com/callback?report_event=CAPTURE&report_event=REFUND
>
>
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

## 2020-10-01

> **new** Added `in_store` as a possible payment channel for
> payments in physical stores.
>
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

## 2020-09-01

> **new** Added option for configurating the payment channel.
> See `configuration.channel`. The new option add support for
> `in_app` channel with appswitch deeplink URL (Vipps).
>
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

> **new** Add support for optional `order.discount_lines` when creating
> a new sessions.
>
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

> **new** Add support for updating a session
> - [PUT /v1/sessions/{session_id}](#operation/checkout_session_put)
> - [POST /view@{session_id}@session@lock](#operation/checkout_sid_lock)

> `total_income` moved from applicant to top level for instabank.invoice and instabank.installment.
> The field is required, but there will be a grace period of two months before it is enforced.
> Deprecated `applicant.total_income`
>
> - [POST /v1/sessions/pay](#operation/checkout_sid_pay_post)

## 2020-08-01

> **new** Add support for optional `metadata` when creating
> a new session.
>
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

> **new** Add support for optional `merchant_reference_2` when
> creating a new session
>
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

> **new** Add support for delayed callback. You can enable the delay callback feature
> by including `delay_callback=<seconds>` query parameter in the `callback_url`
>
>     https://example.com/callback?delay_callback=30
>

## 2020-07-01

> **new**: Add support for overriding Netaxept gateway settings
> - [PUT /v1/admin/gateways/netaxept/override](#operation/admin_checkout_id_gw_override_netaxept_put)

> **new**: Add terminal options for Netaxept creditcard payment. Enable use of
> Netaxept hosted checkout, and provided custom configuration.

> **new**: Add support for Netaxept.
> - [GET /view/{session_id}/netaxept](#operation/checkout_sid_netaxept_html_get)

> **new**: Add support for overriding PayEx gateway settings
> - [PUT /v1/admin/gateways/payex/override](#operation/admin_checkout_id_gw_override_payex_put)

> **new**: Include payment token in transaction details
> - [GET /v1/transactions/{id}?includes=card.payment_token](#operation/transactions_id_get)

> **new** Added option for using payment token for payex.creditcard payments
> to prefill payment details so the customer (payer) do not need to enter all
> these details for every purchase.

> **new** Added option for generating payment token for payex.creditcard
> payments, see `configuration.payex.creditcard`. Use the new option to
> generate a payment token that can be used in future payments to prefill
> the details for the creditcard.

> **new** Added `instabank.postponement` payment type.

> **new** Added `swish.swish` payment type, direct integration with Swish.

## 2020-06-01

> **change** Add support for `ON_HOLD` transaction status. The new status
> is limited to Collector transactions, to signal that the processing
> of the transaction is not yet completed. The new status will be used in
> cases where Collector performs aditional controls before approving the
> payment.

> **new** Add support for setting `merchant_reference_2` to an existing
> transaction and search for transactions by `merchant_reference_2`.
>
> - [PUT /v1/transaction/{transction_id}](#operation/transactions_id_put)
> - [GET /v1/transactions](#operation/transactions_get)

## 2020-05-01

> **new** Add support for POST callback with the authorized transaction
> included in the request body. You can enable the POST callback feature
> by including `method=POST` query parameter in the `callback_url`
>
>     https://example.com/callback?method=POST
>
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)

## 2020-04-01

> **new** Add support for `instabank.installment` payment

> **changed**: Removed error `capture` from list of valid error added to
> the redirect to the `url.redirect_url`. The error was used for payments with
> `auto-capture` enabled, and set in case where the auto capture failed.
> The merchant can assume the transaction will be captured automatically as
> soon as possible when creating a session with `auto-capture` enabled.
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)

> **changed**: A callback (when `url.callback_url` is set) will now be sent
> as soon as possible after the transaction is `AUTHORIZED`. We will no longer
> wait until the transaction `CAPTURED` in case when `auto-capture` is enabled.
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)

> **change**: Add support for creating session with Ingenico enabled
> - [POST /sessions-profile](#operation/checkout_session_profile_post)
> - [POST /sessions](#operation/checkout_session_post)
> - [POST /admin/session/profiles](#operation/admin_session_profile_post)

> **change**: Add support for creating session with Ingenico enabled
> - [POST /sessions-profile](#operation/checkout_session_profile_post)
> - [POST /sessions](#operation/checkout_session_post)
> - [POST /admin/session/profiles](#operation/admin_session_profile_post)

> **new** Add support for `collector.invoice_b2b` payment

## 2020-03-01

> **new** Add support for configuring Ingenico gateway
> - [PUT /admin/gateways/ingenico](#operation/admin_checkout_id_gw_ingenico_put)

> **new** Add support for enabling `Dintero-Signature` header for all
> system-to-system request sent from Dintero to the merchant
> - [POST /v1/admin/signature](#operation/admin_signature_post)

> **fix**: Documentation for endpoint [GET /v1/admin/api-keys](#operation/admin_api_keys_get).
> The resource returns a list of api-keys, not a single api-key.

> **new** Add support for `collector.installment` payment

> **new** Add support for putting merchant_terms_url in profile and session
> - [POST /v1/admin/session/profiles](#operation/admin_session_profile_post)
> - [PUT /v1/admin/session/profiles/{profile_id}](#operation/admin_session_profile_details_put)
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)

> **new** Add support for overriding gateway settings
> - [PUT /v1/admin/gateways/vipps/override](#operation/admin_checkout_id_gw_override_vipps_put)
> - [PUT /v1/admin/gateways/santander/override](#operation/admin_checkout_id_gw_override_santander_put)

## 2019-12-01

> **new** Add support for `include_session` query parameter
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

> **new** Add support for discount calculation on sessions.
> The discounts will be calculated when customer is identified
>
> Extend the order and transaction items with new properties to
> support discount calculation of session:
> - `discount_lines`
> - `gross_amount`
> - `is_change`
> - `eligible_for_discount`
>
> Support calculating and updating session with discount from:
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

> **new** Add store property to `session.order` and transaction.
> Adds support for including details about the sales location in the order

> **new** Add `shipping_option` from `session.order` to to `transaction`
> - [GET /transactions](#operation/transactions_get)
> - [GET /transactions/{id}](#operation/transactions_id_get)

> **changed** Minor changes to the `shipping_option` object(s) in sessions
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [GET /v1/sessions](#operation/checkout_sessions_get)
> - [GET /v1/sessions/{session_id}](#operation/checkout_session_get)
> - [GET /view/{session_id}/session](#operation/checkout_sid_json_get)

> **new** Add an endpoint for abandon a checkout payment
> - [POST /view/{session_id}/session/abandon](#operation/view_sid_session_abandon_post)

## 2019-11-01

> **changed**: Express Checkout flow added to sessions
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [GET /v1/sessions](#operation/checkout_sessions_get)
> - [GET /v1/sessions/{session_id}](#operation/checkout_session_get)
> - [GET /view/{session_id}/session](#operation/checkout_sid_json_get)

> **new** Update a an Express Checkout session order
> - [PUT /view/{session_id}/session](#operation/checkout_sid_json_put)

> **new**: Extend Transaction with optional `billing_address` field.

## 2019-10-01

> **new**: Extend Transaction Event with correction field
> to handle correction of status after operations errors

> **changed**: previously required fields are now optional for `instabank.finance`.
> - mortgage_debt
> - student_debt
> - other_secured_debt

> **changed**: Payments for _payment product type_ `instabank.invoice` now
> contain an optional `applicant` object used for sending more details about
> the payee. The applicant data will be required for amounts over a limit
> specified by Instabank.
> - [POST /v1/sessions/{session_id}/pay](#operation/checkout_sid_pay_post)


> **changed**: Payment sessions with `instabank.invoice` now contains an
> `require_applicant` boolean flag in the _instabank invoice configuration_
> when getting the session.
> - [GET /v1/sessions/{session_id}](#operation/checkout_session_get)

> **changed**: Adds detailed debt array to `instabank.finance`.

## 2019-09-01

> **changed**: Disabled `instabank.invoice` for amounts less than 500 NOK

> **new**: Filter transaction list by `payment_product_type`:
> - instabank.finance
> - instabank.invoice
> - vipps
> - payex.creditcard
> - payex.swish

> **new**: Filter transactions list by `card_brand`:
> - Visa
> - MasterCard

> **new**: Added optional `remember_me` boolean to POST pay request body
> when initializing a payment of a session.
> - [POST /v1/sessions/{session_id}/pay](#operation/checkout_sid_pay_post)

## 2019-07-01

> **fix**: `Transaction.status` typo, rename `PARTICALLY_CAPTURED_REFUNDED` to
> `PARTIALLY_CAPTURED_REFUNDED`.

> **changed**: replaced `card` payment type with `payex`. The payex
> payment type adds support for payment product types:
> - payex.creditcard
> - payex.swish

> **changed**: Add support for optional custom expires_at parameter when
> creating a new session either directly or from a profile.
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

> **changed**: Add support for override of configuration when creating
> a new session from a profile.
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)

> **new**: support cancel of session
> - [POST /v1/sessions/{session_id}/cancel](#operation/checkout_session_cancel_post)

> **changed**: In SessionBase, extend order with `partial_payment`
> property that can be used in case where the payment is partial
> and the `order.amount` is less or equal to the `order.items.amount`.
> - [POST /v1/sessions](#operation/checkout_session_post)
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)

## 2019-06-01

> **break**: Pay with `instabank.finance` type requires now additional
> properties to comply with new regulations from Finanstilsynet.
> - [POST /v1/sessions/{session_id}/pay](#operation/checkout_sid_pay_post)
> **changed**: In SessionMeta events, extend event with `details` object
> and enumerate the event names available.
> - [GET /v1/sessions/{session_id}](#operation/checkout_session_get)

> **changed**: Remove `instabank.installment` and
> `instabank.postponement` payment type. The types will no longer be
> accepted by:
> - [PUT /v1/admin/checkout](#operation/admin_checkout_id_put)
> - [PUT /v1/admin/gateways/instabank](#operation/admin_checkout_id_gw_instabank_put)
> - [POST /v1/admin/session/profiles](#operation/admin_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

## 2019-05-01
> In SessionMeta renamed field  `expiry_at` to `expires_at`.

> **new**: PaymentConfiguration extended with optional `auto_capture` boolean field. If set to true the
> checkout serivce will automatically capture the payment after the transaction is `AUTHORIZED`.

> **new**: Add support for checkout with SMS.
> A SMS with link to the checkout can now be sent when a new
> session is created.
> See relevant resources for more information.
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)

## 2019-04-01

> **fix**: Fix documentation for the response from [api-keys](#tag/api-keys)
> endpoints. No `gateways` property will be included in response to api-keys
> requests.

> **doc**: Document support for JWT Bearer authentication. Use API client
> to get an JWT access token.
> - [Create Client](https://docs.dintero.com/api.html#operation/aid_auth_clients_post)
> - [Get token](https://docs.dintero.com/api.html#operation/aid_auths_oauth_token_post)

## 2019-03-01

> **break**: Administration of checkout gateways was moved to new
> endpoints. Gateway configuration will no longer be supported via
> the `PUT /admin/checkout` endpoint.
> - [PUT /admin/checkout](#operation/admin_checkout_id_put)
> - [POST /admin/gateways/{gateway}/status](#operation/admin_checkout_gw_type_status_post)
> - [PUT /admin/gateways/instabank](#operation/admin_checkout_id_gw_instabank_put)
> - [PUT /admin/gateways/vipps](#operation/admin_checkout_id_gw_vipps_put)
>
> **removed**:
> - ~`POST /admin/gateways/{gateway}`~ (check gateway status)

> **new**: Extend transaction.event with `created_by` property.
> Include the user who created the event, i.e. applied an operation
> to the transaction.

## 2019-01-31

> **new**: Add support for checkout with QR-Code
> A QR Code can now be generated for a Checkout Session or a Sale Location.
> See relevant resource for more information.
> - [POST /v1/locations/{location_id}/qr](#operation/qr_locations_lid_post)
> - [POST /v1/sessions/{session_id}/qr](#operation/qr_sessions_sid_post)
> - [POST /v1/locations/{location_id}/checkout/{session_id}](#operation/qr_locations_lid_checkout_sid_post)
> - [DELETE /v1/locations/{location_id}/checkout/{session_id}](#operation/qr_locations_lid_checkout_sid_delete)

> **new**: Add support for filter transactions with query parameters.
> Transactions can now be filtered on: `status`, `payment_product`,
> `merchant_reference`, `session_id`, `amount` and `created_at`.
> - [GET /v1/transactions](#operation/transactions_get)

## 2018-11-24

> **new**: Add support for `session.url.callback_url`. Get system-to-system
>  notification when session payment is completed.
> - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)
> - [POST /v1/sessions](#operation/checkout_session_post)





This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: LATEST
- SDK version: 1.0.0
- Build date: 2021-06-16T11:26:58.374561Z[Etc/UTC]
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Dintero.OpenApiClient.Checkout.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");
            // Configure API key authorization: adminKey
            config.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ApiKeysApi(config);
            var apiKeyId = apiKeyId_example;  // string | 

            try
            {
                // Rotate api-key
                InlineResponse200 result = apiInstance.AdminApiKeysApiKeyIdRotatePost(apiKeyId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApiKeysApi.AdminApiKeysApiKeyIdRotatePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApiKeysApi* | [**AdminApiKeysApiKeyIdRotatePost**](docs/ApiKeysApi.md#adminapikeysapikeyidrotatepost) | **POST** /admin/api-keys/{api_key_id}/rotate-api-key | Rotate api-key
*ApiKeysApi* | [**AdminApiKeysGet**](docs/ApiKeysApi.md#adminapikeysget) | **GET** /admin/api-keys | List api-keys
*ApiKeysApi* | [**AdminApiKeysPost**](docs/ApiKeysApi.md#adminapikeyspost) | **POST** /admin/api-keys | Create api-key
*ApiKeysApi* | [**AdminParametersApiKeyDelete**](docs/ApiKeysApi.md#adminparametersapikeydelete) | **DELETE** /admin/api-keys/{api_key_id} | Delete api-key
*BamboraApi* | [**CheckoutBamboraCallbackGet**](docs/BamboraApi.md#checkoutbamboracallbackget) | **GET** /sessions/{session_id}/bambora/callback/{callback_ref} | Handle Bambora callback
*BamboraApi* | [**CheckoutSidBamboraRedirectGet**](docs/BamboraApi.md#checkoutsidbamboraredirectget) | **GET** /sessions/{session_id}/bambora/redirect/{redirect_ref} | Handle redirect from payment
*BamboraGatewayApi* | [**AdminCheckoutIdGwBamboraPut**](docs/BamboraGatewayApi.md#admincheckoutidgwbamboraput) | **PUT** /admin/gateways/bambora | Update Bambora gateway
*CheckoutApi* | [**AdminCheckoutIdGet**](docs/CheckoutApi.md#admincheckoutidget) | **GET** /admin/checkout | Get payment checkout configuration
*CheckoutApi* | [**AdminCheckoutIdPut**](docs/CheckoutApi.md#admincheckoutidput) | **PUT** /admin/checkout | Update payment checkout configuration
*CheckoutApi* | [**QrLocationsLidCheckoutSidDelete**](docs/CheckoutApi.md#qrlocationslidcheckoutsiddelete) | **DELETE** /locations/{location_id}/checkout/{session_id} | Remove session from a location
*CheckoutApi* | [**QrLocationsLidCheckoutSidPost**](docs/CheckoutApi.md#qrlocationslidcheckoutsidpost) | **POST** /locations/{location_id}/checkout/{session_id} | Enable session on a location
*CollectorApi* | [**CheckoutSidCollectorCallbackPost**](docs/CollectorApi.md#checkoutsidcollectorcallbackpost) | **GET** /callbacks/collector/antifraud | Handle Collector Anti-fraud callback after an update
*CollectorApi* | [**CheckoutSidCollectorRedirectGet**](docs/CollectorApi.md#checkoutsidcollectorredirectget) | **GET** /sessions/{session_id}/collector/redirect | Handle redirect from payment
*CollectorGatewayApi* | [**AdminCheckoutIdGwCollectorPut**](docs/CollectorGatewayApi.md#admincheckoutidgwcollectorput) | **PUT** /admin/gateways/collector | Update Collector gateway
*CollectorGatewayApi* | [**AdminCheckoutIdGwOverrideCollectorPut**](docs/CollectorGatewayApi.md#admincheckoutidgwoverridecollectorput) | **PUT** /admin/gateways/collector/override | Update overrides for Collector Gateway
*CreditchecksApi* | [**CreditchecksPost**](docs/CreditchecksApi.md#creditcheckspost) | **POST** /creditchecks | Perform a credit check
*ExampleSessionCallbacksApi* | [**ExampleDiscountCodesCallbackUrl**](docs/ExampleSessionCallbacksApi.md#examplediscountcodescallbackurl) | **POST** /examples/discount_code_callback_url | Discount codes Update
*ExampleSessionCallbacksApi* | [**ExampleShippingAddressCallbackUrl**](docs/ExampleSessionCallbacksApi.md#exampleshippingaddresscallbackurl) | **POST** /examples/shipping_address_callback_url | Address Update
*GatewaysApi* | [**AdminCheckoutGwTypeStatusPost**](docs/GatewaysApi.md#admincheckoutgwtypestatuspost) | **POST** /admin/gateways/{gateway}/status | Check gateway status
*GatewaysApi* | [**EventsTransactionPost**](docs/GatewaysApi.md#eventstransactionpost) | **POST** /events/transaction/{intent} | process transaction event
*GenerateCheckoutImageApi* | [**BrandingLogoframe**](docs/GenerateCheckoutImageApi.md#brandinglogoframe) | **GET** /branding/logos/{logos}/variant/{variant}/color/{color}/width/{width}/{template} | Get payment logos image
*GenerateCheckoutImageApi* | [**BrandingProfile**](docs/GenerateCheckoutImageApi.md#brandingprofile) | **GET** /branding/profiles/{profile_id}/variant/{variant}/color/{color}/width/{width}/{template} | Get checkout profile image
*GenerateQRCodeApi* | [**QrLocationsLidPost**](docs/GenerateQRCodeApi.md#qrlocationslidpost) | **POST** /locations/{location_id}/qr | QR Code for a Location.
*GenerateQRCodeApi* | [**QrSessionsSidPost**](docs/GenerateQRCodeApi.md#qrsessionssidpost) | **POST** /sessions/{session_id}/qr | QR Code for a Session
*IngenicoApi* | [**CheckoutIngenicoWebhooksGet**](docs/IngenicoApi.md#checkoutingenicowebhooksget) | **GET** /events/gateways/ingenico/transaction/hooks | Handle Ingenico webhooks url validation
*IngenicoApi* | [**CheckoutIngenicoWebhooksPost**](docs/IngenicoApi.md#checkoutingenicowebhookspost) | **POST** /events/gateways/ingenico/transaction/hooks | Handle Ingenico webhooks
*IngenicoApi* | [**CheckoutSidIngenicoRedirectGet**](docs/IngenicoApi.md#checkoutsidingenicoredirectget) | **GET** /sessions/{session_id}/ingenico/redirect/{redirect_ref} | Handle redirect from payment
*IngenicoGatewayApi* | [**AdminCheckoutIdGwIngenicoPut**](docs/IngenicoGatewayApi.md#admincheckoutidgwingenicoput) | **PUT** /admin/gateways/ingenico | Update Ingenico gateway
*InstabankGatewayApi* | [**AdminCheckoutIdGwInstabankPut**](docs/InstabankGatewayApi.md#admincheckoutidgwinstabankput) | **PUT** /admin/gateways/instabank | Update Instabank gateway
*NetaxeptApi* | [**CheckoutNetaxeptWebhooksPost**](docs/NetaxeptApi.md#checkoutnetaxeptwebhookspost) | **POST** /events/gateways/netaxept/transaction/hooks | Handle Netaxept callback
*NetaxeptApi* | [**CheckoutSidNetaxeptHtmlGet**](docs/NetaxeptApi.md#checkoutsidnetaxepthtmlget) | **GET** /view/{session_id}/netaxept | Redirect to Netaxept hosted payment window
*NetaxeptApi* | [**CheckoutSidNetaxeptRedirectGet**](docs/NetaxeptApi.md#checkoutsidnetaxeptredirectget) | **GET** /sessions/{session_id}/netaxept/redirect/{redirect_ref} | Handle redirect from payment
*NetaxeptGatewayApi* | [**AdminCheckoutIdGwNetaxeptPut**](docs/NetaxeptGatewayApi.md#admincheckoutidgwnetaxeptput) | **PUT** /admin/gateways/netaxept | Update Netaxept gateway
*NetaxeptGatewayApi* | [**AdminCheckoutIdGwOverrideNetaxeptPut**](docs/NetaxeptGatewayApi.md#admincheckoutidgwoverridenetaxeptput) | **PUT** /admin/gateways/netaxept/override | Update overrides for Netaxept Gateway
*PayexApi* | [**CheckoutSidCallbackPost**](docs/PayexApi.md#checkoutsidcallbackpost) | **POST** /sessions/{session_id}/payex/callback/{payment_product_type} | Handle Payex callback after a change or update 
*PayexApi* | [**CheckoutSidPayexRedirectGet**](docs/PayexApi.md#checkoutsidpayexredirectget) | **GET** /sessions/{session_id}/payex/redirect/{action}/{payment_product_type} | Handle redirect from payment
*PayexGatewayApi* | [**AdminCheckoutIdGwOverridePayexPut**](docs/PayexGatewayApi.md#admincheckoutidgwoverridepayexput) | **PUT** /admin/gateways/payex/override | Update overrides for PayEx Gateway
*PayexGatewayApi* | [**AdminCheckoutIdGwPayexPut**](docs/PayexGatewayApi.md#admincheckoutidgwpayexput) | **PUT** /admin/gateways/payex | Update PayEx gateway
*PaymentApi* | [**CheckoutSessionPayPost**](docs/PaymentApi.md#checkoutsessionpaypost) | **POST** /sessions/pay | Create and pay merchant initiated session
*PaymentApi* | [**CheckoutSidPayPost**](docs/PaymentApi.md#checkoutsidpaypost) | **POST** /sessions/{session_id}/pay | Initiate a checkout payment
*PaymentApi* | [**CheckoutSidRedirectGet**](docs/PaymentApi.md#checkoutsidredirectget) | **GET** /sessions/{session_id}/redirect/{redirect_ref} | Handle redirect from payment
*PaymentApi* | [**CheckoutSidSantanderRedirectGet**](docs/PaymentApi.md#checkoutsidsantanderredirectget) | **GET** /sessions/{session_id}/santander/redirect | Handle redirect from payment
*ProfilesApi* | [**AdminSessionProfileDetailsDelete**](docs/ProfilesApi.md#adminsessionprofiledetailsdelete) | **DELETE** /admin/session/profiles/{profile_id} | Delete session profile
*ProfilesApi* | [**AdminSessionProfileDetailsGet**](docs/ProfilesApi.md#adminsessionprofiledetailsget) | **GET** /admin/session/profiles/{profile_id} | Get session profile details
*ProfilesApi* | [**AdminSessionProfileDetailsPut**](docs/ProfilesApi.md#adminsessionprofiledetailsput) | **PUT** /admin/session/profiles/{profile_id} | Update session profile
*ProfilesApi* | [**AdminSessionProfileGet**](docs/ProfilesApi.md#adminsessionprofileget) | **GET** /admin/session/profiles | List profiles
*ProfilesApi* | [**AdminSessionProfilePost**](docs/ProfilesApi.md#adminsessionprofilepost) | **POST** /admin/session/profiles | Create session profile
*SantanderGatewayApi* | [**AdminCheckoutIdGwOverrideSantanderPut**](docs/SantanderGatewayApi.md#admincheckoutidgwoverridesantanderput) | **PUT** /admin/gateways/santander/override | Update store override for Santander gateway
*SantanderGatewayApi* | [**AdminCheckoutIdGwSantanderPut**](docs/SantanderGatewayApi.md#admincheckoutidgwsantanderput) | **PUT** /admin/gateways/santander | Update Santander gateway
*SecretsApi* | [**AdminSignatureGet**](docs/SecretsApi.md#adminsignatureget) | **GET** /admin/signature | Get signature secret
*SecretsApi* | [**AdminSignaturePost**](docs/SecretsApi.md#adminsignaturepost) | **POST** /admin/signature | Create signature secret
*SessionApi* | [**CheckoutPaymentTokenSessionPost**](docs/SessionApi.md#checkoutpaymenttokensessionpost) | **POST** /sessions/payment-token | Payment token session
*SessionApi* | [**CheckoutSessionCancelPost**](docs/SessionApi.md#checkoutsessioncancelpost) | **POST** /sessions/{session_id}/cancel | Cancel session
*SessionApi* | [**CheckoutSessionGet**](docs/SessionApi.md#checkoutsessionget) | **GET** /sessions/{session_id} | Get checkout session details
*SessionApi* | [**CheckoutSessionPost**](docs/SessionApi.md#checkoutsessionpost) | **POST** /sessions | Create a checkout session
*SessionApi* | [**CheckoutSessionProfilePost**](docs/SessionApi.md#checkoutsessionprofilepost) | **POST** /sessions-profile | Create checkout session from profile
*SessionApi* | [**CheckoutSessionPut**](docs/SessionApi.md#checkoutsessionput) | **PUT** /sessions/{session_id} | Update checkout session details
*SessionApi* | [**CheckoutSessionsGet**](docs/SessionApi.md#checkoutsessionsget) | **GET** /sessions | List checkout sessions
*SwishApi* | [**CheckoutSidSwishGet**](docs/SwishApi.md#checkoutsidswishget) | **GET** /view/{session_id}/swish/{payment_request_id}/status | Get status about the Swish session. 
*SwishApi* | [**CheckoutSidSwishRedirectGet**](docs/SwishApi.md#checkoutsidswishredirectget) | **GET** /sessions/{session_id}/swish/redirect/{redirect_ref} | Handle redirect from payment
*SwishApi* | [**CheckoutSwishPaymentCallbackPost**](docs/SwishApi.md#checkoutswishpaymentcallbackpost) | **POST** /events/gateways/swish/transaction/payment/{session_id}/{callback_ref} | Handle Swish payment callback
*SwishApi* | [**CheckoutSwishRefundCallbackPost**](docs/SwishApi.md#checkoutswishrefundcallbackpost) | **POST** /events/gateways/swish/transaction/refund/{id}/{callback_ref} | Handle Swish refund callback
*SwishGatewayApi* | [**AdminCheckoutIdGwOverrideSwishPut**](docs/SwishGatewayApi.md#admincheckoutidgwoverrideswishput) | **PUT** /admin/gateways/swish/override | Update store override for Swish gateway
*SwishGatewayApi* | [**AdminCheckoutIdGwSwishPut**](docs/SwishGatewayApi.md#admincheckoutidgwswishput) | **PUT** /admin/gateways/swish | Update Swish gateway
*TransactionsApi* | [**TransactionsEventsSettlementsPost**](docs/TransactionsApi.md#transactionseventssettlementspost) | **POST** /transactions/events/settlements | Update transactions with settlements
*TransactionsApi* | [**TransactionsGet**](docs/TransactionsApi.md#transactionsget) | **GET** /transactions | List all transactions
*TransactionsApi* | [**TransactionsIdCapturePost**](docs/TransactionsApi.md#transactionsidcapturepost) | **POST** /transactions/{id}/capture | Capture a transaction
*TransactionsApi* | [**TransactionsIdGet**](docs/TransactionsApi.md#transactionsidget) | **GET** /transactions/{id} | Get a transaction
*TransactionsApi* | [**TransactionsIdPut**](docs/TransactionsApi.md#transactionsidput) | **PUT** /transactions/{id} | Update a transaction
*TransactionsApi* | [**TransactionsIdRefundPost**](docs/TransactionsApi.md#transactionsidrefundpost) | **POST** /transactions/{id}/refund | Refund transaction
*TransactionsApi* | [**TransactionsIdVoidPost**](docs/TransactionsApi.md#transactionsidvoidpost) | **POST** /transactions/{id}/void | Void transaction
*ViewApi* | [**CheckoutSidHtmlGet**](docs/ViewApi.md#checkoutsidhtmlget) | **GET** /view/{session_id} | Get the Checkout page
*ViewApi* | [**CheckoutSidJsonGet**](docs/ViewApi.md#checkoutsidjsonget) | **GET** /view/{session_id}/session | Get checkout details
*ViewApi* | [**CheckoutSidJsonOrderAddressesPut**](docs/ViewApi.md#checkoutsidjsonorderaddressesput) | **PUT** /view/{session_id}/session/order/addresses | Set Express Checkout addresses
*ViewApi* | [**CheckoutSidJsonOrderDiscountCodesPut**](docs/ViewApi.md#checkoutsidjsonorderdiscountcodesput) | **PUT** /view/{session_id}/session/order/discount_codes | Set Express Checkout discount codes
*ViewApi* | [**CheckoutSidJsonOrderItemsShippingOptionPut**](docs/ViewApi.md#checkoutsidjsonorderitemsshippingoptionput) | **PUT** /view/{session_id}/session/order/shipping_option | Set Express Checkout shipping option
*ViewApi* | [**CheckoutSidJsonOrderShippingAddressPut**](docs/ViewApi.md#checkoutsidjsonordershippingaddressput) | **PUT** /view/{session_id}/session/order/shipping_address | Set Express Checkout shipping address
*ViewApi* | [**CheckoutSidLock**](docs/ViewApi.md#checkoutsidlock) | **POST** /view/{session_id}/session/lock | Lock a checkout session
*ViewApi* | [**CheckoutSidPaymentsProductTypePost**](docs/ViewApi.md#checkoutsidpaymentsproducttypepost) | **POST** /view/{session_id}/payments/{payment_product_type} | Get payment operations
*ViewApi* | [**CheckoutSidSendScc**](docs/ViewApi.md#checkoutsidsendscc) | **POST** /view/{session_id}/session/publish/scc | Send a verification code to the customer
*ViewApi* | [**ViewSidSessionAbandonPost**](docs/ViewApi.md#viewsidsessionabandonpost) | **POST** /view/{session_id}/session/abandon | Abandon a checkout payment
*ViewPosApi* | [**ViewLocationLidDetailsPost**](docs/ViewPosApi.md#viewlocationliddetailspost) | **GET** /view-location/{location_id}/details | Get location details
*ViewPosApi* | [**ViewLocationLidGet**](docs/ViewPosApi.md#viewlocationlidget) | **GET** /view-location/{location_id} | Get the Location Checkout page
*ViewPosApi* | [**ViewLocationLidSessionRedirectGet**](docs/ViewPosApi.md#viewlocationlidsessionredirectget) | **GET** /view-location/{location_id}/session/{redirect_ref} | Location redirect
*VippsApi* | [**CheckoutSidHtmlVippsGet**](docs/VippsApi.md#checkoutsidhtmlvippsget) | **GET** /view/{session_id}/vipps | Get the Vipps push notification page
*VippsApi* | [**CheckoutSidVippsPaymentsOrderidPost**](docs/VippsApi.md#checkoutsidvippspaymentsorderidpost) | **POST** /sessions/{session_id}/vipps/v2/payments/{order_id} | Handle Vipps callback after the payment request
*VippsGatewayApi* | [**AdminCheckoutIdGwOverrideVippsPut**](docs/VippsGatewayApi.md#admincheckoutidgwoverridevippsput) | **PUT** /admin/gateways/vipps/override | Update overrides for Vipps Gateway
*VippsGatewayApi* | [**AdminCheckoutIdGwVippsPut**](docs/VippsGatewayApi.md#admincheckoutidgwvippsput) | **PUT** /admin/gateways/vipps | Update Vipps gateway


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Address](docs/Address.md)
 - [Model.ApiKey](docs/ApiKey.md)
 - [Model.ApiKeyRead](docs/ApiKeyRead.md)
 - [Model.ApiKeyReadAllOf](docs/ApiKeyReadAllOf.md)
 - [Model.ApiKeyValue](docs/ApiKeyValue.md)
 - [Model.AutoCaptureConfiguration](docs/AutoCaptureConfiguration.md)
 - [Model.BamboraConfiguration](docs/BamboraConfiguration.md)
 - [Model.BamboraConfigurationCreditcard](docs/BamboraConfigurationCreditcard.md)
 - [Model.BamboraConfigurationMobilepay](docs/BamboraConfigurationMobilepay.md)
 - [Model.BamboraConfigurationVipps](docs/BamboraConfigurationVipps.md)
 - [Model.BamboraGwRead](docs/BamboraGwRead.md)
 - [Model.BamboraGwWrite](docs/BamboraGwWrite.md)
 - [Model.BamboraGwWriteAllOf](docs/BamboraGwWriteAllOf.md)
 - [Model.BamboraPaymentOperation](docs/BamboraPaymentOperation.md)
 - [Model.BamboraPaymentOperationAllOf](docs/BamboraPaymentOperationAllOf.md)
 - [Model.BamboraPaymentOperationAllOfSession](docs/BamboraPaymentOperationAllOfSession.md)
 - [Model.BamboraVippsPayment](docs/BamboraVippsPayment.md)
 - [Model.BamboraVippsPaymentAllOf](docs/BamboraVippsPaymentAllOf.md)
 - [Model.CheckoutConfig](docs/CheckoutConfig.md)
 - [Model.CheckoutConfigGateways](docs/CheckoutConfigGateways.md)
 - [Model.CheckoutConfigWrite](docs/CheckoutConfigWrite.md)
 - [Model.CheckoutConfigWriteConfiguration](docs/CheckoutConfigWriteConfiguration.md)
 - [Model.CheckoutConfigWriteConfigurationDetails](docs/CheckoutConfigWriteConfigurationDetails.md)
 - [Model.CheckoutConfigWriteConfigurationMerchant](docs/CheckoutConfigWriteConfigurationMerchant.md)
 - [Model.CheckoutConfigWriteConfigurationPaymentOptions](docs/CheckoutConfigWriteConfigurationPaymentOptions.md)
 - [Model.CollectorAddress](docs/CollectorAddress.md)
 - [Model.CollectorB2BAddress](docs/CollectorB2BAddress.md)
 - [Model.CollectorConfiguration](docs/CollectorConfiguration.md)
 - [Model.CollectorConfigurationFinance](docs/CollectorConfigurationFinance.md)
 - [Model.CollectorConfigurationInstallment](docs/CollectorConfigurationInstallment.md)
 - [Model.CollectorConfigurationInvoice](docs/CollectorConfigurationInvoice.md)
 - [Model.CollectorConfigurationInvoiceB2b](docs/CollectorConfigurationInvoiceB2b.md)
 - [Model.CollectorConfigurationInvoiceB2bOptions](docs/CollectorConfigurationInvoiceB2bOptions.md)
 - [Model.CollectorConfigurationInvoiceB2bPreapproved](docs/CollectorConfigurationInvoiceB2bPreapproved.md)
 - [Model.CollectorConfigurationInvoiceB2bPreapprovedAccounts](docs/CollectorConfigurationInvoiceB2bPreapprovedAccounts.md)
 - [Model.CollectorConfigurationInvoiceOptions](docs/CollectorConfigurationInvoiceOptions.md)
 - [Model.CollectorDetails](docs/CollectorDetails.md)
 - [Model.CollectorFinancePayment](docs/CollectorFinancePayment.md)
 - [Model.CollectorFinancePaymentAllOf](docs/CollectorFinancePaymentAllOf.md)
 - [Model.CollectorGwRead](docs/CollectorGwRead.md)
 - [Model.CollectorGwReadOptions](docs/CollectorGwReadOptions.md)
 - [Model.CollectorGwReadStores](docs/CollectorGwReadStores.md)
 - [Model.CollectorGwStoreOverrideRead](docs/CollectorGwStoreOverrideRead.md)
 - [Model.CollectorGwStoreOverrideWrite](docs/CollectorGwStoreOverrideWrite.md)
 - [Model.CollectorGwStoreOverrideWriteAllOf](docs/CollectorGwStoreOverrideWriteAllOf.md)
 - [Model.CollectorGwStoreOverrideWriteAllOfOptions](docs/CollectorGwStoreOverrideWriteAllOfOptions.md)
 - [Model.CollectorGwStoreOverrideWriteAllOfOptionsCustomerClient](docs/CollectorGwStoreOverrideWriteAllOfOptionsCustomerClient.md)
 - [Model.CollectorGwWrite](docs/CollectorGwWrite.md)
 - [Model.CollectorInstallmentB2BPreapprovedPayment](docs/CollectorInstallmentB2BPreapprovedPayment.md)
 - [Model.CollectorInstallmentB2BPreapprovedPaymentAllOf](docs/CollectorInstallmentB2BPreapprovedPaymentAllOf.md)
 - [Model.CollectorInstallmentB2BPreapprovedPaymentAllOfProduct](docs/CollectorInstallmentB2BPreapprovedPaymentAllOfProduct.md)
 - [Model.CollectorInstallmentPayment](docs/CollectorInstallmentPayment.md)
 - [Model.CollectorInstallmentPaymentAllOf](docs/CollectorInstallmentPaymentAllOf.md)
 - [Model.CollectorInstallmentPaymentOperation](docs/CollectorInstallmentPaymentOperation.md)
 - [Model.CollectorInstallmentPaymentOperationAllOf](docs/CollectorInstallmentPaymentOperationAllOf.md)
 - [Model.CollectorInvoiceB2BPayment](docs/CollectorInvoiceB2BPayment.md)
 - [Model.CollectorInvoiceB2BPaymentAllOf](docs/CollectorInvoiceB2BPaymentAllOf.md)
 - [Model.CollectorInvoiceB2BPreapprovedPayment](docs/CollectorInvoiceB2BPreapprovedPayment.md)
 - [Model.CollectorInvoiceB2BPreapprovedPaymentAllOf](docs/CollectorInvoiceB2BPreapprovedPaymentAllOf.md)
 - [Model.CollectorInvoicePayment](docs/CollectorInvoicePayment.md)
 - [Model.CollectorPaymentDetails](docs/CollectorPaymentDetails.md)
 - [Model.CollectorProduct](docs/CollectorProduct.md)
 - [Model.CountryConfiguration](docs/CountryConfiguration.md)
 - [Model.CountryConfigurationCountries](docs/CountryConfigurationCountries.md)
 - [Model.CreditchecksApplicant](docs/CreditchecksApplicant.md)
 - [Model.CreditchecksStore](docs/CreditchecksStore.md)
 - [Model.DiscountCodesOrderUpdate](docs/DiscountCodesOrderUpdate.md)
 - [Model.DiscountItem](docs/DiscountItem.md)
 - [Model.DiscountType](docs/DiscountType.md)
 - [Model.DiscountsConfiguration](docs/DiscountsConfiguration.md)
 - [Model.DiscountsConfigurationDiscounts](docs/DiscountsConfigurationDiscounts.md)
 - [Model.DiscountsConfigurationDiscountsExpressDiscountCodes](docs/DiscountsConfigurationDiscountsExpressDiscountCodes.md)
 - [Model.DiscountsConfigurationDiscountsOrder](docs/DiscountsConfigurationDiscountsOrder.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorError](docs/ErrorError.md)
 - [Model.GwVersion](docs/GwVersion.md)
 - [Model.GwVersionWrite](docs/GwVersionWrite.md)
 - [Model.Id](docs/Id.md)
 - [Model.IngenicoConfiguration](docs/IngenicoConfiguration.md)
 - [Model.IngenicoCreditCardPaymentOperation](docs/IngenicoCreditCardPaymentOperation.md)
 - [Model.IngenicoCreditCardPaymentOperationAllOf](docs/IngenicoCreditCardPaymentOperationAllOf.md)
 - [Model.IngenicoCreditCardPaymentOperationAllOfSession](docs/IngenicoCreditCardPaymentOperationAllOfSession.md)
 - [Model.IngenicoCreditcardPayment](docs/IngenicoCreditcardPayment.md)
 - [Model.IngenicoCreditcardPaymentAllOf](docs/IngenicoCreditcardPaymentAllOf.md)
 - [Model.IngenicoGwRead](docs/IngenicoGwRead.md)
 - [Model.IngenicoGwReadOptions](docs/IngenicoGwReadOptions.md)
 - [Model.IngenicoGwReadOptionsCardPaymentMethodSpecificInput](docs/IngenicoGwReadOptionsCardPaymentMethodSpecificInput.md)
 - [Model.IngenicoGwReadOptionsHostedCheckoutSpecificInput](docs/IngenicoGwReadOptionsHostedCheckoutSpecificInput.md)
 - [Model.IngenicoGwReadOptionsHostedCheckoutSpecificInputPaymentProductFilters](docs/IngenicoGwReadOptionsHostedCheckoutSpecificInputPaymentProductFilters.md)
 - [Model.IngenicoGwReadOptionsHostedCheckoutSpecificInputPaymentProductFiltersRestrictTo](docs/IngenicoGwReadOptionsHostedCheckoutSpecificInputPaymentProductFiltersRestrictTo.md)
 - [Model.IngenicoGwWrite](docs/IngenicoGwWrite.md)
 - [Model.IngenicoGwWriteAllOf](docs/IngenicoGwWriteAllOf.md)
 - [Model.IngenicoPaymentDetails](docs/IngenicoPaymentDetails.md)
 - [Model.IngenicoWebhookEvent](docs/IngenicoWebhookEvent.md)
 - [Model.IngenicoWebhookEventPayment](docs/IngenicoWebhookEventPayment.md)
 - [Model.IngenicoWebhookEventPaymentHostedCheckoutSpecificOutput](docs/IngenicoWebhookEventPaymentHostedCheckoutSpecificOutput.md)
 - [Model.IngenicoWebhookEventPaymentPaymentOutput](docs/IngenicoWebhookEventPaymentPaymentOutput.md)
 - [Model.IngenicoWebhookEventPaymentPaymentOutputAmountOfMoney](docs/IngenicoWebhookEventPaymentPaymentOutputAmountOfMoney.md)
 - [Model.IngenicoWebhookEventPaymentPaymentOutputCardPaymentMethodSpecificOutput](docs/IngenicoWebhookEventPaymentPaymentOutputCardPaymentMethodSpecificOutput.md)
 - [Model.IngenicoWebhookEventPaymentPaymentOutputCardPaymentMethodSpecificOutputCard](docs/IngenicoWebhookEventPaymentPaymentOutputCardPaymentMethodSpecificOutputCard.md)
 - [Model.IngenicoWebhookEventPaymentPaymentOutputCardPaymentMethodSpecificOutputFraudResults](docs/IngenicoWebhookEventPaymentPaymentOutputCardPaymentMethodSpecificOutputFraudResults.md)
 - [Model.IngenicoWebhookEventPaymentPaymentOutputCardPaymentMethodSpecificOutputThreeDSecureResults](docs/IngenicoWebhookEventPaymentPaymentOutputCardPaymentMethodSpecificOutputThreeDSecureResults.md)
 - [Model.IngenicoWebhookEventPaymentPaymentOutputCardPaymentMethodSpecificOutputThreeDSecureResultsAuthenticationAmount](docs/IngenicoWebhookEventPaymentPaymentOutputCardPaymentMethodSpecificOutputThreeDSecureResultsAuthenticationAmount.md)
 - [Model.IngenicoWebhookEventPaymentPaymentOutputReferences](docs/IngenicoWebhookEventPaymentPaymentOutputReferences.md)
 - [Model.IngenicoWebhookEventPaymentStatusOutput](docs/IngenicoWebhookEventPaymentStatusOutput.md)
 - [Model.IngenicoWebhookEventPaymentStatusOutputErrors](docs/IngenicoWebhookEventPaymentStatusOutputErrors.md)
 - [Model.IngenicoWebhookEventPayout](docs/IngenicoWebhookEventPayout.md)
 - [Model.IngenicoWebhookEventPayoutPayoutOutput](docs/IngenicoWebhookEventPayoutPayoutOutput.md)
 - [Model.IngenicoWebhookEventRefund](docs/IngenicoWebhookEventRefund.md)
 - [Model.IngenicoWebhookEventRefundRefundOutput](docs/IngenicoWebhookEventRefundRefundOutput.md)
 - [Model.IngenicoWebhookEventRefundRefundOutputCardRefundMethodSpecificOutput](docs/IngenicoWebhookEventRefundRefundOutputCardRefundMethodSpecificOutput.md)
 - [Model.IngenicoWebhookEventRefundStatusOutput](docs/IngenicoWebhookEventRefundStatusOutput.md)
 - [Model.IngenicoWebhookEventToken](docs/IngenicoWebhookEventToken.md)
 - [Model.IngenicoWebhookEventTokenCard](docs/IngenicoWebhookEventTokenCard.md)
 - [Model.IngenicoWebhookEventTokenCardCustomer](docs/IngenicoWebhookEventTokenCardCustomer.md)
 - [Model.IngenicoWebhookEventTokenCardCustomerBillingAddress](docs/IngenicoWebhookEventTokenCardCustomerBillingAddress.md)
 - [Model.IngenicoWebhookEventTokenCardCustomerCompanyInformation](docs/IngenicoWebhookEventTokenCardCustomerCompanyInformation.md)
 - [Model.IngenicoWebhookEventTokenCardCustomerData](docs/IngenicoWebhookEventTokenCardCustomerData.md)
 - [Model.IngenicoWebhookEventTokenCardCustomerDataCardWithoutCvv](docs/IngenicoWebhookEventTokenCardCustomerDataCardWithoutCvv.md)
 - [Model.InlineObject](docs/InlineObject.md)
 - [Model.InlineObject1](docs/InlineObject1.md)
 - [Model.InlineObject10](docs/InlineObject10.md)
 - [Model.InlineObject11](docs/InlineObject11.md)
 - [Model.InlineObject12](docs/InlineObject12.md)
 - [Model.InlineObject13](docs/InlineObject13.md)
 - [Model.InlineObject14](docs/InlineObject14.md)
 - [Model.InlineObject15](docs/InlineObject15.md)
 - [Model.InlineObject16](docs/InlineObject16.md)
 - [Model.InlineObject17](docs/InlineObject17.md)
 - [Model.InlineObject18](docs/InlineObject18.md)
 - [Model.InlineObject19](docs/InlineObject19.md)
 - [Model.InlineObject2](docs/InlineObject2.md)
 - [Model.InlineObject20](docs/InlineObject20.md)
 - [Model.InlineObject21](docs/InlineObject21.md)
 - [Model.InlineObject3](docs/InlineObject3.md)
 - [Model.InlineObject4](docs/InlineObject4.md)
 - [Model.InlineObject5](docs/InlineObject5.md)
 - [Model.InlineObject6](docs/InlineObject6.md)
 - [Model.InlineObject7](docs/InlineObject7.md)
 - [Model.InlineObject8](docs/InlineObject8.md)
 - [Model.InlineObject9](docs/InlineObject9.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse20010](docs/InlineResponse20010.md)
 - [Model.InlineResponse20011](docs/InlineResponse20011.md)
 - [Model.InlineResponse20011Links](docs/InlineResponse20011Links.md)
 - [Model.InlineResponse20011Merchant](docs/InlineResponse20011Merchant.md)
 - [Model.InlineResponse20012](docs/InlineResponse20012.md)
 - [Model.InlineResponse20013](docs/InlineResponse20013.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2005Results](docs/InlineResponse2005Results.md)
 - [Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse2008](docs/InlineResponse2008.md)
 - [Model.InlineResponse2009](docs/InlineResponse2009.md)
 - [Model.InlineResponse404](docs/InlineResponse404.md)
 - [Model.InstabankApplication](docs/InstabankApplication.md)
 - [Model.InstabankApplicationDebt](docs/InstabankApplicationDebt.md)
 - [Model.InstabankConfiguration](docs/InstabankConfiguration.md)
 - [Model.InstabankConfigurationFinance](docs/InstabankConfigurationFinance.md)
 - [Model.InstabankConfigurationInstallment](docs/InstabankConfigurationInstallment.md)
 - [Model.InstabankConfigurationInvoice](docs/InstabankConfigurationInvoice.md)
 - [Model.InstabankConfigurationPostponement](docs/InstabankConfigurationPostponement.md)
 - [Model.InstabankDetails](docs/InstabankDetails.md)
 - [Model.InstabankFinancePayment](docs/InstabankFinancePayment.md)
 - [Model.InstabankFinancePaymentAllOf](docs/InstabankFinancePaymentAllOf.md)
 - [Model.InstabankFinanceProduct](docs/InstabankFinanceProduct.md)
 - [Model.InstabankFinanceProductLoanExample](docs/InstabankFinanceProductLoanExample.md)
 - [Model.InstabankGwRead](docs/InstabankGwRead.md)
 - [Model.InstabankGwReadPaymentProductCodes](docs/InstabankGwReadPaymentProductCodes.md)
 - [Model.InstabankGwWrite](docs/InstabankGwWrite.md)
 - [Model.InstabankInstallmentPayment](docs/InstabankInstallmentPayment.md)
 - [Model.InstabankInstallmentPaymentAllOf](docs/InstabankInstallmentPaymentAllOf.md)
 - [Model.InstabankInstallmentProduct](docs/InstabankInstallmentProduct.md)
 - [Model.InstabankInvoicePayment](docs/InstabankInvoicePayment.md)
 - [Model.InstabankInvoicePaymentAllOf](docs/InstabankInvoicePaymentAllOf.md)
 - [Model.InstabankInvoiceProduct](docs/InstabankInvoiceProduct.md)
 - [Model.InstabankItem](docs/InstabankItem.md)
 - [Model.InstabankPaymentDetails](docs/InstabankPaymentDetails.md)
 - [Model.InstabankPostponementPayment](docs/InstabankPostponementPayment.md)
 - [Model.InstabankPostponementProduct](docs/InstabankPostponementProduct.md)
 - [Model.Metadata](docs/Metadata.md)
 - [Model.MitPayment](docs/MitPayment.md)
 - [Model.MitSessionBase](docs/MitSessionBase.md)
 - [Model.MitSessionBaseUrl](docs/MitSessionBaseUrl.md)
 - [Model.MitSessionOptions](docs/MitSessionOptions.md)
 - [Model.MitSessionOptionsAllOf](docs/MitSessionOptionsAllOf.md)
 - [Model.MyDinteroUserCreation](docs/MyDinteroUserCreation.md)
 - [Model.MyDinteroUserCreationTerms](docs/MyDinteroUserCreationTerms.md)
 - [Model.NetaxeptConfiguration](docs/NetaxeptConfiguration.md)
 - [Model.NetaxeptConfigurationCreditcard](docs/NetaxeptConfigurationCreditcard.md)
 - [Model.NetaxeptConfigurationCreditcardTerminal](docs/NetaxeptConfigurationCreditcardTerminal.md)
 - [Model.NetaxeptGwRead](docs/NetaxeptGwRead.md)
 - [Model.NetaxeptGwStoreOverride](docs/NetaxeptGwStoreOverride.md)
 - [Model.NetaxeptGwWrite](docs/NetaxeptGwWrite.md)
 - [Model.NetaxeptGwWriteAllOf](docs/NetaxeptGwWriteAllOf.md)
 - [Model.OrderAddress](docs/OrderAddress.md)
 - [Model.OrderDiscountItem](docs/OrderDiscountItem.md)
 - [Model.OrderItem](docs/OrderItem.md)
 - [Model.OrderItemGroups](docs/OrderItemGroups.md)
 - [Model.PayExCallback](docs/PayExCallback.md)
 - [Model.PayExCallbackPayment](docs/PayExCallbackPayment.md)
 - [Model.PayExCallbackPaymentOrder](docs/PayExCallbackPaymentOrder.md)
 - [Model.PayExCallbackTransaction](docs/PayExCallbackTransaction.md)
 - [Model.PayExConfiguration](docs/PayExConfiguration.md)
 - [Model.PayExConfigurationCreditcard](docs/PayExConfigurationCreditcard.md)
 - [Model.PayExConfigurationSwish](docs/PayExConfigurationSwish.md)
 - [Model.PayExGwOverrideRead](docs/PayExGwOverrideRead.md)
 - [Model.PayExGwRead](docs/PayExGwRead.md)
 - [Model.PayExGwStoreOverride](docs/PayExGwStoreOverride.md)
 - [Model.PayExGwWrite](docs/PayExGwWrite.md)
 - [Model.PayExGwWriteAllOf](docs/PayExGwWriteAllOf.md)
 - [Model.PayExMitPayment](docs/PayExMitPayment.md)
 - [Model.PayExMitPaymentAllOf](docs/PayExMitPaymentAllOf.md)
 - [Model.PayExTokenProvider](docs/PayExTokenProvider.md)
 - [Model.PayExTokenProviderAllOf](docs/PayExTokenProviderAllOf.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.PaymentConfiguration](docs/PaymentConfiguration.md)
 - [Model.PaymentConfigurationAllOf](docs/PaymentConfigurationAllOf.md)
 - [Model.PaymentOperation](docs/PaymentOperation.md)
 - [Model.PaymentOperations](docs/PaymentOperations.md)
 - [Model.PaymentResponse](docs/PaymentResponse.md)
 - [Model.PaymentResponseActions](docs/PaymentResponseActions.md)
 - [Model.ProfileConfiguration](docs/ProfileConfiguration.md)
 - [Model.ProfileConfigurationResponse](docs/ProfileConfigurationResponse.md)
 - [Model.ProfileConfigurationUrl](docs/ProfileConfigurationUrl.md)
 - [Model.QRCode](docs/QRCode.md)
 - [Model.QROptions](docs/QROptions.md)
 - [Model.SantanderConfiguration](docs/SantanderConfiguration.md)
 - [Model.SantanderConfigurationDebitAccount](docs/SantanderConfigurationDebitAccount.md)
 - [Model.SantanderConfigurationDebitAccountAccounts](docs/SantanderConfigurationDebitAccountAccounts.md)
 - [Model.SantanderDetails](docs/SantanderDetails.md)
 - [Model.SantanderGwRead](docs/SantanderGwRead.md)
 - [Model.SantanderGwStoreOverrideRead](docs/SantanderGwStoreOverrideRead.md)
 - [Model.SantanderGwStoreOverrideWrite](docs/SantanderGwStoreOverrideWrite.md)
 - [Model.SantanderGwStoreOverrideWriteAllOf](docs/SantanderGwStoreOverrideWriteAllOf.md)
 - [Model.SantanderGwWrite](docs/SantanderGwWrite.md)
 - [Model.SantanderGwWriteAllOf](docs/SantanderGwWriteAllOf.md)
 - [Model.SantanderPayment](docs/SantanderPayment.md)
 - [Model.SantanderPaymentDetails](docs/SantanderPaymentDetails.md)
 - [Model.SendSCCPaymentOperation](docs/SendSCCPaymentOperation.md)
 - [Model.SendSCCPaymentOperationAllOf](docs/SendSCCPaymentOperationAllOf.md)
 - [Model.Session](docs/Session.md)
 - [Model.SessionBase](docs/SessionBase.md)
 - [Model.SessionCancelled](docs/SessionCancelled.md)
 - [Model.SessionCustomer](docs/SessionCustomer.md)
 - [Model.SessionCustomerTokens](docs/SessionCustomerTokens.md)
 - [Model.SessionCustomerTokensCustomer](docs/SessionCustomerTokensCustomer.md)
 - [Model.SessionCustomerTokensCustomerTokens](docs/SessionCustomerTokensCustomerTokens.md)
 - [Model.SessionCustomerTokensCustomerTokensPayexCreditcard](docs/SessionCustomerTokensCustomerTokensPayexCreditcard.md)
 - [Model.SessionExpress](docs/SessionExpress.md)
 - [Model.SessionExpressExpress](docs/SessionExpressExpress.md)
 - [Model.SessionExpressExpressDiscountCodes](docs/SessionExpressExpressDiscountCodes.md)
 - [Model.SessionLock](docs/SessionLock.md)
 - [Model.SessionLockPayLock](docs/SessionLockPayLock.md)
 - [Model.SessionMeta](docs/SessionMeta.md)
 - [Model.SessionMetaDetails](docs/SessionMetaDetails.md)
 - [Model.SessionMetaDetailsBambora](docs/SessionMetaDetailsBambora.md)
 - [Model.SessionMetaDetailsIngenico](docs/SessionMetaDetailsIngenico.md)
 - [Model.SessionMetaEvents](docs/SessionMetaEvents.md)
 - [Model.SessionNotFound](docs/SessionNotFound.md)
 - [Model.SessionNotFoundError](docs/SessionNotFoundError.md)
 - [Model.SessionNotFoundErrorSessionDetails](docs/SessionNotFoundErrorSessionDetails.md)
 - [Model.SessionNotFoundErrorSessionDetailsMerchant](docs/SessionNotFoundErrorSessionDetailsMerchant.md)
 - [Model.SessionOperations](docs/SessionOperations.md)
 - [Model.SessionOperationsOperations](docs/SessionOperationsOperations.md)
 - [Model.SessionOptions](docs/SessionOptions.md)
 - [Model.SessionOptionsAllOf](docs/SessionOptionsAllOf.md)
 - [Model.SessionOrder](docs/SessionOrder.md)
 - [Model.SessionOrderAllOf](docs/SessionOrderAllOf.md)
 - [Model.SessionOrderUpdate](docs/SessionOrderUpdate.md)
 - [Model.SessionPayability](docs/SessionPayability.md)
 - [Model.SessionPaymentToken](docs/SessionPaymentToken.md)
 - [Model.SessionPaymentTokenOrder](docs/SessionPaymentTokenOrder.md)
 - [Model.SessionProfile](docs/SessionProfile.md)
 - [Model.SessionProfileAllOf](docs/SessionProfileAllOf.md)
 - [Model.SessionRead](docs/SessionRead.md)
 - [Model.SessionReadConfiguration](docs/SessionReadConfiguration.md)
 - [Model.SessionReadCustomer](docs/SessionReadCustomer.md)
 - [Model.SessionReadCustomerTokens](docs/SessionReadCustomerTokens.md)
 - [Model.SessionReadCustomerTokensPayexCreditcard](docs/SessionReadCustomerTokensPayexCreditcard.md)
 - [Model.SessionThemeConfiguration](docs/SessionThemeConfiguration.md)
 - [Model.SessionThemeConfigurationTheme](docs/SessionThemeConfigurationTheme.md)
 - [Model.SessionUrls](docs/SessionUrls.md)
 - [Model.SettlementStatus](docs/SettlementStatus.md)
 - [Model.ShippingAddressCallbackSessionOrderUpdate](docs/ShippingAddressCallbackSessionOrderUpdate.md)
 - [Model.ShippingOption](docs/ShippingOption.md)
 - [Model.ShippingOptionEta](docs/ShippingOptionEta.md)
 - [Model.ShippingOptionTimeSlot](docs/ShippingOptionTimeSlot.md)
 - [Model.SignatureV0](docs/SignatureV0.md)
 - [Model.SignatureV0AllOf](docs/SignatureV0AllOf.md)
 - [Model.SignatureV0AllOfSignature](docs/SignatureV0AllOfSignature.md)
 - [Model.Store](docs/Store.md)
 - [Model.SwishConfiguration](docs/SwishConfiguration.md)
 - [Model.SwishConfigurationSwish](docs/SwishConfigurationSwish.md)
 - [Model.SwishGwRead](docs/SwishGwRead.md)
 - [Model.SwishGwStoreOverrideRead](docs/SwishGwStoreOverrideRead.md)
 - [Model.SwishGwStoreOverrideWrite](docs/SwishGwStoreOverrideWrite.md)
 - [Model.SwishGwWrite](docs/SwishGwWrite.md)
 - [Model.SwishGwWriteAllOf](docs/SwishGwWriteAllOf.md)
 - [Model.SwishPayment](docs/SwishPayment.md)
 - [Model.SwishPaymentCallback](docs/SwishPaymentCallback.md)
 - [Model.SwishPollStatus](docs/SwishPollStatus.md)
 - [Model.SwishRefundCallback](docs/SwishRefundCallback.md)
 - [Model.TokenProvider](docs/TokenProvider.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionBambora](docs/TransactionBambora.md)
 - [Model.TransactionBamboraAllOf](docs/TransactionBamboraAllOf.md)
 - [Model.TransactionBamboraAllOfCard](docs/TransactionBamboraAllOfCard.md)
 - [Model.TransactionBamboraAllOfEvents](docs/TransactionBamboraAllOfEvents.md)
 - [Model.TransactionBamboraAllOfMetadata](docs/TransactionBamboraAllOfMetadata.md)
 - [Model.TransactionBamboraAllOfMetadata1](docs/TransactionBamboraAllOfMetadata1.md)
 - [Model.TransactionCollector](docs/TransactionCollector.md)
 - [Model.TransactionCollectorAllOf](docs/TransactionCollectorAllOf.md)
 - [Model.TransactionCollectorAllOfEvents](docs/TransactionCollectorAllOfEvents.md)
 - [Model.TransactionCollectorAllOfMetadata](docs/TransactionCollectorAllOfMetadata.md)
 - [Model.TransactionCollectorAllOfMetadata1](docs/TransactionCollectorAllOfMetadata1.md)
 - [Model.TransactionCustomer](docs/TransactionCustomer.md)
 - [Model.TransactionEvent](docs/TransactionEvent.md)
 - [Model.TransactionEventCorrection](docs/TransactionEventCorrection.md)
 - [Model.TransactionEventError](docs/TransactionEventError.md)
 - [Model.TransactionIngenico](docs/TransactionIngenico.md)
 - [Model.TransactionIngenicoAllOf](docs/TransactionIngenicoAllOf.md)
 - [Model.TransactionIngenicoAllOfCard](docs/TransactionIngenicoAllOfCard.md)
 - [Model.TransactionIngenicoAllOfEvents](docs/TransactionIngenicoAllOfEvents.md)
 - [Model.TransactionIngenicoAllOfMetadata](docs/TransactionIngenicoAllOfMetadata.md)
 - [Model.TransactionIngenicoAllOfMetadata1](docs/TransactionIngenicoAllOfMetadata1.md)
 - [Model.TransactionInstabank](docs/TransactionInstabank.md)
 - [Model.TransactionInstabankAllOf](docs/TransactionInstabankAllOf.md)
 - [Model.TransactionInstabankAllOfEvents](docs/TransactionInstabankAllOfEvents.md)
 - [Model.TransactionInstabankAllOfMetadata](docs/TransactionInstabankAllOfMetadata.md)
 - [Model.TransactionInstabankAllOfMetadata1](docs/TransactionInstabankAllOfMetadata1.md)
 - [Model.TransactionMetadata](docs/TransactionMetadata.md)
 - [Model.TransactionNetaxept](docs/TransactionNetaxept.md)
 - [Model.TransactionNetaxeptAllOf](docs/TransactionNetaxeptAllOf.md)
 - [Model.TransactionNetaxeptAllOfCard](docs/TransactionNetaxeptAllOfCard.md)
 - [Model.TransactionNetaxeptAllOfEvents](docs/TransactionNetaxeptAllOfEvents.md)
 - [Model.TransactionNetaxeptAllOfMetadata](docs/TransactionNetaxeptAllOfMetadata.md)
 - [Model.TransactionNetaxeptAllOfMetadata1](docs/TransactionNetaxeptAllOfMetadata1.md)
 - [Model.TransactionPayEx](docs/TransactionPayEx.md)
 - [Model.TransactionPayExAllOf](docs/TransactionPayExAllOf.md)
 - [Model.TransactionPayExAllOfCard](docs/TransactionPayExAllOfCard.md)
 - [Model.TransactionPayExAllOfEvents](docs/TransactionPayExAllOfEvents.md)
 - [Model.TransactionPayExAllOfMetadata](docs/TransactionPayExAllOfMetadata.md)
 - [Model.TransactionPayExAllOfMetadata1](docs/TransactionPayExAllOfMetadata1.md)
 - [Model.TransactionSantander](docs/TransactionSantander.md)
 - [Model.TransactionSantanderAllOf](docs/TransactionSantanderAllOf.md)
 - [Model.TransactionSantanderAllOfEvents](docs/TransactionSantanderAllOfEvents.md)
 - [Model.TransactionSantanderAllOfMetadata](docs/TransactionSantanderAllOfMetadata.md)
 - [Model.TransactionSettlementsEvent](docs/TransactionSettlementsEvent.md)
 - [Model.TransactionSettlementsRead](docs/TransactionSettlementsRead.md)
 - [Model.TransactionSettlementsWrite](docs/TransactionSettlementsWrite.md)
 - [Model.TransactionSwish](docs/TransactionSwish.md)
 - [Model.TransactionSwishAllOf](docs/TransactionSwishAllOf.md)
 - [Model.TransactionSwishAllOfEvents](docs/TransactionSwishAllOfEvents.md)
 - [Model.TransactionSwishAllOfMetadata](docs/TransactionSwishAllOfMetadata.md)
 - [Model.TransactionSwishAllOfMetadata1](docs/TransactionSwishAllOfMetadata1.md)
 - [Model.TransactionUrl](docs/TransactionUrl.md)
 - [Model.TransactionVipps](docs/TransactionVipps.md)
 - [Model.TransactionVippsAllOf](docs/TransactionVippsAllOf.md)
 - [Model.TransactionVippsAllOfEvents](docs/TransactionVippsAllOfEvents.md)
 - [Model.TransactionVippsAllOfMetadata](docs/TransactionVippsAllOfMetadata.md)
 - [Model.TransactionVippsAllOfMetadata1](docs/TransactionVippsAllOfMetadata1.md)
 - [Model.UpdateSessionOptions](docs/UpdateSessionOptions.md)
 - [Model.ViewPaymentOperation](docs/ViewPaymentOperation.md)
 - [Model.ViewPaymentOperationAllOf](docs/ViewPaymentOperationAllOf.md)
 - [Model.ViewSessionUpdateAddress](docs/ViewSessionUpdateAddress.md)
 - [Model.ViewSessionUpdateDiscountCodes](docs/ViewSessionUpdateDiscountCodes.md)
 - [Model.VippsCallback](docs/VippsCallback.md)
 - [Model.VippsCallbackTransactionInfo](docs/VippsCallbackTransactionInfo.md)
 - [Model.VippsConfiguration](docs/VippsConfiguration.md)
 - [Model.VippsGwRead](docs/VippsGwRead.md)
 - [Model.VippsGwStoreOverrideRead](docs/VippsGwStoreOverrideRead.md)
 - [Model.VippsGwStoreOverrideWrite](docs/VippsGwStoreOverrideWrite.md)
 - [Model.VippsGwStoreOverrideWriteAllOf](docs/VippsGwStoreOverrideWriteAllOf.md)
 - [Model.VippsGwWrite](docs/VippsGwWrite.md)
 - [Model.VippsGwWriteAllOf](docs/VippsGwWriteAllOf.md)
 - [Model.VippsPayment](docs/VippsPayment.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="JWT"></a>
### JWT

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

<a name="adminKey"></a>
### adminKey

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header

<a name="apikey"></a>
### apikey

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header

