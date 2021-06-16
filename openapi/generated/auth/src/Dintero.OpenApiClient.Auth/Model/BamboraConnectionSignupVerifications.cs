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
    /// Verify that the business complies with the following requirements from the payment connections. 
    /// </summary>
    [DataContract(Name = "BamboraConnectionSignup_verifications")]
    public partial class BamboraConnectionSignupVerifications : IEquatable<BamboraConnectionSignupVerifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BamboraConnectionSignupVerifications" /> class.
        /// </summary>
        /// <param name="termsAndConditions">The payment site displays terms and conditions, including return policy, delivery options and a privacy policy. .</param>
        /// <param name="termsAndConditionsUrl">Url to terms and conditions, including return policy, delivery options and a privacy policy. .</param>
        /// <param name="contactInformation">The company&#39;s contact information is easily available, including organization number, phone number and address .</param>
        /// <param name="paymentSite">Customers have access to a payment site. Applies to online stores..</param>
        /// <param name="clearPricing">All products and services have clearly marked prices..</param>
        /// <param name="paymentProductLogos">Visa and Mastercard logos are visible on the payment site..</param>
        public BamboraConnectionSignupVerifications(bool termsAndConditions = default(bool), string termsAndConditionsUrl = default(string), bool contactInformation = default(bool), bool paymentSite = default(bool), bool clearPricing = default(bool), bool paymentProductLogos = default(bool))
        {
            this.TermsAndConditions = termsAndConditions;
            this.TermsAndConditionsUrl = termsAndConditionsUrl;
            this.ContactInformation = contactInformation;
            this.PaymentSite = paymentSite;
            this.ClearPricing = clearPricing;
            this.PaymentProductLogos = paymentProductLogos;
        }

        /// <summary>
        /// The payment site displays terms and conditions, including return policy, delivery options and a privacy policy. 
        /// </summary>
        /// <value>The payment site displays terms and conditions, including return policy, delivery options and a privacy policy. </value>
        [DataMember(Name = "terms_and_conditions", EmitDefaultValue = true)]
        public bool TermsAndConditions { get; set; }

        /// <summary>
        /// Url to terms and conditions, including return policy, delivery options and a privacy policy. 
        /// </summary>
        /// <value>Url to terms and conditions, including return policy, delivery options and a privacy policy. </value>
        [DataMember(Name = "terms_and_conditions_url", EmitDefaultValue = false)]
        public string TermsAndConditionsUrl { get; set; }

        /// <summary>
        /// The company&#39;s contact information is easily available, including organization number, phone number and address 
        /// </summary>
        /// <value>The company&#39;s contact information is easily available, including organization number, phone number and address </value>
        [DataMember(Name = "contact_information", EmitDefaultValue = true)]
        public bool ContactInformation { get; set; }

        /// <summary>
        /// Customers have access to a payment site. Applies to online stores.
        /// </summary>
        /// <value>Customers have access to a payment site. Applies to online stores.</value>
        [DataMember(Name = "payment_site", EmitDefaultValue = true)]
        public bool PaymentSite { get; set; }

        /// <summary>
        /// All products and services have clearly marked prices.
        /// </summary>
        /// <value>All products and services have clearly marked prices.</value>
        [DataMember(Name = "clear_pricing", EmitDefaultValue = true)]
        public bool ClearPricing { get; set; }

        /// <summary>
        /// Visa and Mastercard logos are visible on the payment site.
        /// </summary>
        /// <value>Visa and Mastercard logos are visible on the payment site.</value>
        [DataMember(Name = "payment_product_logos", EmitDefaultValue = true)]
        public bool PaymentProductLogos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BamboraConnectionSignupVerifications {\n");
            sb.Append("  TermsAndConditions: ").Append(TermsAndConditions).Append("\n");
            sb.Append("  TermsAndConditionsUrl: ").Append(TermsAndConditionsUrl).Append("\n");
            sb.Append("  ContactInformation: ").Append(ContactInformation).Append("\n");
            sb.Append("  PaymentSite: ").Append(PaymentSite).Append("\n");
            sb.Append("  ClearPricing: ").Append(ClearPricing).Append("\n");
            sb.Append("  PaymentProductLogos: ").Append(PaymentProductLogos).Append("\n");
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
            return this.Equals(input as BamboraConnectionSignupVerifications);
        }

        /// <summary>
        /// Returns true if BamboraConnectionSignupVerifications instances are equal
        /// </summary>
        /// <param name="input">Instance of BamboraConnectionSignupVerifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BamboraConnectionSignupVerifications input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TermsAndConditions == input.TermsAndConditions ||
                    this.TermsAndConditions.Equals(input.TermsAndConditions)
                ) && 
                (
                    this.TermsAndConditionsUrl == input.TermsAndConditionsUrl ||
                    (this.TermsAndConditionsUrl != null &&
                    this.TermsAndConditionsUrl.Equals(input.TermsAndConditionsUrl))
                ) && 
                (
                    this.ContactInformation == input.ContactInformation ||
                    this.ContactInformation.Equals(input.ContactInformation)
                ) && 
                (
                    this.PaymentSite == input.PaymentSite ||
                    this.PaymentSite.Equals(input.PaymentSite)
                ) && 
                (
                    this.ClearPricing == input.ClearPricing ||
                    this.ClearPricing.Equals(input.ClearPricing)
                ) && 
                (
                    this.PaymentProductLogos == input.PaymentProductLogos ||
                    this.PaymentProductLogos.Equals(input.PaymentProductLogos)
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
                hashCode = hashCode * 59 + this.TermsAndConditions.GetHashCode();
                if (this.TermsAndConditionsUrl != null)
                    hashCode = hashCode * 59 + this.TermsAndConditionsUrl.GetHashCode();
                hashCode = hashCode * 59 + this.ContactInformation.GetHashCode();
                hashCode = hashCode * 59 + this.PaymentSite.GetHashCode();
                hashCode = hashCode * 59 + this.ClearPricing.GetHashCode();
                hashCode = hashCode * 59 + this.PaymentProductLogos.GetHashCode();
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
