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
    public interface IRolesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Roles collection
        /// </summary>
        /// <remarks>
        /// Retrieve filtered list of roles that can be assigned to users.  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup roles matching id, name and description  (optional)</param>
        /// <param name="name">lookup roles by name  (optional)</param>
        /// <param name="includeDeleted">include deleted roles in the response  (optional, default to false)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>List&lt;AuthRole&gt;</returns>
        List<AuthRole> AidAuthsRolesGet(string oid, string search = default(string), string name = default(string), bool? includeDeleted = default(bool?), int? limit = default(int?), string startingAfter = default(string));

        /// <summary>
        /// Roles collection
        /// </summary>
        /// <remarks>
        /// Retrieve filtered list of roles that can be assigned to users.  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup roles matching id, name and description  (optional)</param>
        /// <param name="name">lookup roles by name  (optional)</param>
        /// <param name="includeDeleted">include deleted roles in the response  (optional, default to false)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>ApiResponse of List&lt;AuthRole&gt;</returns>
        ApiResponse<List<AuthRole>> AidAuthsRolesGetWithHttpInfo(string oid, string search = default(string), string name = default(string), bool? includeDeleted = default(bool?), int? limit = default(int?), string startingAfter = default(string));
        /// <summary>
        /// Delete role 
        /// </summary>
        /// <remarks>
        /// scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <returns>AuthRole</returns>
        AuthRole AidAuthsRolesIdDelete(string oid, string roleId);

        /// <summary>
        /// Delete role 
        /// </summary>
        /// <remarks>
        /// scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <returns>ApiResponse of AuthRole</returns>
        ApiResponse<AuthRole> AidAuthsRolesIdDeleteWithHttpInfo(string oid, string roleId);
        /// <summary>
        /// Get role 
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <returns>AuthRole</returns>
        AuthRole AidAuthsRolesIdGet(string oid, string roleId);

        /// <summary>
        /// Get role 
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <returns>ApiResponse of AuthRole</returns>
        ApiResponse<AuthRole> AidAuthsRolesIdGetWithHttpInfo(string oid, string roleId);
        /// <summary>
        /// Update role 
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="data"></param>
        /// <returns>AuthRole</returns>
        AuthRole AidAuthsRolesIdPut(string oid, string roleId, AuthRole data);

        /// <summary>
        /// Update role 
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AuthRole</returns>
        ApiResponse<AuthRole> AidAuthsRolesIdPutWithHttpInfo(string oid, string roleId, AuthRole data);
        /// <summary>
        /// Create a role
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>AuthRole</returns>
        AuthRole AidAuthsRolesPost(string oid, AuthRole data);

        /// <summary>
        /// Create a role
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AuthRole</returns>
        ApiResponse<AuthRole> AidAuthsRolesPostWithHttpInfo(string oid, AuthRole data);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRolesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Roles collection
        /// </summary>
        /// <remarks>
        /// Retrieve filtered list of roles that can be assigned to users.  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup roles matching id, name and description  (optional)</param>
        /// <param name="name">lookup roles by name  (optional)</param>
        /// <param name="includeDeleted">include deleted roles in the response  (optional, default to false)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AuthRole&gt;</returns>
        System.Threading.Tasks.Task<List<AuthRole>> AidAuthsRolesGetAsync(string oid, string search = default(string), string name = default(string), bool? includeDeleted = default(bool?), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Roles collection
        /// </summary>
        /// <remarks>
        /// Retrieve filtered list of roles that can be assigned to users.  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup roles matching id, name and description  (optional)</param>
        /// <param name="name">lookup roles by name  (optional)</param>
        /// <param name="includeDeleted">include deleted roles in the response  (optional, default to false)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AuthRole&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AuthRole>>> AidAuthsRolesGetWithHttpInfoAsync(string oid, string search = default(string), string name = default(string), bool? includeDeleted = default(bool?), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete role 
        /// </summary>
        /// <remarks>
        /// scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthRole</returns>
        System.Threading.Tasks.Task<AuthRole> AidAuthsRolesIdDeleteAsync(string oid, string roleId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete role 
        /// </summary>
        /// <remarks>
        /// scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthRole>> AidAuthsRolesIdDeleteWithHttpInfoAsync(string oid, string roleId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get role 
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthRole</returns>
        System.Threading.Tasks.Task<AuthRole> AidAuthsRolesIdGetAsync(string oid, string roleId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get role 
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthRole>> AidAuthsRolesIdGetWithHttpInfoAsync(string oid, string roleId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Update role 
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthRole</returns>
        System.Threading.Tasks.Task<AuthRole> AidAuthsRolesIdPutAsync(string oid, string roleId, AuthRole data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update role 
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthRole>> AidAuthsRolesIdPutWithHttpInfoAsync(string oid, string roleId, AuthRole data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create a role
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthRole</returns>
        System.Threading.Tasks.Task<AuthRole> AidAuthsRolesPostAsync(string oid, AuthRole data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a role
        /// </summary>
        /// <remarks>
        ///  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthRole>> AidAuthsRolesPostWithHttpInfoAsync(string oid, AuthRole data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRolesApi : IRolesApiSync, IRolesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RolesApi : IRolesApi
    {
        private Dintero.OpenApiClient.Auth.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RolesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RolesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RolesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RolesApi(String basePath)
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
        /// Initializes a new instance of the <see cref="RolesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RolesApi(Dintero.OpenApiClient.Auth.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="RolesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public RolesApi(Dintero.OpenApiClient.Auth.Client.ISynchronousClient client, Dintero.OpenApiClient.Auth.Client.IAsynchronousClient asyncClient, Dintero.OpenApiClient.Auth.Client.IReadableConfiguration configuration)
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
        /// Roles collection Retrieve filtered list of roles that can be assigned to users.  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup roles matching id, name and description  (optional)</param>
        /// <param name="name">lookup roles by name  (optional)</param>
        /// <param name="includeDeleted">include deleted roles in the response  (optional, default to false)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>List&lt;AuthRole&gt;</returns>
        public List<AuthRole> AidAuthsRolesGet(string oid, string search = default(string), string name = default(string), bool? includeDeleted = default(bool?), int? limit = default(int?), string startingAfter = default(string))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AuthRole>> localVarResponse = AidAuthsRolesGetWithHttpInfo(oid, search, name, includeDeleted, limit, startingAfter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Roles collection Retrieve filtered list of roles that can be assigned to users.  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup roles matching id, name and description  (optional)</param>
        /// <param name="name">lookup roles by name  (optional)</param>
        /// <param name="includeDeleted">include deleted roles in the response  (optional, default to false)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>ApiResponse of List&lt;AuthRole&gt;</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AuthRole>> AidAuthsRolesGetWithHttpInfo(string oid, string search = default(string), string name = default(string), bool? includeDeleted = default(bool?), int? limit = default(int?), string startingAfter = default(string))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling RolesApi->AidAuthsRolesGet");

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
            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "search", search));
            }
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "name", name));
            }
            if (includeDeleted != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "include_deleted", includeDeleted));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (startingAfter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "starting_after", startingAfter));
            }

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<AuthRole>>("/accounts/{oid}/auth/roles", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsRolesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Roles collection Retrieve filtered list of roles that can be assigned to users.  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup roles matching id, name and description  (optional)</param>
        /// <param name="name">lookup roles by name  (optional)</param>
        /// <param name="includeDeleted">include deleted roles in the response  (optional, default to false)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AuthRole&gt;</returns>
        public async System.Threading.Tasks.Task<List<AuthRole>> AidAuthsRolesGetAsync(string oid, string search = default(string), string name = default(string), bool? includeDeleted = default(bool?), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AuthRole>> localVarResponse = await AidAuthsRolesGetWithHttpInfoAsync(oid, search, name, includeDeleted, limit, startingAfter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Roles collection Retrieve filtered list of roles that can be assigned to users.  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup roles matching id, name and description  (optional)</param>
        /// <param name="name">lookup roles by name  (optional)</param>
        /// <param name="includeDeleted">include deleted roles in the response  (optional, default to false)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AuthRole&gt;)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AuthRole>>> AidAuthsRolesGetWithHttpInfoAsync(string oid, string search = default(string), string name = default(string), bool? includeDeleted = default(bool?), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling RolesApi->AidAuthsRolesGet");


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
            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "search", search));
            }
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "name", name));
            }
            if (includeDeleted != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "include_deleted", includeDeleted));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (startingAfter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("", "starting_after", startingAfter));
            }

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<AuthRole>>("/accounts/{oid}/auth/roles", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsRolesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete role  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <returns>AuthRole</returns>
        public AuthRole AidAuthsRolesIdDelete(string oid, string roleId)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> localVarResponse = AidAuthsRolesIdDeleteWithHttpInfo(oid, roleId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete role  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <returns>ApiResponse of AuthRole</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> AidAuthsRolesIdDeleteWithHttpInfo(string oid, string roleId)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling RolesApi->AidAuthsRolesIdDelete");

            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'roleId' when calling RolesApi->AidAuthsRolesIdDelete");

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
            localVarRequestOptions.PathParameters.Add("role_id", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(roleId)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<AuthRole>("/accounts/{oid}/auth/roles/{role_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsRolesIdDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete role  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthRole</returns>
        public async System.Threading.Tasks.Task<AuthRole> AidAuthsRolesIdDeleteAsync(string oid, string roleId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> localVarResponse = await AidAuthsRolesIdDeleteWithHttpInfoAsync(oid, roleId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete role  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthRole)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole>> AidAuthsRolesIdDeleteWithHttpInfoAsync(string oid, string roleId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling RolesApi->AidAuthsRolesIdDelete");

            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'roleId' when calling RolesApi->AidAuthsRolesIdDelete");


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
            localVarRequestOptions.PathParameters.Add("role_id", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(roleId)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<AuthRole>("/accounts/{oid}/auth/roles/{role_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsRolesIdDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get role   scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <returns>AuthRole</returns>
        public AuthRole AidAuthsRolesIdGet(string oid, string roleId)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> localVarResponse = AidAuthsRolesIdGetWithHttpInfo(oid, roleId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get role   scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <returns>ApiResponse of AuthRole</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> AidAuthsRolesIdGetWithHttpInfo(string oid, string roleId)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling RolesApi->AidAuthsRolesIdGet");

            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'roleId' when calling RolesApi->AidAuthsRolesIdGet");

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
            localVarRequestOptions.PathParameters.Add("role_id", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(roleId)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AuthRole>("/accounts/{oid}/auth/roles/{role_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsRolesIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get role   scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthRole</returns>
        public async System.Threading.Tasks.Task<AuthRole> AidAuthsRolesIdGetAsync(string oid, string roleId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> localVarResponse = await AidAuthsRolesIdGetWithHttpInfoAsync(oid, roleId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get role   scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthRole)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole>> AidAuthsRolesIdGetWithHttpInfoAsync(string oid, string roleId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling RolesApi->AidAuthsRolesIdGet");

            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'roleId' when calling RolesApi->AidAuthsRolesIdGet");


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
            localVarRequestOptions.PathParameters.Add("role_id", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(roleId)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AuthRole>("/accounts/{oid}/auth/roles/{role_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsRolesIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update role   scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="data"></param>
        /// <returns>AuthRole</returns>
        public AuthRole AidAuthsRolesIdPut(string oid, string roleId, AuthRole data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> localVarResponse = AidAuthsRolesIdPutWithHttpInfo(oid, roleId, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update role   scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AuthRole</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> AidAuthsRolesIdPutWithHttpInfo(string oid, string roleId, AuthRole data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling RolesApi->AidAuthsRolesIdPut");

            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'roleId' when calling RolesApi->AidAuthsRolesIdPut");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling RolesApi->AidAuthsRolesIdPut");

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
            localVarRequestOptions.PathParameters.Add("role_id", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(roleId)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<AuthRole>("/accounts/{oid}/auth/roles/{role_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsRolesIdPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update role   scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthRole</returns>
        public async System.Threading.Tasks.Task<AuthRole> AidAuthsRolesIdPutAsync(string oid, string roleId, AuthRole data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> localVarResponse = await AidAuthsRolesIdPutWithHttpInfoAsync(oid, roleId, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update role   scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="roleId">The id of the rule to delete </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthRole)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole>> AidAuthsRolesIdPutWithHttpInfoAsync(string oid, string roleId, AuthRole data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling RolesApi->AidAuthsRolesIdPut");

            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'roleId' when calling RolesApi->AidAuthsRolesIdPut");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling RolesApi->AidAuthsRolesIdPut");


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
            localVarRequestOptions.PathParameters.Add("role_id", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(roleId)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<AuthRole>("/accounts/{oid}/auth/roles/{role_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsRolesIdPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a role  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>AuthRole</returns>
        public AuthRole AidAuthsRolesPost(string oid, AuthRole data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> localVarResponse = AidAuthsRolesPostWithHttpInfo(oid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a role  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AuthRole</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> AidAuthsRolesPostWithHttpInfo(string oid, AuthRole data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling RolesApi->AidAuthsRolesPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling RolesApi->AidAuthsRolesPost");

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
            var localVarResponse = this.Client.Post<AuthRole>("/accounts/{oid}/auth/roles", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsRolesPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a role  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthRole</returns>
        public async System.Threading.Tasks.Task<AuthRole> AidAuthsRolesPostAsync(string oid, AuthRole data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole> localVarResponse = await AidAuthsRolesPostWithHttpInfoAsync(oid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a role  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthRole)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AuthRole>> AidAuthsRolesPostWithHttpInfoAsync(string oid, AuthRole data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling RolesApi->AidAuthsRolesPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling RolesApi->AidAuthsRolesPost");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<AuthRole>("/accounts/{oid}/auth/roles", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAuthsRolesPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
