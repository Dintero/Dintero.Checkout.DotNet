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
    /// The details of an account company 
    /// </summary>
    [DataContract(Name = "AccountCompany")]
    public partial class AccountCompany : IEquatable<AccountCompany>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCompany" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountCompany() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCompany" /> class.
        /// </summary>
        /// <param name="businessName">businessName (required).</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="organizationNumber">Companys identification number.</param>
        /// <param name="industry">industry.</param>
        /// <param name="website">website.</param>
        /// <param name="termsUrl">termsUrl.</param>
        /// <param name="bankName">The name of the bank where the company&#39;s bank account is.</param>
        /// <param name="accountNumber">The company&#39;s bank account number.</param>
        /// <param name="address">address (required).</param>
        /// <param name="email">email.</param>
        /// <param name="technicalEmail">Technical email. Dintero will use this email when contacting the company about technical issues. .</param>
        /// <param name="phoneNumber">mobile number of a person / company, ITU/E.123 format with international prefix (+PPNNNNNNNNN...) .</param>
        /// <param name="branding">branding.</param>
        public AccountCompany(string businessName = default(string), string displayName = default(string), string organizationNumber = default(string), string industry = default(string), string website = default(string), string termsUrl = default(string), string bankName = default(string), string accountNumber = default(string), Address address = default(Address), string email = default(string), string technicalEmail = default(string), string phoneNumber = default(string), AccountCompanyBranding branding = default(AccountCompanyBranding))
        {
            // to ensure "businessName" is required (not null)
            this.BusinessName = businessName ?? throw new ArgumentNullException("businessName is a required property for AccountCompany and cannot be null");
            // to ensure "address" is required (not null)
            this.Address = address ?? throw new ArgumentNullException("address is a required property for AccountCompany and cannot be null");
            this.DisplayName = displayName;
            this.OrganizationNumber = organizationNumber;
            this.Industry = industry;
            this.Website = website;
            this.TermsUrl = termsUrl;
            this.BankName = bankName;
            this.AccountNumber = accountNumber;
            this.Email = email;
            this.TechnicalEmail = technicalEmail;
            this.PhoneNumber = phoneNumber;
            this.Branding = branding;
        }

        /// <summary>
        /// Gets or Sets BusinessName
        /// </summary>
        [DataMember(Name = "business_name", IsRequired = true, EmitDefaultValue = false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Companys identification number
        /// </summary>
        /// <value>Companys identification number</value>
        [DataMember(Name = "organization_number", EmitDefaultValue = false)]
        public string OrganizationNumber { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name = "industry", EmitDefaultValue = false)]
        public string Industry { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets TermsUrl
        /// </summary>
        [DataMember(Name = "terms_url", EmitDefaultValue = false)]
        public string TermsUrl { get; set; }

        /// <summary>
        /// The name of the bank where the company&#39;s bank account is
        /// </summary>
        /// <value>The name of the bank where the company&#39;s bank account is</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// The company&#39;s bank account number
        /// </summary>
        /// <value>The company&#39;s bank account number</value>
        [DataMember(Name = "account_number", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Technical email. Dintero will use this email when contacting the company about technical issues. 
        /// </summary>
        /// <value>Technical email. Dintero will use this email when contacting the company about technical issues. </value>
        [DataMember(Name = "technical_email", EmitDefaultValue = false)]
        public string TechnicalEmail { get; set; }

        /// <summary>
        /// mobile number of a person / company, ITU/E.123 format with international prefix (+PPNNNNNNNNN...) 
        /// </summary>
        /// <value>mobile number of a person / company, ITU/E.123 format with international prefix (+PPNNNNNNNNN...) </value>
        [DataMember(Name = "phone_number", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Branding
        /// </summary>
        [DataMember(Name = "branding", EmitDefaultValue = false)]
        public AccountCompanyBranding Branding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountCompany {\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  OrganizationNumber: ").Append(OrganizationNumber).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  TermsUrl: ").Append(TermsUrl).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  TechnicalEmail: ").Append(TechnicalEmail).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Branding: ").Append(Branding).Append("\n");
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
            return this.Equals(input as AccountCompany);
        }

        /// <summary>
        /// Returns true if AccountCompany instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCompany input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusinessName == input.BusinessName ||
                    (this.BusinessName != null &&
                    this.BusinessName.Equals(input.BusinessName))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.OrganizationNumber == input.OrganizationNumber ||
                    (this.OrganizationNumber != null &&
                    this.OrganizationNumber.Equals(input.OrganizationNumber))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.TermsUrl == input.TermsUrl ||
                    (this.TermsUrl != null &&
                    this.TermsUrl.Equals(input.TermsUrl))
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.TechnicalEmail == input.TechnicalEmail ||
                    (this.TechnicalEmail != null &&
                    this.TechnicalEmail.Equals(input.TechnicalEmail))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Branding == input.Branding ||
                    (this.Branding != null &&
                    this.Branding.Equals(input.Branding))
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
                if (this.BusinessName != null)
                    hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.OrganizationNumber != null)
                    hashCode = hashCode * 59 + this.OrganizationNumber.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.TermsUrl != null)
                    hashCode = hashCode * 59 + this.TermsUrl.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.TechnicalEmail != null)
                    hashCode = hashCode * 59 + this.TechnicalEmail.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Branding != null)
                    hashCode = hashCode * 59 + this.Branding.GetHashCode();
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
            // Website (string) maxLength
            if(this.Website != null && this.Website.Length > 120)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Website, length must be less than 120.", new [] { "Website" });
            }

            // TermsUrl (string) maxLength
            if(this.TermsUrl != null && this.TermsUrl.Length > 240)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TermsUrl, length must be less than 240.", new [] { "TermsUrl" });
            }

            // PhoneNumber (string) pattern
            Regex regexPhoneNumber = new Regex(@"^\\+?\\d{5,15}$", RegexOptions.CultureInvariant);
            if (false == regexPhoneNumber.Match(this.PhoneNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, must match a pattern of " + regexPhoneNumber, new [] { "PhoneNumber" });
            }

            yield break;
        }
    }

}
