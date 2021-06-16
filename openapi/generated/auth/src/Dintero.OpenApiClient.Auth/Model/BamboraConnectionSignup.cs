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
    /// BamboraConnectionSignup
    /// </summary>
    [DataContract(Name = "BamboraConnectionSignup")]
    public partial class BamboraConnectionSignup : IEquatable<BamboraConnectionSignup>, IValidatableObject
    {
        /// <summary>
        /// Defines StoreType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StoreTypeEnum
        {
            /// <summary>
            /// Enum Online for value: online
            /// </summary>
            [EnumMember(Value = "online")]
            Online = 1,

            /// <summary>
            /// Enum Instore for value: instore
            /// </summary>
            [EnumMember(Value = "instore")]
            Instore = 2,

            /// <summary>
            /// Enum Remote for value: remote
            /// </summary>
            [EnumMember(Value = "remote")]
            Remote = 3

        }



        /// <summary>
        /// Gets or Sets StoreType
        /// </summary>
        [DataMember(Name = "store_type", EmitDefaultValue = false)]
        public List<StoreTypeEnum> StoreType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BamboraConnectionSignup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BamboraConnectionSignup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BamboraConnectionSignup" /> class.
        /// </summary>
        /// <param name="paymentOptions">paymentOptions (required).</param>
        /// <param name="storeType">storeType.</param>
        /// <param name="revenue">revenue (required).</param>
        /// <param name="bankName">The name of the bank where the company&#39;s bank account is (required).</param>
        /// <param name="accountNumber">The company&#39;s bank account number (required).</param>
        /// <param name="ownership">ownership.</param>
        /// <param name="verifications">verifications.</param>
        /// <param name="signature">signature.</param>
        /// <param name="applicant">applicant.</param>
        public BamboraConnectionSignup(List<BamboraConnectionSignupPaymentOptions> paymentOptions = default(List<BamboraConnectionSignupPaymentOptions>), List<StoreTypeEnum> storeType = default(List<StoreTypeEnum>), BamboraConnectionSignupRevenue revenue = default(BamboraConnectionSignupRevenue), string bankName = default(string), string accountNumber = default(string), BamboraConnectionSignupOwnership ownership = default(BamboraConnectionSignupOwnership), BamboraConnectionSignupVerifications verifications = default(BamboraConnectionSignupVerifications), BamboraConnectionSignupSignature signature = default(BamboraConnectionSignupSignature), BamboraConnectionSignupApplicant applicant = default(BamboraConnectionSignupApplicant))
        {
            // to ensure "paymentOptions" is required (not null)
            this.PaymentOptions = paymentOptions ?? throw new ArgumentNullException("paymentOptions is a required property for BamboraConnectionSignup and cannot be null");
            // to ensure "revenue" is required (not null)
            this.Revenue = revenue ?? throw new ArgumentNullException("revenue is a required property for BamboraConnectionSignup and cannot be null");
            // to ensure "bankName" is required (not null)
            this.BankName = bankName ?? throw new ArgumentNullException("bankName is a required property for BamboraConnectionSignup and cannot be null");
            // to ensure "accountNumber" is required (not null)
            this.AccountNumber = accountNumber ?? throw new ArgumentNullException("accountNumber is a required property for BamboraConnectionSignup and cannot be null");
            this.StoreType = storeType;
            this.Ownership = ownership;
            this.Verifications = verifications;
            this.Signature = signature;
            this.Applicant = applicant;
        }

        /// <summary>
        /// Gets or Sets PaymentOptions
        /// </summary>
        [DataMember(Name = "payment_options", IsRequired = true, EmitDefaultValue = false)]
        public List<BamboraConnectionSignupPaymentOptions> PaymentOptions { get; set; }

        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name = "revenue", IsRequired = true, EmitDefaultValue = false)]
        public BamboraConnectionSignupRevenue Revenue { get; set; }

        /// <summary>
        /// The name of the bank where the company&#39;s bank account is
        /// </summary>
        /// <value>The name of the bank where the company&#39;s bank account is</value>
        [DataMember(Name = "bank_name", IsRequired = true, EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// The company&#39;s bank account number
        /// </summary>
        /// <value>The company&#39;s bank account number</value>
        [DataMember(Name = "account_number", IsRequired = true, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets Ownership
        /// </summary>
        [DataMember(Name = "ownership", EmitDefaultValue = false)]
        public BamboraConnectionSignupOwnership Ownership { get; set; }

        /// <summary>
        /// Gets or Sets Verifications
        /// </summary>
        [DataMember(Name = "verifications", EmitDefaultValue = false)]
        public BamboraConnectionSignupVerifications Verifications { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public BamboraConnectionSignupSignature Signature { get; set; }

        /// <summary>
        /// Gets or Sets Applicant
        /// </summary>
        [DataMember(Name = "applicant", EmitDefaultValue = false)]
        public BamboraConnectionSignupApplicant Applicant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BamboraConnectionSignup {\n");
            sb.Append("  PaymentOptions: ").Append(PaymentOptions).Append("\n");
            sb.Append("  StoreType: ").Append(StoreType).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Ownership: ").Append(Ownership).Append("\n");
            sb.Append("  Verifications: ").Append(Verifications).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Applicant: ").Append(Applicant).Append("\n");
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
            return this.Equals(input as BamboraConnectionSignup);
        }

        /// <summary>
        /// Returns true if BamboraConnectionSignup instances are equal
        /// </summary>
        /// <param name="input">Instance of BamboraConnectionSignup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BamboraConnectionSignup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentOptions == input.PaymentOptions ||
                    this.PaymentOptions != null &&
                    input.PaymentOptions != null &&
                    this.PaymentOptions.SequenceEqual(input.PaymentOptions)
                ) && 
                (
                    this.StoreType == input.StoreType ||
                    this.StoreType.SequenceEqual(input.StoreType)
                ) && 
                (
                    this.Revenue == input.Revenue ||
                    (this.Revenue != null &&
                    this.Revenue.Equals(input.Revenue))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Ownership == input.Ownership ||
                    (this.Ownership != null &&
                    this.Ownership.Equals(input.Ownership))
                ) && 
                (
                    this.Verifications == input.Verifications ||
                    (this.Verifications != null &&
                    this.Verifications.Equals(input.Verifications))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.Applicant == input.Applicant ||
                    (this.Applicant != null &&
                    this.Applicant.Equals(input.Applicant))
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
                if (this.PaymentOptions != null)
                    hashCode = hashCode * 59 + this.PaymentOptions.GetHashCode();
                hashCode = hashCode * 59 + this.StoreType.GetHashCode();
                if (this.Revenue != null)
                    hashCode = hashCode * 59 + this.Revenue.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.Ownership != null)
                    hashCode = hashCode * 59 + this.Ownership.GetHashCode();
                if (this.Verifications != null)
                    hashCode = hashCode * 59 + this.Verifications.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.Applicant != null)
                    hashCode = hashCode * 59 + this.Applicant.GetHashCode();
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
