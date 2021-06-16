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

namespace Dintero.OpenApiClient.Checkout.Client
{
    /// <summary>
    /// A dictionary in which one key has many associated values.
    /// </summary>
    /// <typeparam name="TKey">The type of the key</typeparam>
    /// <typeparam name="TValue">The type of the value associated with the key.</typeparam>
    public class Multimap<TKey, TValue> : IDictionary<TKey, IList<TValue>>
    {
        #region Private Fields

        private readonly Dictionary<TKey, IList<TValue>> _dictionary;

        #endregion Private Fields

        #region Constructors

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public Multimap()
        {
            _dictionary = new Dictionary<TKey, IList<TValue>>();
        }

        /// <summary>
        /// Constructor with comparer.
        /// </summary>
        /// <param name="comparer"></param>
        public Multimap(IEqualityComparer<TKey> comparer)
        {
            _dictionary = new Dictionary<TKey, IList<TValue>>(comparer);
        }

        #endregion Constructors

        #region Enumerators

        /// <summary>
        /// To get the enumerator.
        /// </summary>
        /// <returns>Enumerator</returns>
        public IEnumerator<KeyValuePair<TKey, IList<TValue>>> GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        /// <summary>
        /// To get the enumerator.
        /// </summary>
        /// <returns>Enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        #endregion Enumerators

        #region Public Members
        /// <summary>
        /// Add values to Multimap
        /// </summary>
        /// <param name="item">Key value pair</param>
        public void Add(KeyValuePair<TKey, IList<TValue>> item)
        {
            if (!TryAdd(item.Key, item.Value))
                throw new InvalidOperationException("Could not add values to Multimap.");
        }

        /// <summary>
        /// Add Multimap to Multimap
        /// </summary>
        /// <param name="multimap">Multimap</param>
        public void Add(Multimap<TKey, TValue> multimap)
        {
            foreach (var item in multimap)
            {
                if (!TryAdd(item.Key, item.Value))
                    throw new InvalidOperationException("Could not add values to Multimap.");
            }
        }

        /// <summary>
        /// Clear Multimap
        /// </summary>
        public void Clear()
        {
            _dictionary.Clear();
        }

        /// <summary>
        /// Determines whether Multimap contains the specified item.
        /// </summary>
        /// <param name="item">Key value pair</param>
        /// <exception cref="NotImplementedException">Method needs to be implemented</exception>
        /// <returns>true if the Multimap contains the item; otherwise, false.</returns>
        public bool Contains(KeyValuePair<TKey, IList<TValue>> item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Copy items of the Multimap to an array,
        ///     starting at a particular array index.
        /// </summary>
        /// <param name="array">The array that is the destination of the items copied
        ///     from Multimap. The array must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
        /// <exception cref="NotImplementedException">Method needs to be implemented</exception>
        public void CopyTo(KeyValuePair<TKey, IList<TValue>>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the specified item from the Multimap.
        /// </summary>
        /// <param name="item">Key value pair</param>
        /// <returns>true if the item is successfully removed; otherwise, false.</returns>
        /// <exception cref="NotImplementedException">Method needs to be implemented</exception>
        public bool Remove(KeyValuePair<TKey, IList<TValue>> item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the number of items contained in the Multimap.
        /// </summary>
        public int Count => _dictionary.Count;

        /// <summary>
        /// Gets a value indicating whether the Multimap is read-only.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Adds an item with the provided key and value to the Multimap.
        /// </summary>
        /// <param name="key">The object to use as the key of the item to add.</param>
        /// <param name="value">The object to use as the value of the item to add.</param>
        /// <exception cref="InvalidOperationException">Thrown when couldn't add the value to Multimap.</exception>
        public void Add(TKey key, IList<TValue> value)
        {
            if (value != null && value.Count > 0)
            {
                if (_dictionary.TryGetValue(key, out var list))
                {
                    foreach (var k in value) list.Add(k);
                }
                else
                {
                    list = new List<TValue>(value);
                    if (!TryAdd(key, list))
                        throw new InvalidOperationException("Could not add values to Multimap.");
                }
            }
        }

        /// <summary>
        /// Determines whether the Multimap contains an item with the specified key.
        /// </summary>
        /// <param name="key">The key to locate in the Multimap.</param>
        /// <returns>true if the Multimap contains an item with
        ///     the key; otherwise, false.</returns>
        public bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        /// <summary>
        /// Removes item with the specified key from the Multimap.
        /// </summary>
        /// <param name="key">The key to locate in the Multimap.</param>
        /// <returns>true if the item is successfully removed; otherwise, false.</returns>
        public bool Remove(TKey key)
        {
            return TryRemove(key, out var _);
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key whose value to get.</param>
        /// <param name="value">When this method returns, the value associated with the specified key, if the
        ///     key is found; otherwise, the default value for the type of the value parameter.
        ///     This parameter is passed uninitialized.</param>
        /// <returns> true if the object that implements Multimap contains
        ///     an item with the specified key; otherwise, false.</returns>
        public bool TryGetValue(TKey key, out IList<TValue> value)
        {
            return _dictionary.TryGetValue(key, out value);
        }

        /// <summary>
        /// Gets or sets the item with the specified key.
        /// </summary>
        /// <param name="key">The key of the item to get or set.</param>
        /// <returns>The value of the specified key.</returns>
        public IList<TValue> this[TKey key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }

        /// <summary>
        /// Gets a System.Collections.Generic.ICollection containing the keys of the Multimap.
        /// </summary>
        public ICollection<TKey> Keys => _dictionary.Keys;

        /// <summary>
        /// Gets a System.Collections.Generic.ICollection containing the values of the Multimap.
        /// </summary>
        public ICollection<IList<TValue>> Values => _dictionary.Values;

        /// <summary>
        ///  Copy the items of the Multimap to an System.Array,
        ///     starting at a particular System.Array index.
        /// </summary>
        /// <param name="array">The one-dimensional System.Array that is the destination of the items copied
        ///     from Multimap. The System.Array must have zero-based indexing.</param>
        /// <param name="index">The zero-based index in array at which copying begins.</param>
        public void CopyTo(Array array, int index)
        {
            ((ICollection)_dictionary).CopyTo(array, index);
        }

        /// <summary>
        /// Adds an item with the provided key and value to the Multimap.
        /// </summary>
        /// <param name="key">The object to use as the key of the item to add.</param>
        /// <param name="value">The object to use as the value of the item to add.</param>
        /// <exception cref="InvalidOperationException">Thrown when couldn't add value to Multimap.</exception>
        public void Add(TKey key, TValue value)
        {
            if (value != null)
            {
                if (_dictionary.TryGetValue(key, out var list))
                {
                    list.Add(value);
                }
                else
                {
                    list = new List<TValue> { value };
                    if (!TryAdd(key, list))
                        throw new InvalidOperationException("Could not add value to Multimap.");
                }
            }
        }

        #endregion Public Members

        #region Private Members

        /**
         * Helper method to encapsulate generator differences between dictionary types.
         */
        private bool TryRemove(TKey key, out IList<TValue> value)
        {
            _dictionary.TryGetValue(key, out value);
            return _dictionary.Remove(key);
        }

        /**
         * Helper method to encapsulate generator differences between dictionary types.
         */
        private bool TryAdd(TKey key, IList<TValue> value)
        {
            try
            {
                _dictionary.Add(key, value);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }
        #endregion Private Members
    }
}
