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
    /// PasswordLess
    /// </summary>
    [DataContract(Name = "PasswordLess")]
    public partial class PasswordLess : IEquatable<PasswordLess>, IValidatableObject
    {
        /// <summary>
        /// How to send the code to the user. 
        /// </summary>
        /// <value>How to send the code to the user. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConnectionEnum
        {
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 1,

            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms = 2

        }


        /// <summary>
        /// How to send the code to the user. 
        /// </summary>
        /// <value>How to send the code to the user. </value>
        [DataMember(Name = "connection", IsRequired = true, EmitDefaultValue = false)]
        public ConnectionEnum Connection { get; set; }
        /// <summary>
        /// Passwordless for type company/customer requires that the email is registered to a customers users 
        /// </summary>
        /// <value>Passwordless for type company/customer requires that the email is registered to a customers users </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Company for value: company
            /// </summary>
            [EnumMember(Value = "company")]
            Company = 1,

            /// <summary>
            /// Enum Customer for value: customer
            /// </summary>
            [EnumMember(Value = "customer")]
            Customer = 2

        }


        /// <summary>
        /// Passwordless for type company/customer requires that the email is registered to a customers users 
        /// </summary>
        /// <value>Passwordless for type company/customer requires that the email is registered to a customers users </value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Use &#x60;code&#x60; to send a verification code. 
        /// </summary>
        /// <value>Use &#x60;code&#x60; to send a verification code. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SendEnum
        {
            /// <summary>
            /// Enum Code for value: code
            /// </summary>
            [EnumMember(Value = "code")]
            Code = 1

        }


        /// <summary>
        /// Use &#x60;code&#x60; to send a verification code. 
        /// </summary>
        /// <value>Use &#x60;code&#x60; to send a verification code. </value>
        [DataMember(Name = "send", EmitDefaultValue = false)]
        public SendEnum? Send { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordLess" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordLess() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordLess" /> class.
        /// </summary>
        /// <param name="audience">The unique identifier of the target API you want to access.  (required).</param>
        /// <param name="clientId">clientId (required).</param>
        /// <param name="connection">How to send the code to the user.  (required).</param>
        /// <param name="email">The user&#39;s email address .</param>
        /// <param name="type">Passwordless for type company/customer requires that the email is registered to a customers users  (default to TypeEnum.Customer).</param>
        /// <param name="send">Use &#x60;code&#x60; to send a verification code.  (default to SendEnum.Code).</param>
        /// <param name="loginSessionId">Use &#x60;login_session_id&#x60; to resend the same verifcation code to an alternative connection. .</param>
        public PasswordLess(string audience = default(string), string clientId = default(string), ConnectionEnum connection = default(ConnectionEnum), string email = default(string), TypeEnum? type = TypeEnum.Customer, SendEnum? send = SendEnum.Code, Guid loginSessionId = default(Guid))
        {
            // to ensure "audience" is required (not null)
            this.Audience = audience ?? throw new ArgumentNullException("audience is a required property for PasswordLess and cannot be null");
            // to ensure "clientId" is required (not null)
            this.ClientId = clientId ?? throw new ArgumentNullException("clientId is a required property for PasswordLess and cannot be null");
            this.Connection = connection;
            this.Email = email;
            this.Type = type;
            this.Send = send;
            this.LoginSessionId = loginSessionId;
        }

        /// <summary>
        /// The unique identifier of the target API you want to access. 
        /// </summary>
        /// <value>The unique identifier of the target API you want to access. </value>
        [DataMember(Name = "audience", IsRequired = true, EmitDefaultValue = false)]
        public string Audience { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The user&#39;s email address 
        /// </summary>
        /// <value>The user&#39;s email address </value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Use &#x60;login_session_id&#x60; to resend the same verifcation code to an alternative connection. 
        /// </summary>
        /// <value>Use &#x60;login_session_id&#x60; to resend the same verifcation code to an alternative connection. </value>
        [DataMember(Name = "login_session_id", EmitDefaultValue = false)]
        public Guid LoginSessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordLess {\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Connection: ").Append(Connection).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Send: ").Append(Send).Append("\n");
            sb.Append("  LoginSessionId: ").Append(LoginSessionId).Append("\n");
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
            return this.Equals(input as PasswordLess);
        }

        /// <summary>
        /// Returns true if PasswordLess instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordLess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordLess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Audience == input.Audience ||
                    (this.Audience != null &&
                    this.Audience.Equals(input.Audience))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Connection == input.Connection ||
                    this.Connection.Equals(input.Connection)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Send == input.Send ||
                    this.Send.Equals(input.Send)
                ) && 
                (
                    this.LoginSessionId == input.LoginSessionId ||
                    (this.LoginSessionId != null &&
                    this.LoginSessionId.Equals(input.LoginSessionId))
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
                if (this.Audience != null)
                    hashCode = hashCode * 59 + this.Audience.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                hashCode = hashCode * 59 + this.Connection.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Send.GetHashCode();
                if (this.LoginSessionId != null)
                    hashCode = hashCode * 59 + this.LoginSessionId.GetHashCode();
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
