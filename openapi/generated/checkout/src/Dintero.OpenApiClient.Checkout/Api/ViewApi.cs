/*
 * Checkout API
 *
 * # Changelog All notable changes to the API.  ## 2021-06-01  > new: Support `bambora.mobilepay` payment product type. Extend configuration on > gateway and session to enable MobilePay payment via Bambora Wallet service. The > payment type must be enabled by Bambora. > - [PUT /v1/admin/checkout](#operation/admin_checkout_id_put) > - [POST /v1/session-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions/{session_id}/pay](#operation/checkout_sid_pay_post)  > doc: Fix documentation for payment-token session endpoint. `session` and > `payment_token` are required when creating payment-token session. > - [POST /v1/sessions/payment-token](#operation/checkout_payment_token_session_post)  > new: Support `enable_on_hold`-configuration on session configuration and in checkout configuration > - [POST /v1/session-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post) > - [PUT /v1/admin/checkout](#operation/admin_checkout_id_put)  ## 2021-05-01  > new: Support `bambora.vipps` payment product type. Extend configuration on > gateway and session to enable Vipps payment via Bambora Wallet service. The > payment type must be enabled by Bambora. > - [PUT /v1/admin/gateways/bambora](#operation/admin_checkout_id_gw_bambora_put) > - [PUT /v1/admin/checkout](#operation/admin_checkout_id_put) > - [POST /v1/session-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions/{session_id}/pay](#operation/checkout_sid_pay_post)  > **new**: Support session profile configuration when creating payment-token session > - [POST /v1/sessions/payment-token](#operation/checkout_payment_token_session_post)  > **new**: Extend  shipping_address_callback response with support for updating  > the checkout session in addition to returning available shipping options. This will allow > the callback endpoint to update the content of the order, like changing amount, or > currency or update the items in the order. > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST examples/shipping_address_callback_url](#operation/example_shipping_address_callback_url)   ## 2021-04-01  > **change**: Add support for void on part capture. Void can be used to release > the remaining authorization on a part captured transaction. The support is > limited to `payex.creditcard` transactions. > - [POST /v1/transactions/{id}/void](#operation/transactions_id_void_post)  > **change**: Add support for `language` query parameter when getting payment > operations > - [POST /v1/view/{session_id}/payments/{payment_product_type}](#operation/checkout_sid_payments_product_type_post)  > **change**: Add support Bambora creditcard payment. > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)  > **change**: Add support for bypassing the Dintero redirect for in_app-payments, and > redirect from app to app. > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)  ## 2021-03-01 > **change** Add support for includes query parameter in session url.callback_url. > `includes` set to session will enable the sessions url.callback_url to include session data in the body. > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)  ## 2021-02-01  > **new**: It is now possible to use full ISO 8601 compliant datetimes in date range queries. > Note: If timezone isn't specified, UTC is assumed > Note: To keep things backwards compatible, end-dates with the \"yyyy-mm-dd\" format will be  > shifted forward by a day. > - [GET /v1/transactions](#operation/transactions_get) > - [GET /v1/sessions](#operation/checkout_sessions_get)  > **new**: Add possibility to create myDintero-user in address change  > - [POST /v1/view/{session_id}/session/order/addresses](#operation/checkout_sid_json_order_addresses_put)  > **new**: Extend transaction data with embedded session data > `includes` now supports 'session' >  - [GET /v1/transactions/{id}](#operation/transactions_id_get)  > **new**: Extend Vipps transaction metadata with > `vipps:merchantInfo.merchantSerialNumber`, the Merchant Serial Number > (MSN) that was used when the transaction was initiated.  > **new** Add support for setting settlements on a transaction, one event > per payout to a bank account > - [POST /v1/transactions/events/payout](#operation/transactions_events_payout_post)  > **new**: Version support when updating PayEx gateway configuration. The > new option allows the gateway to be configured with multiple merchant > agreements > - [PUT /v1/admin/gateways/payex](#operation/admin_checkout_id_gw_payex_put) > - [PUT /v1/admin/gateways/payex/override](#operation/admin_checkout_id_gw_override_payex_put)  > **change**: Add support for additional query parameters. > `search` will match on merchant reference's and customer name > `transaction_id` will filter results to include only sessions associated with the provided transaction ids > `created_at.gte` will exclude all sessions created before provided date > `created_at.lte` will exclude all sessions created after provided date > - [GET /v1/sessions](#operation/checkout_sessions_get)  ## 2021-01-01  > **new**: Endpoint for initiating MIT payments > - [POST /v1/sessions/pay](#operation/checkout_session_pay_post)  > **new**: Checkout sessions and profiles supports theming via `configuration.theme` > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST /admin/session/profiles](#operation/admin_session_profile_post)  ## 2020-12-01  > **new**: Add support for using external discount codes in Express checkout. > A session can be configured with a `express.discount_code_callback_url` that will be > invoked when the session is updated with a promotion code. The response from > the callback will then be used to adjust the order and shipping options > available. > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST examples/discount_code_callback_url](#operation/example_discount_code_callback_url)  > **new**: Add support for an advance credit check of Collector B2B customers > - [POST /v1/creditchecks](#operation/creditchecks_post)   ## 2020-11-01  > **new**: Add support for overriding Collector gateway settings > - [PUT /v1/admin/gateways/collector/override](#operation/admin_checkout_id_gw_override_collector_put)  > **new** Add support for `collector.invoice_b2b_preapproved` and `collector.installment_b2b_preapproved` payment  > **new** Async transaction operations. The response status from > capture, refund or void can now be `202` if the request was accepted > but the processing has not been completed. > > The transaction with an operation that was accepted will receive a > update later when the processing completes. > The event that completes the operation will include an > `initiate_request_id` property. > You can use the `callback_url` to receive a callback when the > processing completes. > > The status of the transaction will remain unchanged until the processing > of the operation completes. > > - [POST /v1/transactions/{id}/capture](#operation/transactions_id_capture_post) > - [POST /v1/transactions/{id}/refund](#operation/transactions_id_refund_post) > - [POST /v1/transactions/{id}/void](#operation/transactions_id_void_post)  > **new** Add support for callback when transaction is updated. You can now > receive callbacks on captures, refunds and void by including > `report_event=<event>` query parameter in the `callback_url`. > >     https://example.com/callback?report_event=CAPTURE&report_event=REFUND > > > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  ## 2020-10-01  > **new** Added `in_store` as a possible payment channel for > payments in physical stores. > > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  ## 2020-09-01  > **new** Added option for configurating the payment channel. > See `configuration.channel`. The new option add support for > `in_app` channel with appswitch deeplink URL (Vipps). > > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  > **new** Add support for optional `order.discount_lines` when creating > a new sessions. > > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  > **new** Add support for updating a session > - [PUT /v1/sessions/{session_id}](#operation/checkout_session_put) > - [POST /view@{session_id}@session@lock](#operation/checkout_sid_lock)  > `total_income` moved from applicant to top level for instabank.invoice and instabank.installment. > The field is required, but there will be a grace period of two months before it is enforced. > Deprecated `applicant.total_income` > > - [POST /v1/sessions/pay](#operation/checkout_sid_pay_post)  ## 2020-08-01  > **new** Add support for optional `metadata` when creating > a new session. > > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  > **new** Add support for optional `merchant_reference_2` when > creating a new session > > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  > **new** Add support for delayed callback. You can enable the delay callback feature > by including `delay_callback=<seconds>` query parameter in the `callback_url` > >     https://example.com/callback?delay_callback=30 >  ## 2020-07-01  > **new**: Add support for overriding Netaxept gateway settings > - [PUT /v1/admin/gateways/netaxept/override](#operation/admin_checkout_id_gw_override_netaxept_put)  > **new**: Add terminal options for Netaxept creditcard payment. Enable use of > Netaxept hosted checkout, and provided custom configuration.  > **new**: Add support for Netaxept. > - [GET /view/{session_id}/netaxept](#operation/checkout_sid_netaxept_html_get)  > **new**: Add support for overriding PayEx gateway settings > - [PUT /v1/admin/gateways/payex/override](#operation/admin_checkout_id_gw_override_payex_put)  > **new**: Include payment token in transaction details > - [GET /v1/transactions/{id}?includes=card.payment_token](#operation/transactions_id_get)  > **new** Added option for using payment token for payex.creditcard payments > to prefill payment details so the customer (payer) do not need to enter all > these details for every purchase.  > **new** Added option for generating payment token for payex.creditcard > payments, see `configuration.payex.creditcard`. Use the new option to > generate a payment token that can be used in future payments to prefill > the details for the creditcard.  > **new** Added `instabank.postponement` payment type.  > **new** Added `swish.swish` payment type, direct integration with Swish.  ## 2020-06-01  > **change** Add support for `ON_HOLD` transaction status. The new status > is limited to Collector transactions, to signal that the processing > of the transaction is not yet completed. The new status will be used in > cases where Collector performs aditional controls before approving the > payment.  > **new** Add support for setting `merchant_reference_2` to an existing > transaction and search for transactions by `merchant_reference_2`. > > - [PUT /v1/transaction/{transction_id}](#operation/transactions_id_put) > - [GET /v1/transactions](#operation/transactions_get)  ## 2020-05-01  > **new** Add support for POST callback with the authorized transaction > included in the request body. You can enable the POST callback feature > by including `method=POST` query parameter in the `callback_url` > >     https://example.com/callback?method=POST > > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)  ## 2020-04-01  > **new** Add support for `instabank.installment` payment  > **changed**: Removed error `capture` from list of valid error added to > the redirect to the `url.redirect_url`. The error was used for payments with > `auto-capture` enabled, and set in case where the auto capture failed. > The merchant can assume the transaction will be captured automatically as > soon as possible when creating a session with `auto-capture` enabled. > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)  > **changed**: A callback (when `url.callback_url` is set) will now be sent > as soon as possible after the transaction is `AUTHORIZED`. We will no longer > wait until the transaction `CAPTURED` in case when `auto-capture` is enabled. > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)  > **change**: Add support for creating session with Ingenico enabled > - [POST /sessions-profile](#operation/checkout_session_profile_post) > - [POST /sessions](#operation/checkout_session_post) > - [POST /admin/session/profiles](#operation/admin_session_profile_post)  > **change**: Add support for creating session with Ingenico enabled > - [POST /sessions-profile](#operation/checkout_session_profile_post) > - [POST /sessions](#operation/checkout_session_post) > - [POST /admin/session/profiles](#operation/admin_session_profile_post)  > **new** Add support for `collector.invoice_b2b` payment  ## 2020-03-01  > **new** Add support for configuring Ingenico gateway > - [PUT /admin/gateways/ingenico](#operation/admin_checkout_id_gw_ingenico_put)  > **new** Add support for enabling `Dintero-Signature` header for all > system-to-system request sent from Dintero to the merchant > - [POST /v1/admin/signature](#operation/admin_signature_post)  > **fix**: Documentation for endpoint [GET /v1/admin/api-keys](#operation/admin_api_keys_get). > The resource returns a list of api-keys, not a single api-key.  > **new** Add support for `collector.installment` payment  > **new** Add support for putting merchant_terms_url in profile and session > - [POST /v1/admin/session/profiles](#operation/admin_session_profile_post) > - [PUT /v1/admin/session/profiles/{profile_id}](#operation/admin_session_profile_details_put) > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)  > **new** Add support for overriding gateway settings > - [PUT /v1/admin/gateways/vipps/override](#operation/admin_checkout_id_gw_override_vipps_put) > - [PUT /v1/admin/gateways/santander/override](#operation/admin_checkout_id_gw_override_santander_put)  ## 2019-12-01  > **new** Add support for `include_session` query parameter > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  > **new** Add support for discount calculation on sessions. > The discounts will be calculated when customer is identified > > Extend the order and transaction items with new properties to > support discount calculation of session: > - `discount_lines` > - `gross_amount` > - `is_change` > - `eligible_for_discount` > > Support calculating and updating session with discount from: > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  > **new** Add store property to `session.order` and transaction. > Adds support for including details about the sales location in the order  > **new** Add `shipping_option` from `session.order` to to `transaction` > - [GET /transactions](#operation/transactions_get) > - [GET /transactions/{id}](#operation/transactions_id_get)  > **changed** Minor changes to the `shipping_option` object(s) in sessions > - [POST /v1/sessions](#operation/checkout_session_post) > - [GET /v1/sessions](#operation/checkout_sessions_get) > - [GET /v1/sessions/{session_id}](#operation/checkout_session_get) > - [GET /view/{session_id}/session](#operation/checkout_sid_json_get)  > **new** Add an endpoint for abandon a checkout payment > - [POST /view/{session_id}/session/abandon](#operation/view_sid_session_abandon_post)  ## 2019-11-01  > **changed**: Express Checkout flow added to sessions > - [POST /v1/sessions](#operation/checkout_session_post) > - [GET /v1/sessions](#operation/checkout_sessions_get) > - [GET /v1/sessions/{session_id}](#operation/checkout_session_get) > - [GET /view/{session_id}/session](#operation/checkout_sid_json_get)  > **new** Update a an Express Checkout session order > - [PUT /view/{session_id}/session](#operation/checkout_sid_json_put)  > **new**: Extend Transaction with optional `billing_address` field.  ## 2019-10-01  > **new**: Extend Transaction Event with correction field > to handle correction of status after operations errors  > **changed**: previously required fields are now optional for `instabank.finance`. > - mortgage_debt > - student_debt > - other_secured_debt  > **changed**: Payments for _payment product type_ `instabank.invoice` now > contain an optional `applicant` object used for sending more details about > the payee. The applicant data will be required for amounts over a limit > specified by Instabank. > - [POST /v1/sessions/{session_id}/pay](#operation/checkout_sid_pay_post)   > **changed**: Payment sessions with `instabank.invoice` now contains an > `require_applicant` boolean flag in the _instabank invoice configuration_ > when getting the session. > - [GET /v1/sessions/{session_id}](#operation/checkout_session_get)  > **changed**: Adds detailed debt array to `instabank.finance`.  ## 2019-09-01  > **changed**: Disabled `instabank.invoice` for amounts less than 500 NOK  > **new**: Filter transaction list by `payment_product_type`: > - instabank.finance > - instabank.invoice > - vipps > - payex.creditcard > - payex.swish  > **new**: Filter transactions list by `card_brand`: > - Visa > - MasterCard  > **new**: Added optional `remember_me` boolean to POST pay request body > when initializing a payment of a session. > - [POST /v1/sessions/{session_id}/pay](#operation/checkout_sid_pay_post)  ## 2019-07-01  > **fix**: `Transaction.status` typo, rename `PARTICALLY_CAPTURED_REFUNDED` to > `PARTIALLY_CAPTURED_REFUNDED`.  > **changed**: replaced `card` payment type with `payex`. The payex > payment type adds support for payment product types: > - payex.creditcard > - payex.swish  > **changed**: Add support for optional custom expires_at parameter when > creating a new session either directly or from a profile. > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  > **changed**: Add support for override of configuration when creating > a new session from a profile. > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)  > **new**: support cancel of session > - [POST /v1/sessions/{session_id}/cancel](#operation/checkout_session_cancel_post)  > **changed**: In SessionBase, extend order with `partial_payment` > property that can be used in case where the payment is partial > and the `order.amount` is less or equal to the `order.items.amount`. > - [POST /v1/sessions](#operation/checkout_session_post) > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post)  ## 2019-06-01  > **break**: Pay with `instabank.finance` type requires now additional > properties to comply with new regulations from Finanstilsynet. > - [POST /v1/sessions/{session_id}/pay](#operation/checkout_sid_pay_post) > **changed**: In SessionMeta events, extend event with `details` object > and enumerate the event names available. > - [GET /v1/sessions/{session_id}](#operation/checkout_session_get)  > **changed**: Remove `instabank.installment` and > `instabank.postponement` payment type. The types will no longer be > accepted by: > - [PUT /v1/admin/checkout](#operation/admin_checkout_id_put) > - [PUT /v1/admin/gateways/instabank](#operation/admin_checkout_id_gw_instabank_put) > - [POST /v1/admin/session/profiles](#operation/admin_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  ## 2019-05-01 > In SessionMeta renamed field  `expiry_at` to `expires_at`.  > **new**: PaymentConfiguration extended with optional `auto_capture` boolean field. If set to true the > checkout serivce will automatically capture the payment after the transaction is `AUTHORIZED`.  > **new**: Add support for checkout with SMS. > A SMS with link to the checkout can now be sent when a new > session is created. > See relevant resources for more information. > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)  ## 2019-04-01  > **fix**: Fix documentation for the response from [api-keys](#tag/api-keys) > endpoints. No `gateways` property will be included in response to api-keys > requests.  > **doc**: Document support for JWT Bearer authentication. Use API client > to get an JWT access token. > - [Create Client](https://docs.dintero.com/api.html#operation/aid_auth_clients_post) > - [Get token](https://docs.dintero.com/api.html#operation/aid_auths_oauth_token_post)  ## 2019-03-01  > **break**: Administration of checkout gateways was moved to new > endpoints. Gateway configuration will no longer be supported via > the `PUT /admin/checkout` endpoint. > - [PUT /admin/checkout](#operation/admin_checkout_id_put) > - [POST /admin/gateways/{gateway}/status](#operation/admin_checkout_gw_type_status_post) > - [PUT /admin/gateways/instabank](#operation/admin_checkout_id_gw_instabank_put) > - [PUT /admin/gateways/vipps](#operation/admin_checkout_id_gw_vipps_put) > > **removed**: > - ~`POST /admin/gateways/{gateway}`~ (check gateway status)  > **new**: Extend transaction.event with `created_by` property. > Include the user who created the event, i.e. applied an operation > to the transaction.  ## 2019-01-31  > **new**: Add support for checkout with QR-Code > A QR Code can now be generated for a Checkout Session or a Sale Location. > See relevant resource for more information. > - [POST /v1/locations/{location_id}/qr](#operation/qr_locations_lid_post) > - [POST /v1/sessions/{session_id}/qr](#operation/qr_sessions_sid_post) > - [POST /v1/locations/{location_id}/checkout/{session_id}](#operation/qr_locations_lid_checkout_sid_post) > - [DELETE /v1/locations/{location_id}/checkout/{session_id}](#operation/qr_locations_lid_checkout_sid_delete)  > **new**: Add support for filter transactions with query parameters. > Transactions can now be filtered on: `status`, `payment_product`, > `merchant_reference`, `session_id`, `amount` and `created_at`. > - [GET /v1/transactions](#operation/transactions_get)  ## 2018-11-24  > **new**: Add support for `session.url.callback_url`. Get system-to-system >  notification when session payment is completed. > - [POST /v1/sessions-profile](#operation/checkout_session_profile_post) > - [POST /v1/sessions](#operation/checkout_session_post)    
 *
 * The version of the OpenAPI document: LATEST
 * Contact: integration@dintero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Dintero.OpenApiClient.Checkout.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IViewApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the Checkout page
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="language"> (optional)</param>
        /// <param name="ui"> (optional)</param>
        /// <param name="scc">Optional query parameter. SMS-confirm-code. To verify the identity of the payee. (optional)</param>
        /// <returns></returns>
        void CheckoutSidHtmlGet(string sessionId, string language = default(string), string ui = default(string), string scc = default(string));

        /// <summary>
        /// Get the Checkout page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="language"> (optional)</param>
        /// <param name="ui"> (optional)</param>
        /// <param name="scc">Optional query parameter. SMS-confirm-code. To verify the identity of the payee. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CheckoutSidHtmlGetWithHttpInfo(string sessionId, string language = default(string), string ui = default(string), string scc = default(string));
        /// <summary>
        /// Get checkout details
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 CheckoutSidJsonGet(string sessionId);

        /// <summary>
        /// Get checkout details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>ApiResponse of InlineResponse20012</returns>
        ApiResponse<InlineResponse20012> CheckoutSidJsonGetWithHttpInfo(string sessionId);
        /// <summary>
        /// Set Express Checkout addresses
        /// </summary>
        /// <remarks>
        /// Changes the &#x60;order.shipping_address&#x60; and &#x60;order.billing_address&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 CheckoutSidJsonOrderAddressesPut(string sessionId, ViewSessionUpdateAddress options, string ifUnmodifiedSince = default(string));

        /// <summary>
        /// Set Express Checkout addresses
        /// </summary>
        /// <remarks>
        /// Changes the &#x60;order.shipping_address&#x60; and &#x60;order.billing_address&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        ApiResponse<InlineResponse20013> CheckoutSidJsonOrderAddressesPutWithHttpInfo(string sessionId, ViewSessionUpdateAddress options, string ifUnmodifiedSince = default(string));
        /// <summary>
        /// Set Express Checkout discount codes
        /// </summary>
        /// <remarks>
        /// Changes the &#x60;order.discount_codes&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.discount_codes_callback_url&#x60;_ is set, the session will be updated with discount on the order and the shipping options. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 CheckoutSidJsonOrderDiscountCodesPut(string sessionId, ViewSessionUpdateDiscountCodes options, string ifUnmodifiedSince = default(string));

        /// <summary>
        /// Set Express Checkout discount codes
        /// </summary>
        /// <remarks>
        /// Changes the &#x60;order.discount_codes&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.discount_codes_callback_url&#x60;_ is set, the session will be updated with discount on the order and the shipping options. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        ApiResponse<InlineResponse20013> CheckoutSidJsonOrderDiscountCodesPutWithHttpInfo(string sessionId, ViewSessionUpdateDiscountCodes options, string ifUnmodifiedSince = default(string));
        /// <summary>
        /// Set Express Checkout shipping option
        /// </summary>
        /// <remarks>
        /// Changes the selected shipping_option, submitted by end user in the  Express Checkout flow. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 CheckoutSidJsonOrderItemsShippingOptionPut(string sessionId, ShippingOption options, string ifUnmodifiedSince = default(string));

        /// <summary>
        /// Set Express Checkout shipping option
        /// </summary>
        /// <remarks>
        /// Changes the selected shipping_option, submitted by end user in the  Express Checkout flow. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        ApiResponse<InlineResponse20013> CheckoutSidJsonOrderItemsShippingOptionPutWithHttpInfo(string sessionId, ShippingOption options, string ifUnmodifiedSince = default(string));
        /// <summary>
        /// Set Express Checkout shipping address
        /// </summary>
        /// <remarks>
        /// Changes the order.shipping_address, submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 CheckoutSidJsonOrderShippingAddressPut(string sessionId, OrderAddress options, string ifUnmodifiedSince = default(string));

        /// <summary>
        /// Set Express Checkout shipping address
        /// </summary>
        /// <remarks>
        /// Changes the order.shipping_address, submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        ApiResponse<InlineResponse20013> CheckoutSidJsonOrderShippingAddressPutWithHttpInfo(string sessionId, OrderAddress options, string ifUnmodifiedSince = default(string));
        /// <summary>
        /// Lock a checkout session
        /// </summary>
        /// <remarks>
        /// When locked, the session can not be paid. Locking the session is only available when express is enabled. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>SessionLock</returns>
        SessionLock CheckoutSidLock(string sessionId);

        /// <summary>
        /// Lock a checkout session
        /// </summary>
        /// <remarks>
        /// When locked, the session can not be paid. Locking the session is only available when express is enabled. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>ApiResponse of SessionLock</returns>
        ApiResponse<SessionLock> CheckoutSidLockWithHttpInfo(string sessionId);
        /// <summary>
        /// Get payment operations
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="paymentProductType"></param>
        /// <param name="language">Preferred language to use in the payment operation. Example: &#x60;nb-NO&#x60;  (optional)</param>
        /// <returns>PaymentOperations</returns>
        PaymentOperations CheckoutSidPaymentsProductTypePost(string sessionId, string paymentProductType, string language = default(string));

        /// <summary>
        /// Get payment operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="paymentProductType"></param>
        /// <param name="language">Preferred language to use in the payment operation. Example: &#x60;nb-NO&#x60;  (optional)</param>
        /// <returns>ApiResponse of PaymentOperations</returns>
        ApiResponse<PaymentOperations> CheckoutSidPaymentsProductTypePostWithHttpInfo(string sessionId, string paymentProductType, string language = default(string));
        /// <summary>
        /// Send a verification code to the customer
        /// </summary>
        /// <remarks>
        /// Send a SMS with a payment verification code 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns></returns>
        void CheckoutSidSendScc(string sessionId);

        /// <summary>
        /// Send a verification code to the customer
        /// </summary>
        /// <remarks>
        /// Send a SMS with a payment verification code 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CheckoutSidSendSccWithHttpInfo(string sessionId);
        /// <summary>
        /// Abandon a checkout payment
        /// </summary>
        /// <remarks>
        /// Abandon a checkout payment before completing payment. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns></returns>
        void ViewSidSessionAbandonPost(string sessionId);

        /// <summary>
        /// Abandon a checkout payment
        /// </summary>
        /// <remarks>
        /// Abandon a checkout payment before completing payment. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ViewSidSessionAbandonPostWithHttpInfo(string sessionId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IViewApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the Checkout page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="language"> (optional)</param>
        /// <param name="ui"> (optional)</param>
        /// <param name="scc">Optional query parameter. SMS-confirm-code. To verify the identity of the payee. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CheckoutSidHtmlGetAsync(string sessionId, string language = default(string), string ui = default(string), string scc = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the Checkout page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="language"> (optional)</param>
        /// <param name="ui"> (optional)</param>
        /// <param name="scc">Optional query parameter. SMS-confirm-code. To verify the identity of the payee. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CheckoutSidHtmlGetWithHttpInfoAsync(string sessionId, string language = default(string), string ui = default(string), string scc = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get checkout details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse20012</returns>
        System.Threading.Tasks.Task<InlineResponse20012> CheckoutSidJsonGetAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get checkout details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> CheckoutSidJsonGetWithHttpInfoAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Set Express Checkout addresses
        /// </summary>
        /// <remarks>
        /// Changes the &#x60;order.shipping_address&#x60; and &#x60;order.billing_address&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse20013</returns>
        System.Threading.Tasks.Task<InlineResponse20013> CheckoutSidJsonOrderAddressesPutAsync(string sessionId, ViewSessionUpdateAddress options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Set Express Checkout addresses
        /// </summary>
        /// <remarks>
        /// Changes the &#x60;order.shipping_address&#x60; and &#x60;order.billing_address&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> CheckoutSidJsonOrderAddressesPutWithHttpInfoAsync(string sessionId, ViewSessionUpdateAddress options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Set Express Checkout discount codes
        /// </summary>
        /// <remarks>
        /// Changes the &#x60;order.discount_codes&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.discount_codes_callback_url&#x60;_ is set, the session will be updated with discount on the order and the shipping options. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse20013</returns>
        System.Threading.Tasks.Task<InlineResponse20013> CheckoutSidJsonOrderDiscountCodesPutAsync(string sessionId, ViewSessionUpdateDiscountCodes options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Set Express Checkout discount codes
        /// </summary>
        /// <remarks>
        /// Changes the &#x60;order.discount_codes&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.discount_codes_callback_url&#x60;_ is set, the session will be updated with discount on the order and the shipping options. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> CheckoutSidJsonOrderDiscountCodesPutWithHttpInfoAsync(string sessionId, ViewSessionUpdateDiscountCodes options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Set Express Checkout shipping option
        /// </summary>
        /// <remarks>
        /// Changes the selected shipping_option, submitted by end user in the  Express Checkout flow. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse20013</returns>
        System.Threading.Tasks.Task<InlineResponse20013> CheckoutSidJsonOrderItemsShippingOptionPutAsync(string sessionId, ShippingOption options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Set Express Checkout shipping option
        /// </summary>
        /// <remarks>
        /// Changes the selected shipping_option, submitted by end user in the  Express Checkout flow. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> CheckoutSidJsonOrderItemsShippingOptionPutWithHttpInfoAsync(string sessionId, ShippingOption options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Set Express Checkout shipping address
        /// </summary>
        /// <remarks>
        /// Changes the order.shipping_address, submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse20013</returns>
        System.Threading.Tasks.Task<InlineResponse20013> CheckoutSidJsonOrderShippingAddressPutAsync(string sessionId, OrderAddress options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Set Express Checkout shipping address
        /// </summary>
        /// <remarks>
        /// Changes the order.shipping_address, submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> CheckoutSidJsonOrderShippingAddressPutWithHttpInfoAsync(string sessionId, OrderAddress options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lock a checkout session
        /// </summary>
        /// <remarks>
        /// When locked, the session can not be paid. Locking the session is only available when express is enabled. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SessionLock</returns>
        System.Threading.Tasks.Task<SessionLock> CheckoutSidLockAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lock a checkout session
        /// </summary>
        /// <remarks>
        /// When locked, the session can not be paid. Locking the session is only available when express is enabled. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SessionLock)</returns>
        System.Threading.Tasks.Task<ApiResponse<SessionLock>> CheckoutSidLockWithHttpInfoAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get payment operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="paymentProductType"></param>
        /// <param name="language">Preferred language to use in the payment operation. Example: &#x60;nb-NO&#x60;  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaymentOperations</returns>
        System.Threading.Tasks.Task<PaymentOperations> CheckoutSidPaymentsProductTypePostAsync(string sessionId, string paymentProductType, string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get payment operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="paymentProductType"></param>
        /// <param name="language">Preferred language to use in the payment operation. Example: &#x60;nb-NO&#x60;  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaymentOperations)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentOperations>> CheckoutSidPaymentsProductTypePostWithHttpInfoAsync(string sessionId, string paymentProductType, string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a verification code to the customer
        /// </summary>
        /// <remarks>
        /// Send a SMS with a payment verification code 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CheckoutSidSendSccAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Send a verification code to the customer
        /// </summary>
        /// <remarks>
        /// Send a SMS with a payment verification code 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CheckoutSidSendSccWithHttpInfoAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Abandon a checkout payment
        /// </summary>
        /// <remarks>
        /// Abandon a checkout payment before completing payment. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ViewSidSessionAbandonPostAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Abandon a checkout payment
        /// </summary>
        /// <remarks>
        /// Abandon a checkout payment before completing payment. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ViewSidSessionAbandonPostWithHttpInfoAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IViewApi : IViewApiSync, IViewApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ViewApi : IViewApi
    {
        private Dintero.OpenApiClient.Checkout.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ViewApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ViewApi(String basePath)
        {
            this.Configuration = Dintero.OpenApiClient.Checkout.Client.Configuration.MergeConfigurations(
                Dintero.OpenApiClient.Checkout.Client.GlobalConfiguration.Instance,
                new Dintero.OpenApiClient.Checkout.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Dintero.OpenApiClient.Checkout.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Dintero.OpenApiClient.Checkout.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Dintero.OpenApiClient.Checkout.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ViewApi(Dintero.OpenApiClient.Checkout.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Dintero.OpenApiClient.Checkout.Client.Configuration.MergeConfigurations(
                Dintero.OpenApiClient.Checkout.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Dintero.OpenApiClient.Checkout.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Dintero.OpenApiClient.Checkout.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Dintero.OpenApiClient.Checkout.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ViewApi(Dintero.OpenApiClient.Checkout.Client.ISynchronousClient client, Dintero.OpenApiClient.Checkout.Client.IAsynchronousClient asyncClient, Dintero.OpenApiClient.Checkout.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Dintero.OpenApiClient.Checkout.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Dintero.OpenApiClient.Checkout.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Dintero.OpenApiClient.Checkout.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Dintero.OpenApiClient.Checkout.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Dintero.OpenApiClient.Checkout.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get the Checkout page 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="language"> (optional)</param>
        /// <param name="ui"> (optional)</param>
        /// <param name="scc">Optional query parameter. SMS-confirm-code. To verify the identity of the payee. (optional)</param>
        /// <returns></returns>
        public void CheckoutSidHtmlGet(string sessionId, string language = default(string), string ui = default(string), string scc = default(string))
        {
            CheckoutSidHtmlGetWithHttpInfo(sessionId, language, ui, scc);
        }

        /// <summary>
        /// Get the Checkout page 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="language"> (optional)</param>
        /// <param name="ui"> (optional)</param>
        /// <param name="scc">Optional query parameter. SMS-confirm-code. To verify the identity of the payee. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<Object> CheckoutSidHtmlGetWithHttpInfo(string sessionId, string language = default(string), string ui = default(string), string scc = default(string))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidHtmlGet");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            if (language != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToMultiMap("", "language", language));
            }
            if (ui != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToMultiMap("", "ui", ui));
            }
            if (scc != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToMultiMap("", "scc", scc));
            }

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/view/{session_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidHtmlGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Checkout page 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="language"> (optional)</param>
        /// <param name="ui"> (optional)</param>
        /// <param name="scc">Optional query parameter. SMS-confirm-code. To verify the identity of the payee. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CheckoutSidHtmlGetAsync(string sessionId, string language = default(string), string ui = default(string), string scc = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await CheckoutSidHtmlGetWithHttpInfoAsync(sessionId, language, ui, scc, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the Checkout page 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="language"> (optional)</param>
        /// <param name="ui"> (optional)</param>
        /// <param name="scc">Optional query parameter. SMS-confirm-code. To verify the identity of the payee. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<Object>> CheckoutSidHtmlGetWithHttpInfoAsync(string sessionId, string language = default(string), string ui = default(string), string scc = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidHtmlGet");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            if (language != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToMultiMap("", "language", language));
            }
            if (ui != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToMultiMap("", "ui", ui));
            }
            if (scc != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToMultiMap("", "scc", scc));
            }

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/view/{session_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidHtmlGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get checkout details 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>InlineResponse20012</returns>
        public InlineResponse20012 CheckoutSidJsonGet(string sessionId)
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20012> localVarResponse = CheckoutSidJsonGetWithHttpInfo(sessionId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get checkout details 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>ApiResponse of InlineResponse20012</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20012> CheckoutSidJsonGetWithHttpInfo(string sessionId)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidJsonGet");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<InlineResponse20012>("/view/{session_id}/session", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidJsonGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get checkout details 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse20012</returns>
        public async System.Threading.Tasks.Task<InlineResponse20012> CheckoutSidJsonGetAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20012> localVarResponse = await CheckoutSidJsonGetWithHttpInfoAsync(sessionId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get checkout details 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20012>> CheckoutSidJsonGetWithHttpInfoAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidJsonGet");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<InlineResponse20012>("/view/{session_id}/session", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidJsonGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set Express Checkout addresses Changes the &#x60;order.shipping_address&#x60; and &#x60;order.billing_address&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>InlineResponse20013</returns>
        public InlineResponse20013 CheckoutSidJsonOrderAddressesPut(string sessionId, ViewSessionUpdateAddress options, string ifUnmodifiedSince = default(string))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> localVarResponse = CheckoutSidJsonOrderAddressesPutWithHttpInfo(sessionId, options, ifUnmodifiedSince);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set Express Checkout addresses Changes the &#x60;order.shipping_address&#x60; and &#x60;order.billing_address&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> CheckoutSidJsonOrderAddressesPutWithHttpInfo(string sessionId, ViewSessionUpdateAddress options, string ifUnmodifiedSince = default(string))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidJsonOrderAddressesPut");

            // verify the required parameter 'options' is set
            if (options == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'options' when calling ViewApi->CheckoutSidJsonOrderAddressesPut");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            if (ifUnmodifiedSince != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Unmodified-Since", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(ifUnmodifiedSince)); // header parameter
            }
            localVarRequestOptions.Data = options;

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<InlineResponse20013>("/view/{session_id}/session/order/addresses", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidJsonOrderAddressesPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set Express Checkout addresses Changes the &#x60;order.shipping_address&#x60; and &#x60;order.billing_address&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse20013</returns>
        public async System.Threading.Tasks.Task<InlineResponse20013> CheckoutSidJsonOrderAddressesPutAsync(string sessionId, ViewSessionUpdateAddress options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> localVarResponse = await CheckoutSidJsonOrderAddressesPutWithHttpInfoAsync(sessionId, options, ifUnmodifiedSince, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set Express Checkout addresses Changes the &#x60;order.shipping_address&#x60; and &#x60;order.billing_address&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013>> CheckoutSidJsonOrderAddressesPutWithHttpInfoAsync(string sessionId, ViewSessionUpdateAddress options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidJsonOrderAddressesPut");

            // verify the required parameter 'options' is set
            if (options == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'options' when calling ViewApi->CheckoutSidJsonOrderAddressesPut");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            if (ifUnmodifiedSince != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Unmodified-Since", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(ifUnmodifiedSince)); // header parameter
            }
            localVarRequestOptions.Data = options;

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<InlineResponse20013>("/view/{session_id}/session/order/addresses", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidJsonOrderAddressesPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set Express Checkout discount codes Changes the &#x60;order.discount_codes&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.discount_codes_callback_url&#x60;_ is set, the session will be updated with discount on the order and the shipping options. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>InlineResponse20013</returns>
        public InlineResponse20013 CheckoutSidJsonOrderDiscountCodesPut(string sessionId, ViewSessionUpdateDiscountCodes options, string ifUnmodifiedSince = default(string))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> localVarResponse = CheckoutSidJsonOrderDiscountCodesPutWithHttpInfo(sessionId, options, ifUnmodifiedSince);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set Express Checkout discount codes Changes the &#x60;order.discount_codes&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.discount_codes_callback_url&#x60;_ is set, the session will be updated with discount on the order and the shipping options. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> CheckoutSidJsonOrderDiscountCodesPutWithHttpInfo(string sessionId, ViewSessionUpdateDiscountCodes options, string ifUnmodifiedSince = default(string))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidJsonOrderDiscountCodesPut");

            // verify the required parameter 'options' is set
            if (options == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'options' when calling ViewApi->CheckoutSidJsonOrderDiscountCodesPut");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            if (ifUnmodifiedSince != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Unmodified-Since", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(ifUnmodifiedSince)); // header parameter
            }
            localVarRequestOptions.Data = options;

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<InlineResponse20013>("/view/{session_id}/session/order/discount_codes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidJsonOrderDiscountCodesPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set Express Checkout discount codes Changes the &#x60;order.discount_codes&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.discount_codes_callback_url&#x60;_ is set, the session will be updated with discount on the order and the shipping options. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse20013</returns>
        public async System.Threading.Tasks.Task<InlineResponse20013> CheckoutSidJsonOrderDiscountCodesPutAsync(string sessionId, ViewSessionUpdateDiscountCodes options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> localVarResponse = await CheckoutSidJsonOrderDiscountCodesPutWithHttpInfoAsync(sessionId, options, ifUnmodifiedSince, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set Express Checkout discount codes Changes the &#x60;order.discount_codes&#x60; submitted by end user in the Express Checkout flow.  If the _&#x60;express.discount_codes_callback_url&#x60;_ is set, the session will be updated with discount on the order and the shipping options. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013>> CheckoutSidJsonOrderDiscountCodesPutWithHttpInfoAsync(string sessionId, ViewSessionUpdateDiscountCodes options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidJsonOrderDiscountCodesPut");

            // verify the required parameter 'options' is set
            if (options == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'options' when calling ViewApi->CheckoutSidJsonOrderDiscountCodesPut");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            if (ifUnmodifiedSince != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Unmodified-Since", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(ifUnmodifiedSince)); // header parameter
            }
            localVarRequestOptions.Data = options;

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<InlineResponse20013>("/view/{session_id}/session/order/discount_codes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidJsonOrderDiscountCodesPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set Express Checkout shipping option Changes the selected shipping_option, submitted by end user in the  Express Checkout flow. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>InlineResponse20013</returns>
        public InlineResponse20013 CheckoutSidJsonOrderItemsShippingOptionPut(string sessionId, ShippingOption options, string ifUnmodifiedSince = default(string))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> localVarResponse = CheckoutSidJsonOrderItemsShippingOptionPutWithHttpInfo(sessionId, options, ifUnmodifiedSince);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set Express Checkout shipping option Changes the selected shipping_option, submitted by end user in the  Express Checkout flow. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> CheckoutSidJsonOrderItemsShippingOptionPutWithHttpInfo(string sessionId, ShippingOption options, string ifUnmodifiedSince = default(string))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidJsonOrderItemsShippingOptionPut");

            // verify the required parameter 'options' is set
            if (options == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'options' when calling ViewApi->CheckoutSidJsonOrderItemsShippingOptionPut");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            if (ifUnmodifiedSince != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Unmodified-Since", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(ifUnmodifiedSince)); // header parameter
            }
            localVarRequestOptions.Data = options;

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<InlineResponse20013>("/view/{session_id}/session/order/shipping_option", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidJsonOrderItemsShippingOptionPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set Express Checkout shipping option Changes the selected shipping_option, submitted by end user in the  Express Checkout flow. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse20013</returns>
        public async System.Threading.Tasks.Task<InlineResponse20013> CheckoutSidJsonOrderItemsShippingOptionPutAsync(string sessionId, ShippingOption options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> localVarResponse = await CheckoutSidJsonOrderItemsShippingOptionPutWithHttpInfoAsync(sessionId, options, ifUnmodifiedSince, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set Express Checkout shipping option Changes the selected shipping_option, submitted by end user in the  Express Checkout flow. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013>> CheckoutSidJsonOrderItemsShippingOptionPutWithHttpInfoAsync(string sessionId, ShippingOption options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidJsonOrderItemsShippingOptionPut");

            // verify the required parameter 'options' is set
            if (options == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'options' when calling ViewApi->CheckoutSidJsonOrderItemsShippingOptionPut");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            if (ifUnmodifiedSince != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Unmodified-Since", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(ifUnmodifiedSince)); // header parameter
            }
            localVarRequestOptions.Data = options;

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<InlineResponse20013>("/view/{session_id}/session/order/shipping_option", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidJsonOrderItemsShippingOptionPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set Express Checkout shipping address Changes the order.shipping_address, submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>InlineResponse20013</returns>
        public InlineResponse20013 CheckoutSidJsonOrderShippingAddressPut(string sessionId, OrderAddress options, string ifUnmodifiedSince = default(string))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> localVarResponse = CheckoutSidJsonOrderShippingAddressPutWithHttpInfo(sessionId, options, ifUnmodifiedSince);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set Express Checkout shipping address Changes the order.shipping_address, submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> CheckoutSidJsonOrderShippingAddressPutWithHttpInfo(string sessionId, OrderAddress options, string ifUnmodifiedSince = default(string))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidJsonOrderShippingAddressPut");

            // verify the required parameter 'options' is set
            if (options == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'options' when calling ViewApi->CheckoutSidJsonOrderShippingAddressPut");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            if (ifUnmodifiedSince != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Unmodified-Since", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(ifUnmodifiedSince)); // header parameter
            }
            localVarRequestOptions.Data = options;

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<InlineResponse20013>("/view/{session_id}/session/order/shipping_address", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidJsonOrderShippingAddressPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set Express Checkout shipping address Changes the order.shipping_address, submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse20013</returns>
        public async System.Threading.Tasks.Task<InlineResponse20013> CheckoutSidJsonOrderShippingAddressPutAsync(string sessionId, OrderAddress options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013> localVarResponse = await CheckoutSidJsonOrderShippingAddressPutWithHttpInfoAsync(sessionId, options, ifUnmodifiedSince, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set Express Checkout shipping address Changes the order.shipping_address, submitted by end user in the Express Checkout flow.  If the _&#x60;express.shipping_address_callback_url&#x60;_ is set, the _&#x60;express.shipping_options&#x60;_ in the response will be updated to show the available shipping options for the updated address. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="options"></param>
        /// <param name="ifUnmodifiedSince">Optional header. The put request is discarded and a 412 is returned if the header does not match the &#x60;updated_at&#x60; property of the session. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<InlineResponse20013>> CheckoutSidJsonOrderShippingAddressPutWithHttpInfoAsync(string sessionId, OrderAddress options, string ifUnmodifiedSince = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidJsonOrderShippingAddressPut");

            // verify the required parameter 'options' is set
            if (options == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'options' when calling ViewApi->CheckoutSidJsonOrderShippingAddressPut");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            if (ifUnmodifiedSince != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Unmodified-Since", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(ifUnmodifiedSince)); // header parameter
            }
            localVarRequestOptions.Data = options;

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<InlineResponse20013>("/view/{session_id}/session/order/shipping_address", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidJsonOrderShippingAddressPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Lock a checkout session When locked, the session can not be paid. Locking the session is only available when express is enabled. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>SessionLock</returns>
        public SessionLock CheckoutSidLock(string sessionId)
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<SessionLock> localVarResponse = CheckoutSidLockWithHttpInfo(sessionId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Lock a checkout session When locked, the session can not be paid. Locking the session is only available when express is enabled. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>ApiResponse of SessionLock</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<SessionLock> CheckoutSidLockWithHttpInfo(string sessionId)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidLock");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<SessionLock>("/view/{session_id}/session/lock", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidLock", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Lock a checkout session When locked, the session can not be paid. Locking the session is only available when express is enabled. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SessionLock</returns>
        public async System.Threading.Tasks.Task<SessionLock> CheckoutSidLockAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<SessionLock> localVarResponse = await CheckoutSidLockWithHttpInfoAsync(sessionId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Lock a checkout session When locked, the session can not be paid. Locking the session is only available when express is enabled. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SessionLock)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<SessionLock>> CheckoutSidLockWithHttpInfoAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidLock");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<SessionLock>("/view/{session_id}/session/lock", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidLock", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get payment operations 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="paymentProductType"></param>
        /// <param name="language">Preferred language to use in the payment operation. Example: &#x60;nb-NO&#x60;  (optional)</param>
        /// <returns>PaymentOperations</returns>
        public PaymentOperations CheckoutSidPaymentsProductTypePost(string sessionId, string paymentProductType, string language = default(string))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<PaymentOperations> localVarResponse = CheckoutSidPaymentsProductTypePostWithHttpInfo(sessionId, paymentProductType, language);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get payment operations 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="paymentProductType"></param>
        /// <param name="language">Preferred language to use in the payment operation. Example: &#x60;nb-NO&#x60;  (optional)</param>
        /// <returns>ApiResponse of PaymentOperations</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<PaymentOperations> CheckoutSidPaymentsProductTypePostWithHttpInfo(string sessionId, string paymentProductType, string language = default(string))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidPaymentsProductTypePost");

            // verify the required parameter 'paymentProductType' is set
            if (paymentProductType == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'paymentProductType' when calling ViewApi->CheckoutSidPaymentsProductTypePost");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            localVarRequestOptions.PathParameters.Add("payment_product_type", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(paymentProductType)); // path parameter
            if (language != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToMultiMap("", "language", language));
            }

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<PaymentOperations>("/view/{session_id}/payments/{payment_product_type}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidPaymentsProductTypePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get payment operations 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="paymentProductType"></param>
        /// <param name="language">Preferred language to use in the payment operation. Example: &#x60;nb-NO&#x60;  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaymentOperations</returns>
        public async System.Threading.Tasks.Task<PaymentOperations> CheckoutSidPaymentsProductTypePostAsync(string sessionId, string paymentProductType, string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<PaymentOperations> localVarResponse = await CheckoutSidPaymentsProductTypePostWithHttpInfoAsync(sessionId, paymentProductType, language, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get payment operations 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="paymentProductType"></param>
        /// <param name="language">Preferred language to use in the payment operation. Example: &#x60;nb-NO&#x60;  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaymentOperations)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<PaymentOperations>> CheckoutSidPaymentsProductTypePostWithHttpInfoAsync(string sessionId, string paymentProductType, string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidPaymentsProductTypePost");

            // verify the required parameter 'paymentProductType' is set
            if (paymentProductType == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'paymentProductType' when calling ViewApi->CheckoutSidPaymentsProductTypePost");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter
            localVarRequestOptions.PathParameters.Add("payment_product_type", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(paymentProductType)); // path parameter
            if (language != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToMultiMap("", "language", language));
            }

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PaymentOperations>("/view/{session_id}/payments/{payment_product_type}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidPaymentsProductTypePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send a verification code to the customer Send a SMS with a payment verification code 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns></returns>
        public void CheckoutSidSendScc(string sessionId)
        {
            CheckoutSidSendSccWithHttpInfo(sessionId);
        }

        /// <summary>
        /// Send a verification code to the customer Send a SMS with a payment verification code 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<Object> CheckoutSidSendSccWithHttpInfo(string sessionId)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidSendScc");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/view/{session_id}/session/publish/scc", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidSendScc", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send a verification code to the customer Send a SMS with a payment verification code 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CheckoutSidSendSccAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await CheckoutSidSendSccWithHttpInfoAsync(sessionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Send a verification code to the customer Send a SMS with a payment verification code 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<Object>> CheckoutSidSendSccWithHttpInfoAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->CheckoutSidSendScc");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/view/{session_id}/session/publish/scc", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckoutSidSendScc", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Abandon a checkout payment Abandon a checkout payment before completing payment. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns></returns>
        public void ViewSidSessionAbandonPost(string sessionId)
        {
            ViewSidSessionAbandonPostWithHttpInfo(sessionId);
        }

        /// <summary>
        /// Abandon a checkout payment Abandon a checkout payment before completing payment. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<Object> ViewSidSessionAbandonPostWithHttpInfo(string sessionId)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->ViewSidSessionAbandonPost");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/view/{session_id}/session/abandon", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ViewSidSessionAbandonPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Abandon a checkout payment Abandon a checkout payment before completing payment. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ViewSidSessionAbandonPostAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ViewSidSessionAbandonPostWithHttpInfoAsync(sessionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Abandon a checkout payment Abandon a checkout payment before completing payment. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<Object>> ViewSidSessionAbandonPostWithHttpInfoAsync(string sessionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'sessionId' when calling ViewApi->ViewSidSessionAbandonPost");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("session_id", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(sessionId)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/view/{session_id}/session/abandon", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ViewSidSessionAbandonPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
