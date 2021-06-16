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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dintero.OpenApiClient.Checkout.Client.OpenAPIDateConverter;

namespace Dintero.OpenApiClient.Checkout.Model
{
    /// <summary>
    /// Ingenico webhook event - see https://epayments.developer-ingenico.com/documentation/webhooks/
    /// </summary>
    [DataContract(Name = "IngenicoWebhookEvent")]
    public partial class IngenicoWebhookEvent : IEquatable<IngenicoWebhookEvent>, IValidatableObject
    {
        /// <summary>
        /// One of the event names as listed on our webhooks event types page. Each type is of the following format: object.event, e.g. \&quot;payment.created\&quot; or \&quot;refund.captured\&quot;. See https://epayments.developer-ingenico.com/documentation/webhooks/event-types/ 
        /// </summary>
        /// <value>One of the event names as listed on our webhooks event types page. Each type is of the following format: object.event, e.g. \&quot;payment.created\&quot; or \&quot;refund.captured\&quot;. See https://epayments.developer-ingenico.com/documentation/webhooks/event-types/ </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PaymentCreated for value: payment.created
            /// </summary>
            [EnumMember(Value = "payment.created")]
            PaymentCreated = 1,

            /// <summary>
            /// Enum PaymentRedirected for value: payment.redirected
            /// </summary>
            [EnumMember(Value = "payment.redirected")]
            PaymentRedirected = 2,

            /// <summary>
            /// Enum PaymentPendingPayment for value: payment.pending_payment
            /// </summary>
            [EnumMember(Value = "payment.pending_payment")]
            PaymentPendingPayment = 3,

            /// <summary>
            /// Enum PaymentAccountVerified for value: payment.account_verified
            /// </summary>
            [EnumMember(Value = "payment.account_verified")]
            PaymentAccountVerified = 4,

            /// <summary>
            /// Enum PaymentPendingFraudApproval for value: payment.pending_fraud_approval
            /// </summary>
            [EnumMember(Value = "payment.pending_fraud_approval")]
            PaymentPendingFraudApproval = 5,

            /// <summary>
            /// Enum PaymentAuthorizationRequested for value: payment.authorization_requested
            /// </summary>
            [EnumMember(Value = "payment.authorization_requested")]
            PaymentAuthorizationRequested = 6,

            /// <summary>
            /// Enum PaymentPendingApproval for value: payment.pending_approval
            /// </summary>
            [EnumMember(Value = "payment.pending_approval")]
            PaymentPendingApproval = 7,

            /// <summary>
            /// Enum PaymentPendingCompletion for value: payment.pending_completion
            /// </summary>
            [EnumMember(Value = "payment.pending_completion")]
            PaymentPendingCompletion = 8,

            /// <summary>
            /// Enum PaymentPendingCapture for value: payment.pending_capture
            /// </summary>
            [EnumMember(Value = "payment.pending_capture")]
            PaymentPendingCapture = 9,

            /// <summary>
            /// Enum PaymentCaptureRequested for value: payment.capture_requested
            /// </summary>
            [EnumMember(Value = "payment.capture_requested")]
            PaymentCaptureRequested = 10,

            /// <summary>
            /// Enum PaymentCaptured for value: payment.captured
            /// </summary>
            [EnumMember(Value = "payment.captured")]
            PaymentCaptured = 11,

            /// <summary>
            /// Enum PaymentPaid for value: payment.paid
            /// </summary>
            [EnumMember(Value = "payment.paid")]
            PaymentPaid = 12,

            /// <summary>
            /// Enum PaymentReversed for value: payment.reversed
            /// </summary>
            [EnumMember(Value = "payment.reversed")]
            PaymentReversed = 13,

            /// <summary>
            /// Enum PaymentChargebackNotification for value: payment.chargeback_notification
            /// </summary>
            [EnumMember(Value = "payment.chargeback_notification")]
            PaymentChargebackNotification = 14,

            /// <summary>
            /// Enum PaymentChargebacked for value: payment.chargebacked
            /// </summary>
            [EnumMember(Value = "payment.chargebacked")]
            PaymentChargebacked = 15,

            /// <summary>
            /// Enum PaymentRejected for value: payment.rejected
            /// </summary>
            [EnumMember(Value = "payment.rejected")]
            PaymentRejected = 16,

            /// <summary>
            /// Enum PaymentRejectedCapture for value: payment.rejected_capture
            /// </summary>
            [EnumMember(Value = "payment.rejected_capture")]
            PaymentRejectedCapture = 17,

            /// <summary>
            /// Enum PaymentCancelled for value: payment.cancelled
            /// </summary>
            [EnumMember(Value = "payment.cancelled")]
            PaymentCancelled = 18,

            /// <summary>
            /// Enum PaymentRefunded for value: payment.refunded
            /// </summary>
            [EnumMember(Value = "payment.refunded")]
            PaymentRefunded = 19,

            /// <summary>
            /// Enum RefundCreated for value: refund.created
            /// </summary>
            [EnumMember(Value = "refund.created")]
            RefundCreated = 20,

            /// <summary>
            /// Enum RefundPendingApproval for value: refund.pending_approval
            /// </summary>
            [EnumMember(Value = "refund.pending_approval")]
            RefundPendingApproval = 21,

            /// <summary>
            /// Enum RefundRejected for value: refund.rejected
            /// </summary>
            [EnumMember(Value = "refund.rejected")]
            RefundRejected = 22,

            /// <summary>
            /// Enum RefundRefundRequested for value: refund.refund_requested
            /// </summary>
            [EnumMember(Value = "refund.refund_requested")]
            RefundRefundRequested = 23,

            /// <summary>
            /// Enum RefundCaptured for value: refund.captured
            /// </summary>
            [EnumMember(Value = "refund.captured")]
            RefundCaptured = 24,

            /// <summary>
            /// Enum RefundRefunded for value: refund.refunded
            /// </summary>
            [EnumMember(Value = "refund.refunded")]
            RefundRefunded = 25,

            /// <summary>
            /// Enum RefundCancelled for value: refund.cancelled
            /// </summary>
            [EnumMember(Value = "refund.cancelled")]
            RefundCancelled = 26,

            /// <summary>
            /// Enum PayoutCreated for value: payout.created
            /// </summary>
            [EnumMember(Value = "payout.created")]
            PayoutCreated = 27,

            /// <summary>
            /// Enum PayoutPendingApproval for value: payout.pending_approval
            /// </summary>
            [EnumMember(Value = "payout.pending_approval")]
            PayoutPendingApproval = 28,

            /// <summary>
            /// Enum PayoutRejected for value: payout.rejected
            /// </summary>
            [EnumMember(Value = "payout.rejected")]
            PayoutRejected = 29,

            /// <summary>
            /// Enum PayoutPayoutRequested for value: payout.payout_requested
            /// </summary>
            [EnumMember(Value = "payout.payout_requested")]
            PayoutPayoutRequested = 30,

            /// <summary>
            /// Enum PayoutAccountCredited for value: payout.account_credited
            /// </summary>
            [EnumMember(Value = "payout.account_credited")]
            PayoutAccountCredited = 31,

            /// <summary>
            /// Enum PayoutRejectedCredit for value: payout.rejected_credit
            /// </summary>
            [EnumMember(Value = "payout.rejected_credit")]
            PayoutRejectedCredit = 32,

            /// <summary>
            /// Enum PayoutCancelled for value: payout.cancelled
            /// </summary>
            [EnumMember(Value = "payout.cancelled")]
            PayoutCancelled = 33,

            /// <summary>
            /// Enum PayoutReversed for value: payout.reversed
            /// </summary>
            [EnumMember(Value = "payout.reversed")]
            PayoutReversed = 34,

            /// <summary>
            /// Enum TokenCreated for value: token.created
            /// </summary>
            [EnumMember(Value = "token.created")]
            TokenCreated = 35,

            /// <summary>
            /// Enum TokenUpdated for value: token.updated
            /// </summary>
            [EnumMember(Value = "token.updated")]
            TokenUpdated = 36,

            /// <summary>
            /// Enum TokenExpired for value: token.expired
            /// </summary>
            [EnumMember(Value = "token.expired")]
            TokenExpired = 37,

            /// <summary>
            /// Enum TokenExpiringSoon for value: token.expiring_soon
            /// </summary>
            [EnumMember(Value = "token.expiring_soon")]
            TokenExpiringSoon = 38,

            /// <summary>
            /// Enum TokenDeleted for value: token.deleted
            /// </summary>
            [EnumMember(Value = "token.deleted")]
            TokenDeleted = 39,

            /// <summary>
            /// Enum DisputeDraft for value: dispute.draft
            /// </summary>
            [EnumMember(Value = "dispute.draft")]
            DisputeDraft = 40,

            /// <summary>
            /// Enum DisputeCreated for value: dispute.created
            /// </summary>
            [EnumMember(Value = "dispute.created")]
            DisputeCreated = 41,

            /// <summary>
            /// Enum DisputeInvalidRepresentment for value: dispute.invalid_representment
            /// </summary>
            [EnumMember(Value = "dispute.invalid_representment")]
            DisputeInvalidRepresentment = 42,

            /// <summary>
            /// Enum DisputeSendToBank for value: dispute.send_to_bank
            /// </summary>
            [EnumMember(Value = "dispute.send_to_bank")]
            DisputeSendToBank = 43,

            /// <summary>
            /// Enum DisputeSuccess for value: dispute.success
            /// </summary>
            [EnumMember(Value = "dispute.success")]
            DisputeSuccess = 44,

            /// <summary>
            /// Enum DisputeExpired for value: dispute.expired
            /// </summary>
            [EnumMember(Value = "dispute.expired")]
            DisputeExpired = 45,

            /// <summary>
            /// Enum DisputeCancelled for value: dispute.cancelled
            /// </summary>
            [EnumMember(Value = "dispute.cancelled")]
            DisputeCancelled = 46

        }


        /// <summary>
        /// One of the event names as listed on our webhooks event types page. Each type is of the following format: object.event, e.g. \&quot;payment.created\&quot; or \&quot;refund.captured\&quot;. See https://epayments.developer-ingenico.com/documentation/webhooks/event-types/ 
        /// </summary>
        /// <value>One of the event names as listed on our webhooks event types page. Each type is of the following format: object.event, e.g. \&quot;payment.created\&quot; or \&quot;refund.captured\&quot;. See https://epayments.developer-ingenico.com/documentation/webhooks/event-types/ </value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IngenicoWebhookEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IngenicoWebhookEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IngenicoWebhookEvent" /> class.
        /// </summary>
        /// <param name="apiVersion">The version of the REST API that is used for the structure of the object. (required).</param>
        /// <param name="id">The unique id of this event. You should use this id to verify that you did not already receive this event.  (required).</param>
        /// <param name="created">The date and time that the event occured in the yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ format  (required).</param>
        /// <param name="merchantId">The id of the merchant the event occurred on. (required).</param>
        /// <param name="type">One of the event names as listed on our webhooks event types page. Each type is of the following format: object.event, e.g. \&quot;payment.created\&quot; or \&quot;refund.captured\&quot;. See https://epayments.developer-ingenico.com/documentation/webhooks/event-types/  (required).</param>
        /// <param name="payment">payment.</param>
        /// <param name="refund">refund.</param>
        /// <param name="payout">payout.</param>
        /// <param name="token">token.</param>
        public IngenicoWebhookEvent(string apiVersion = default(string), string id = default(string), string created = default(string), string merchantId = default(string), TypeEnum type = default(TypeEnum), IngenicoWebhookEventPayment payment = default(IngenicoWebhookEventPayment), IngenicoWebhookEventRefund refund = default(IngenicoWebhookEventRefund), IngenicoWebhookEventPayout payout = default(IngenicoWebhookEventPayout), IngenicoWebhookEventToken token = default(IngenicoWebhookEventToken))
        {
            // to ensure "apiVersion" is required (not null)
            this.ApiVersion = apiVersion ?? throw new ArgumentNullException("apiVersion is a required property for IngenicoWebhookEvent and cannot be null");
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for IngenicoWebhookEvent and cannot be null");
            // to ensure "created" is required (not null)
            this.Created = created ?? throw new ArgumentNullException("created is a required property for IngenicoWebhookEvent and cannot be null");
            // to ensure "merchantId" is required (not null)
            this.MerchantId = merchantId ?? throw new ArgumentNullException("merchantId is a required property for IngenicoWebhookEvent and cannot be null");
            this.Type = type;
            this.Payment = payment;
            this.Refund = refund;
            this.Payout = payout;
            this.Token = token;
        }

        /// <summary>
        /// The version of the REST API that is used for the structure of the object.
        /// </summary>
        /// <value>The version of the REST API that is used for the structure of the object.</value>
        [DataMember(Name = "apiVersion", IsRequired = true, EmitDefaultValue = false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The unique id of this event. You should use this id to verify that you did not already receive this event. 
        /// </summary>
        /// <value>The unique id of this event. You should use this id to verify that you did not already receive this event. </value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The date and time that the event occured in the yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ format 
        /// </summary>
        /// <value>The date and time that the event occured in the yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ format </value>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// The id of the merchant the event occurred on.
        /// </summary>
        /// <value>The id of the merchant the event occurred on.</value>
        [DataMember(Name = "merchantId", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name = "payment", EmitDefaultValue = false)]
        public IngenicoWebhookEventPayment Payment { get; set; }

        /// <summary>
        /// Gets or Sets Refund
        /// </summary>
        [DataMember(Name = "refund", EmitDefaultValue = false)]
        public IngenicoWebhookEventRefund Refund { get; set; }

        /// <summary>
        /// Gets or Sets Payout
        /// </summary>
        [DataMember(Name = "payout", EmitDefaultValue = false)]
        public IngenicoWebhookEventPayout Payout { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public IngenicoWebhookEventToken Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IngenicoWebhookEvent {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Refund: ").Append(Refund).Append("\n");
            sb.Append("  Payout: ").Append(Payout).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IngenicoWebhookEvent);
        }

        /// <summary>
        /// Returns true if IngenicoWebhookEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of IngenicoWebhookEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IngenicoWebhookEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Payment == input.Payment ||
                    (this.Payment != null &&
                    this.Payment.Equals(input.Payment))
                ) && 
                (
                    this.Refund == input.Refund ||
                    (this.Refund != null &&
                    this.Refund.Equals(input.Refund))
                ) && 
                (
                    this.Payout == input.Payout ||
                    (this.Payout != null &&
                    this.Payout.Equals(input.Payout))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Payment != null)
                    hashCode = hashCode * 59 + this.Payment.GetHashCode();
                if (this.Refund != null)
                    hashCode = hashCode * 59 + this.Refund.GetHashCode();
                if (this.Payout != null)
                    hashCode = hashCode * 59 + this.Payout.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
