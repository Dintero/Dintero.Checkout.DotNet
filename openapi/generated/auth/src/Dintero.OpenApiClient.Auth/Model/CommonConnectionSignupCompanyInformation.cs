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
    /// Information on what your company does 
    /// </summary>
    [DataContract(Name = "CommonConnectionSignup_company_information")]
    public partial class CommonConnectionSignupCompanyInformation : IEquatable<CommonConnectionSignupCompanyInformation>, IValidatableObject
    {
        /// <summary>
        /// Defines Industry
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IndustryEnum
        {
            /// <summary>
            /// Enum Goods for value: goods
            /// </summary>
            [EnumMember(Value = "goods")]
            Goods = 1,

            /// <summary>
            /// Enum Services for value: services
            /// </summary>
            [EnumMember(Value = "services")]
            Services = 2,

            /// <summary>
            /// Enum SubscriptionsOrMemberships for value: subscriptions_or_memberships
            /// </summary>
            [EnumMember(Value = "subscriptions_or_memberships")]
            SubscriptionsOrMemberships = 3,

            /// <summary>
            /// Enum Charity for value: charity
            /// </summary>
            [EnumMember(Value = "charity")]
            Charity = 4,

            /// <summary>
            /// Enum TravelAndEntertainment for value: travel_and_entertainment
            /// </summary>
            [EnumMember(Value = "travel_and_entertainment")]
            TravelAndEntertainment = 5,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 6

        }


        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name = "industry", EmitDefaultValue = false)]
        public IndustryEnum? Industry { get; set; }
        /// <summary>
        /// Company MCC code 
        /// </summary>
        /// <value>Company MCC code </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompanyCategoryEnum
        {
            /// <summary>
            /// Enum _4722 for value: 4722
            /// </summary>
            [EnumMember(Value = "4722")]
            _4722 = 1,

            /// <summary>
            /// Enum _5021 for value: 5021
            /// </summary>
            [EnumMember(Value = "5021")]
            _5021 = 2,

            /// <summary>
            /// Enum _5045 for value: 5045
            /// </summary>
            [EnumMember(Value = "5045")]
            _5045 = 3,

            /// <summary>
            /// Enum _5122 for value: 5122
            /// </summary>
            [EnumMember(Value = "5122")]
            _5122 = 4,

            /// <summary>
            /// Enum _5211 for value: 5211
            /// </summary>
            [EnumMember(Value = "5211")]
            _5211 = 5,

            /// <summary>
            /// Enum _5399 for value: 5399
            /// </summary>
            [EnumMember(Value = "5399")]
            _5399 = 6,

            /// <summary>
            /// Enum _5499 for value: 5499
            /// </summary>
            [EnumMember(Value = "5499")]
            _5499 = 7,

            /// <summary>
            /// Enum _5691 for value: 5691
            /// </summary>
            [EnumMember(Value = "5691")]
            _5691 = 8,

            /// <summary>
            /// Enum _5699 for value: 5699
            /// </summary>
            [EnumMember(Value = "5699")]
            _5699 = 9,

            /// <summary>
            /// Enum _5712 for value: 5712
            /// </summary>
            [EnumMember(Value = "5712")]
            _5712 = 10,

            /// <summary>
            /// Enum _5719 for value: 5719
            /// </summary>
            [EnumMember(Value = "5719")]
            _5719 = 11,

            /// <summary>
            /// Enum _5732 for value: 5732
            /// </summary>
            [EnumMember(Value = "5732")]
            _5732 = 12,

            /// <summary>
            /// Enum _5816 for value: 5816
            /// </summary>
            [EnumMember(Value = "5816")]
            _5816 = 13,

            /// <summary>
            /// Enum _5817 for value: 5817
            /// </summary>
            [EnumMember(Value = "5817")]
            _5817 = 14,

            /// <summary>
            /// Enum _5932 for value: 5932
            /// </summary>
            [EnumMember(Value = "5932")]
            _5932 = 15,

            /// <summary>
            /// Enum _5941 for value: 5941
            /// </summary>
            [EnumMember(Value = "5941")]
            _5941 = 16,

            /// <summary>
            /// Enum _5944 for value: 5944
            /// </summary>
            [EnumMember(Value = "5944")]
            _5944 = 17,

            /// <summary>
            /// Enum _5945 for value: 5945
            /// </summary>
            [EnumMember(Value = "5945")]
            _5945 = 18,

            /// <summary>
            /// Enum _5971 for value: 5971
            /// </summary>
            [EnumMember(Value = "5971")]
            _5971 = 19,

            /// <summary>
            /// Enum _5977 for value: 5977
            /// </summary>
            [EnumMember(Value = "5977")]
            _5977 = 20,

            /// <summary>
            /// Enum _5993 for value: 5993
            /// </summary>
            [EnumMember(Value = "5993")]
            _5993 = 21,

            /// <summary>
            /// Enum _5999 for value: 5999
            /// </summary>
            [EnumMember(Value = "5999")]
            _5999 = 22,

            /// <summary>
            /// Enum _7011 for value: 7011
            /// </summary>
            [EnumMember(Value = "7011")]
            _7011 = 23,

            /// <summary>
            /// Enum _7033 for value: 7033
            /// </summary>
            [EnumMember(Value = "7033")]
            _7033 = 24,

            /// <summary>
            /// Enum _7298 for value: 7298
            /// </summary>
            [EnumMember(Value = "7298")]
            _7298 = 25,

            /// <summary>
            /// Enum _7392 for value: 7392
            /// </summary>
            [EnumMember(Value = "7392")]
            _7392 = 26,

            /// <summary>
            /// Enum _7399 for value: 7399
            /// </summary>
            [EnumMember(Value = "7399")]
            _7399 = 27,

            /// <summary>
            /// Enum _7512 for value: 7512
            /// </summary>
            [EnumMember(Value = "7512")]
            _7512 = 28,

            /// <summary>
            /// Enum _7922 for value: 7922
            /// </summary>
            [EnumMember(Value = "7922")]
            _7922 = 29,

            /// <summary>
            /// Enum _7929 for value: 7929
            /// </summary>
            [EnumMember(Value = "7929")]
            _7929 = 30,

            /// <summary>
            /// Enum _7991 for value: 7991
            /// </summary>
            [EnumMember(Value = "7991")]
            _7991 = 31,

            /// <summary>
            /// Enum _7997 for value: 7997
            /// </summary>
            [EnumMember(Value = "7997")]
            _7997 = 32,

            /// <summary>
            /// Enum _7999 for value: 7999
            /// </summary>
            [EnumMember(Value = "7999")]
            _7999 = 33,

            /// <summary>
            /// Enum _8299 for value: 8299
            /// </summary>
            [EnumMember(Value = "8299")]
            _8299 = 34,

            /// <summary>
            /// Enum _8398 for value: 8398
            /// </summary>
            [EnumMember(Value = "8398")]
            _8398 = 35,

            /// <summary>
            /// Enum _8641 for value: 8641
            /// </summary>
            [EnumMember(Value = "8641")]
            _8641 = 36,

            /// <summary>
            /// Enum _8699 for value: 8699
            /// </summary>
            [EnumMember(Value = "8699")]
            _8699 = 37,

            /// <summary>
            /// Enum _8999 for value: 8999
            /// </summary>
            [EnumMember(Value = "8999")]
            _8999 = 38

        }


        /// <summary>
        /// Company MCC code 
        /// </summary>
        /// <value>Company MCC code </value>
        [DataMember(Name = "company_category", EmitDefaultValue = false)]
        public CompanyCategoryEnum? CompanyCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonConnectionSignupCompanyInformation" /> class.
        /// </summary>
        /// <param name="industry">industry.</param>
        /// <param name="companyCategory">Company MCC code .</param>
        /// <param name="companyDescription">Description of the product or services that the company accepts payments from .</param>
        public CommonConnectionSignupCompanyInformation(IndustryEnum? industry = default(IndustryEnum?), CompanyCategoryEnum? companyCategory = default(CompanyCategoryEnum?), string companyDescription = default(string))
        {
            this.Industry = industry;
            this.CompanyCategory = companyCategory;
            this.CompanyDescription = companyDescription;
        }

        /// <summary>
        /// Description of the product or services that the company accepts payments from 
        /// </summary>
        /// <value>Description of the product or services that the company accepts payments from </value>
        [DataMember(Name = "company_description", EmitDefaultValue = false)]
        public string CompanyDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonConnectionSignupCompanyInformation {\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  CompanyCategory: ").Append(CompanyCategory).Append("\n");
            sb.Append("  CompanyDescription: ").Append(CompanyDescription).Append("\n");
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
            return this.Equals(input as CommonConnectionSignupCompanyInformation);
        }

        /// <summary>
        /// Returns true if CommonConnectionSignupCompanyInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonConnectionSignupCompanyInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonConnectionSignupCompanyInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Industry == input.Industry ||
                    this.Industry.Equals(input.Industry)
                ) && 
                (
                    this.CompanyCategory == input.CompanyCategory ||
                    this.CompanyCategory.Equals(input.CompanyCategory)
                ) && 
                (
                    this.CompanyDescription == input.CompanyDescription ||
                    (this.CompanyDescription != null &&
                    this.CompanyDescription.Equals(input.CompanyDescription))
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
                hashCode = hashCode * 59 + this.Industry.GetHashCode();
                hashCode = hashCode * 59 + this.CompanyCategory.GetHashCode();
                if (this.CompanyDescription != null)
                    hashCode = hashCode * 59 + this.CompanyDescription.GetHashCode();
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
