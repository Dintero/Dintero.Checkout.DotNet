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
    public interface IConnectionOnboardingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Bambora signup
        /// </summary>
        /// <remarks>
        /// Initialize Bambora signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>BamboraConnection</returns>
        BamboraConnection AidAccountSettingsConnectionsBamboraPost(string aid, InlineObject4 data);

        /// <summary>
        /// Bambora signup
        /// </summary>
        /// <remarks>
        /// Initialize Bambora signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of BamboraConnection</returns>
        ApiResponse<BamboraConnection> AidAccountSettingsConnectionsBamboraPostWithHttpInfo(string aid, InlineObject4 data);
        /// <summary>
        /// Collector Bank signup
        /// </summary>
        /// <remarks>
        /// Initialize Collector Bank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>CollectorConnection</returns>
        CollectorConnection AidAccountSettingsConnectionsCollectorPost(string aid, InlineObject5 data);

        /// <summary>
        /// Collector Bank signup
        /// </summary>
        /// <remarks>
        /// Initialize Collector Bank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of CollectorConnection</returns>
        ApiResponse<CollectorConnection> AidAccountSettingsConnectionsCollectorPostWithHttpInfo(string aid, InlineObject5 data);
        /// <summary>
        /// Common signup
        /// </summary>
        /// <remarks>
        /// Initialize Common signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>CommonConnection</returns>
        CommonConnection AidAccountSettingsConnectionsCommonPost(string aid, InlineObject6 data);

        /// <summary>
        /// Common signup
        /// </summary>
        /// <remarks>
        /// Initialize Common signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of CommonConnection</returns>
        ApiResponse<CommonConnection> AidAccountSettingsConnectionsCommonPostWithHttpInfo(string aid, InlineObject6 data);
        /// <summary>
        /// Instabank signup
        /// </summary>
        /// <remarks>
        /// Initialize Instabank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>InstabankConnection</returns>
        InstabankConnection AidAccountSettingsConnectionsInstabankPost(string aid, InlineObject7 data);

        /// <summary>
        /// Instabank signup
        /// </summary>
        /// <remarks>
        /// Initialize Instabank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of InstabankConnection</returns>
        ApiResponse<InstabankConnection> AidAccountSettingsConnectionsInstabankPostWithHttpInfo(string aid, InlineObject7 data);
        /// <summary>
        /// PayEx signup
        /// </summary>
        /// <remarks>
        /// Initialize PayEx signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="paymentProductType"></param>
        /// <param name="data"></param>
        /// <returns>PayExConnection</returns>
        PayExConnection AidAccountSettingsConnectionsPayexPost(string aid, string paymentProductType, InlineObject8 data);

        /// <summary>
        /// PayEx signup
        /// </summary>
        /// <remarks>
        /// Initialize PayEx signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="paymentProductType"></param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of PayExConnection</returns>
        ApiResponse<PayExConnection> AidAccountSettingsConnectionsPayexPostWithHttpInfo(string aid, string paymentProductType, InlineObject8 data);
        /// <summary>
        /// Swish signup
        /// </summary>
        /// <remarks>
        /// Initialize Swish signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>SwishConnection</returns>
        SwishConnection AidAccountSettingsConnectionsSwishPost(string aid, InlineObject9 data);

        /// <summary>
        /// Swish signup
        /// </summary>
        /// <remarks>
        /// Initialize Swish signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of SwishConnection</returns>
        ApiResponse<SwishConnection> AidAccountSettingsConnectionsSwishPostWithHttpInfo(string aid, InlineObject9 data);
        /// <summary>
        /// Vipps signup
        /// </summary>
        /// <remarks>
        /// Initialize Vipps signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>VippsConnection</returns>
        VippsConnection AidAccountSettingsConnectionsVippsPost(string aid);

        /// <summary>
        /// Vipps signup
        /// </summary>
        /// <remarks>
        /// Initialize Vipps signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ApiResponse of VippsConnection</returns>
        ApiResponse<VippsConnection> AidAccountSettingsConnectionsVippsPostWithHttpInfo(string aid);
        /// <summary>
        /// Vipps signup
        /// </summary>
        /// <remarks>
        /// Reinitialize Vipps signup if connection is not enabled.  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>VippsConnection</returns>
        VippsConnection AidAccountSettingsConnectionsVippsPut(string aid);

        /// <summary>
        /// Vipps signup
        /// </summary>
        /// <remarks>
        /// Reinitialize Vipps signup if connection is not enabled.  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ApiResponse of VippsConnection</returns>
        ApiResponse<VippsConnection> AidAccountSettingsConnectionsVippsPutWithHttpInfo(string aid);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectionOnboardingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Bambora signup
        /// </summary>
        /// <remarks>
        /// Initialize Bambora signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BamboraConnection</returns>
        System.Threading.Tasks.Task<BamboraConnection> AidAccountSettingsConnectionsBamboraPostAsync(string aid, InlineObject4 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Bambora signup
        /// </summary>
        /// <remarks>
        /// Initialize Bambora signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BamboraConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<BamboraConnection>> AidAccountSettingsConnectionsBamboraPostWithHttpInfoAsync(string aid, InlineObject4 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Collector Bank signup
        /// </summary>
        /// <remarks>
        /// Initialize Collector Bank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectorConnection</returns>
        System.Threading.Tasks.Task<CollectorConnection> AidAccountSettingsConnectionsCollectorPostAsync(string aid, InlineObject5 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Collector Bank signup
        /// </summary>
        /// <remarks>
        /// Initialize Collector Bank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectorConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectorConnection>> AidAccountSettingsConnectionsCollectorPostWithHttpInfoAsync(string aid, InlineObject5 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Common signup
        /// </summary>
        /// <remarks>
        /// Initialize Common signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommonConnection</returns>
        System.Threading.Tasks.Task<CommonConnection> AidAccountSettingsConnectionsCommonPostAsync(string aid, InlineObject6 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Common signup
        /// </summary>
        /// <remarks>
        /// Initialize Common signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommonConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonConnection>> AidAccountSettingsConnectionsCommonPostWithHttpInfoAsync(string aid, InlineObject6 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Instabank signup
        /// </summary>
        /// <remarks>
        /// Initialize Instabank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InstabankConnection</returns>
        System.Threading.Tasks.Task<InstabankConnection> AidAccountSettingsConnectionsInstabankPostAsync(string aid, InlineObject7 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Instabank signup
        /// </summary>
        /// <remarks>
        /// Initialize Instabank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InstabankConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<InstabankConnection>> AidAccountSettingsConnectionsInstabankPostWithHttpInfoAsync(string aid, InlineObject7 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// PayEx signup
        /// </summary>
        /// <remarks>
        /// Initialize PayEx signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="paymentProductType"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PayExConnection</returns>
        System.Threading.Tasks.Task<PayExConnection> AidAccountSettingsConnectionsPayexPostAsync(string aid, string paymentProductType, InlineObject8 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// PayEx signup
        /// </summary>
        /// <remarks>
        /// Initialize PayEx signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="paymentProductType"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PayExConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<PayExConnection>> AidAccountSettingsConnectionsPayexPostWithHttpInfoAsync(string aid, string paymentProductType, InlineObject8 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Swish signup
        /// </summary>
        /// <remarks>
        /// Initialize Swish signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SwishConnection</returns>
        System.Threading.Tasks.Task<SwishConnection> AidAccountSettingsConnectionsSwishPostAsync(string aid, InlineObject9 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Swish signup
        /// </summary>
        /// <remarks>
        /// Initialize Swish signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SwishConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<SwishConnection>> AidAccountSettingsConnectionsSwishPostWithHttpInfoAsync(string aid, InlineObject9 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Vipps signup
        /// </summary>
        /// <remarks>
        /// Initialize Vipps signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VippsConnection</returns>
        System.Threading.Tasks.Task<VippsConnection> AidAccountSettingsConnectionsVippsPostAsync(string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Vipps signup
        /// </summary>
        /// <remarks>
        /// Initialize Vipps signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VippsConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<VippsConnection>> AidAccountSettingsConnectionsVippsPostWithHttpInfoAsync(string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Vipps signup
        /// </summary>
        /// <remarks>
        /// Reinitialize Vipps signup if connection is not enabled.  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VippsConnection</returns>
        System.Threading.Tasks.Task<VippsConnection> AidAccountSettingsConnectionsVippsPutAsync(string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Vipps signup
        /// </summary>
        /// <remarks>
        /// Reinitialize Vipps signup if connection is not enabled.  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VippsConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<VippsConnection>> AidAccountSettingsConnectionsVippsPutWithHttpInfoAsync(string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectionOnboardingApi : IConnectionOnboardingApiSync, IConnectionOnboardingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConnectionOnboardingApi : IConnectionOnboardingApi
    {
        private Dintero.OpenApiClient.Auth.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionOnboardingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectionOnboardingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionOnboardingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectionOnboardingApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ConnectionOnboardingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConnectionOnboardingApi(Dintero.OpenApiClient.Auth.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ConnectionOnboardingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ConnectionOnboardingApi(Dintero.OpenApiClient.Auth.Client.ISynchronousClient client, Dintero.OpenApiClient.Auth.Client.IAsynchronousClient asyncClient, Dintero.OpenApiClient.Auth.Client.IReadableConfiguration configuration)
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
        /// Bambora signup Initialize Bambora signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>BamboraConnection</returns>
        public BamboraConnection AidAccountSettingsConnectionsBamboraPost(string aid, InlineObject4 data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<BamboraConnection> localVarResponse = AidAccountSettingsConnectionsBamboraPostWithHttpInfo(aid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Bambora signup Initialize Bambora signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of BamboraConnection</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<BamboraConnection> AidAccountSettingsConnectionsBamboraPostWithHttpInfo(string aid, InlineObject4 data)
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsBamboraPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsBamboraPost");

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
            var localVarResponse = this.Client.Post<BamboraConnection>("/accounts/{aid}/management/settings/connections/bambora", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsBamboraPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Bambora signup Initialize Bambora signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BamboraConnection</returns>
        public async System.Threading.Tasks.Task<BamboraConnection> AidAccountSettingsConnectionsBamboraPostAsync(string aid, InlineObject4 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<BamboraConnection> localVarResponse = await AidAccountSettingsConnectionsBamboraPostWithHttpInfoAsync(aid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Bambora signup Initialize Bambora signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BamboraConnection)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<BamboraConnection>> AidAccountSettingsConnectionsBamboraPostWithHttpInfoAsync(string aid, InlineObject4 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsBamboraPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsBamboraPost");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<BamboraConnection>("/accounts/{aid}/management/settings/connections/bambora", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsBamboraPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Collector Bank signup Initialize Collector Bank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>CollectorConnection</returns>
        public CollectorConnection AidAccountSettingsConnectionsCollectorPost(string aid, InlineObject5 data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<CollectorConnection> localVarResponse = AidAccountSettingsConnectionsCollectorPostWithHttpInfo(aid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Collector Bank signup Initialize Collector Bank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of CollectorConnection</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<CollectorConnection> AidAccountSettingsConnectionsCollectorPostWithHttpInfo(string aid, InlineObject5 data)
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsCollectorPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsCollectorPost");

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
            var localVarResponse = this.Client.Post<CollectorConnection>("/accounts/{aid}/management/settings/connections/collector", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsCollectorPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Collector Bank signup Initialize Collector Bank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectorConnection</returns>
        public async System.Threading.Tasks.Task<CollectorConnection> AidAccountSettingsConnectionsCollectorPostAsync(string aid, InlineObject5 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<CollectorConnection> localVarResponse = await AidAccountSettingsConnectionsCollectorPostWithHttpInfoAsync(aid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Collector Bank signup Initialize Collector Bank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectorConnection)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<CollectorConnection>> AidAccountSettingsConnectionsCollectorPostWithHttpInfoAsync(string aid, InlineObject5 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsCollectorPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsCollectorPost");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<CollectorConnection>("/accounts/{aid}/management/settings/connections/collector", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsCollectorPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Common signup Initialize Common signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>CommonConnection</returns>
        public CommonConnection AidAccountSettingsConnectionsCommonPost(string aid, InlineObject6 data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<CommonConnection> localVarResponse = AidAccountSettingsConnectionsCommonPostWithHttpInfo(aid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Common signup Initialize Common signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of CommonConnection</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<CommonConnection> AidAccountSettingsConnectionsCommonPostWithHttpInfo(string aid, InlineObject6 data)
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsCommonPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsCommonPost");

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
            var localVarResponse = this.Client.Post<CommonConnection>("/accounts/{aid}/management/settings/connections/common", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsCommonPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Common signup Initialize Common signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommonConnection</returns>
        public async System.Threading.Tasks.Task<CommonConnection> AidAccountSettingsConnectionsCommonPostAsync(string aid, InlineObject6 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<CommonConnection> localVarResponse = await AidAccountSettingsConnectionsCommonPostWithHttpInfoAsync(aid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Common signup Initialize Common signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommonConnection)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<CommonConnection>> AidAccountSettingsConnectionsCommonPostWithHttpInfoAsync(string aid, InlineObject6 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsCommonPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsCommonPost");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<CommonConnection>("/accounts/{aid}/management/settings/connections/common", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsCommonPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Instabank signup Initialize Instabank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>InstabankConnection</returns>
        public InstabankConnection AidAccountSettingsConnectionsInstabankPost(string aid, InlineObject7 data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<InstabankConnection> localVarResponse = AidAccountSettingsConnectionsInstabankPostWithHttpInfo(aid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Instabank signup Initialize Instabank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of InstabankConnection</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<InstabankConnection> AidAccountSettingsConnectionsInstabankPostWithHttpInfo(string aid, InlineObject7 data)
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsInstabankPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsInstabankPost");

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
            var localVarResponse = this.Client.Post<InstabankConnection>("/accounts/{aid}/management/settings/connections/instabank", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsInstabankPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Instabank signup Initialize Instabank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InstabankConnection</returns>
        public async System.Threading.Tasks.Task<InstabankConnection> AidAccountSettingsConnectionsInstabankPostAsync(string aid, InlineObject7 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<InstabankConnection> localVarResponse = await AidAccountSettingsConnectionsInstabankPostWithHttpInfoAsync(aid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Instabank signup Initialize Instabank signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InstabankConnection)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<InstabankConnection>> AidAccountSettingsConnectionsInstabankPostWithHttpInfoAsync(string aid, InlineObject7 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsInstabankPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsInstabankPost");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<InstabankConnection>("/accounts/{aid}/management/settings/connections/instabank", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsInstabankPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// PayEx signup Initialize PayEx signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="paymentProductType"></param>
        /// <param name="data"></param>
        /// <returns>PayExConnection</returns>
        public PayExConnection AidAccountSettingsConnectionsPayexPost(string aid, string paymentProductType, InlineObject8 data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<PayExConnection> localVarResponse = AidAccountSettingsConnectionsPayexPostWithHttpInfo(aid, paymentProductType, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PayEx signup Initialize PayEx signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="paymentProductType"></param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of PayExConnection</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<PayExConnection> AidAccountSettingsConnectionsPayexPostWithHttpInfo(string aid, string paymentProductType, InlineObject8 data)
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsPayexPost");

            // verify the required parameter 'paymentProductType' is set
            if (paymentProductType == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'paymentProductType' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsPayexPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsPayexPost");

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
            localVarRequestOptions.PathParameters.Add("payment_product_type", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(paymentProductType)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<PayExConnection>("/accounts/{aid}/management/settings/connections/payex/{payment_product_type}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsPayexPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// PayEx signup Initialize PayEx signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="paymentProductType"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PayExConnection</returns>
        public async System.Threading.Tasks.Task<PayExConnection> AidAccountSettingsConnectionsPayexPostAsync(string aid, string paymentProductType, InlineObject8 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<PayExConnection> localVarResponse = await AidAccountSettingsConnectionsPayexPostWithHttpInfoAsync(aid, paymentProductType, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PayEx signup Initialize PayEx signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="paymentProductType"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PayExConnection)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<PayExConnection>> AidAccountSettingsConnectionsPayexPostWithHttpInfoAsync(string aid, string paymentProductType, InlineObject8 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsPayexPost");

            // verify the required parameter 'paymentProductType' is set
            if (paymentProductType == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'paymentProductType' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsPayexPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsPayexPost");


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
            localVarRequestOptions.PathParameters.Add("payment_product_type", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(paymentProductType)); // path parameter
            localVarRequestOptions.Data = data;

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PayExConnection>("/accounts/{aid}/management/settings/connections/payex/{payment_product_type}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsPayexPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Swish signup Initialize Swish signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>SwishConnection</returns>
        public SwishConnection AidAccountSettingsConnectionsSwishPost(string aid, InlineObject9 data)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<SwishConnection> localVarResponse = AidAccountSettingsConnectionsSwishPostWithHttpInfo(aid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Swish signup Initialize Swish signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of SwishConnection</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<SwishConnection> AidAccountSettingsConnectionsSwishPostWithHttpInfo(string aid, InlineObject9 data)
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsSwishPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsSwishPost");

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
            var localVarResponse = this.Client.Post<SwishConnection>("/accounts/{aid}/management/settings/connections/swish", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsSwishPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Swish signup Initialize Swish signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SwishConnection</returns>
        public async System.Threading.Tasks.Task<SwishConnection> AidAccountSettingsConnectionsSwishPostAsync(string aid, InlineObject9 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<SwishConnection> localVarResponse = await AidAccountSettingsConnectionsSwishPostWithHttpInfoAsync(aid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Swish signup Initialize Swish signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SwishConnection)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<SwishConnection>> AidAccountSettingsConnectionsSwishPostWithHttpInfoAsync(string aid, InlineObject9 data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsSwishPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'data' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsSwishPost");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<SwishConnection>("/accounts/{aid}/management/settings/connections/swish", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsSwishPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Vipps signup Initialize Vipps signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>VippsConnection</returns>
        public VippsConnection AidAccountSettingsConnectionsVippsPost(string aid)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<VippsConnection> localVarResponse = AidAccountSettingsConnectionsVippsPostWithHttpInfo(aid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Vipps signup Initialize Vipps signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ApiResponse of VippsConnection</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<VippsConnection> AidAccountSettingsConnectionsVippsPostWithHttpInfo(string aid)
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsVippsPost");

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

            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<VippsConnection>("/accounts/{aid}/management/settings/connections/vipps", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsVippsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Vipps signup Initialize Vipps signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VippsConnection</returns>
        public async System.Threading.Tasks.Task<VippsConnection> AidAccountSettingsConnectionsVippsPostAsync(string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<VippsConnection> localVarResponse = await AidAccountSettingsConnectionsVippsPostWithHttpInfoAsync(aid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Vipps signup Initialize Vipps signup  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VippsConnection)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<VippsConnection>> AidAccountSettingsConnectionsVippsPostWithHttpInfoAsync(string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsVippsPost");


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

            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<VippsConnection>("/accounts/{aid}/management/settings/connections/vipps", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsVippsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Vipps signup Reinitialize Vipps signup if connection is not enabled.  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>VippsConnection</returns>
        public VippsConnection AidAccountSettingsConnectionsVippsPut(string aid)
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<VippsConnection> localVarResponse = AidAccountSettingsConnectionsVippsPutWithHttpInfo(aid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Vipps signup Reinitialize Vipps signup if connection is not enabled.  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <returns>ApiResponse of VippsConnection</returns>
        public Dintero.OpenApiClient.Auth.Client.ApiResponse<VippsConnection> AidAccountSettingsConnectionsVippsPutWithHttpInfo(string aid)
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsVippsPut");

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

            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<VippsConnection>("/accounts/{aid}/management/settings/connections/vipps", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsVippsPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Vipps signup Reinitialize Vipps signup if connection is not enabled.  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VippsConnection</returns>
        public async System.Threading.Tasks.Task<VippsConnection> AidAccountSettingsConnectionsVippsPutAsync(string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Auth.Client.ApiResponse<VippsConnection> localVarResponse = await AidAccountSettingsConnectionsVippsPutWithHttpInfoAsync(aid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Vipps signup Reinitialize Vipps signup if connection is not enabled.  Requires the account company to be configured with &#x60;organization_number&#x60; [PUT /management/settings](#operation/aid_account_settings_put)  scopes: - admin:accounts - write:accounts 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Auth.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">An id that uniquely identifies the account. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VippsConnection)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Auth.Client.ApiResponse<VippsConnection>> AidAccountSettingsConnectionsVippsPutWithHttpInfoAsync(string aid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'aid' is set
            if (aid == null)
                throw new Dintero.OpenApiClient.Auth.Client.ApiException(400, "Missing required parameter 'aid' when calling ConnectionOnboardingApi->AidAccountSettingsConnectionsVippsPut");


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

            localVarRequestOptions.PathParameters.Add("aid", Dintero.OpenApiClient.Auth.Client.ClientUtils.ParameterToString(aid)); // path parameter

            // authentication (JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<VippsConnection>("/accounts/{aid}/management/settings/connections/vipps", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AidAccountSettingsConnectionsVippsPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
