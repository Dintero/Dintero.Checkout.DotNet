/*
 * Account Management API
 *
 * API for managing accounts and authentication  # Changelog All notable changes to the API.  ## 2021-06-01  > Add support for configuring SMS MFA for account user > - [PUT /v1/account/user/mfa/sms](#operation/account_user_mfa_sms_put)  ## 2021-05-01  > Add support for `phone_number` in `account.company` and `account.billing` > - [PUT /v1/accounts/{aid}/management/settings](#operation/aid_account_settings_put) > - [PUT /v1/accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_put)  > Add new endpoints for managing Bambora connection > - [POST /management/settings/connections/bambora](#operation/aid_account_settings_connections_bambora_post) > - [GET /management/settings/connections/bambora](#operation/aid_account_settings_connections_bambora_get) > - [POST /management/settings/connections/bambora/{callback_reference}](#operation/aid_account_settings_connections_bambora_callback_post)  ## 2021-04-01  > Add support for `account_manager` > - [POST /accounts/{oid}/signup](#operation/accounts_oid_signup_post) > - [POST /accounts/{oid}/signup/prefill](#operation/accounts_oid_signup_prefill_post) > - [GET /v1/accounts/{oid}/management/accounts](#operation/aid_mgmnt_accounts_get) > - [PUT /v1/accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_put) > - [GET /v1/accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_get)  > Add support for filter on services and connections. > - [GET /v1/accounts/{oid}/management/accounts](#operation/aid_mgmnt_accounts_get)  > Extend the Account to support new properties, `progression`, `reseller_id` and `statistics` to services. > - [GET /v1/accounts/{oid}/management/accounts](#operation/aid_mgmnt_accounts_get) > - [PUT /v1/accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_put) > - [GET /v1/accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_get)  > Add support for account events. > - [POST /v1/accounts/{oid}/management/accounts/{aid}/events](#operation/aid_mgmnt_accounts_events_post) > - [GET /v1/accounts/{oid}/management/accounts/{aid}/events](#operation/aid_mgmnt_accounts_events_get)  ## 2021-03-01  > Make Swish cert and passphrase not required > - [POST /v1/accounts/{aid}/management/settings/connections/swish/{callback_reference}](#operation/aid_account_settings_connections_swish_callback_post)  > Add support for changing account user password > - [PUT /v1/accounts/{aid}/account/user/password](#operation/account_user_password_put)  > Add support for `authorize` when verifying a signup. > - [POST /v1/accounts/{aid}/signup/verify](#operation/accounts_oid_signup_verify_post)  ## 2021-02-01  > Document `429 Too Many Requests` response from > - [POST /v1/accounts/{aid}/auth/token](#operation/aid_auths_oauth_token_post) > - [POST /v1/accounts/{aid}/auth/passwordless](#operation/aid_auth_account_passwordless_post)  > **Break**: Require `ident_type` and `ident` to be include when requesting token > with `grant_type=authorization_code` > - [POST /v1/accounts/{aid}/auth/token](#operation/aid_auths_oauth_token_post)  > Add support for sending verification code for passwordless login via SMS, and > `session_id={uuid} to resend the same verification code again > Remove unsupported request options, `send=link` and `type=account`. > - [POST /v1/accounts/{aid}/auth/passwordless](#operation/aid_auth_account_passwordless_post)  ## 2021-01-01  > Add support for logging on without MFA even if configured with MFA > - [POST /v1/accounts/{oid}/auth/token](#operation/aid_auths_oauth_token_post)  > Add support for managing account users scopes with roles. > - [Roles](#tag/roles) > - [POST /management/users](#operation/aid_accounts_aid_mgmnt_users_post) > - [PUT /management/users/{uid}](#operation/aid_accounts_aid_mgmnt_users_put)  ## 2020-11-01  > Extend the endpoint for getting user accounts to include the accounts > `display_name` and `icon_url`. > > - [GET /account/user](#operation/account_user_get)  > Add support for account users authenticated by external Identity providers. > External authentication is limited to account users created with > `authentication_type=external`. > > - [POST /management/users](#operation/aid_accounts_aid_mgmnt_users_get) > > Following endpoints has been updated to allow Bearer authorization using > ID token issued by external Identity provider. > > - [GET /account/user](#operation/account_user_get) > - [POST /auth/token](#operation/aid_auths_oauth_token_post) > > Account has been updated with `jwks.uri` property that is required to > validate the ID tokens issued by external identity providers.  ## 2020-09-01  > Add new endpoint for handling HTTP redirect with ID token query parameter > - [POST /auth/redirect](#operation/aid_auths_oauth_redirect_post)  > Add new endpoint for uploading assets > - [POST /management/assets](#tag/account-assets)  ## 2020-07-01  > Add new endpoints for managing Swish connection > - [POST /management/settings/connections/swish](#operation/aid_account_settings_connections_swish_post) > - [GET /management/settings/connections/swish](#operation/aid_account_settings_connections_swish_get) > - [POST /management/settings/connections/swish/{callback_reference}](#operation/aid_account_settings_connections_swish_callback_post)  ## 2020-05-01  > Extend the AccountCompany with `email` and `technical_email` > - [PUT /accounts/{aid}/management/settings](#operation/aid_account_settings_put) > - [POST /accounts/{oid}/management/accounts](#operation/aid_mgmnt_accounts_post) > - [PUT /accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_put)  ## 2020-01-31  > Add support for `applicant.agreement.attachments` > - [POST /accounts/{oid}/signup](http://localhost:8080/#operation/accounts_oid_signup_post) >  > Add support for enabling MFA (OOB) for auth users. > - [POST /auth/users](#operation/aid_auth_users_post)  ## 2019-12-31  > Extend the AccountApplicant with support for > `promo_code` and utm campaign codes. > - [POST /signup](#operation/accounts_oid_signup_post)  ## 2019-11-31  > Add support for creating client with description > - [POST /auth/clients](#operation/aid_auth_clients_post)  ## 2019-09-31  > Extend settings with PayEx connections > - [GET /management/settings](#operation/aid_account_aid_get) > - [GET /management/accounts](#operation/aid_mgmnt_accounts_get)  ## 2019-07-31  > Add new endpoints for managing PayEx connection > - [POST /management/settings/connections/payex/{payment_product_type}](#operation/aid_account_settings_connections_payex_post) > - [GET /management/settings/connections/payex/{payment_product_type}](#operation/aid_account_settings_connections_payex_get) > - [POST /management/settings/connections/payex/{payment_product_type}/{callback_reference}](#operation/aid_account_settings_connections_payex_callback_post)  ## 2019-06-31  > The scope required for accessing endpoint has changed, > we will continue to support the old scopes but they was removed from > the documentation  > Support `search`, `limit` and `starting_after` query parameter > when listing partner accounts > - [GET /management/accounts](#operation/aid_mgmnt_accounts_get)  > Support for issuing exchange token for a sub-account, > to allow partner accounts to manage sub accounts. > - [POST /auth/impersonate_token](#operation/aid_auths_oauth_exchange_token_post)  ## 2019-05-31  > Support for including a Refresh Token when requesting > an Access Token. Use `grant-type=refresh_token` to get an Access Token > from a Refresh Token. > - [POST /auth/token](#operation/aid_auths_oauth_token_post)  > Support for revoking a Refresh Token > - [POST /auth/revoke](#operation/aid_auths_oauth_revoke_post)  ## 2018-12-17  > Rename typo in Account definition > All `bussiness_name` properties renamed to `business_name`  
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
using OpenAPIDateConverter = Dintero.OpenApiClient.Auth.Client.OpenAPIDateConverter;

namespace Dintero.OpenApiClient.Auth.Model
{
    /// <summary>
    /// BamboraConnectionSignupRevenue
    /// </summary>
    [DataContract(Name = "BamboraConnectionSignup_revenue")]
    public partial class BamboraConnectionSignupRevenue : IEquatable<BamboraConnectionSignupRevenue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BamboraConnectionSignupRevenue" /> class.
        /// </summary>
        /// <param name="currency">The three-character ISO-4217 currency for the expected amounts. https://en.wikipedia.org/wiki/ISO_4217 .</param>
        /// <param name="yearlyRevenue">yearlyRevenue.</param>
        /// <param name="highestTransactionAmount">estimated highest amount in a single transaction .</param>
        /// <param name="averageAmount">average amount of transactions .</param>
        /// <param name="acceptPrepaid">The company accepts advanced payments.</param>
        /// <param name="subscriptionsOrMemberships">The company sells subscriptions or memberships.</param>
        /// <param name="giftCards">The company sells gift cards.</param>
        public BamboraConnectionSignupRevenue(string currency = default(string), string yearlyRevenue = default(string), string highestTransactionAmount = default(string), string averageAmount = default(string), bool acceptPrepaid = default(bool), bool subscriptionsOrMemberships = default(bool), bool giftCards = default(bool))
        {
            this.Currency = currency;
            this.YearlyRevenue = yearlyRevenue;
            this.HighestTransactionAmount = highestTransactionAmount;
            this.AverageAmount = averageAmount;
            this.AcceptPrepaid = acceptPrepaid;
            this.SubscriptionsOrMemberships = subscriptionsOrMemberships;
            this.GiftCards = giftCards;
        }

        /// <summary>
        /// The three-character ISO-4217 currency for the expected amounts. https://en.wikipedia.org/wiki/ISO_4217 
        /// </summary>
        /// <value>The three-character ISO-4217 currency for the expected amounts. https://en.wikipedia.org/wiki/ISO_4217 </value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets YearlyRevenue
        /// </summary>
        [DataMember(Name = "yearly_revenue", EmitDefaultValue = false)]
        public string YearlyRevenue { get; set; }

        /// <summary>
        /// estimated highest amount in a single transaction 
        /// </summary>
        /// <value>estimated highest amount in a single transaction </value>
        [DataMember(Name = "highest_transaction_amount", EmitDefaultValue = false)]
        public string HighestTransactionAmount { get; set; }

        /// <summary>
        /// average amount of transactions 
        /// </summary>
        /// <value>average amount of transactions </value>
        [DataMember(Name = "average_amount", EmitDefaultValue = false)]
        public string AverageAmount { get; set; }

        /// <summary>
        /// The company accepts advanced payments
        /// </summary>
        /// <value>The company accepts advanced payments</value>
        [DataMember(Name = "accept_prepaid", EmitDefaultValue = true)]
        public bool AcceptPrepaid { get; set; }

        /// <summary>
        /// The company sells subscriptions or memberships
        /// </summary>
        /// <value>The company sells subscriptions or memberships</value>
        [DataMember(Name = "subscriptions_or_memberships", EmitDefaultValue = true)]
        public bool SubscriptionsOrMemberships { get; set; }

        /// <summary>
        /// The company sells gift cards
        /// </summary>
        /// <value>The company sells gift cards</value>
        [DataMember(Name = "gift_cards", EmitDefaultValue = true)]
        public bool GiftCards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BamboraConnectionSignupRevenue {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  YearlyRevenue: ").Append(YearlyRevenue).Append("\n");
            sb.Append("  HighestTransactionAmount: ").Append(HighestTransactionAmount).Append("\n");
            sb.Append("  AverageAmount: ").Append(AverageAmount).Append("\n");
            sb.Append("  AcceptPrepaid: ").Append(AcceptPrepaid).Append("\n");
            sb.Append("  SubscriptionsOrMemberships: ").Append(SubscriptionsOrMemberships).Append("\n");
            sb.Append("  GiftCards: ").Append(GiftCards).Append("\n");
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
            return this.Equals(input as BamboraConnectionSignupRevenue);
        }

        /// <summary>
        /// Returns true if BamboraConnectionSignupRevenue instances are equal
        /// </summary>
        /// <param name="input">Instance of BamboraConnectionSignupRevenue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BamboraConnectionSignupRevenue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.YearlyRevenue == input.YearlyRevenue ||
                    (this.YearlyRevenue != null &&
                    this.YearlyRevenue.Equals(input.YearlyRevenue))
                ) && 
                (
                    this.HighestTransactionAmount == input.HighestTransactionAmount ||
                    (this.HighestTransactionAmount != null &&
                    this.HighestTransactionAmount.Equals(input.HighestTransactionAmount))
                ) && 
                (
                    this.AverageAmount == input.AverageAmount ||
                    (this.AverageAmount != null &&
                    this.AverageAmount.Equals(input.AverageAmount))
                ) && 
                (
                    this.AcceptPrepaid == input.AcceptPrepaid ||
                    this.AcceptPrepaid.Equals(input.AcceptPrepaid)
                ) && 
                (
                    this.SubscriptionsOrMemberships == input.SubscriptionsOrMemberships ||
                    this.SubscriptionsOrMemberships.Equals(input.SubscriptionsOrMemberships)
                ) && 
                (
                    this.GiftCards == input.GiftCards ||
                    this.GiftCards.Equals(input.GiftCards)
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.YearlyRevenue != null)
                    hashCode = hashCode * 59 + this.YearlyRevenue.GetHashCode();
                if (this.HighestTransactionAmount != null)
                    hashCode = hashCode * 59 + this.HighestTransactionAmount.GetHashCode();
                if (this.AverageAmount != null)
                    hashCode = hashCode * 59 + this.AverageAmount.GetHashCode();
                hashCode = hashCode * 59 + this.AcceptPrepaid.GetHashCode();
                hashCode = hashCode * 59 + this.SubscriptionsOrMemberships.GetHashCode();
                hashCode = hashCode * 59 + this.GiftCards.GetHashCode();
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
