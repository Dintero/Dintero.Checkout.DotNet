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
    /// Account
    /// </summary>
    [DataContract(Name = "Account")]
    public partial class Account : IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Account() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="jwks">jwks.</param>
        /// <param name="applicant">The individual completing the account registration (required).</param>
        /// <param name="company">company (required).</param>
        /// <param name="billing">billing (required).</param>
        /// <param name="subscription">subscription.</param>
        /// <param name="livemode">Flag indicating whether the account exists in live mode and test mode.  (default to false).</param>
        /// <param name="languageCode">The preferred language for the account as defined by &lt;a href&#x3D;\&quot;https://tools.ietf.org/html/bcp47\&quot;&gt;BCP 47&lt;/a&gt; (IETF BCP 47, \&quot;Tags for Identifying Languages\&quot;). .</param>
        /// <param name="connections">connections.</param>
        /// <param name="services">services.</param>
        public Account(AccountJwksJwks jwks = default(AccountJwksJwks), AccountApplicant applicant = default(AccountApplicant), AccountCompany company = default(AccountCompany), AccountBilling billing = default(AccountBilling), Subscription subscription = default(Subscription), bool livemode = false, string languageCode = default(string), AccountAllOfConnections connections = default(AccountAllOfConnections), AccountAllOfServices services = default(AccountAllOfServices))
        {
            // to ensure "applicant" is required (not null)
            this.Applicant = applicant ?? throw new ArgumentNullException("applicant is a required property for Account and cannot be null");
            // to ensure "company" is required (not null)
            this.Company = company ?? throw new ArgumentNullException("company is a required property for Account and cannot be null");
            // to ensure "billing" is required (not null)
            this.Billing = billing ?? throw new ArgumentNullException("billing is a required property for Account and cannot be null");
            this.Jwks = jwks;
            this.Subscription = subscription;
            this.Livemode = livemode;
            this.LanguageCode = languageCode;
            this.Connections = connections;
            this.Services = services;
        }

        /// <summary>
        /// An UUID that uniquely identifies the resource 
        /// </summary>
        /// <value>An UUID that uniquely identifies the resource </value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }

        /// <summary>
        /// The date-time when the resource was created 
        /// </summary>
        /// <value>The date-time when the resource was created </value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }

        /// <summary>
        /// The ID of the user/client created the resource 
        /// </summary>
        /// <value>The ID of the user/client created the resource </value>
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }

        /// <summary>
        /// The date-time when the resource was last updated 
        /// </summary>
        /// <value>The date-time when the resource was last updated </value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }

        /// <summary>
        /// The ID of the user/client created the resource 
        /// </summary>
        /// <value>The ID of the user/client created the resource </value>
        [DataMember(Name = "deleted_by", EmitDefaultValue = false)]
        public string DeletedBy { get; private set; }

        /// <summary>
        /// Returns false as DeletedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeletedBy()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name = "deleted_at", EmitDefaultValue = false)]
        public DateTime DeletedAt { get; private set; }

        /// <summary>
        /// Returns false as DeletedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeletedAt()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Jwks
        /// </summary>
        [DataMember(Name = "jwks", EmitDefaultValue = false)]
        public AccountJwksJwks Jwks { get; set; }

        /// <summary>
        /// The individual completing the account registration
        /// </summary>
        /// <value>The individual completing the account registration</value>
        [DataMember(Name = "applicant", IsRequired = true, EmitDefaultValue = false)]
        public AccountApplicant Applicant { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", IsRequired = true, EmitDefaultValue = false)]
        public AccountCompany Company { get; set; }

        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name = "billing", IsRequired = true, EmitDefaultValue = false)]
        public AccountBilling Billing { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public Subscription Subscription { get; set; }

        /// <summary>
        /// The id that uniquely identifies the account.
        /// </summary>
        /// <value>The id that uniquely identifies the account.</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; private set; }

        /// <summary>
        /// Returns false as AccountId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountId()
        {
            return false;
        }

        /// <summary>
        /// The id of the partner associated with the account
        /// </summary>
        /// <value>The id of the partner associated with the account</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; private set; }

        /// <summary>
        /// Returns false as PartnerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePartnerId()
        {
            return false;
        }

        /// <summary>
        /// Flag indicating whether the account exists in live mode and test mode. 
        /// </summary>
        /// <value>Flag indicating whether the account exists in live mode and test mode. </value>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// The account is active
        /// </summary>
        /// <value>The account is active</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; private set; }

        /// <summary>
        /// Returns false as Active should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActive()
        {
            return false;
        }

        /// <summary>
        /// The preferred language for the account as defined by &lt;a href&#x3D;\&quot;https://tools.ietf.org/html/bcp47\&quot;&gt;BCP 47&lt;/a&gt; (IETF BCP 47, \&quot;Tags for Identifying Languages\&quot;). 
        /// </summary>
        /// <value>The preferred language for the account as defined by &lt;a href&#x3D;\&quot;https://tools.ietf.org/html/bcp47\&quot;&gt;BCP 47&lt;/a&gt; (IETF BCP 47, \&quot;Tags for Identifying Languages\&quot;). </value>
        [DataMember(Name = "language_code", EmitDefaultValue = false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or Sets Connections
        /// </summary>
        [DataMember(Name = "connections", EmitDefaultValue = false)]
        public AccountAllOfConnections Connections { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name = "services", EmitDefaultValue = false)]
        public AccountAllOfServices Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DeletedBy: ").Append(DeletedBy).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  Jwks: ").Append(Jwks).Append("\n");
            sb.Append("  Applicant: ").Append(Applicant).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.DeletedBy == input.DeletedBy ||
                    (this.DeletedBy != null &&
                    this.DeletedBy.Equals(input.DeletedBy))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
                ) && 
                (
                    this.Jwks == input.Jwks ||
                    (this.Jwks != null &&
                    this.Jwks.Equals(input.Jwks))
                ) && 
                (
                    this.Applicant == input.Applicant ||
                    (this.Applicant != null &&
                    this.Applicant.Equals(input.Applicant))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Billing == input.Billing ||
                    (this.Billing != null &&
                    this.Billing.Equals(input.Billing))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.Livemode == input.Livemode ||
                    this.Livemode.Equals(input.Livemode)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
                ) && 
                (
                    this.Connections == input.Connections ||
                    (this.Connections != null &&
                    this.Connections.Equals(input.Connections))
                ) && 
                (
                    this.Services == input.Services ||
                    (this.Services != null &&
                    this.Services.Equals(input.Services))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.DeletedBy != null)
                    hashCode = hashCode * 59 + this.DeletedBy.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.Jwks != null)
                    hashCode = hashCode * 59 + this.Jwks.GetHashCode();
                if (this.Applicant != null)
                    hashCode = hashCode * 59 + this.Applicant.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Billing != null)
                    hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.PartnerId != null)
                    hashCode = hashCode * 59 + this.PartnerId.GetHashCode();
                hashCode = hashCode * 59 + this.Livemode.GetHashCode();
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.LanguageCode != null)
                    hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
                if (this.Connections != null)
                    hashCode = hashCode * 59 + this.Connections.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
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
