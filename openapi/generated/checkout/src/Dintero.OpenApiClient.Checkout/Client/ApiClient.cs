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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;
using RestSharp;
using RestSharp.Deserializers;
using RestSharpMethod = RestSharp.Method;
using Polly;

namespace Dintero.OpenApiClient.Checkout.Client
{
    /// <summary>
    /// Allows RestSharp to Serialize/Deserialize JSON using our custom logic, but only when ContentType is JSON.
    /// </summary>
    internal class CustomJsonCodec : RestSharp.Serializers.ISerializer, RestSharp.Deserializers.IDeserializer
    {
        private readonly IReadableConfiguration _configuration;
        private static readonly string _contentType = "application/json";
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        public CustomJsonCodec(IReadableConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CustomJsonCodec(JsonSerializerSettings serializerSettings, IReadableConfiguration configuration)
        {
            _serializerSettings = serializerSettings;
            _configuration = configuration;
        }

        /// <summary>
        /// Serialize the object into a JSON string.
        /// </summary>
        /// <param name="obj">Object to be serialized.</param>
        /// <returns>A JSON string.</returns>
        public string Serialize(object obj)
        {
            if (obj != null && obj is Dintero.OpenApiClient.Checkout.Model.AbstractOpenAPISchema)
            {
                // the object to be serialized is an oneOf/anyOf schema
                return ((Dintero.OpenApiClient.Checkout.Model.AbstractOpenAPISchema)obj).ToJson();
            }
            else
            {
                return JsonConvert.SerializeObject(obj, _serializerSettings);
            }
        }

        public T Deserialize<T>(IRestResponse response)
        {
            var result = (T)Deserialize(response, typeof(T));
            return result;
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        internal object Deserialize(IRestResponse response, Type type)
        {
            if (type == typeof(byte[])) // return byte array
            {
                return response.RawBytes;
            }

            // TODO: ? if (type.IsAssignableFrom(typeof(Stream)))
            if (type == typeof(Stream))
            {
                var bytes = response.RawBytes;
                if (response.Headers != null)
                {
                    var filePath = String.IsNullOrEmpty(_configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : _configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in response.Headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            File.WriteAllBytes(fileName, bytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(bytes);
                return stream;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(response.Content, null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(String) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return Convert.ChangeType(response.Content, type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(response.Content, type, _serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }

        public string ContentType
        {
            get { return _contentType; }
            set { throw new InvalidOperationException("Not allowed to set content type."); }
        }
    }
    /// <summary>
    /// Provides a default implementation of an Api client (both synchronous and asynchronous implementatios),
    /// encapsulating general REST accessor use cases.
    /// </summary>
    public partial class ApiClient : ISynchronousClient, IAsynchronousClient
    {
        private readonly String _baseUrl;

        /// <summary>
        /// Specifies the settings on a <see cref="JsonSerializer" /> object.
        /// These settings can be adjusted to accomodate custom serialization rules.
        /// </summary>
        public JsonSerializerSettings SerializerSettings { get; set; } = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        partial void InterceptRequest(IRestRequest request);

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        partial void InterceptResponse(IRestRequest request, IRestResponse response);

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />, defaulting to the global configurations' base url.
        /// </summary>
        public ApiClient()
        {
            _baseUrl = Dintero.OpenApiClient.Checkout.Client.GlobalConfiguration.Instance.BasePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        public ApiClient(String basePath)
        {
            if (string.IsNullOrEmpty(basePath))
                throw new ArgumentException("basePath cannot be empty");

            _baseUrl = basePath;
        }

        /// <summary>
        /// Constructs the RestSharp version of an http method
        /// </summary>
        /// <param name="method">Swagger Client Custom HttpMethod</param>
        /// <returns>RestSharp's HttpMethod instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private RestSharpMethod Method(HttpMethod method)
        {
            RestSharpMethod other;
            switch (method)
            {
                case HttpMethod.Get:
                    other = RestSharpMethod.GET;
                    break;
                case HttpMethod.Post:
                    other = RestSharpMethod.POST;
                    break;
                case HttpMethod.Put:
                    other = RestSharpMethod.PUT;
                    break;
                case HttpMethod.Delete:
                    other = RestSharpMethod.DELETE;
                    break;
                case HttpMethod.Head:
                    other = RestSharpMethod.HEAD;
                    break;
                case HttpMethod.Options:
                    other = RestSharpMethod.OPTIONS;
                    break;
                case HttpMethod.Patch:
                    other = RestSharpMethod.PATCH;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("method", method, null);
            }

            return other;
        }

        /// <summary>
        /// Provides all logic for constructing a new RestSharp <see cref="RestRequest"/>.
        /// At this point, all information for querying the service is known. Here, it is simply
        /// mapped into the RestSharp request.
        /// </summary>
        /// <param name="method">The http verb.</param>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>[private] A new RestRequest instance.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private RestRequest NewRequest(
            HttpMethod method,
            String path,
            RequestOptions options,
            IReadableConfiguration configuration)
        {
            if (path == null) throw new ArgumentNullException("path");
            if (options == null) throw new ArgumentNullException("options");
            if (configuration == null) throw new ArgumentNullException("configuration");

            RestRequest request = new RestRequest(Method(method))
            {
                Resource = path,
                JsonSerializer = new CustomJsonCodec(SerializerSettings, configuration)
            };

            if (options.PathParameters != null)
            {
                foreach (var pathParam in options.PathParameters)
                {
                    request.AddParameter(pathParam.Key, pathParam.Value, ParameterType.UrlSegment);
                }
            }

            if (options.QueryParameters != null)
            {
                foreach (var queryParam in options.QueryParameters)
                {
                    foreach (var value in queryParam.Value)
                    {
                        request.AddQueryParameter(queryParam.Key, value);
                    }
                }
            }

            if (configuration.DefaultHeaders != null)
            {
                foreach (var headerParam in configuration.DefaultHeaders)
                {
                    request.AddHeader(headerParam.Key, headerParam.Value);
                }
            }

            if (options.HeaderParameters != null)
            {
                foreach (var headerParam in options.HeaderParameters)
                {
                    foreach (var value in headerParam.Value)
                    {
                        request.AddHeader(headerParam.Key, value);
                    }
                }
            }

            if (options.FormParameters != null)
            {
                foreach (var formParam in options.FormParameters)
                {
                    request.AddParameter(formParam.Key, formParam.Value);
                }
            }

            if (options.Data != null)
            {
                if (options.Data is Stream stream)
                {
                    var contentType = "application/octet-stream";
                    if (options.HeaderParameters != null)
                    {
                        var contentTypes = options.HeaderParameters["Content-Type"];
                        contentType = contentTypes[0];
                    }

                    var bytes = ClientUtils.ReadAsBytes(stream);
                    request.AddParameter(contentType, bytes, ParameterType.RequestBody);
                }
                else
                {
                    if (options.HeaderParameters != null)
                    {
                        var contentTypes = options.HeaderParameters["Content-Type"];
                        if (contentTypes == null || contentTypes.Any(header => header.Contains("application/json")))
                        {
                            request.RequestFormat = DataFormat.Json;
                        }
                        else
                        {
                            // TODO: Generated client user should add additional handlers. RestSharp only supports XML and JSON, with XML as default.
                        }
                    }
                    else
                    {
                        // Here, we'll assume JSON APIs are more common. XML can be forced by adding produces/consumes to openapi spec explicitly.
                        request.RequestFormat = DataFormat.Json;
                    }

                    request.AddJsonBody(options.Data);
                }
            }

            if (options.FileParameters != null)
            {
                foreach (var fileParam in options.FileParameters)
                {
                    var bytes = ClientUtils.ReadAsBytes(fileParam.Value);
                    var fileStream = fileParam.Value as FileStream;
                    if (fileStream != null)
                        request.Files.Add(FileParameter.Create(fileParam.Key, bytes, System.IO.Path.GetFileName(fileStream.Name)));
                    else
                        request.Files.Add(FileParameter.Create(fileParam.Key, bytes, "no_file_name_provided"));
                }
            }

            if (options.Cookies != null && options.Cookies.Count > 0)
            {
                foreach (var cookie in options.Cookies)
                {
                    request.AddCookie(cookie.Name, cookie.Value);
                }
            }

            return request;
        }

        private ApiResponse<T> ToApiResponse<T>(IRestResponse<T> response)
        {
            T result = response.Data;
            string rawContent = response.Content;

            var transformed = new ApiResponse<T>(response.StatusCode, new Multimap<string, string>(), result, rawContent)
            {
                ErrorText = response.ErrorMessage,
                Cookies = new List<Cookie>()
            };

            if (response.Headers != null)
            {
                foreach (var responseHeader in response.Headers)
                {
                    transformed.Headers.Add(responseHeader.Name, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            if (response.Cookies != null)
            {
                foreach (var responseCookies in response.Cookies)
                {
                    transformed.Cookies.Add(
                        new Cookie(
                            responseCookies.Name,
                            responseCookies.Value,
                            responseCookies.Path,
                            responseCookies.Domain)
                        );
                }
            }

            return transformed;
        }

        private ApiResponse<T> Exec<T>(RestRequest req, IReadableConfiguration configuration)
        {
            RestClient client = new RestClient(_baseUrl);

            client.ClearHandlers();
            var existingDeserializer = req.JsonSerializer as IDeserializer;
            if (existingDeserializer != null)
            {
                client.AddHandler("application/json", () => existingDeserializer);
                client.AddHandler("text/json", () => existingDeserializer);
                client.AddHandler("text/x-json", () => existingDeserializer);
                client.AddHandler("text/javascript", () => existingDeserializer);
                client.AddHandler("*+json", () => existingDeserializer);
            }
            else
            {
                var customDeserializer = new CustomJsonCodec(SerializerSettings, configuration);
                client.AddHandler("application/json", () => customDeserializer);
                client.AddHandler("text/json", () => customDeserializer);
                client.AddHandler("text/x-json", () => customDeserializer);
                client.AddHandler("text/javascript", () => customDeserializer);
                client.AddHandler("*+json", () => customDeserializer);
            }

            var xmlDeserializer = new XmlDeserializer();
            client.AddHandler("application/xml", () => xmlDeserializer);
            client.AddHandler("text/xml", () => xmlDeserializer);
            client.AddHandler("*+xml", () => xmlDeserializer);
            client.AddHandler("*", () => xmlDeserializer);

            client.Timeout = configuration.Timeout;

            if (configuration.Proxy != null)
            {
                client.Proxy = configuration.Proxy;
            }

            if (configuration.UserAgent != null)
            {
                client.UserAgent = configuration.UserAgent;
            }

            if (configuration.ClientCertificates != null)
            {
                client.ClientCertificates = configuration.ClientCertificates;
            }

            InterceptRequest(req);

            IRestResponse<T> response;
            if (RetryConfiguration.RetryPolicy != null)
            {
                var policy = RetryConfiguration.RetryPolicy;
                var policyResult = policy.ExecuteAndCapture(() => client.Execute(req));
                response = (policyResult.Outcome == OutcomeType.Successful) ? client.Deserialize<T>(policyResult.Result) : new RestResponse<T>
                {
                    Request = req,
                    ErrorException = policyResult.FinalException
                };
            }
            else
            {
                response = client.Execute<T>(req);
            }

            // if the response type is oneOf/anyOf, call FromJSON to deserialize the data
            if (typeof(Dintero.OpenApiClient.Checkout.Model.AbstractOpenAPISchema).IsAssignableFrom(typeof(T)))
            {
                response.Data = (T) typeof(T).GetMethod("FromJson").Invoke(null, new object[] { response.Content });
            }
            else if (typeof(T).Name == "Stream") // for binary response
            {
                response.Data = (T)(object)new MemoryStream(response.RawBytes);
            }

            InterceptResponse(req, response);

            var result = ToApiResponse(response);
            if (response.ErrorMessage != null)
            {
                result.ErrorText = response.ErrorMessage;
            }

            if (response.Cookies != null && response.Cookies.Count > 0)
            {
                if (result.Cookies == null) result.Cookies = new List<Cookie>();
                foreach (var restResponseCookie in response.Cookies)
                {
                    var cookie = new Cookie(
                        restResponseCookie.Name,
                        restResponseCookie.Value,
                        restResponseCookie.Path,
                        restResponseCookie.Domain
                    )
                    {
                        Comment = restResponseCookie.Comment,
                        CommentUri = restResponseCookie.CommentUri,
                        Discard = restResponseCookie.Discard,
                        Expired = restResponseCookie.Expired,
                        Expires = restResponseCookie.Expires,
                        HttpOnly = restResponseCookie.HttpOnly,
                        Port = restResponseCookie.Port,
                        Secure = restResponseCookie.Secure,
                        Version = restResponseCookie.Version
                    };

                    result.Cookies.Add(cookie);
                }
            }
            return result;
        }

        private async Task<ApiResponse<T>> ExecAsync<T>(RestRequest req, IReadableConfiguration configuration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            RestClient client = new RestClient(_baseUrl);

            client.ClearHandlers();
            var existingDeserializer = req.JsonSerializer as IDeserializer;
            if (existingDeserializer != null)
            {
                client.AddHandler("application/json", () => existingDeserializer);
                client.AddHandler("text/json", () => existingDeserializer);
                client.AddHandler("text/x-json", () => existingDeserializer);
                client.AddHandler("text/javascript", () => existingDeserializer);
                client.AddHandler("*+json", () => existingDeserializer);
            }
            else
            {
                var customDeserializer = new CustomJsonCodec(SerializerSettings, configuration);
                client.AddHandler("application/json", () => customDeserializer);
                client.AddHandler("text/json", () => customDeserializer);
                client.AddHandler("text/x-json", () => customDeserializer);
                client.AddHandler("text/javascript", () => customDeserializer);
                client.AddHandler("*+json", () => customDeserializer);
            }

            var xmlDeserializer = new XmlDeserializer();
            client.AddHandler("application/xml", () => xmlDeserializer);
            client.AddHandler("text/xml", () => xmlDeserializer);
            client.AddHandler("*+xml", () => xmlDeserializer);
            client.AddHandler("*", () => xmlDeserializer);

            client.Timeout = configuration.Timeout;

            if (configuration.Proxy != null)
            {
                client.Proxy = configuration.Proxy;
            }

            if (configuration.UserAgent != null)
            {
                client.UserAgent = configuration.UserAgent;
            }

            if (configuration.ClientCertificates != null)
            {
                client.ClientCertificates = configuration.ClientCertificates;
            }

            InterceptRequest(req);

            IRestResponse<T> response;
            if (RetryConfiguration.AsyncRetryPolicy != null)
            {
                var policy = RetryConfiguration.AsyncRetryPolicy;
                var policyResult = await policy.ExecuteAndCaptureAsync(() => client.ExecuteAsync(req, cancellationToken)).ConfigureAwait(false);
                response = (policyResult.Outcome == OutcomeType.Successful) ? client.Deserialize<T>(policyResult.Result) : new RestResponse<T>
                {
                    Request = req,
                    ErrorException = policyResult.FinalException
                };
            }
            else
            {
                response = await client.ExecuteAsync<T>(req, cancellationToken).ConfigureAwait(false);
            }

            // if the response type is oneOf/anyOf, call FromJSON to deserialize the data
            if (typeof(Dintero.OpenApiClient.Checkout.Model.AbstractOpenAPISchema).IsAssignableFrom(typeof(T)))
            {
                response.Data = (T) typeof(T).GetMethod("FromJson").Invoke(null, new object[] { response.Content });
            }
            else if (typeof(T).Name == "Stream") // for binary response
            {
                response.Data = (T)(object)new MemoryStream(response.RawBytes);
            }

            InterceptResponse(req, response);

            var result = ToApiResponse(response);
            if (response.ErrorMessage != null)
            {
                result.ErrorText = response.ErrorMessage;
            }

            if (response.Cookies != null && response.Cookies.Count > 0)
            {
                if (result.Cookies == null) result.Cookies = new List<Cookie>();
                foreach (var restResponseCookie in response.Cookies)
                {
                    var cookie = new Cookie(
                        restResponseCookie.Name,
                        restResponseCookie.Value,
                        restResponseCookie.Path,
                        restResponseCookie.Domain
                    )
                    {
                        Comment = restResponseCookie.Comment,
                        CommentUri = restResponseCookie.CommentUri,
                        Discard = restResponseCookie.Discard,
                        Expired = restResponseCookie.Expired,
                        Expires = restResponseCookie.Expires,
                        HttpOnly = restResponseCookie.HttpOnly,
                        Port = restResponseCookie.Port,
                        Secure = restResponseCookie.Secure,
                        Version = restResponseCookie.Version
                    };

                    result.Cookies.Add(cookie);
                }
            }
            return result;
        }

        #region IAsynchronousClient
        /// <summary>
        /// Make a HTTP GET request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Get, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP POST request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Post, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP PUT request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Put, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP DELETE request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> DeleteAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Delete, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP HEAD request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> HeadAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Head, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP OPTION request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> OptionsAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Options, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP PATCH request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PatchAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Patch, path, options, config), config, cancellationToken);
        }
        #endregion IAsynchronousClient

        #region ISynchronousClient
        /// <summary>
        /// Make a HTTP GET request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Get<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Get, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP POST request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Post<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Post, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP PUT request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Put<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Put, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP DELETE request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Delete<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Delete, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP HEAD request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Head<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Head, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP OPTION request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Options<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Options, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP PATCH request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Patch<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Patch, path, options, config), config);
        }
        #endregion ISynchronousClient
    }
}
