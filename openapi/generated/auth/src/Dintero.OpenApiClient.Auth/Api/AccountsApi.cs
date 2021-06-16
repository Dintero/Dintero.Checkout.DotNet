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
    public interface IAccountsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Update connection status
        /// </summary>
        /// <remarks>
        /// Update an account connection with new status  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="connection">The connection to update </param>
        /// <param name="data"></param>
        /// <returns>AccountConnectionEvent</returns>
        AccountConnectionEvent AidAccountsAidConnectionsEventsPost(string oid, string aid, string connection, AccountConnectionEvent data);

        /// <summary>
        /// Update connection status
        /// </summary>
        /// <remarks>
        /// Update an account connection with new status  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="connection">The connection to update </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AccountConnectionEvent</returns>
        ApiResponse<AccountConnectionEvent> AidAccountsAidConnectionsEventsPostWithHttpInfo(string oid, string aid, string connection, AccountConnectionEvent data);
        /// <summary>
        /// Get Account
        /// </summary>
        /// <remarks>
        /// Get account details  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ExtendedAccount</returns>
        ExtendedAccount AidAccountsAidGet(string oid, string aid);

        /// <summary>
        /// Get Account
        /// </summary>
        /// <remarks>
        /// Get account details  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ApiResponse of ExtendedAccount</returns>
        ApiResponse<ExtendedAccount> AidAccountsAidGetWithHttpInfo(string oid, string aid);
        /// <summary>
        /// Update Account
        /// </summary>
        /// <remarks>
        /// Update an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ExtendedAccount</returns>
        ExtendedAccount AidAccountsAidPut(string oid, string aid, UNKNOWN_BASE_TYPE data);

        /// <summary>
        /// Update Account
        /// </summary>
        /// <remarks>
        /// Update an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of ExtendedAccount</returns>
        ApiResponse<ExtendedAccount> AidAccountsAidPutWithHttpInfo(string oid, string aid, UNKNOWN_BASE_TYPE data);
        /// <summary>
        /// Delete Account
        /// </summary>
        /// <remarks>
        /// Delete an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ExtendedAccount</returns>
        ExtendedAccount AidMgmntAccountsAidDelete(string oid, string aid);

        /// <summary>
        /// Delete Account
        /// </summary>
        /// <remarks>
        /// Delete an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ApiResponse of ExtendedAccount</returns>
        ApiResponse<ExtendedAccount> AidMgmntAccountsAidDeleteWithHttpInfo(string oid, string aid);
        /// <summary>
        /// Account events
        /// </summary>
        /// <remarks>
        /// Get list of account events  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="type">filter events by type  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>List&lt;AccountEvent&gt;</returns>
        List<AccountEvent> AidMgmntAccountsEventsGet(string oid, string aid, List<string> type = default(List<string>), int? limit = default(int?), string startingAfter = default(string));

        /// <summary>
        /// Account events
        /// </summary>
        /// <remarks>
        /// Get list of account events  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="type">filter events by type  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>ApiResponse of List&lt;AccountEvent&gt;</returns>
        ApiResponse<List<AccountEvent>> AidMgmntAccountsEventsGetWithHttpInfo(string oid, string aid, List<string> type = default(List<string>), int? limit = default(int?), string startingAfter = default(string));
        /// <summary>
        /// Create Account Event
        /// </summary>
        /// <remarks>
        /// Create an account event  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="_event"></param>
        /// <returns>AccountEvent</returns>
        AccountEvent AidMgmntAccountsEventsPost(string oid, string aid, AccountEvent _event);

        /// <summary>
        /// Create Account Event
        /// </summary>
        /// <remarks>
        /// Create an account event  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="_event"></param>
        /// <returns>ApiResponse of AccountEvent</returns>
        ApiResponse<AccountEvent> AidMgmntAccountsEventsPostWithHttpInfo(string oid, string aid, AccountEvent _event);
        /// <summary>
        /// Accounts collection
        /// </summary>
        /// <remarks>
        /// Get list of accounts filtered by the partner account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup accounts where search term match account id  (optional)</param>
        /// <param name="progression">filter account by progression  (optional)</param>
        /// <param name="connections">filter account by connections  (optional)</param>
        /// <param name="connectionsProgression">filter account by connections progression  (optional)</param>
        /// <param name="services">filter accounts by services registered  (optional)</param>
        /// <param name="servicesProgression">filter account by services progression  (optional)</param>
        /// <param name="accountManager">filter account by account_manager  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>List&lt;ExtendedAccount&gt;</returns>
        List<ExtendedAccount> AidMgmntAccountsGet(string oid, string search = default(string), List<string> progression = default(List<string>), List<string> connections = default(List<string>), List<string> connectionsProgression = default(List<string>), List<string> services = default(List<string>), List<string> servicesProgression = default(List<string>), List<string> accountManager = default(List<string>), int? limit = default(int?), string startingAfter = default(string));

        /// <summary>
        /// Accounts collection
        /// </summary>
        /// <remarks>
        /// Get list of accounts filtered by the partner account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup accounts where search term match account id  (optional)</param>
        /// <param name="progression">filter account by progression  (optional)</param>
        /// <param name="connections">filter account by connections  (optional)</param>
        /// <param name="connectionsProgression">filter account by connections progression  (optional)</param>
        /// <param name="services">filter accounts by services registered  (optional)</param>
        /// <param name="servicesProgression">filter account by services progression  (optional)</param>
        /// <param name="accountManager">filter account by account_manager  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>ApiResponse of List&lt;ExtendedAccount&gt;</returns>
        ApiResponse<List<ExtendedAccount>> AidMgmntAccountsGetWithHttpInfo(string oid, string search = default(string), List<string> progression = default(List<string>), List<string> connections = default(List<string>), List<string> connectionsProgression = default(List<string>), List<string> services = default(List<string>), List<string> servicesProgression = default(List<string>), List<string> accountManager = default(List<string>), int? limit = default(int?), string startingAfter = default(string));
        /// <summary>
        /// Create Account
        /// </summary>
        /// <remarks>
        /// Create an account from an partner account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ExtendedAccount</returns>
        ExtendedAccount AidMgmntAccountsPost(string oid, UNKNOWN_BASE_TYPE data);

        /// <summary>
        /// Create Account
        /// </summary>
        /// <remarks>
        /// Create an account from an partner account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of ExtendedAccount</returns>
        ApiResponse<ExtendedAccount> AidMgmntAccountsPostWithHttpInfo(string oid, UNKNOWN_BASE_TYPE data);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Update connection status
        /// </summary>
        /// <remarks>
        /// Update an account connection with new status  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="connection">The connection to update </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountConnectionEvent</returns>
        System.Threading.Tasks.Task<AccountConnectionEvent> AidAccountsAidConnectionsEventsPostAsync(string oid, string aid, string connection, AccountConnectionEvent data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update connection status
        /// </summary>
        /// <remarks>
        /// Update an account connection with new status  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="connection">The connection to update </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountConnectionEvent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountConnectionEvent>> AidAccountsAidConnectionsEventsPostWithHttpInfoAsync(string oid, string aid, string connection, AccountConnectionEvent data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Account
        /// </summary>
        /// <remarks>
        /// Get account details  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExtendedAccount</returns>
        System.Threading.Tasks.Task<ExtendedAccount> AidAccountsAidGetAsync(string oid, string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Account
        /// </summary>
        /// <remarks>
        /// Get account details  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExtendedAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtendedAccount>> AidAccountsAidGetWithHttpInfoAsync(string oid, string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Update Account
        /// </summary>
        /// <remarks>
        /// Update an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExtendedAccount</returns>
        System.Threading.Tasks.Task<ExtendedAccount> AidAccountsAidPutAsync(string oid, string aid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update Account
        /// </summary>
        /// <remarks>
        /// Update an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExtendedAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtendedAccount>> AidAccountsAidPutWithHttpInfoAsync(string oid, string aid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete Account
        /// </summary>
        /// <remarks>
        /// Delete an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExtendedAccount</returns>
        System.Threading.Tasks.Task<ExtendedAccount> AidMgmntAccountsAidDeleteAsync(string oid, string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete Account
        /// </summary>
        /// <remarks>
        /// Delete an account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExtendedAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtendedAccount>> AidMgmntAccountsAidDeleteWithHttpInfoAsync(string oid, string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Account events
        /// </summary>
        /// <remarks>
        /// Get list of account events  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="type">filter events by type  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AccountEvent&gt;</returns>
        System.Threading.Tasks.Task<List<AccountEvent>> AidMgmntAccountsEventsGetAsync(string oid, string aid, List<string> type = default(List<string>), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Account events
        /// </summary>
        /// <remarks>
        /// Get list of account events  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="type">filter events by type  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AccountEvent&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AccountEvent>>> AidMgmntAccountsEventsGetWithHttpInfoAsync(string oid, string aid, List<string> type = default(List<string>), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create Account Event
        /// </summary>
        /// <remarks>
        /// Create an account event  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="_event"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountEvent</returns>
        System.Threading.Tasks.Task<AccountEvent> AidMgmntAccountsEventsPostAsync(string oid, string aid, AccountEvent _event, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create Account Event
        /// </summary>
        /// <remarks>
        /// Create an account event  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="_event"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountEvent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountEvent>> AidMgmntAccountsEventsPostWithHttpInfoAsync(string oid, string aid, AccountEvent _event, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Accounts collection
        /// </summary>
        /// <remarks>
        /// Get list of accounts filtered by the partner account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup accounts where search term match account id  (optional)</param>
        /// <param name="progression">filter account by progression  (optional)</param>
        /// <param name="connections">filter account by connections  (optional)</param>
        /// <param name="connectionsProgression">filter account by connections progression  (optional)</param>
        /// <param name="services">filter accounts by services registered  (optional)</param>
        /// <param name="servicesProgression">filter account by services progression  (optional)</param>
        /// <param name="accountManager">filter account by account_manager  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ExtendedAccount&gt;</returns>
        System.Threading.Tasks.Task<List<ExtendedAccount>> AidMgmntAccountsGetAsync(string oid, string search = default(string), List<string> progression = default(List<string>), List<string> connections = default(List<string>), List<string> connectionsProgression = default(List<string>), List<string> services = default(List<string>), List<string> servicesProgression = default(List<string>), List<string> accountManager = default(List<string>), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Accounts collection
        /// </summary>
        /// <remarks>
        /// Get list of accounts filtered by the partner account  scopes: - admin:accounts - read:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup accounts where search term match account id  (optional)</param>
        /// <param name="progression">filter account by progression  (optional)</param>
        /// <param name="connections">filter account by connections  (optional)</param>
        /// <param name="connectionsProgression">filter account by connections progression  (optional)</param>
        /// <param name="services">filter accounts by services registered  (optional)</param>
        /// <param name="servicesProgression">filter account by services progression  (optional)</param>
        /// <param name="accountManager">filter account by account_manager  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ExtendedAccount&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ExtendedAccount>>> AidMgmntAccountsGetWithHttpInfoAsync(string oid, string search = default(string), List<string> progression = default(List<string>), List<string> connections = default(List<string>), List<string> connectionsProgression = default(List<string>), List<string> services = default(List<string>), List<string> servicesProgression = default(List<string>), List<string> accountManager = default(List<string>), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create Account
        /// </summary>
        /// <remarks>
        /// Create an account from an partner account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExtendedAccount</returns>
        System.Threading.Tasks.Task<ExtendedAccount> AidMgmntAccountsPostAsync(string oid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create Account
        /// </summary>
        /// <remarks>
        /// Create an account from an partner account  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExtendedAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtendedAccount>> AidMgmntAccountsPostWithHttpInfoAsync(string oid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApi : IAccountsApiSync, IAccountsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountsApi : IAccountsApi
    {
        private Dintero.OpenApiClient.Auth.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountsApi(Dintero.OpenApiClient.Auth.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AccountsApi(Dintero.OpenApiClient.Auth.Client.ISynchronousClient client, Dintero.OpenApiClient.Auth.Client.IAsynchronousClient asyncClient, Dintero.OpenApiClient.Auth.Client.IReadableConfiguration configuration)
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
        /// Update connection status Update an account connection with new status  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="connection">The connection to update </param>
        /// <param name="data"></param>
        /// <returns>AccountConnectionEvent</returns>
        public AccountConnectionEvent AidAccountsAidConnectionsEventsPost(string oid, string aid, string connection, AccountConnectionEvent data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountConnectionEvent> localVarResponse = AidAccountsAidConnectionsEventsPostWithHttpInfo(oid, aid, connection, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update connection status Update an account connection with new status  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="connection">The connection to update </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AccountConnectionEvent</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountConnectionEvent> AidAccountsAidConnectionsEventsPostWithHttpInfo(string oid, string aid, string connection, AccountConnectionEvent data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidAccountsAidConnectionsEventsPost");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidAccountsAidConnectionsEventsPost");

            // verify the required parameter 'connection' is set
            if (connection == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'connection' when calling AccountsApi->AidAccountsAidConnectionsEventsPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountsApi->AidAccountsAidConnectionsEventsPost");

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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            localVarRequestOptions.PathParameters.Add("connection", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(connection)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AccountConnectionEvent>("/accounts/{oid}/management/accounts/{aid}/connections/{connection}/events", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidConnectionsEventsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update connection status Update an account connection with new status  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="connection">The connection to update </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountConnectionEvent</returns>
        public async System.Threading.Tasks.Task<AccountConnectionEvent> AidAccountsAidConnectionsEventsPostAsync(string oid, string aid, string connection, AccountConnectionEvent data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountConnectionEvent> localVarResponse = await AidAccountsAidConnectionsEventsPostWithHttpInfoAsync(oid, aid, connection, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update connection status Update an account connection with new status  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="connection">The connection to update </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountConnectionEvent)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountConnectionEvent>> AidAccountsAidConnectionsEventsPostWithHttpInfoAsync(string oid, string aid, string connection, AccountConnectionEvent data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidAccountsAidConnectionsEventsPost");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidAccountsAidConnectionsEventsPost");

            // verify the required parameter 'connection' is set
            if (connection == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'connection' when calling AccountsApi->AidAccountsAidConnectionsEventsPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountsApi->AidAccountsAidConnectionsEventsPost");


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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            localVarRequestOptions.PathParameters.Add("connection", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(connection)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AccountConnectionEvent>("/accounts/{oid}/management/accounts/{aid}/connections/{connection}/events", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidConnectionsEventsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Account Get account details  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ExtendedAccount</returns>
        public ExtendedAccount AidAccountsAidGet(string oid, string aid)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> localVarResponse = AidAccountsAidGetWithHttpInfo(oid, aid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Account Get account details  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ApiResponse of ExtendedAccount</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> AidAccountsAidGetWithHttpInfo(string oid, string aid)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidAccountsAidGet");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidAccountsAidGet");

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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ExtendedAccount>("/accounts/{oid}/management/accounts/{aid}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Account Get account details  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExtendedAccount</returns>
        public async System.Threading.Tasks.Task<ExtendedAccount> AidAccountsAidGetAsync(string oid, string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> localVarResponse = await AidAccountsAidGetWithHttpInfoAsync(oid, aid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Account Get account details  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExtendedAccount)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount>> AidAccountsAidGetWithHttpInfoAsync(string oid, string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidAccountsAidGet");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidAccountsAidGet");


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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ExtendedAccount>("/accounts/{oid}/management/accounts/{aid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update Account Update an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ExtendedAccount</returns>
        public ExtendedAccount AidAccountsAidPut(string oid, string aid, UNKNOWN_BASE_TYPE data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> localVarResponse = AidAccountsAidPutWithHttpInfo(oid, aid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update Account Update an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of ExtendedAccount</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> AidAccountsAidPutWithHttpInfo(string oid, string aid, UNKNOWN_BASE_TYPE data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidAccountsAidPut");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidAccountsAidPut");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountsApi->AidAccountsAidPut");

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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<ExtendedAccount>("/accounts/{oid}/management/accounts/{aid}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update Account Update an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExtendedAccount</returns>
        public async System.Threading.Tasks.Task<ExtendedAccount> AidAccountsAidPutAsync(string oid, string aid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> localVarResponse = await AidAccountsAidPutWithHttpInfoAsync(oid, aid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update Account Update an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExtendedAccount)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount>> AidAccountsAidPutWithHttpInfoAsync(string oid, string aid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidAccountsAidPut");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidAccountsAidPut");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountsApi->AidAccountsAidPut");


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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<ExtendedAccount>("/accounts/{oid}/management/accounts/{aid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountsAidPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete Account Delete an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ExtendedAccount</returns>
        public ExtendedAccount AidMgmntAccountsAidDelete(string oid, string aid)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> localVarResponse = AidMgmntAccountsAidDeleteWithHttpInfo(oid, aid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Account Delete an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ApiResponse of ExtendedAccount</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> AidMgmntAccountsAidDeleteWithHttpInfo(string oid, string aid)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidMgmntAccountsAidDelete");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidMgmntAccountsAidDelete");

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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<ExtendedAccount>("/accounts/{oid}/management/accounts/{aid}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidMgmntAccountsAidDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete Account Delete an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExtendedAccount</returns>
        public async System.Threading.Tasks.Task<ExtendedAccount> AidMgmntAccountsAidDeleteAsync(string oid, string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> localVarResponse = await AidMgmntAccountsAidDeleteWithHttpInfoAsync(oid, aid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Account Delete an account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExtendedAccount)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount>> AidMgmntAccountsAidDeleteWithHttpInfoAsync(string oid, string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidMgmntAccountsAidDelete");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidMgmntAccountsAidDelete");


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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<ExtendedAccount>("/accounts/{oid}/management/accounts/{aid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidMgmntAccountsAidDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Account events Get list of account events  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="type">filter events by type  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>List&lt;AccountEvent&gt;</returns>
        public List<AccountEvent> AidMgmntAccountsEventsGet(string oid, string aid, List<string> type = default(List<string>), int? limit = default(int?), string startingAfter = default(string))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AccountEvent>> localVarResponse = AidMgmntAccountsEventsGetWithHttpInfo(oid, aid, type, limit, startingAfter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Account events Get list of account events  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="type">filter events by type  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>ApiResponse of List&lt;AccountEvent&gt;</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AccountEvent>> AidMgmntAccountsEventsGetWithHttpInfo(string oid, string aid, List<string> type = default(List<string>), int? limit = default(int?), string startingAfter = default(string))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidMgmntAccountsEventsGet");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidMgmntAccountsEventsGet");

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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "type", type));
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
            var localVarResponse = this.Client.Get<List<AccountEvent>>("/accounts/{oid}/management/accounts/{aid}/events", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidMgmntAccountsEventsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Account events Get list of account events  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="type">filter events by type  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AccountEvent&gt;</returns>
        public async System.Threading.Tasks.Task<List<AccountEvent>> AidMgmntAccountsEventsGetAsync(string oid, string aid, List<string> type = default(List<string>), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AccountEvent>> localVarResponse = await AidMgmntAccountsEventsGetWithHttpInfoAsync(oid, aid, type, limit, startingAfter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Account events Get list of account events  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="type">filter events by type  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AccountEvent&gt;)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<List<AccountEvent>>> AidMgmntAccountsEventsGetWithHttpInfoAsync(string oid, string aid, List<string> type = default(List<string>), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidMgmntAccountsEventsGet");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidMgmntAccountsEventsGet");


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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "type", type));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<AccountEvent>>("/accounts/{oid}/management/accounts/{aid}/events", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidMgmntAccountsEventsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create Account Event Create an account event  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="_event"></param>
        /// <returns>AccountEvent</returns>
        public AccountEvent AidMgmntAccountsEventsPost(string oid, string aid, AccountEvent _event)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountEvent> localVarResponse = AidMgmntAccountsEventsPostWithHttpInfo(oid, aid, _event);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Account Event Create an account event  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="_event"></param>
        /// <returns>ApiResponse of AccountEvent</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountEvent> AidMgmntAccountsEventsPostWithHttpInfo(string oid, string aid, AccountEvent _event)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidMgmntAccountsEventsPost");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidMgmntAccountsEventsPost");

            // verify the required parameter '_event' is set
            if (_event == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter '_event' when calling AccountsApi->AidMgmntAccountsEventsPost");

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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            localVarRequestOptions.Data = _event;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AccountEvent>("/accounts/{oid}/management/accounts/{aid}/events", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidMgmntAccountsEventsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create Account Event Create an account event  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="_event"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountEvent</returns>
        public async System.Threading.Tasks.Task<AccountEvent> AidMgmntAccountsEventsPostAsync(string oid, string aid, AccountEvent _event, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountEvent> localVarResponse = await AidMgmntAccountsEventsPostWithHttpInfoAsync(oid, aid, _event, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Account Event Create an account event  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="_event"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountEvent)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<AccountEvent>> AidMgmntAccountsEventsPostWithHttpInfoAsync(string oid, string aid, AccountEvent _event, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidMgmntAccountsEventsPost");

            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling AccountsApi->AidMgmntAccountsEventsPost");

            // verify the required parameter '_event' is set
            if (_event == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter '_event' when calling AccountsApi->AidMgmntAccountsEventsPost");


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
            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter
            localVarRequestOptions.Data = _event;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AccountEvent>("/accounts/{oid}/management/accounts/{aid}/events", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidMgmntAccountsEventsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Accounts collection Get list of accounts filtered by the partner account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup accounts where search term match account id  (optional)</param>
        /// <param name="progression">filter account by progression  (optional)</param>
        /// <param name="connections">filter account by connections  (optional)</param>
        /// <param name="connectionsProgression">filter account by connections progression  (optional)</param>
        /// <param name="services">filter accounts by services registered  (optional)</param>
        /// <param name="servicesProgression">filter account by services progression  (optional)</param>
        /// <param name="accountManager">filter account by account_manager  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>List&lt;ExtendedAccount&gt;</returns>
        public List<ExtendedAccount> AidMgmntAccountsGet(string oid, string search = default(string), List<string> progression = default(List<string>), List<string> connections = default(List<string>), List<string> connectionsProgression = default(List<string>), List<string> services = default(List<string>), List<string> servicesProgression = default(List<string>), List<string> accountManager = default(List<string>), int? limit = default(int?), string startingAfter = default(string))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<List<ExtendedAccount>> localVarResponse = AidMgmntAccountsGetWithHttpInfo(oid, search, progression, connections, connectionsProgression, services, servicesProgression, accountManager, limit, startingAfter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Accounts collection Get list of accounts filtered by the partner account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup accounts where search term match account id  (optional)</param>
        /// <param name="progression">filter account by progression  (optional)</param>
        /// <param name="connections">filter account by connections  (optional)</param>
        /// <param name="connectionsProgression">filter account by connections progression  (optional)</param>
        /// <param name="services">filter accounts by services registered  (optional)</param>
        /// <param name="servicesProgression">filter account by services progression  (optional)</param>
        /// <param name="accountManager">filter account by account_manager  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <returns>ApiResponse of List&lt;ExtendedAccount&gt;</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<List<ExtendedAccount>> AidMgmntAccountsGetWithHttpInfo(string oid, string search = default(string), List<string> progression = default(List<string>), List<string> connections = default(List<string>), List<string> connectionsProgression = default(List<string>), List<string> services = default(List<string>), List<string> servicesProgression = default(List<string>), List<string> accountManager = default(List<string>), int? limit = default(int?), string startingAfter = default(string))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidMgmntAccountsGet");

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
            if (progression != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "progression", progression));
            }
            if (connections != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "connections", connections));
            }
            if (connectionsProgression != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "connections_progression", connectionsProgression));
            }
            if (services != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "services", services));
            }
            if (servicesProgression != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "services_progression", servicesProgression));
            }
            if (accountManager != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "account_manager", accountManager));
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
            var localVarResponse = this.Client.Get<List<ExtendedAccount>>("/accounts/{oid}/management/accounts", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidMgmntAccountsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Accounts collection Get list of accounts filtered by the partner account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup accounts where search term match account id  (optional)</param>
        /// <param name="progression">filter account by progression  (optional)</param>
        /// <param name="connections">filter account by connections  (optional)</param>
        /// <param name="connectionsProgression">filter account by connections progression  (optional)</param>
        /// <param name="services">filter accounts by services registered  (optional)</param>
        /// <param name="servicesProgression">filter account by services progression  (optional)</param>
        /// <param name="accountManager">filter account by account_manager  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ExtendedAccount&gt;</returns>
        public async System.Threading.Tasks.Task<List<ExtendedAccount>> AidMgmntAccountsGetAsync(string oid, string search = default(string), List<string> progression = default(List<string>), List<string> connections = default(List<string>), List<string> connectionsProgression = default(List<string>), List<string> services = default(List<string>), List<string> servicesProgression = default(List<string>), List<string> accountManager = default(List<string>), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<List<ExtendedAccount>> localVarResponse = await AidMgmntAccountsGetWithHttpInfoAsync(oid, search, progression, connections, connectionsProgression, services, servicesProgression, accountManager, limit, startingAfter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Accounts collection Get list of accounts filtered by the partner account  scopes: - admin:accounts - read:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="search">lookup accounts where search term match account id  (optional)</param>
        /// <param name="progression">filter account by progression  (optional)</param>
        /// <param name="connections">filter account by connections  (optional)</param>
        /// <param name="connectionsProgression">filter account by connections progression  (optional)</param>
        /// <param name="services">filter accounts by services registered  (optional)</param>
        /// <param name="servicesProgression">filter account by services progression  (optional)</param>
        /// <param name="accountManager">filter account by account_manager  (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned. Limit can range between 1 and 100 items, and the default is 10 items.  (optional, default to 10)</param>
        /// <param name="startingAfter">cursor for use in pagination. starting_after is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with &#x60;obj_foo&#x60;, your subsequent call can include &#x60;starting_after&#x3D;obj_foo&#x60; in order to fetch the next page of the list.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ExtendedAccount&gt;)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<List<ExtendedAccount>>> AidMgmntAccountsGetWithHttpInfoAsync(string oid, string search = default(string), List<string> progression = default(List<string>), List<string> connections = default(List<string>), List<string> connectionsProgression = default(List<string>), List<string> services = default(List<string>), List<string> servicesProgression = default(List<string>), List<string> accountManager = default(List<string>), int? limit = default(int?), string startingAfter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidMgmntAccountsGet");


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
            if (progression != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "progression", progression));
            }
            if (connections != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "connections", connections));
            }
            if (connectionsProgression != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "connections_progression", connectionsProgression));
            }
            if (services != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "services", services));
            }
            if (servicesProgression != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "services_progression", servicesProgression));
            }
            if (accountManager != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToMultiMap("multi", "account_manager", accountManager));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ExtendedAccount>>("/accounts/{oid}/management/accounts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidMgmntAccountsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create Account Create an account from an partner account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ExtendedAccount</returns>
        public ExtendedAccount AidMgmntAccountsPost(string oid, UNKNOWN_BASE_TYPE data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> localVarResponse = AidMgmntAccountsPostWithHttpInfo(oid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Account Create an account from an partner account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of ExtendedAccount</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> AidMgmntAccountsPostWithHttpInfo(string oid, UNKNOWN_BASE_TYPE data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidMgmntAccountsPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountsApi->AidMgmntAccountsPost");

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
            var localVarResponse = this.Client.Post<ExtendedAccount>("/accounts/{oid}/management/accounts", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidMgmntAccountsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create Account Create an account from an partner account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExtendedAccount</returns>
        public async System.Threading.Tasks.Task<ExtendedAccount> AidMgmntAccountsPostAsync(string oid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount> localVarResponse = await AidMgmntAccountsPostWithHttpInfoAsync(oid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Account Create an account from an partner account  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExtendedAccount)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<ExtendedAccount>> AidMgmntAccountsPostWithHttpInfoAsync(string oid, UNKNOWN_BASE_TYPE data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'oid' when calling AccountsApi->AidMgmntAccountsPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling AccountsApi->AidMgmntAccountsPost");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ExtendedAccount>("/accounts/{oid}/management/accounts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidMgmntAccountsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
