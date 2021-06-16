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
    /// InstabankConnectionSignup
    /// </summary>
    [DataContract(Name = "InstabankConnectionSignup")]
    public partial class InstabankConnectionSignup : IEquatable<InstabankConnectionSignup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstabankConnectionSignup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstabankConnectionSignup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstabankConnectionSignup" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="phoneNumber">A phone number in E.164 number formatting.  (required).</param>
        /// <param name="totalNumberOfTransactions">Estimated number of transactions  (required).</param>
        /// <param name="totalVolumeOfTransactions">Estimated yearly transaction volume  (required).</param>
        /// <param name="financeNumberOfTransactions">Estimated number of finance transactions  (required).</param>
        /// <param name="financeVolumeOfTransactions">Estimated yearly volume of finance transactions  (required).</param>
        /// <param name="industry">industry (required).</param>
        /// <param name="accountNumber">The account number for where settlement payout is transfered to. Must be a checking account in a Norwegian bank.  (required).</param>
        /// <param name="paymentOptions">paymentOptions (required).</param>
        public InstabankConnectionSignup(string email = default(string), string phoneNumber = default(string), string totalNumberOfTransactions = default(string), string totalVolumeOfTransactions = default(string), string financeNumberOfTransactions = default(string), string financeVolumeOfTransactions = default(string), string industry = default(string), string accountNumber = default(string), List<InstabankConnectionConfigurationPaymentOptions> paymentOptions = default(List<InstabankConnectionConfigurationPaymentOptions>))
        {
            // to ensure "email" is required (not null)
            this.Email = email ?? throw new ArgumentNullException("email is a required property for InstabankConnectionSignup and cannot be null");
            // to ensure "phoneNumber" is required (not null)
            this.PhoneNumber = phoneNumber ?? throw new ArgumentNullException("phoneNumber is a required property for InstabankConnectionSignup and cannot be null");
            // to ensure "totalNumberOfTransactions" is required (not null)
            this.TotalNumberOfTransactions = totalNumberOfTransactions ?? throw new ArgumentNullException("totalNumberOfTransactions is a required property for InstabankConnectionSignup and cannot be null");
            // to ensure "totalVolumeOfTransactions" is required (not null)
            this.TotalVolumeOfTransactions = totalVolumeOfTransactions ?? throw new ArgumentNullException("totalVolumeOfTransactions is a required property for InstabankConnectionSignup and cannot be null");
            // to ensure "financeNumberOfTransactions" is required (not null)
            this.FinanceNumberOfTransactions = financeNumberOfTransactions ?? throw new ArgumentNullException("financeNumberOfTransactions is a required property for InstabankConnectionSignup and cannot be null");
            // to ensure "financeVolumeOfTransactions" is required (not null)
            this.FinanceVolumeOfTransactions = financeVolumeOfTransactions ?? throw new ArgumentNullException("financeVolumeOfTransactions is a required property for InstabankConnectionSignup and cannot be null");
            // to ensure "industry" is required (not null)
            this.Industry = industry ?? throw new ArgumentNullException("industry is a required property for InstabankConnectionSignup and cannot be null");
            // to ensure "accountNumber" is required (not null)
            this.AccountNumber = accountNumber ?? throw new ArgumentNullException("accountNumber is a required property for InstabankConnectionSignup and cannot be null");
            // to ensure "paymentOptions" is required (not null)
            this.PaymentOptions = paymentOptions ?? throw new ArgumentNullException("paymentOptions is a required property for InstabankConnectionSignup and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// A phone number in E.164 number formatting. 
        /// </summary>
        /// <value>A phone number in E.164 number formatting. </value>
        [DataMember(Name = "phone_number", IsRequired = true, EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Estimated number of transactions 
        /// </summary>
        /// <value>Estimated number of transactions </value>
        [DataMember(Name = "total_number_of_transactions", IsRequired = true, EmitDefaultValue = false)]
        public string TotalNumberOfTransactions { get; set; }

        /// <summary>
        /// Estimated yearly transaction volume 
        /// </summary>
        /// <value>Estimated yearly transaction volume </value>
        [DataMember(Name = "total_volume_of_transactions", IsRequired = true, EmitDefaultValue = false)]
        public string TotalVolumeOfTransactions { get; set; }

        /// <summary>
        /// Estimated number of finance transactions 
        /// </summary>
        /// <value>Estimated number of finance transactions </value>
        [DataMember(Name = "finance_number_of_transactions", IsRequired = true, EmitDefaultValue = false)]
        public string FinanceNumberOfTransactions { get; set; }

        /// <summary>
        /// Estimated yearly volume of finance transactions 
        /// </summary>
        /// <value>Estimated yearly volume of finance transactions </value>
        [DataMember(Name = "finance_volume_of_transactions", IsRequired = true, EmitDefaultValue = false)]
        public string FinanceVolumeOfTransactions { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name = "industry", IsRequired = true, EmitDefaultValue = false)]
        public string Industry { get; set; }

        /// <summary>
        /// The account number for where settlement payout is transfered to. Must be a checking account in a Norwegian bank. 
        /// </summary>
        /// <value>The account number for where settlement payout is transfered to. Must be a checking account in a Norwegian bank. </value>
        [DataMember(Name = "account_number", IsRequired = true, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets PaymentOptions
        /// </summary>
        [DataMember(Name = "payment_options", IsRequired = true, EmitDefaultValue = false)]
        public List<InstabankConnectionConfigurationPaymentOptions> PaymentOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstabankConnectionSignup {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  TotalNumberOfTransactions: ").Append(TotalNumberOfTransactions).Append("\n");
            sb.Append("  TotalVolumeOfTransactions: ").Append(TotalVolumeOfTransactions).Append("\n");
            sb.Append("  FinanceNumberOfTransactions: ").Append(FinanceNumberOfTransactions).Append("\n");
            sb.Append("  FinanceVolumeOfTransactions: ").Append(FinanceVolumeOfTransactions).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  PaymentOptions: ").Append(PaymentOptions).Append("\n");
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
            return this.Equals(input as InstabankConnectionSignup);
        }

        /// <summary>
        /// Returns true if InstabankConnectionSignup instances are equal
        /// </summary>
        /// <param name="input">Instance of InstabankConnectionSignup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstabankConnectionSignup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.TotalNumberOfTransactions == input.TotalNumberOfTransactions ||
                    (this.TotalNumberOfTransactions != null &&
                    this.TotalNumberOfTransactions.Equals(input.TotalNumberOfTransactions))
                ) && 
                (
                    this.TotalVolumeOfTransactions == input.TotalVolumeOfTransactions ||
                    (this.TotalVolumeOfTransactions != null &&
                    this.TotalVolumeOfTransactions.Equals(input.TotalVolumeOfTransactions))
                ) && 
                (
                    this.FinanceNumberOfTransactions == input.FinanceNumberOfTransactions ||
                    (this.FinanceNumberOfTransactions != null &&
                    this.FinanceNumberOfTransactions.Equals(input.FinanceNumberOfTransactions))
                ) && 
                (
                    this.FinanceVolumeOfTransactions == input.FinanceVolumeOfTransactions ||
                    (this.FinanceVolumeOfTransactions != null &&
                    this.FinanceVolumeOfTransactions.Equals(input.FinanceVolumeOfTransactions))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.PaymentOptions == input.PaymentOptions ||
                    this.PaymentOptions != null &&
                    input.PaymentOptions != null &&
                    this.PaymentOptions.SequenceEqual(input.PaymentOptions)
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.TotalNumberOfTransactions != null)
                    hashCode = hashCode * 59 + this.TotalNumberOfTransactions.GetHashCode();
                if (this.TotalVolumeOfTransactions != null)
                    hashCode = hashCode * 59 + this.TotalVolumeOfTransactions.GetHashCode();
                if (this.FinanceNumberOfTransactions != null)
                    hashCode = hashCode * 59 + this.FinanceNumberOfTransactions.GetHashCode();
                if (this.FinanceVolumeOfTransactions != null)
                    hashCode = hashCode * 59 + this.FinanceVolumeOfTransactions.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.PaymentOptions != null)
                    hashCode = hashCode * 59 + this.PaymentOptions.GetHashCode();
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
            // TotalNumberOfTransactions (string) minLength
            if(this.TotalNumberOfTransactions != null && this.TotalNumberOfTransactions.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalNumberOfTransactions, length must be greater than 1.", new [] { "TotalNumberOfTransactions" });
            }

            // TotalVolumeOfTransactions (string) minLength
            if(this.TotalVolumeOfTransactions != null && this.TotalVolumeOfTransactions.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalVolumeOfTransactions, length must be greater than 1.", new [] { "TotalVolumeOfTransactions" });
            }

            // FinanceNumberOfTransactions (string) minLength
            if(this.FinanceNumberOfTransactions != null && this.FinanceNumberOfTransactions.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FinanceNumberOfTransactions, length must be greater than 1.", new [] { "FinanceNumberOfTransactions" });
            }

            // FinanceVolumeOfTransactions (string) minLength
            if(this.FinanceVolumeOfTransactions != null && this.FinanceVolumeOfTransactions.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FinanceVolumeOfTransactions, length must be greater than 1.", new [] { "FinanceVolumeOfTransactions" });
            }

            // AccountNumber (string) maxLength
            if(this.AccountNumber != null && this.AccountNumber.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 11.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if(this.AccountNumber != null && this.AccountNumber.Length < 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 11.", new [] { "AccountNumber" });
            }

            yield break;
        }
    }

}
