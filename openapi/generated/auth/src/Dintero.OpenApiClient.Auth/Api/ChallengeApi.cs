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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Dintero.OpenApiClient.Auth.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChallengeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Challenge request
        /// </summary>
        /// <remarks>
        /// Request a challenge for multi-factor authentication (MFA) based on the challenge types supported by the user.  The challenge_type is how the user will get the challenge and prove possession. Supported challenge types include:    - &#x60;oob&#x60;: for SMS messages or out-of-band (OOB)  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 AidAuthMfaChallengePost(string aid, AuthChallenge data);

        /// <summary>
        /// Challenge request
        /// </summary>
        /// <remarks>
        /// Request a challenge for multi-factor authentication (MFA) based on the challenge types supported by the user.  The challenge_type is how the user will get the challenge and prove possession. Supported challenge types include:    - &#x60;oob&#x60;: for SMS messages or out-of-band (OOB)  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> AidAuthMfaChallengePostWithHttpInfo(string aid, AuthChallenge data);
        /// <summary>
        /// Recovery
        /// </summary>
        /// <remarks>
        /// Request a recovery for user with multi-factor authentication (MFA) enabled.  A recovery is done with two out-of-band (OOB) challenges over different channels.  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;.  A &#x60;403 status&#x60; with &#x60;mfa_required&#x60; error will be returned on success, use the response to request a new challenge from the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 AidAuthMfaRecoveryPost(string aid, UNKNOWN_BASE_TYPE data);

        /// <summary>
        /// Recovery
        /// </summary>
        /// <remarks>
        /// Request a recovery for user with multi-factor authentication (MFA) enabled.  A recovery is done with two out-of-band (OOB) challenges over different channels.  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;.  A &#x60;403 status&#x60; with &#x60;mfa_required&#x60; error will be returned on success, use the response to request a new challenge from the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> AidAuthMfaRecoveryPostWithHttpInfo(string aid, UNKNOWN_BASE_TYPE data);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChallengeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Challenge request
        /// </summary>
        /// <remarks>
        /// Request a challenge for multi-factor authentication (MFA) based on the challenge types supported by the user.  The challenge_type is how the user will get the challenge and prove possession. Supported challenge types include:    - &#x60;oob&#x60;: for SMS messages or out-of-band (OOB)  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> AidAuthMfaChallengePostAsync(string aid, AuthChallenge data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Challenge request
        /// </summary>
        /// <remarks>
        /// Request a challenge for multi-factor authentication (MFA) based on the challenge types supported by the user.  The challenge_type is how the user will get the challenge and prove possession. Supported challenge types include:    - &#x60;oob&#x60;: for SMS messages or out-of-band (OOB)  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> AidAuthMfaChallengePostWithHttpInfoAsync(string aid, AuthChallenge data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Recovery
        /// </summary>
        /// <remarks>
        /// Request a recovery for user with multi-factor authentication (MFA) enabled.  A recovery is done with two out-of-band (OOB) challenges over different channels.  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;.  A &#x60;403 status&#x60; with &#x60;mfa_required&#x60; error will be returned on success, use the response to request a new challenge from the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> AidAuthMfaRecoveryPostAsync(string aid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Recovery
        /// </summary>
        /// <remarks>
        /// Request a recovery for user with multi-factor authentication (MFA) enabled.  A recovery is done with two out-of-band (OOB) challenges over different channels.  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;.  A &#x60;403 status&#x60; with &#x60;mfa_required&#x60; error will be returned on success, use the response to request a new challenge from the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> AidAuthMfaRecoveryPostWithHttpInfoAsync(string aid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChallengeApi : IChallengeApiSync, IChallengeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ChallengeApi : IChallengeApi
    {
        private Dintero.OpenApiClient.Auth.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChallengeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChallengeApi(String basePath)
        {
            this.Configuration = Dintero.OpenApiClient.Auth.Client.Configuration.MergeConfigurations(
                Dintero.OpenApiClient.Auth.Client.GlobalConfiguration.Instance,
                new Dintero.OpenApiClient.Auth.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Dintero.OpenApiClient.Auth.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Dintero.OpenApiClient.Auth.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Dintero.OpenApiClient.Auth.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ChallengeApi(Dintero.OpenApiClient.Auth.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Dintero.OpenApiClient.Auth.Client.Configuration.MergeConfigurations(
                Dintero.OpenApiClient.Auth.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Dintero.OpenApiClient.Auth.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Dintero.OpenApiClient.Auth.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Dintero.OpenApiClient.Auth.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ChallengeApi(Dintero.OpenApiClient.Auth.Client.ISynchronousClient client, Dintero.OpenApiClient.Auth.Client.IAsynchronousClient asyncClient, Dintero.OpenApiClient.Auth.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Dintero.OpenApiClient.Auth.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Dintero.OpenApiClient.Auth.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Dintero.OpenApiClient.Auth.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Dintero.OpenApiClient.Auth.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Dintero.OpenApiClient.Auth.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Challenge request Request a challenge for multi-factor authentication (MFA) based on the challenge types supported by the user.  The challenge_type is how the user will get the challenge and prove possession. Supported challenge types include:    - &#x60;oob&#x60;: for SMS messages or out-of-band (OOB)  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 AidAuthMfaChallengePost(string aid, AuthChallenge data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse200> localVarResponse = AidAuthMfaChallengePostWithHttpInfo(aid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Challenge request Request a challenge for multi-factor authentication (MFA) based on the challenge types supported by the user.  The challenge_type is how the user will get the challenge and prove possession. Supported challenge types include:    - &#x60;oob&#x60;: for SMS messages or out-of-band (OOB)  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse200> AidAuthMfaChallengePostWithHttpInfo(string aid, AuthChallenge data)
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ChallengeApi->AidAuthMfaChallengePost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ChallengeApi->AidAuthMfaChallengePost");

            Dintero.OpenApiClient.Auth.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Auth.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<InlineResponse200>("/accounts/{aid}/auth/mfa/challenge", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthMfaChallengePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Challenge request Request a challenge for multi-factor authentication (MFA) based on the challenge types supported by the user.  The challenge_type is how the user will get the challenge and prove possession. Supported challenge types include:    - &#x60;oob&#x60;: for SMS messages or out-of-band (OOB)  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> AidAuthMfaChallengePostAsync(string aid, AuthChallenge data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse200> localVarResponse = await AidAuthMfaChallengePostWithHttpInfoAsync(aid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Challenge request Request a challenge for multi-factor authentication (MFA) based on the challenge types supported by the user.  The challenge_type is how the user will get the challenge and prove possession. Supported challenge types include:    - &#x60;oob&#x60;: for SMS messages or out-of-band (OOB)  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse200>> AidAuthMfaChallengePostWithHttpInfoAsync(string aid, AuthChallenge data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ChallengeApi->AidAuthMfaChallengePost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ChallengeApi->AidAuthMfaChallengePost");


            Dintero.OpenApiClient.Auth.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Auth.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<InlineResponse200>("/accounts/{aid}/auth/mfa/challenge", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthMfaChallengePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Recovery Request a recovery for user with multi-factor authentication (MFA) enabled.  A recovery is done with two out-of-band (OOB) challenges over different channels.  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;.  A &#x60;403 status&#x60; with &#x60;mfa_required&#x60; error will be returned on success, use the response to request a new challenge from the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 AidAuthMfaRecoveryPost(string aid, UNKNOWN_BASE_TYPE data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2001> localVarResponse = AidAuthMfaRecoveryPostWithHttpInfo(aid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Recovery Request a recovery for user with multi-factor authentication (MFA) enabled.  A recovery is done with two out-of-band (OOB) challenges over different channels.  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;.  A &#x60;403 status&#x60; with &#x60;mfa_required&#x60; error will be returned on success, use the response to request a new challenge from the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2001> AidAuthMfaRecoveryPostWithHttpInfo(string aid, UNKNOWN_BASE_TYPE data)
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ChallengeApi->AidAuthMfaRecoveryPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ChallengeApi->AidAuthMfaRecoveryPost");

            Dintero.OpenApiClient.Auth.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Auth.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<InlineResponse2001>("/accounts/{aid}/auth/mfa/recovery", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthMfaRecoveryPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Recovery Request a recovery for user with multi-factor authentication (MFA) enabled.  A recovery is done with two out-of-band (OOB) challenges over different channels.  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;.  A &#x60;403 status&#x60; with &#x60;mfa_required&#x60; error will be returned on success, use the response to request a new challenge from the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> AidAuthMfaRecoveryPostAsync(string aid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2001> localVarResponse = await AidAuthMfaRecoveryPostWithHttpInfoAsync(aid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Recovery Request a recovery for user with multi-factor authentication (MFA) enabled.  A recovery is done with two out-of-band (OOB) challenges over different channels.  Use the response to request access token from the [auth/token](#operation/aid_auths_oauth_token_post) endpoint with &#x60;grant_type&#x3D;mfa_oob&#x60;.  A &#x60;403 status&#x60; with &#x60;mfa_required&#x60; error will be returned on success, use the response to request a new challenge from the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2001>> AidAuthMfaRecoveryPostWithHttpInfoAsync(string aid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ChallengeApi->AidAuthMfaRecoveryPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ChallengeApi->AidAuthMfaRecoveryPost");


            Dintero.OpenApiClient.Auth.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Auth.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<InlineResponse2001>("/accounts/{aid}/auth/mfa/recovery", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthMfaRecoveryPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
