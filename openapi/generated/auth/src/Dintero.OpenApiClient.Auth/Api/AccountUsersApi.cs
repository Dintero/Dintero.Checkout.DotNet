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
    public interface IAccountUsersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Authenticated User
        /// </summary>
        /// <remarks>
        /// Get public and private profile information when authenticated through Bearer auth  &gt; Use ID token as Bearer token if the user was authenticated &gt; externally. The ID token must include a &#x60;email&#x60; claim that &gt; identifies the account user.  scopes: - openid - aws.cognito.signin.user.admin 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AuthenticatedAccountUser</returns>
        AuthenticatedAccountUser AccountUserGet();

        /// <summary>
        /// Authenticated User
        /// </summary>
        /// <remarks>
        /// Get public and private profile information when authenticated through Bearer auth  &gt; Use ID token as Bearer token if the user was authenticated &gt; externally. The ID token must include a &#x60;email&#x60; claim that &gt; identifies the account user.  scopes: - openid - aws.cognito.signin.user.admin 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AuthenticatedAccountUser</returns>
        ApiResponse<AuthenticatedAccountUser> AccountUserGetWithHttpInfo();
        /// <summary>
        /// Configure SMS MFA
        /// </summary>
        /// <remarks>
        /// Update the user SMS MFA configuration 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns></returns>
        void AccountUserMfaSmsPut(InlineObject data);

        /// <summary>
        /// Configure SMS MFA
        /// </summary>
        /// <remarks>
        /// Update the user SMS MFA configuration 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AccountUserMfaSmsPutWithHttpInfo(InlineObject data);
        /// <summary>
        /// Change User password
        /// </summary>
        /// <remarks>
        /// Change the password for the account user  scopes: - openid 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void AccountUserPasswordPut(InlineObject1 body = default(InlineObject1));

        /// <summary>
        /// Change User password
        /// </summary>
        /// <remarks>
        /// Change the password for the account user  scopes: - openid 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AccountUserPasswordPutWithHttpInfo(InlineObject1 body = default(InlineObject1));
        /// <summary>
        /// Get user activity log
        /// </summary>
        /// <remarks>
        /// Get activities for User  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <returns>List&lt;AuditEvent&gt;</returns>
        List<AuditEvent> AidAccountsAidMgmntUsersActivitiesGet(string oid, string uid);

        /// <summary>
        /// Get user activity log
        /// </summary>
        /// <remarks>
        /// Get activities for User  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <returns>ApiResponse of List&lt;AuditEvent&gt;</returns>
        ApiResponse<List<AuditEvent>> AidAccountsAidMgmntUsersActivitiesGetWithHttpInfo(string oid, string uid);
        /// <summary>
        /// Delete User
        /// </summary>
        /// <remarks>
        /// Delete an user from an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>AccountUserResponse</returns>
        AccountUserResponse AidAccountsAidMgmntUsersDelete(string oid, string uid, List<string> expand = default(List<string>));

        /// <summary>
        /// Delete User
        /// </summary>
        /// <remarks>
        /// Delete an user from an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>ApiResponse of AccountUserResponse</returns>
        ApiResponse<AccountUserResponse> AidAccountsAidMgmntUsersDeleteWithHttpInfo(string oid, string uid, List<string> expand = default(List<string>));
        /// <summary>
        /// Users Collection
        /// </summary>
        /// <remarks>
        /// Get list of all users with access to the account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>List&lt;AccountUserResponse&gt;</returns>
        List<AccountUserResponse> AidAccountsAidMgmntUsersGet(string oid, List<string> expand = default(List<string>));

        /// <summary>
        /// Users Collection
        /// </summary>
        /// <remarks>
        /// Get list of all users with access to the account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>ApiResponse of List&lt;AccountUserResponse&gt;</returns>
        ApiResponse<List<AccountUserResponse>> AidAccountsAidMgmntUsersGetWithHttpInfo(string oid, List<string> expand = default(List<string>));
        /// <summary>
        /// Create User
        /// </summary>
        /// <remarks>
        /// Create and grant user access to the account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>AccountUserResponse</returns>
        AccountUserResponse AidAccountsAidMgmntUsersPost(string oid, InlineObject12 data, List<string> expand = default(List<string>));

        /// <summary>
        /// Create User
        /// </summary>
        /// <remarks>
        /// Create and grant user access to the account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>ApiResponse of AccountUserResponse</returns>
        ApiResponse<AccountUserResponse> AidAccountsAidMgmntUsersPostWithHttpInfo(string oid, InlineObject12 data, List<string> expand = default(List<string>));
        /// <summary>
        /// Update User
        /// </summary>
        /// <remarks>
        /// Update user  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>AccountUserResponse</returns>
        AccountUserResponse AidAccountsAidMgmntUsersPut(string oid, string uid, UNKNOWN_BASE_TYPE data, List<string> expand = default(List<string>));

        /// <summary>
        /// Update User
        /// </summary>
        /// <remarks>
        /// Update user  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>ApiResponse of AccountUserResponse</returns>
        ApiResponse<AccountUserResponse> AidAccountsAidMgmntUsersPutWithHttpInfo(string oid, string uid, UNKNOWN_BASE_TYPE data, List<string> expand = default(List<string>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountUsersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Authenticated User
        /// </summary>
        /// <remarks>
        /// Get public and private profile information when authenticated through Bearer auth  &gt; Use ID token as Bearer token if the user was authenticated &gt; externally. The ID token must include a &#x60;email&#x60; claim that &gt; identifies the account user.  scopes: - openid - aws.cognito.signin.user.admin 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthenticatedAccountUser</returns>
        System.Threading.Tasks.Task<AuthenticatedAccountUser> AccountUserGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Authenticated User
        /// </summary>
        /// <remarks>
        /// Get public and private profile information when authenticated through Bearer auth  &gt; Use ID token as Bearer token if the user was authenticated &gt; externally. The ID token must include a &#x60;email&#x60; claim that &gt; identifies the account user.  scopes: - openid - aws.cognito.signin.user.admin 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthenticatedAccountUser)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthenticatedAccountUser>> AccountUserGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Configure SMS MFA
        /// </summary>
        /// <remarks>
        /// Update the user SMS MFA configuration 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AccountUserMfaSmsPutAsync(InlineObject data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Configure SMS MFA
        /// </summary>
        /// <remarks>
        /// Update the user SMS MFA configuration 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AccountUserMfaSmsPutWithHttpInfoAsync(InlineObject data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Change User password
        /// </summary>
        /// <remarks>
        /// Change the password for the account user  scopes: - openid 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AccountUserPasswordPutAsync(InlineObject1 body = default(InlineObject1), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Change User password
        /// </summary>
        /// <remarks>
        /// Change the password for the account user  scopes: - openid 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AccountUserPasswordPutWithHttpInfoAsync(InlineObject1 body = default(InlineObject1), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get user activity log
        /// </summary>
        /// <remarks>
        /// Get activities for User  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AuditEvent&gt;</returns>
        System.Threading.Tasks.Task<List<AuditEvent>> AidAccountsAidMgmntUsersActivitiesGetAsync(string oid, string uid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get user activity log
        /// </summary>
        /// <remarks>
        /// Get activities for User  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AuditEvent&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AuditEvent>>> AidAccountsAidMgmntUsersActivitiesGetWithHttpInfoAsync(string oid, string uid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete User
        /// </summary>
        /// <remarks>
        /// Delete an user from an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountUserResponse</returns>
        System.Threading.Tasks.Task<AccountUserResponse> AidAccountsAidMgmntUsersDeleteAsync(string oid, string uid, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete User
        /// </summary>
        /// <remarks>
        /// Delete an user from an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountUserResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountUserResponse>> AidAccountsAidMgmntUsersDeleteWithHttpInfoAsync(string oid, string uid, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Users Collection
        /// </summary>
        /// <remarks>
        /// Get list of all users with access to the account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AccountUserResponse&gt;</returns>
        System.Threading.Tasks.Task<List<AccountUserResponse>> AidAccountsAidMgmntUsersGetAsync(string oid, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Users Collection
        /// </summary>
        /// <remarks>
        /// Get list of all users with access to the account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AccountUserResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AccountUserResponse>>> AidAccountsAidMgmntUsersGetWithHttpInfoAsync(string oid, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create User
        /// </summary>
        /// <remarks>
        /// Create and grant user access to the account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountUserResponse</returns>
        System.Threading.Tasks.Task<AccountUserResponse> AidAccountsAidMgmntUsersPostAsync(string oid, InlineObject12 data, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create User
        /// </summary>
        /// <remarks>
        /// Create and grant user access to the account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountUserResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountUserResponse>> AidAccountsAidMgmntUsersPostWithHttpInfoAsync(string oid, InlineObject12 data, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Update User
        /// </summary>
        /// <remarks>
        /// Update user  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountUserResponse</returns>
        System.Threading.Tasks.Task<AccountUserResponse> AidAccountsAidMgmntUsersPutAsync(string oid, string uid, UNKNOWN_BASE_TYPE data, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update User
        /// </summary>
        /// <remarks>
        /// Update user  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountUserResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountUserResponse>> AidAccountsAidMgmntUsersPutWithHttpInfoAsync(string oid, string uid, UNKNOWN_BASE_TYPE data, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountUsersApi : IAccountUsersApiSync, IAccountUsersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountUsersApi : IAccountUsersApi
    {
        private Dintero.OpenApiClient.Auth.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountUsersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountUsersApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AccountUsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountUsersApi(Dintero.OpenApiClient.Auth.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AccountUsersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AccountUsersApi(Dintero.OpenApiClient.Auth.Client.ISynchronousClient client, Dintero.OpenApiClient.Auth.Client.IAsynchronousClient asyncClient, Dintero.OpenApiClient.Auth.Client.IReadableConfiguration configuration)
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
        /// Authenticated User Get public and private profile information when authenticated through Bearer auth  &gt; Use ID token as Bearer token if the user was authenticated &gt; externally. The ID token must include a &#x60;email&#x60; claim that &gt; identifies the account user.  scopes: - openid - aws.cognito.signin.user.admin 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AuthenticatedAccountUser</returns>
        public AuthenticatedAccountUser AccountUserGet()
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthenticatedAccountUser> localVarResponse = AccountUserGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticated User Get public and private profile information when authenticated through Bearer auth  &gt; Use ID token as Bearer token if the user was authenticated &gt; externally. The ID token must include a &#x60;email&#x60; claim that &gt; identifies the account user.  scopes: - openid - aws.cognito.signin.user.admin 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AuthenticatedAccountUser</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthenticatedAccountUser> AccountUserGetWithHttpInfo()
        {
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


            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AuthenticatedAccountUser>("/account/user", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AccountUserGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Authenticated User Get public and private profile information when authenticated through Bearer auth  &gt; Use ID token as Bearer token if the user was authenticated &gt; externally. The ID token must include a &#x60;email&#x60; claim that &gt; identifies the account user.  scopes: - openid - aws.cognito.signin.user.admin 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthenticatedAccountUser</returns>
        public async System.Threading.Tasks.Task<AuthenticatedAccountUser> AccountUserGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthenticatedAccountUser> localVarResponse = await AccountUserGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticated User Get public and private profile information when authenticated through Bearer auth  &gt; Use ID token as Bearer token if the user was authenticated &gt; externally. The ID token must include a &#x60;email&#x60; claim that &gt; identifies the account user.  scopes: - openid - aws.cognito.signin.user.admin 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthenticatedAccountUser)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthenticatedAccountUser>> AccountUserGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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


            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AuthenticatedAccountUser>("/account/user", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AccountUserGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure SMS MFA Update the user SMS MFA configuration 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns></returns>
        public void AccountUserMfaSmsPut(InlineObject data)
        {
            AccountUserMfaSmsPutWithHttpInfo(data);
        }

        /// <summary>
        /// Configure SMS MFA Update the user SMS MFA configuration 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<Object> AccountUserMfaSmsPutWithHttpInfo(InlineObject data)
        {
            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountUsersApi->AccountUserMfaSmsPut");

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

            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/account/user/mfa/sms", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AccountUserMfaSmsPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure SMS MFA Update the user SMS MFA configuration 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AccountUserMfaSmsPutAsync(InlineObject data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await AccountUserMfaSmsPutWithHttpInfoAsync(data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Configure SMS MFA Update the user SMS MFA configuration 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<Object>> AccountUserMfaSmsPutWithHttpInfoAsync(InlineObject data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountUsersApi->AccountUserMfaSmsPut");


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

            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/account/user/mfa/sms", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AccountUserMfaSmsPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change User password Change the password for the account user  scopes: - openid 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void AccountUserPasswordPut(InlineObject1 body = default(InlineObject1))
        {
            AccountUserPasswordPutWithHttpInfo(body);
        }

        /// <summary>
        /// Change User password Change the password for the account user  scopes: - openid 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<Object> AccountUserPasswordPutWithHttpInfo(InlineObject1 body = default(InlineObject1))
        {
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

            localVarRequestOptions.Data = body;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/account/user/password", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AccountUserPasswordPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change User password Change the password for the account user  scopes: - openid 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AccountUserPasswordPutAsync(InlineObject1 body = default(InlineObject1), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await AccountUserPasswordPutWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Change User password Change the password for the account user  scopes: - openid 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<Object>> AccountUserPasswordPutWithHttpInfoAsync(InlineObject1 body = default(InlineObject1), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.Data = body;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/account/user/password", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AccountUserPasswordPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user activity log Get activities for User  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <returns>List&lt;AuditEvent&gt;</returns>
        public List<AuditEvent> AidAccountsAidMgmntUsersActivitiesGet(string oid, string uid)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AuditEvent>> localVarResponse = AidAccountsAidMgmntUsersActivitiesGetWithHttpInfo(oid, uid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user activity log Get activities for User  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <returns>ApiResponse of List&lt;AuditEvent&gt;</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AuditEvent>> AidAccountsAidMgmntUsersActivitiesGetWithHttpInfo(string oid, string uid)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountUsersApi->AidAccountsAidMgmntUsersActivitiesGet");

            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'uid' when calling AccountUsersApi->AidAccountsAidMgmntUsersActivitiesGet");

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
            localVarRequestOptions.PathParameters.Add("uid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(uid)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<AuditEvent>>("/accounts/{oid}/management/users/{uid}/activities", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidMgmntUsersActivitiesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user activity log Get activities for User  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AuditEvent&gt;</returns>
        public async System.Threading.Tasks.Task<List<AuditEvent>> AidAccountsAidMgmntUsersActivitiesGetAsync(string oid, string uid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AuditEvent>> localVarResponse = await AidAccountsAidMgmntUsersActivitiesGetWithHttpInfoAsync(oid, uid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user activity log Get activities for User  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AuditEvent&gt;)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AuditEvent>>> AidAccountsAidMgmntUsersActivitiesGetWithHttpInfoAsync(string oid, string uid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountUsersApi->AidAccountsAidMgmntUsersActivitiesGet");

            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'uid' when calling AccountUsersApi->AidAccountsAidMgmntUsersActivitiesGet");


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
            localVarRequestOptions.PathParameters.Add("uid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(uid)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<AuditEvent>>("/accounts/{oid}/management/users/{uid}/activities", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidMgmntUsersActivitiesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete User Delete an user from an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>AccountUserResponse</returns>
        public AccountUserResponse AidAccountsAidMgmntUsersDelete(string oid, string uid, List<string> expand = default(List<string>))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse> localVarResponse = AidAccountsAidMgmntUsersDeleteWithHttpInfo(oid, uid, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete User Delete an user from an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>ApiResponse of AccountUserResponse</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse> AidAccountsAidMgmntUsersDeleteWithHttpInfo(string oid, string uid, List<string> expand = default(List<string>))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountUsersApi->AidAccountsAidMgmntUsersDelete");

            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'uid' when calling AccountUsersApi->AidAccountsAidMgmntUsersDelete");

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
            localVarRequestOptions.PathParameters.Add("uid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(uid)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("csv", "expand", expand));
            }

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<AccountUserResponse>("/accounts/{oid}/management/users/{uid}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidMgmntUsersDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete User Delete an user from an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountUserResponse</returns>
        public async System.Threading.Tasks.Task<AccountUserResponse> AidAccountsAidMgmntUsersDeleteAsync(string oid, string uid, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse> localVarResponse = await AidAccountsAidMgmntUsersDeleteWithHttpInfoAsync(oid, uid, expand, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete User Delete an user from an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountUserResponse)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse>> AidAccountsAidMgmntUsersDeleteWithHttpInfoAsync(string oid, string uid, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountUsersApi->AidAccountsAidMgmntUsersDelete");

            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'uid' when calling AccountUsersApi->AidAccountsAidMgmntUsersDelete");


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
            localVarRequestOptions.PathParameters.Add("uid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(uid)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("csv", "expand", expand));
            }

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<AccountUserResponse>("/accounts/{oid}/management/users/{uid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidMgmntUsersDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Users Collection Get list of all users with access to the account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>List&lt;AccountUserResponse&gt;</returns>
        public List<AccountUserResponse> AidAccountsAidMgmntUsersGet(string oid, List<string> expand = default(List<string>))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AccountUserResponse>> localVarResponse = AidAccountsAidMgmntUsersGetWithHttpInfo(oid, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Users Collection Get list of all users with access to the account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>ApiResponse of List&lt;AccountUserResponse&gt;</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AccountUserResponse>> AidAccountsAidMgmntUsersGetWithHttpInfo(string oid, List<string> expand = default(List<string>))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountUsersApi->AidAccountsAidMgmntUsersGet");

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
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("csv", "expand", expand));
            }

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<AccountUserResponse>>("/accounts/{oid}/management/users", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidMgmntUsersGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Users Collection Get list of all users with access to the account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AccountUserResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<AccountUserResponse>> AidAccountsAidMgmntUsersGetAsync(string oid, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AccountUserResponse>> localVarResponse = await AidAccountsAidMgmntUsersGetWithHttpInfoAsync(oid, expand, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Users Collection Get list of all users with access to the account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AccountUserResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AccountUserResponse>>> AidAccountsAidMgmntUsersGetWithHttpInfoAsync(string oid, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountUsersApi->AidAccountsAidMgmntUsersGet");


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
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("csv", "expand", expand));
            }

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<AccountUserResponse>>("/accounts/{oid}/management/users", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidMgmntUsersGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create User Create and grant user access to the account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>AccountUserResponse</returns>
        public AccountUserResponse AidAccountsAidMgmntUsersPost(string oid, InlineObject12 data, List<string> expand = default(List<string>))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse> localVarResponse = AidAccountsAidMgmntUsersPostWithHttpInfo(oid, data, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create User Create and grant user access to the account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>ApiResponse of AccountUserResponse</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse> AidAccountsAidMgmntUsersPostWithHttpInfo(string oid, InlineObject12 data, List<string> expand = default(List<string>))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountUsersApi->AidAccountsAidMgmntUsersPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountUsersApi->AidAccountsAidMgmntUsersPost");

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
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("csv", "expand", expand));
            }
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AccountUserResponse>("/accounts/{oid}/management/users", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidMgmntUsersPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create User Create and grant user access to the account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountUserResponse</returns>
        public async System.Threading.Tasks.Task<AccountUserResponse> AidAccountsAidMgmntUsersPostAsync(string oid, InlineObject12 data, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse> localVarResponse = await AidAccountsAidMgmntUsersPostWithHttpInfoAsync(oid, data, expand, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create User Create and grant user access to the account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountUserResponse)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse>> AidAccountsAidMgmntUsersPostWithHttpInfoAsync(string oid, InlineObject12 data, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountUsersApi->AidAccountsAidMgmntUsersPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountUsersApi->AidAccountsAidMgmntUsersPost");


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
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("csv", "expand", expand));
            }
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AccountUserResponse>("/accounts/{oid}/management/users", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidMgmntUsersPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update User Update user  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>AccountUserResponse</returns>
        public AccountUserResponse AidAccountsAidMgmntUsersPut(string oid, string uid, UNKNOWN_BASE_TYPE data, List<string> expand = default(List<string>))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse> localVarResponse = AidAccountsAidMgmntUsersPutWithHttpInfo(oid, uid, data, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update User Update user  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <returns>ApiResponse of AccountUserResponse</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse> AidAccountsAidMgmntUsersPutWithHttpInfo(string oid, string uid, UNKNOWN_BASE_TYPE data, List<string> expand = default(List<string>))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountUsersApi->AidAccountsAidMgmntUsersPut");

            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'uid' when calling AccountUsersApi->AidAccountsAidMgmntUsersPut");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountUsersApi->AidAccountsAidMgmntUsersPut");

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
            localVarRequestOptions.PathParameters.Add("uid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(uid)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("csv", "expand", expand));
            }
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<AccountUserResponse>("/accounts/{oid}/management/users/{uid}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidMgmntUsersPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update User Update user  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountUserResponse</returns>
        public async System.Threading.Tasks.Task<AccountUserResponse> AidAccountsAidMgmntUsersPutAsync(string oid, string uid, UNKNOWN_BASE_TYPE data, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse> localVarResponse = await AidAccountsAidMgmntUsersPutWithHttpInfoAsync(oid, uid, data, expand, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update User Update user  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="uid">Id identifying the user </param>
        /// <param name="data"></param>
        /// <param name="expand">Expand properties in the response  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountUserResponse)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountUserResponse>> AidAccountsAidMgmntUsersPutWithHttpInfoAsync(string oid, string uid, UNKNOWN_BASE_TYPE data, List<string> expand = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountUsersApi->AidAccountsAidMgmntUsersPut");

            // verify the required parameter 'uid' is set
            if (uid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'uid' when calling AccountUsersApi->AidAccountsAidMgmntUsersPut");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountUsersApi->AidAccountsAidMgmntUsersPut");


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
            localVarRequestOptions.PathParameters.Add("uid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(uid)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("csv", "expand", expand));
            }
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<AccountUserResponse>("/accounts/{oid}/management/users/{uid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidMgmntUsersPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
