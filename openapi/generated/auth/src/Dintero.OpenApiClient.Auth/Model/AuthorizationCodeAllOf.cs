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
    /// AuthorizationCodeAllOf
    /// </summary>
    [DataContract(Name = "authorization_code_allOf")]
    public partial class AuthorizationCodeAllOf : IEquatable<AuthorizationCodeAllOf>, IValidatableObject
    {
        /// <summary>
        /// Defines IdentType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IdentTypeEnum
        {
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 1,

            /// <summary>
            /// Enum UserId for value: user_id
            /// </summary>
            [EnumMember(Value = "user_id")]
            UserId = 2

        }


        /// <summary>
        /// Gets or Sets IdentType
        /// </summary>
        [DataMember(Name = "ident_type", IsRequired = true, EmitDefaultValue = false)]
        public IdentTypeEnum IdentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationCodeAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthorizationCodeAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationCodeAllOf" /> class.
        /// </summary>
        /// <param name="identType">identType (required).</param>
        /// <param name="ident">The email that was use when requesting &#x60;verification_code&#x60; from [POST /v1/accounts/{oid}/auth/passwordless](#operation/aid_auth_account_passwordless_post)  (required).</param>
        /// <param name="verificationCode">The one-time Passwordless verification-code to exchange for a access token (required).</param>
        /// <param name="audience">The unique identifier of the target API you want to access. The audience must be a grant associated with the client  (required).</param>
        public AuthorizationCodeAllOf(IdentTypeEnum identType = default(IdentTypeEnum), string ident = default(string), string verificationCode = default(string), string audience = default(string))
        {
            this.IdentType = identType;
            // to ensure "ident" is required (not null)
            this.Ident = ident ?? throw new ArgumentNullException("ident is a required property for AuthorizationCodeAllOf and cannot be null");
            // to ensure "verificationCode" is required (not null)
            this.VerificationCode = verificationCode ?? throw new ArgumentNullException("verificationCode is a required property for AuthorizationCodeAllOf and cannot be null");
            // to ensure "audience" is required (not null)
            this.Audience = audience ?? throw new ArgumentNullException("audience is a required property for AuthorizationCodeAllOf and cannot be null");
        }

        /// <summary>
        /// The email that was use when requesting &#x60;verification_code&#x60; from [POST /v1/accounts/{oid}/auth/passwordless](#operation/aid_auth_account_passwordless_post) 
        /// </summary>
        /// <value>The email that was use when requesting &#x60;verification_code&#x60; from [POST /v1/accounts/{oid}/auth/passwordless](#operation/aid_auth_account_passwordless_post) </value>
        [DataMember(Name = "ident", IsRequired = true, EmitDefaultValue = false)]
        public string Ident { get; set; }

        /// <summary>
        /// The one-time Passwordless verification-code to exchange for a access token
        /// </summary>
        /// <value>The one-time Passwordless verification-code to exchange for a access token</value>
        [DataMember(Name = "verification_code", IsRequired = true, EmitDefaultValue = false)]
        public string VerificationCode { get; set; }

        /// <summary>
        /// The unique identifier of the target API you want to access. The audience must be a grant associated with the client 
        /// </summary>
        /// <value>The unique identifier of the target API you want to access. The audience must be a grant associated with the client </value>
        [DataMember(Name = "audience", IsRequired = true, EmitDefaultValue = false)]
        public string Audience { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizationCodeAllOf {\n");
            sb.Append("  IdentType: ").Append(IdentType).Append("\n");
            sb.Append("  Ident: ").Append(Ident).Append("\n");
            sb.Append("  VerificationCode: ").Append(VerificationCode).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
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
            return this.Equals(input as AuthorizationCodeAllOf);
        }

        /// <summary>
        /// Returns true if AuthorizationCodeAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizationCodeAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizationCodeAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentType == input.IdentType ||
                    this.IdentType.Equals(input.IdentType)
                ) && 
                (
                    this.Ident == input.Ident ||
                    (this.Ident != null &&
                    this.Ident.Equals(input.Ident))
                ) && 
                (
                    this.VerificationCode == input.VerificationCode ||
                    (this.VerificationCode != null &&
                    this.VerificationCode.Equals(input.VerificationCode))
                ) && 
                (
                    this.Audience == input.Audience ||
                    (this.Audience != null &&
                    this.Audience.Equals(input.Audience))
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
                hashCode = hashCode * 59 + this.IdentType.GetHashCode();
                if (this.Ident != null)
                    hashCode = hashCode * 59 + this.Ident.GetHashCode();
                if (this.VerificationCode != null)
                    hashCode = hashCode * 59 + this.VerificationCode.GetHashCode();
                if (this.Audience != null)
                    hashCode = hashCode * 59 + this.Audience.GetHashCode();
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
