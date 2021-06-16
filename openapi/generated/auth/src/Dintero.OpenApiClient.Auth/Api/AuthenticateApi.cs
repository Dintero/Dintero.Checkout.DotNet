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
    public interface IAuthenticateApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Passwordless
        /// </summary>
        /// <remarks>
        /// Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  - The client_id/audience must have a grant with type   &#x60;authorization_code&#x60; to allow sending verification-code - This endpoint is designed to be called from the client-side   and is subjected to rate limits  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless - write:accounts:/auth/passwordless-sms - write:accounts:/auth/passwordless-email 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns></returns>
        void AidAuthAccountPasswordlessPost(string oid, PasswordLess data);

        /// <summary>
        /// Passwordless
        /// </summary>
        /// <remarks>
        /// Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  - The client_id/audience must have a grant with type   &#x60;authorization_code&#x60; to allow sending verification-code - This endpoint is designed to be called from the client-side   and is subjected to rate limits  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless - write:accounts:/auth/passwordless-sms - write:accounts:/auth/passwordless-email 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AidAuthAccountPasswordlessPostWithHttpInfo(string oid, PasswordLess data);
        /// <summary>
        /// Passwordless Code
        /// </summary>
        /// <remarks>
        /// Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  Use this endpoint to generate a one-time verification-code that can be sent to the user.  The client_id/audience must have a grant with type &#x60;authorization_code&#x60; to allow creating a verification-code  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless/code 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 AidAuthPasswordlessPost(string oid, UNKNOWN_BASE_TYPE data);

        /// <summary>
        /// Passwordless Code
        /// </summary>
        /// <remarks>
        /// Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  Use this endpoint to generate a one-time verification-code that can be sent to the user.  The client_id/audience must have a grant with type &#x60;authorization_code&#x60; to allow creating a verification-code  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless/code 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> AidAuthPasswordlessPostWithHttpInfo(string oid, UNKNOWN_BASE_TYPE data);
        /// <summary>
        /// Authorize Passwordless link
        /// </summary>
        /// <remarks>
        /// This endpoint is used to authorize Passwordless link sent to user by email/sms.  A valid request will redirect to This is the OAuth 2.0 grant that Client-side web apps utilize in order to access an API. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="audience">The unique identifier of the target API you want to access. </param>
        /// <param name="responseType">This will specify the type of token you will receive at the end of the flow. Use token to get only an access_token  If &#x60;response_type&#x3D;token&#x60;, after the user authenticates with the provider, this will redirect them to your application callback URL while passing the access_token in the address location.hash. This is used for Single Page Apps and on Native Mobile SDKs. </param>
        /// <param name="clientId">Your application&#39;s Client ID. </param>
        /// <param name="verificationCode">one-time verification-code</param>
        /// <param name="scope">The scopes which you want to request authorization for. (optional)</param>
        /// <param name="state">An opaque value the clients adds to the initial request that Dintero includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks.  (optional)</param>
        /// <param name="redirectUri">The URL to which Dintero will redirect the browser after authorization has been granted by the user.  The &#x60;redirect_uri&#x60; value must be specified as a valid callback URL under your Client&#39;s Settings.  (optional)</param>
        /// <param name="connection">The name of the connection configured to your client. (optional)</param>
        /// <returns></returns>
        void AidAuthsOauthAuthorizePost(string oid, string audience, string responseType, string clientId, string verificationCode, string scope = default(string), string state = default(string), string redirectUri = default(string), string connection = default(string));

        /// <summary>
        /// Authorize Passwordless link
        /// </summary>
        /// <remarks>
        /// This endpoint is used to authorize Passwordless link sent to user by email/sms.  A valid request will redirect to This is the OAuth 2.0 grant that Client-side web apps utilize in order to access an API. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="audience">The unique identifier of the target API you want to access. </param>
        /// <param name="responseType">This will specify the type of token you will receive at the end of the flow. Use token to get only an access_token  If &#x60;response_type&#x3D;token&#x60;, after the user authenticates with the provider, this will redirect them to your application callback URL while passing the access_token in the address location.hash. This is used for Single Page Apps and on Native Mobile SDKs. </param>
        /// <param name="clientId">Your application&#39;s Client ID. </param>
        /// <param name="verificationCode">one-time verification-code</param>
        /// <param name="scope">The scopes which you want to request authorization for. (optional)</param>
        /// <param name="state">An opaque value the clients adds to the initial request that Dintero includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks.  (optional)</param>
        /// <param name="redirectUri">The URL to which Dintero will redirect the browser after authorization has been granted by the user.  The &#x60;redirect_uri&#x60; value must be specified as a valid callback URL under your Client&#39;s Settings.  (optional)</param>
        /// <param name="connection">The name of the connection configured to your client. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AidAuthsOauthAuthorizePostWithHttpInfo(string oid, string audience, string responseType, string clientId, string verificationCode, string scope = default(string), string state = default(string), string redirectUri = default(string), string connection = default(string));
        /// <summary>
        /// Exchange Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to exchange access_token to a sub-account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerId">An id that uniquely identifies the partner account </param>
        /// <param name="data"></param>
        /// <returns>AccessToken</returns>
        AccessToken AidAuthsOauthExchangeTokenPost(string partnerId, Exchange data);

        /// <summary>
        /// Exchange Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to exchange access_token to a sub-account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerId">An id that uniquely identifies the partner account </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AccessToken</returns>
        ApiResponse<AccessToken> AidAuthsOauthExchangeTokenPostWithHttpInfo(string partnerId, Exchange data);
        /// <summary>
        /// Redirect with ID token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to redirect to an URL with a ID token added. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 AidAuthsOauthRedirectPost(string oid, InlineObject11 data);

        /// <summary>
        /// Redirect with ID token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to redirect to an URL with a ID token added. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> AidAuthsOauthRedirectPostWithHttpInfo(string oid, InlineObject11 data);
        /// <summary>
        /// Revoke Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to invalidate a Refresh Token if it has been compromised.  scopes: - admin:accounts - write:accounts - create:accounts:auth:refresh_token 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object AidAuthsOauthRevokePost(string oid, RevokeToken data);

        /// <summary>
        /// Revoke Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to invalidate a Refresh Token if it has been compromised.  scopes: - admin:accounts - write:accounts - create:accounts:auth:refresh_token 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AidAuthsOauthRevokePostWithHttpInfo(string oid, RevokeToken data);
        /// <summary>
        /// Get Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>AccessToken</returns>
        AccessToken AidAuthsOauthTokenPost(string oid, AuthToken data);

        /// <summary>
        /// Get Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AccessToken</returns>
        ApiResponse<AccessToken> AidAuthsOauthTokenPostWithHttpInfo(string oid, AuthToken data);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticateApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Passwordless
        /// </summary>
        /// <remarks>
        /// Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  - The client_id/audience must have a grant with type   &#x60;authorization_code&#x60; to allow sending verification-code - This endpoint is designed to be called from the client-side   and is subjected to rate limits  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless - write:accounts:/auth/passwordless-sms - write:accounts:/auth/passwordless-email 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AidAuthAccountPasswordlessPostAsync(string oid, PasswordLess data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Passwordless
        /// </summary>
        /// <remarks>
        /// Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  - The client_id/audience must have a grant with type   &#x60;authorization_code&#x60; to allow sending verification-code - This endpoint is designed to be called from the client-side   and is subjected to rate limits  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless - write:accounts:/auth/passwordless-sms - write:accounts:/auth/passwordless-email 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AidAuthAccountPasswordlessPostWithHttpInfoAsync(string oid, PasswordLess data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Passwordless Code
        /// </summary>
        /// <remarks>
        /// Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  Use this endpoint to generate a one-time verification-code that can be sent to the user.  The client_id/audience must have a grant with type &#x60;authorization_code&#x60; to allow creating a verification-code  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless/code 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> AidAuthPasswordlessPostAsync(string oid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Passwordless Code
        /// </summary>
        /// <remarks>
        /// Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  Use this endpoint to generate a one-time verification-code that can be sent to the user.  The client_id/audience must have a grant with type &#x60;authorization_code&#x60; to allow creating a verification-code  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless/code 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> AidAuthPasswordlessPostWithHttpInfoAsync(string oid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Authorize Passwordless link
        /// </summary>
        /// <remarks>
        /// This endpoint is used to authorize Passwordless link sent to user by email/sms.  A valid request will redirect to This is the OAuth 2.0 grant that Client-side web apps utilize in order to access an API. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="audience">The unique identifier of the target API you want to access. </param>
        /// <param name="responseType">This will specify the type of token you will receive at the end of the flow. Use token to get only an access_token  If &#x60;response_type&#x3D;token&#x60;, after the user authenticates with the provider, this will redirect them to your application callback URL while passing the access_token in the address location.hash. This is used for Single Page Apps and on Native Mobile SDKs. </param>
        /// <param name="clientId">Your application&#39;s Client ID. </param>
        /// <param name="verificationCode">one-time verification-code</param>
        /// <param name="scope">The scopes which you want to request authorization for. (optional)</param>
        /// <param name="state">An opaque value the clients adds to the initial request that Dintero includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks.  (optional)</param>
        /// <param name="redirectUri">The URL to which Dintero will redirect the browser after authorization has been granted by the user.  The &#x60;redirect_uri&#x60; value must be specified as a valid callback URL under your Client&#39;s Settings.  (optional)</param>
        /// <param name="connection">The name of the connection configured to your client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AidAuthsOauthAuthorizePostAsync(string oid, string audience, string responseType, string clientId, string verificationCode, string scope = default(string), string state = default(string), string redirectUri = default(string), string connection = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Authorize Passwordless link
        /// </summary>
        /// <remarks>
        /// This endpoint is used to authorize Passwordless link sent to user by email/sms.  A valid request will redirect to This is the OAuth 2.0 grant that Client-side web apps utilize in order to access an API. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="audience">The unique identifier of the target API you want to access. </param>
        /// <param name="responseType">This will specify the type of token you will receive at the end of the flow. Use token to get only an access_token  If &#x60;response_type&#x3D;token&#x60;, after the user authenticates with the provider, this will redirect them to your application callback URL while passing the access_token in the address location.hash. This is used for Single Page Apps and on Native Mobile SDKs. </param>
        /// <param name="clientId">Your application&#39;s Client ID. </param>
        /// <param name="verificationCode">one-time verification-code</param>
        /// <param name="scope">The scopes which you want to request authorization for. (optional)</param>
        /// <param name="state">An opaque value the clients adds to the initial request that Dintero includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks.  (optional)</param>
        /// <param name="redirectUri">The URL to which Dintero will redirect the browser after authorization has been granted by the user.  The &#x60;redirect_uri&#x60; value must be specified as a valid callback URL under your Client&#39;s Settings.  (optional)</param>
        /// <param name="connection">The name of the connection configured to your client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AidAuthsOauthAuthorizePostWithHttpInfoAsync(string oid, string audience, string responseType, string clientId, string verificationCode, string scope = default(string), string state = default(string), string redirectUri = default(string), string connection = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Exchange Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to exchange access_token to a sub-account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerId">An id that uniquely identifies the partner account </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessToken</returns>
        System.Threading.Tasks.Task<AccessToken> AidAuthsOauthExchangeTokenPostAsync(string partnerId, Exchange data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Exchange Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to exchange access_token to a sub-account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerId">An id that uniquely identifies the partner account </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessToken>> AidAuthsOauthExchangeTokenPostWithHttpInfoAsync(string partnerId, Exchange data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Redirect with ID token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to redirect to an URL with a ID token added. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> AidAuthsOauthRedirectPostAsync(string oid, InlineObject11 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Redirect with ID token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to redirect to an URL with a ID token added. 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> AidAuthsOauthRedirectPostWithHttpInfoAsync(string oid, InlineObject11 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Revoke Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to invalidate a Refresh Token if it has been compromised.  scopes: - admin:accounts - write:accounts - create:accounts:auth:refresh_token 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AidAuthsOauthRevokePostAsync(string oid, RevokeToken data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Revoke Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to invalidate a Refresh Token if it has been compromised.  scopes: - admin:accounts - write:accounts - create:accounts:auth:refresh_token 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AidAuthsOauthRevokePostWithHttpInfoAsync(string oid, RevokeToken data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessToken</returns>
        System.Threading.Tasks.Task<AccessToken> AidAuthsOauthTokenPostAsync(string oid, AuthToken data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessToken>> AidAuthsOauthTokenPostWithHttpInfoAsync(string oid, AuthToken data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticateApi : IAuthenticateApiSync, IAuthenticateApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticateApi : IAuthenticateApi
    {
        private Dintero.OpenApiClient.Auth.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticateApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticateApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticateApi(Dintero.OpenApiClient.Auth.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthenticateApi(Dintero.OpenApiClient.Auth.Client.ISynchronousClient client, Dintero.OpenApiClient.Auth.Client.IAsynchronousClient asyncClient, Dintero.OpenApiClient.Auth.Client.IReadableConfiguration configuration)
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
        /// Passwordless Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  - The client_id/audience must have a grant with type   &#x60;authorization_code&#x60; to allow sending verification-code - This endpoint is designed to be called from the client-side   and is subjected to rate limits  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless - write:accounts:/auth/passwordless-sms - write:accounts:/auth/passwordless-email 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns></returns>
        public void AidAuthAccountPasswordlessPost(string oid, PasswordLess data)
        {
            AidAuthAccountPasswordlessPostWithHttpInfo(oid, data);
        }

        /// <summary>
        /// Passwordless Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  - The client_id/audience must have a grant with type   &#x60;authorization_code&#x60; to allow sending verification-code - This endpoint is designed to be called from the client-side   and is subjected to rate limits  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless - write:accounts:/auth/passwordless-sms - write:accounts:/auth/passwordless-email 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<Object> AidAuthAccountPasswordlessPostWithHttpInfo(string oid, PasswordLess data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthAccountPasswordlessPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthAccountPasswordlessPost");

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

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/accounts/{oid}/auth/passwordless", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthAccountPasswordlessPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Passwordless Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  - The client_id/audience must have a grant with type   &#x60;authorization_code&#x60; to allow sending verification-code - This endpoint is designed to be called from the client-side   and is subjected to rate limits  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless - write:accounts:/auth/passwordless-sms - write:accounts:/auth/passwordless-email 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AidAuthAccountPasswordlessPostAsync(string oid, PasswordLess data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await AidAuthAccountPasswordlessPostWithHttpInfoAsync(oid, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Passwordless Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  - The client_id/audience must have a grant with type   &#x60;authorization_code&#x60; to allow sending verification-code - This endpoint is designed to be called from the client-side   and is subjected to rate limits  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless - write:accounts:/auth/passwordless-sms - write:accounts:/auth/passwordless-email 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<Object>> AidAuthAccountPasswordlessPostWithHttpInfoAsync(string oid, PasswordLess data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthAccountPasswordlessPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthAccountPasswordlessPost");


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

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/accounts/{oid}/auth/passwordless", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthAccountPasswordlessPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Passwordless Code Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  Use this endpoint to generate a one-time verification-code that can be sent to the user.  The client_id/audience must have a grant with type &#x60;authorization_code&#x60; to allow creating a verification-code  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless/code 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 AidAuthPasswordlessPost(string oid, UNKNOWN_BASE_TYPE data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2005> localVarResponse = AidAuthPasswordlessPostWithHttpInfo(oid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Passwordless Code Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  Use this endpoint to generate a one-time verification-code that can be sent to the user.  The client_id/audience must have a grant with type &#x60;authorization_code&#x60; to allow creating a verification-code  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless/code 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2005> AidAuthPasswordlessPostWithHttpInfo(string oid, UNKNOWN_BASE_TYPE data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthPasswordlessPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthPasswordlessPost");

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

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<InlineResponse2005>("/accounts/{oid}/auth/passwordless/code", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthPasswordlessPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Passwordless Code Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  Use this endpoint to generate a one-time verification-code that can be sent to the user.  The client_id/audience must have a grant with type &#x60;authorization_code&#x60; to allow creating a verification-code  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless/code 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> AidAuthPasswordlessPostAsync(string oid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2005> localVarResponse = await AidAuthPasswordlessPostWithHttpInfoAsync(oid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Passwordless Code Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  Use this endpoint to generate a one-time verification-code that can be sent to the user.  The client_id/audience must have a grant with type &#x60;authorization_code&#x60; to allow creating a verification-code  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless/code 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2005>> AidAuthPasswordlessPostWithHttpInfoAsync(string oid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthPasswordlessPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthPasswordlessPost");


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

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<InlineResponse2005>("/accounts/{oid}/auth/passwordless/code", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthPasswordlessPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Authorize Passwordless link This endpoint is used to authorize Passwordless link sent to user by email/sms.  A valid request will redirect to This is the OAuth 2.0 grant that Client-side web apps utilize in order to access an API. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="audience">The unique identifier of the target API you want to access. </param>
        /// <param name="responseType">This will specify the type of token you will receive at the end of the flow. Use token to get only an access_token  If &#x60;response_type&#x3D;token&#x60;, after the user authenticates with the provider, this will redirect them to your application callback URL while passing the access_token in the address location.hash. This is used for Single Page Apps and on Native Mobile SDKs. </param>
        /// <param name="clientId">Your application&#39;s Client ID. </param>
        /// <param name="verificationCode">one-time verification-code</param>
        /// <param name="scope">The scopes which you want to request authorization for. (optional)</param>
        /// <param name="state">An opaque value the clients adds to the initial request that Dintero includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks.  (optional)</param>
        /// <param name="redirectUri">The URL to which Dintero will redirect the browser after authorization has been granted by the user.  The &#x60;redirect_uri&#x60; value must be specified as a valid callback URL under your Client&#39;s Settings.  (optional)</param>
        /// <param name="connection">The name of the connection configured to your client. (optional)</param>
        /// <returns></returns>
        public void AidAuthsOauthAuthorizePost(string oid, string audience, string responseType, string clientId, string verificationCode, string scope = default(string), string state = default(string), string redirectUri = default(string), string connection = default(string))
        {
            AidAuthsOauthAuthorizePostWithHttpInfo(oid, audience, responseType, clientId, verificationCode, scope, state, redirectUri, connection);
        }

        /// <summary>
        /// Authorize Passwordless link This endpoint is used to authorize Passwordless link sent to user by email/sms.  A valid request will redirect to This is the OAuth 2.0 grant that Client-side web apps utilize in order to access an API. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="audience">The unique identifier of the target API you want to access. </param>
        /// <param name="responseType">This will specify the type of token you will receive at the end of the flow. Use token to get only an access_token  If &#x60;response_type&#x3D;token&#x60;, after the user authenticates with the provider, this will redirect them to your application callback URL while passing the access_token in the address location.hash. This is used for Single Page Apps and on Native Mobile SDKs. </param>
        /// <param name="clientId">Your application&#39;s Client ID. </param>
        /// <param name="verificationCode">one-time verification-code</param>
        /// <param name="scope">The scopes which you want to request authorization for. (optional)</param>
        /// <param name="state">An opaque value the clients adds to the initial request that Dintero includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks.  (optional)</param>
        /// <param name="redirectUri">The URL to which Dintero will redirect the browser after authorization has been granted by the user.  The &#x60;redirect_uri&#x60; value must be specified as a valid callback URL under your Client&#39;s Settings.  (optional)</param>
        /// <param name="connection">The name of the connection configured to your client. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<Object> AidAuthsOauthAuthorizePostWithHttpInfo(string oid, string audience, string responseType, string clientId, string verificationCode, string scope = default(string), string state = default(string), string redirectUri = default(string), string connection = default(string))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthsOauthAuthorizePost");

            // verify the required parameter 'audience' is set
            if (audience == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'audience' when calling AuthenticateApi->AidAuthsOauthAuthorizePost");

            // verify the required parameter 'responseType' is set
            if (responseType == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'responseType' when calling AuthenticateApi->AidAuthsOauthAuthorizePost");

            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'clientId' when calling AuthenticateApi->AidAuthsOauthAuthorizePost");

            // verify the required parameter 'verificationCode' is set
            if (verificationCode == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'verificationCode' when calling AuthenticateApi->AidAuthsOauthAuthorizePost");

            Dintero.OpenApiClient.Auth.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Auth.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "audience", audience));
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }
            localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "response_type", responseType));
            localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "client_id", clientId));
            if (state != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "state", state));
            }
            if (redirectUri != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "redirect_uri", redirectUri));
            }
            localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "verification_code", verificationCode));
            if (connection != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "connection", connection));
            }

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/accounts/{oid}/auth/authorize", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsOauthAuthorizePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Authorize Passwordless link This endpoint is used to authorize Passwordless link sent to user by email/sms.  A valid request will redirect to This is the OAuth 2.0 grant that Client-side web apps utilize in order to access an API. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="audience">The unique identifier of the target API you want to access. </param>
        /// <param name="responseType">This will specify the type of token you will receive at the end of the flow. Use token to get only an access_token  If &#x60;response_type&#x3D;token&#x60;, after the user authenticates with the provider, this will redirect them to your application callback URL while passing the access_token in the address location.hash. This is used for Single Page Apps and on Native Mobile SDKs. </param>
        /// <param name="clientId">Your application&#39;s Client ID. </param>
        /// <param name="verificationCode">one-time verification-code</param>
        /// <param name="scope">The scopes which you want to request authorization for. (optional)</param>
        /// <param name="state">An opaque value the clients adds to the initial request that Dintero includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks.  (optional)</param>
        /// <param name="redirectUri">The URL to which Dintero will redirect the browser after authorization has been granted by the user.  The &#x60;redirect_uri&#x60; value must be specified as a valid callback URL under your Client&#39;s Settings.  (optional)</param>
        /// <param name="connection">The name of the connection configured to your client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AidAuthsOauthAuthorizePostAsync(string oid, string audience, string responseType, string clientId, string verificationCode, string scope = default(string), string state = default(string), string redirectUri = default(string), string connection = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await AidAuthsOauthAuthorizePostWithHttpInfoAsync(oid, audience, responseType, clientId, verificationCode, scope, state, redirectUri, connection, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Authorize Passwordless link This endpoint is used to authorize Passwordless link sent to user by email/sms.  A valid request will redirect to This is the OAuth 2.0 grant that Client-side web apps utilize in order to access an API. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="audience">The unique identifier of the target API you want to access. </param>
        /// <param name="responseType">This will specify the type of token you will receive at the end of the flow. Use token to get only an access_token  If &#x60;response_type&#x3D;token&#x60;, after the user authenticates with the provider, this will redirect them to your application callback URL while passing the access_token in the address location.hash. This is used for Single Page Apps and on Native Mobile SDKs. </param>
        /// <param name="clientId">Your application&#39;s Client ID. </param>
        /// <param name="verificationCode">one-time verification-code</param>
        /// <param name="scope">The scopes which you want to request authorization for. (optional)</param>
        /// <param name="state">An opaque value the clients adds to the initial request that Dintero includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks.  (optional)</param>
        /// <param name="redirectUri">The URL to which Dintero will redirect the browser after authorization has been granted by the user.  The &#x60;redirect_uri&#x60; value must be specified as a valid callback URL under your Client&#39;s Settings.  (optional)</param>
        /// <param name="connection">The name of the connection configured to your client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<Object>> AidAuthsOauthAuthorizePostWithHttpInfoAsync(string oid, string audience, string responseType, string clientId, string verificationCode, string scope = default(string), string state = default(string), string redirectUri = default(string), string connection = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthsOauthAuthorizePost");

            // verify the required parameter 'audience' is set
            if (audience == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'audience' when calling AuthenticateApi->AidAuthsOauthAuthorizePost");

            // verify the required parameter 'responseType' is set
            if (responseType == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'responseType' when calling AuthenticateApi->AidAuthsOauthAuthorizePost");

            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'clientId' when calling AuthenticateApi->AidAuthsOauthAuthorizePost");

            // verify the required parameter 'verificationCode' is set
            if (verificationCode == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'verificationCode' when calling AuthenticateApi->AidAuthsOauthAuthorizePost");


            Dintero.OpenApiClient.Auth.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Auth.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Auth.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "audience", audience));
            if (scope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            }
            localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "response_type", responseType));
            localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "client_id", clientId));
            if (state != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "state", state));
            }
            if (redirectUri != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "redirect_uri", redirectUri));
            }
            localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "verification_code", verificationCode));
            if (connection != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "connection", connection));
            }

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/accounts/{oid}/auth/authorize", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsOauthAuthorizePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Exchange Token Use this endpoint to exchange access_token to a sub-account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerId">An id that uniquely identifies the partner account </param>
        /// <param name="data"></param>
        /// <returns>AccessToken</returns>
        public AccessToken AidAuthsOauthExchangeTokenPost(string partnerId, Exchange data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccessToken> localVarResponse = AidAuthsOauthExchangeTokenPostWithHttpInfo(partnerId, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Exchange Token Use this endpoint to exchange access_token to a sub-account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerId">An id that uniquely identifies the partner account </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AccessToken</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AccessToken> AidAuthsOauthExchangeTokenPostWithHttpInfo(string partnerId, Exchange data)
        {
            // verify the required parameter 'partnerId' is set
            if (partnerId == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'partnerId' when calling AuthenticateApi->AidAuthsOauthExchangeTokenPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthsOauthExchangeTokenPost");

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

            localVarRequestOptions.PathParameters.Add("partner_id", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(partnerId)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AccessToken>("/accounts/{partner_id}/auth/exchange_token", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsOauthExchangeTokenPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Exchange Token Use this endpoint to exchange access_token to a sub-account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerId">An id that uniquely identifies the partner account </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessToken</returns>
        public async System.Threading.Tasks.Task<AccessToken> AidAuthsOauthExchangeTokenPostAsync(string partnerId, Exchange data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccessToken> localVarResponse = await AidAuthsOauthExchangeTokenPostWithHttpInfoAsync(partnerId, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Exchange Token Use this endpoint to exchange access_token to a sub-account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerId">An id that uniquely identifies the partner account </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessToken)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AccessToken>> AidAuthsOauthExchangeTokenPostWithHttpInfoAsync(string partnerId, Exchange data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'partnerId' is set
            if (partnerId == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'partnerId' when calling AuthenticateApi->AidAuthsOauthExchangeTokenPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthsOauthExchangeTokenPost");


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

            localVarRequestOptions.PathParameters.Add("partner_id", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(partnerId)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AccessToken>("/accounts/{partner_id}/auth/exchange_token", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsOauthExchangeTokenPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Redirect with ID token Use this endpoint to redirect to an URL with a ID token added. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 AidAuthsOauthRedirectPost(string oid, InlineObject11 data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2006> localVarResponse = AidAuthsOauthRedirectPostWithHttpInfo(oid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Redirect with ID token Use this endpoint to redirect to an URL with a ID token added. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2006> AidAuthsOauthRedirectPostWithHttpInfo(string oid, InlineObject11 data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthsOauthRedirectPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthsOauthRedirectPost");

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

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<InlineResponse2006>("/accounts/{oid}/auth/redirect", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsOauthRedirectPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Redirect with ID token Use this endpoint to redirect to an URL with a ID token added. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> AidAuthsOauthRedirectPostAsync(string oid, InlineObject11 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2006> localVarResponse = await AidAuthsOauthRedirectPostWithHttpInfoAsync(oid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Redirect with ID token Use this endpoint to redirect to an URL with a ID token added. 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<InlineResponse2006>> AidAuthsOauthRedirectPostWithHttpInfoAsync(string oid, InlineObject11 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthsOauthRedirectPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthsOauthRedirectPost");


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

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<InlineResponse2006>("/accounts/{oid}/auth/redirect", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsOauthRedirectPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Revoke Token Use this endpoint to invalidate a Refresh Token if it has been compromised.  scopes: - admin:accounts - write:accounts - create:accounts:auth:refresh_token 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public Object AidAuthsOauthRevokePost(string oid, RevokeToken data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<Object> localVarResponse = AidAuthsOauthRevokePostWithHttpInfo(oid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Revoke Token Use this endpoint to invalidate a Refresh Token if it has been compromised.  scopes: - admin:accounts - write:accounts - create:accounts:auth:refresh_token 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of Object</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<Object> AidAuthsOauthRevokePostWithHttpInfo(string oid, RevokeToken data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthsOauthRevokePost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthsOauthRevokePost");

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

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/accounts/{oid}/auth/revoke", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsOauthRevokePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Revoke Token Use this endpoint to invalidate a Refresh Token if it has been compromised.  scopes: - admin:accounts - write:accounts - create:accounts:auth:refresh_token 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AidAuthsOauthRevokePostAsync(string oid, RevokeToken data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<Object> localVarResponse = await AidAuthsOauthRevokePostWithHttpInfoAsync(oid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Revoke Token Use this endpoint to invalidate a Refresh Token if it has been compromised.  scopes: - admin:accounts - write:accounts - create:accounts:auth:refresh_token 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<Object>> AidAuthsOauthRevokePostWithHttpInfoAsync(string oid, RevokeToken data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthsOauthRevokePost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthsOauthRevokePost");


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

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/accounts/{oid}/auth/revoke", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsOauthRevokePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Token Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>AccessToken</returns>
        public AccessToken AidAuthsOauthTokenPost(string oid, AuthToken data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccessToken> localVarResponse = AidAuthsOauthTokenPostWithHttpInfo(oid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Token Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AccessToken</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AccessToken> AidAuthsOauthTokenPostWithHttpInfo(string oid, AuthToken data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthsOauthTokenPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthsOauthTokenPost");

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

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (clientAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Dintero.OpenApiClient.Auth.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AccessToken>("/accounts/{oid}/auth/token", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsOauthTokenPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Token Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessToken</returns>
        public async System.Threading.Tasks.Task<AccessToken> AidAuthsOauthTokenPostAsync(string oid, AuthToken data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccessToken> localVarResponse = await AidAuthsOauthTokenPostWithHttpInfoAsync(oid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Token Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessToken)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AccessToken>> AidAuthsOauthTokenPostWithHttpInfoAsync(string oid, AuthToken data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthsOauthTokenPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthsOauthTokenPost");


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

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(oid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (clientAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Dintero.OpenApiClient.Auth.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AccessToken>("/accounts/{oid}/auth/token", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsOauthTokenPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
