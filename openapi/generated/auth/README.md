# Dintero.OpenApiClient.Auth - the C# library for the Account Management API

API for managing accounts and authentication

# Changelog
All notable changes to the API.

## 2021-06-01

> Add support for configuring SMS MFA for account user
> - [PUT /v1/account/user/mfa/sms](#operation/account_user_mfa_sms_put)

## 2021-05-01

> Add support for `phone_number` in `account.company` and `account.billing`
> - [PUT /v1/accounts/{aid}/management/settings](#operation/aid_account_settings_put)
> - [PUT /v1/accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_put)

> Add new endpoints for managing Bambora connection
> - [POST /management/settings/connections/bambora](#operation/aid_account_settings_connections_bambora_post)
> - [GET /management/settings/connections/bambora](#operation/aid_account_settings_connections_bambora_get)
> - [POST /management/settings/connections/bambora/{callback_reference}](#operation/aid_account_settings_connections_bambora_callback_post)

## 2021-04-01

> Add support for `account_manager`
> - [POST /accounts/{oid}/signup](#operation/accounts_oid_signup_post)
> - [POST /accounts/{oid}/signup/prefill](#operation/accounts_oid_signup_prefill_post)
> - [GET /v1/accounts/{oid}/management/accounts](#operation/aid_mgmnt_accounts_get)
> - [PUT /v1/accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_put)
> - [GET /v1/accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_get)

> Add support for filter on services and connections.
> - [GET /v1/accounts/{oid}/management/accounts](#operation/aid_mgmnt_accounts_get)

> Extend the Account to support new properties, `progression`, `reseller_id` and
`statistics` to services.
> - [GET /v1/accounts/{oid}/management/accounts](#operation/aid_mgmnt_accounts_get)
> - [PUT /v1/accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_put)
> - [GET /v1/accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_get)

> Add support for account events.
> - [POST /v1/accounts/{oid}/management/accounts/{aid}/events](#operation/aid_mgmnt_accounts_events_post)
> - [GET /v1/accounts/{oid}/management/accounts/{aid}/events](#operation/aid_mgmnt_accounts_events_get)

## 2021-03-01

> Make Swish cert and passphrase not required
> - [POST /v1/accounts/{aid}/management/settings/connections/swish/{callback_reference}](#operation/aid_account_settings_connections_swish_callback_post)

> Add support for changing account user password
> - [PUT /v1/accounts/{aid}/account/user/password](#operation/account_user_password_put)

> Add support for `authorize` when verifying a signup.
> - [POST /v1/accounts/{aid}/signup/verify](#operation/accounts_oid_signup_verify_post)

## 2021-02-01

> Document `429 Too Many Requests` response from
> - [POST /v1/accounts/{aid}/auth/token](#operation/aid_auths_oauth_token_post)
> - [POST /v1/accounts/{aid}/auth/passwordless](#operation/aid_auth_account_passwordless_post)

> **Break**: Require `ident_type` and `ident` to be include when requesting token
> with `grant_type=authorization_code`
> - [POST /v1/accounts/{aid}/auth/token](#operation/aid_auths_oauth_token_post)

> Add support for sending verification code for passwordless login via SMS, and
> `session_id={uuid} to resend the same verification code again
> Remove unsupported request options, `send=link` and `type=account`.
> - [POST /v1/accounts/{aid}/auth/passwordless](#operation/aid_auth_account_passwordless_post)

## 2021-01-01

> Add support for logging on without MFA even if configured with MFA
> - [POST /v1/accounts/{oid}/auth/token](#operation/aid_auths_oauth_token_post)

> Add support for managing account users scopes with roles.
> - [Roles](#tag/roles)
> - [POST /management/users](#operation/aid_accounts_aid_mgmnt_users_post)
> - [PUT /management/users/{uid}](#operation/aid_accounts_aid_mgmnt_users_put)

## 2020-11-01

> Extend the endpoint for getting user accounts to include the accounts
> `display_name` and `icon_url`.
>
> - [GET /account/user](#operation/account_user_get)

> Add support for account users authenticated by external Identity providers.
> External authentication is limited to account users created with
> `authentication_type=external`.
>
> - [POST /management/users](#operation/aid_accounts_aid_mgmnt_users_get)
>
> Following endpoints has been updated to allow Bearer authorization using
> ID token issued by external Identity provider.
>
> - [GET /account/user](#operation/account_user_get)
> - [POST /auth/token](#operation/aid_auths_oauth_token_post)
>
> Account has been updated with `jwks.uri` property that is required to
> validate the ID tokens issued by external identity providers.

## 2020-09-01

> Add new endpoint for handling HTTP redirect with ID token query parameter
> - [POST /auth/redirect](#operation/aid_auths_oauth_redirect_post)

> Add new endpoint for uploading assets
> - [POST /management/assets](#tag/account-assets)

## 2020-07-01

> Add new endpoints for managing Swish connection
> - [POST /management/settings/connections/swish](#operation/aid_account_settings_connections_swish_post)
> - [GET /management/settings/connections/swish](#operation/aid_account_settings_connections_swish_get)
> - [POST /management/settings/connections/swish/{callback_reference}](#operation/aid_account_settings_connections_swish_callback_post)

## 2020-05-01

> Extend the AccountCompany with `email` and `technical_email`
> - [PUT /accounts/{aid}/management/settings](#operation/aid_account_settings_put)
> - [POST /accounts/{oid}/management/accounts](#operation/aid_mgmnt_accounts_post)
> - [PUT /accounts/{oid}/management/accounts/{aid}](#operation/aid_accounts_aid_put)

## 2020-01-31

> Add support for `applicant.agreement.attachments`
> - [POST /accounts/{oid}/signup](http://localhost:8080/#operation/accounts_oid_signup_post)
>

> Add support for enabling MFA (OOB) for auth users.
> - [POST /auth/users](#operation/aid_auth_users_post)

## 2019-12-31

> Extend the AccountApplicant with support for
> `promo_code` and utm campaign codes.
> - [POST /signup](#operation/accounts_oid_signup_post)

## 2019-11-31

> Add support for creating client with description
> - [POST /auth/clients](#operation/aid_auth_clients_post)

## 2019-09-31

> Extend settings with PayEx connections
> - [GET /management/settings](#operation/aid_account_aid_get)
> - [GET /management/accounts](#operation/aid_mgmnt_accounts_get)

## 2019-07-31

> Add new endpoints for managing PayEx connection
> - [POST /management/settings/connections/payex/{payment_product_type}](#operation/aid_account_settings_connections_payex_post)
> - [GET /management/settings/connections/payex/{payment_product_type}](#operation/aid_account_settings_connections_payex_get)
> - [POST /management/settings/connections/payex/{payment_product_type}/{callback_reference}](#operation/aid_account_settings_connections_payex_callback_post)

## 2019-06-31

> The scope required for accessing endpoint has changed,
> we will continue to support the old scopes but they was removed from
> the documentation

> Support `search`, `limit` and `starting_after` query parameter
> when listing partner accounts
> - [GET /management/accounts](#operation/aid_mgmnt_accounts_get)

> Support for issuing exchange token for a sub-account,
> to allow partner accounts to manage sub accounts.
> - [POST /auth/impersonate_token](#operation/aid_auths_oauth_exchange_token_post)

## 2019-05-31

> Support for including a Refresh Token when requesting
> an Access Token. Use `grant-type=refresh_token` to get an Access Token
> from a Refresh Token.
> - [POST /auth/token](#operation/aid_auths_oauth_token_post)

> Support for revoking a Refresh Token
> - [POST /auth/revoke](#operation/aid_auths_oauth_revoke_post)

## 2018-12-17

> Rename typo in Account definition
> All `bussiness_name` properties renamed to `business_name`



This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: LATEST
- SDK version: 1.0.0
- Build date: 2021-06-16T11:27:15.528247Z[Etc/UTC]
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Dintero.OpenApiClient.Auth.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AccountAssetsApi(config);
            var aid = aid_example;  // string | An id that uniquely identifies the account. 
            var data = new InlineObject2(); // InlineObject2 | 

            try
            {
                // Create asset upload url
                InlineResponse2002 result = apiInstance.AidAccountAssetsPost(aid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountAssetsApi.AidAccountAssetsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountAssetsApi* | [**AidAccountAssetsPost**](docs/AccountAssetsApi.md#aidaccountassetspost) | **POST** /accounts/{aid}/management/assets | Create asset upload url
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsBamboraCallbackPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsbamboracallbackpost) | **POST** /accounts/{aid}/management/settings/connections/bambora/{callback_reference} | Bambora Callback
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsBamboraGet**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsbamboraget) | **GET** /accounts/{aid}/management/settings/connections/bambora | Get Bambora signup status
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsBamboraPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsbamborapost) | **POST** /accounts/{aid}/management/settings/connections/bambora | Bambora signup
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsCollectorCallbackPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionscollectorcallbackpost) | **POST** /accounts/{aid}/management/settings/connections/collector/{callback_reference} | Collector Bank Callback
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsCollectorGet**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionscollectorget) | **GET** /accounts/{aid}/management/settings/connections/collector | Get Collector Bank signup status
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsCollectorPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionscollectorpost) | **POST** /accounts/{aid}/management/settings/connections/collector | Collector Bank signup
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsCommonGet**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionscommonget) | **GET** /accounts/{aid}/management/settings/connections/common | Get Common signup status
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsCommonPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionscommonpost) | **POST** /accounts/{aid}/management/settings/connections/common | Common signup
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsInstabankCallbackPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsinstabankcallbackpost) | **POST** /accounts/{aid}/management/settings/connections/instabank/{callback_reference} | Instabank Callback
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsInstabankGet**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsinstabankget) | **GET** /accounts/{aid}/management/settings/connections/instabank | Get Instabank signup status
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsInstabankPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsinstabankpost) | **POST** /accounts/{aid}/management/settings/connections/instabank | Instabank signup
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsPayexCallbackPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionspayexcallbackpost) | **POST** /accounts/{aid}/management/settings/connections/payex/{payment_product_type}/{callback_reference} | PayEx Callback
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsPayexGet**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionspayexget) | **GET** /accounts/{aid}/management/settings/connections/payex/{payment_product_type} | Get PayEx signup status
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsPayexPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionspayexpost) | **POST** /accounts/{aid}/management/settings/connections/payex/{payment_product_type} | PayEx signup
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsSwishCallbackPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsswishcallbackpost) | **POST** /accounts/{aid}/management/settings/connections/swish/{callback_reference} | Swish Callback
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsSwishGet**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsswishget) | **GET** /accounts/{aid}/management/settings/connections/swish | Get Swish signup status
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsSwishPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsswishpost) | **POST** /accounts/{aid}/management/settings/connections/swish | Swish signup
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsVippsCallbackPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsvippscallbackpost) | **POST** /accounts/{aid}/management/settings/connections/vipps/{callback_reference} | Vipps Callback
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsVippsGet**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsvippsget) | **GET** /accounts/{aid}/management/settings/connections/vipps | Get Vipps signup status
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsVippsPost**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsvippspost) | **POST** /accounts/{aid}/management/settings/connections/vipps | Vipps signup
*AccountConnectionsApi* | [**AidAccountSettingsConnectionsVippsPut**](docs/AccountConnectionsApi.md#aidaccountsettingsconnectionsvippsput) | **PUT** /accounts/{aid}/management/settings/connections/vipps | Vipps signup
*AccountOnboardingApi* | [**AccountsOidSignupPost**](docs/AccountOnboardingApi.md#accountsoidsignuppost) | **POST** /accounts/{oid}/signup | Signup to Dintero Account
*AccountOnboardingApi* | [**AccountsOidSignupVerifyPost**](docs/AccountOnboardingApi.md#accountsoidsignupverifypost) | **POST** /accounts/{oid}/signup/verify | Verify signup
*AccountOnboardingPrefillApi* | [**AccountsOidSignupPrefillAcceptPost**](docs/AccountOnboardingPrefillApi.md#accountsoidsignupprefillacceptpost) | **POST** /accounts/{oid}/signup/prefill/{prefill_id} | Accept pre-filled sign up for a new Dintero Account
*AccountOnboardingPrefillApi* | [**AccountsOidSignupPrefillGet**](docs/AccountOnboardingPrefillApi.md#accountsoidsignupprefillget) | **GET** /accounts/{oid}/signup/prefill/{prefill_id} | Get pending pre-filled sign up for a new Dintero Account
*AccountOnboardingPrefillApi* | [**AccountsOidSignupPrefillPost**](docs/AccountOnboardingPrefillApi.md#accountsoidsignupprefillpost) | **POST** /accounts/{oid}/signup/prefill | Pre-fill a sign up for a new Dintero Account
*AccountSettingsApi* | [**AidAccountAidGet**](docs/AccountSettingsApi.md#aidaccountaidget) | **GET** /accounts/{aid}/management/settings | Get Account settings
*AccountSettingsApi* | [**AidAccountSettingsPut**](docs/AccountSettingsApi.md#aidaccountsettingsput) | **PUT** /accounts/{aid}/management/settings | Update Account Settings
*AccountUsersApi* | [**AccountUserGet**](docs/AccountUsersApi.md#accountuserget) | **GET** /account/user | Authenticated User
*AccountUsersApi* | [**AccountUserMfaSmsPut**](docs/AccountUsersApi.md#accountusermfasmsput) | **PUT** /account/user/mfa/sms | Configure SMS MFA
*AccountUsersApi* | [**AccountUserPasswordPut**](docs/AccountUsersApi.md#accountuserpasswordput) | **POST** /account/user/password | Change User password
*AccountUsersApi* | [**AidAccountsAidMgmntUsersActivitiesGet**](docs/AccountUsersApi.md#aidaccountsaidmgmntusersactivitiesget) | **GET** /accounts/{oid}/management/users/{uid}/activities | Get user activity log
*AccountUsersApi* | [**AidAccountsAidMgmntUsersDelete**](docs/AccountUsersApi.md#aidaccountsaidmgmntusersdelete) | **DELETE** /accounts/{oid}/management/users/{uid} | Delete User
*AccountUsersApi* | [**AidAccountsAidMgmntUsersGet**](docs/AccountUsersApi.md#aidaccountsaidmgmntusersget) | **GET** /accounts/{oid}/management/users | Users Collection
*AccountUsersApi* | [**AidAccountsAidMgmntUsersPost**](docs/AccountUsersApi.md#aidaccountsaidmgmntuserspost) | **POST** /accounts/{oid}/management/users | Create User
*AccountUsersApi* | [**AidAccountsAidMgmntUsersPut**](docs/AccountUsersApi.md#aidaccountsaidmgmntusersput) | **PUT** /accounts/{oid}/management/users/{uid} | Update User
*AccountsApi* | [**AidAccountsAidConnectionsEventsPost**](docs/AccountsApi.md#aidaccountsaidconnectionseventspost) | **POST** /accounts/{oid}/management/accounts/{aid}/connections/{connection}/events | Update connection status
*AccountsApi* | [**AidAccountsAidGet**](docs/AccountsApi.md#aidaccountsaidget) | **GET** /accounts/{oid}/management/accounts/{aid} | Get Account
*AccountsApi* | [**AidAccountsAidPut**](docs/AccountsApi.md#aidaccountsaidput) | **PUT** /accounts/{oid}/management/accounts/{aid} | Update Account
*AccountsApi* | [**AidMgmntAccountsAidDelete**](docs/AccountsApi.md#aidmgmntaccountsaiddelete) | **DELETE** /accounts/{oid}/management/accounts/{aid} | Delete Account
*AccountsApi* | [**AidMgmntAccountsEventsGet**](docs/AccountsApi.md#aidmgmntaccountseventsget) | **GET** /accounts/{oid}/management/accounts/{aid}/events | Account events
*AccountsApi* | [**AidMgmntAccountsEventsPost**](docs/AccountsApi.md#aidmgmntaccountseventspost) | **POST** /accounts/{oid}/management/accounts/{aid}/events | Create Account Event
*AccountsApi* | [**AidMgmntAccountsGet**](docs/AccountsApi.md#aidmgmntaccountsget) | **GET** /accounts/{oid}/management/accounts | Accounts collection
*AccountsApi* | [**AidMgmntAccountsPost**](docs/AccountsApi.md#aidmgmntaccountspost) | **POST** /accounts/{oid}/management/accounts | Create Account
*AuthUsersApi* | [**AidAuthUsersPost**](docs/AuthUsersApi.md#aidauthuserspost) | **POST** /accounts/{aid}/auth/users | Create User
*AuthUsersApi* | [**AidAuthUsersUsernameChangeUsernamePost**](docs/AuthUsersApi.md#aidauthusersusernamechangeusernamepost) | **POST** /accounts/{aid}/auth/users/{username}/change_username | Change username
*AuthUsersApi* | [**AidAuthUsersUsernameDelete**](docs/AuthUsersApi.md#aidauthusersusernamedelete) | **DELETE** /accounts/{aid}/auth/users/{username} | Delete user
*AuthUsersApi* | [**AidAuthUsersUsernamePut**](docs/AuthUsersApi.md#aidauthusersusernameput) | **PUT** /accounts/{aid}/auth/users/{username} | Update user
*AuthenticateApi* | [**AidAuthAccountPasswordlessPost**](docs/AuthenticateApi.md#aidauthaccountpasswordlesspost) | **POST** /accounts/{oid}/auth/passwordless | Passwordless
*AuthenticateApi* | [**AidAuthPasswordlessPost**](docs/AuthenticateApi.md#aidauthpasswordlesspost) | **POST** /accounts/{oid}/auth/passwordless/code | Passwordless Code
*AuthenticateApi* | [**AidAuthsOauthAuthorizePost**](docs/AuthenticateApi.md#aidauthsoauthauthorizepost) | **POST** /accounts/{oid}/auth/authorize | Authorize Passwordless link
*AuthenticateApi* | [**AidAuthsOauthExchangeTokenPost**](docs/AuthenticateApi.md#aidauthsoauthexchangetokenpost) | **POST** /accounts/{partner_id}/auth/exchange_token | Exchange Token
*AuthenticateApi* | [**AidAuthsOauthRedirectPost**](docs/AuthenticateApi.md#aidauthsoauthredirectpost) | **POST** /accounts/{oid}/auth/redirect | Redirect with ID token
*AuthenticateApi* | [**AidAuthsOauthRevokePost**](docs/AuthenticateApi.md#aidauthsoauthrevokepost) | **POST** /accounts/{oid}/auth/revoke | Revoke Token
*AuthenticateApi* | [**AidAuthsOauthTokenPost**](docs/AuthenticateApi.md#aidauthsoauthtokenpost) | **POST** /accounts/{oid}/auth/token | Get Token
*ChallengeApi* | [**AidAuthMfaChallengePost**](docs/ChallengeApi.md#aidauthmfachallengepost) | **POST** /accounts/{aid}/auth/mfa/challenge | Challenge request
*ChallengeApi* | [**AidAuthMfaRecoveryPost**](docs/ChallengeApi.md#aidauthmfarecoverypost) | **POST** /accounts/{aid}/auth/mfa/recovery | Recovery
*ClientsApi* | [**AidAuthClientsGet**](docs/ClientsApi.md#aidauthclientsget) | **GET** /accounts/{oid}/auth/clients | Clients collection
*ClientsApi* | [**AidAuthClientsPost**](docs/ClientsApi.md#aidauthclientspost) | **POST** /accounts/{oid}/auth/clients | Create Client
*ClientsApi* | [**AidAuthsClientsIdDelete**](docs/ClientsApi.md#aidauthsclientsiddelete) | **DELETE** /accounts/{oid}/auth/clients/{id} | Delete Client
*ClientsApi* | [**AidAuthsClientsIdGet**](docs/ClientsApi.md#aidauthsclientsidget) | **GET** /accounts/{oid}/auth/clients/{id} | Get Client
*ClientsApi* | [**AidAuthsClientsIdRotatePost**](docs/ClientsApi.md#aidauthsclientsidrotatepost) | **POST** /accounts/{oid}/auth/clients/{id}/rotate-secret | Rotate a client secret.
*ConnectionOnboardingApi* | [**AidAccountSettingsConnectionsBamboraPost**](docs/ConnectionOnboardingApi.md#aidaccountsettingsconnectionsbamborapost) | **POST** /accounts/{aid}/management/settings/connections/bambora | Bambora signup
*ConnectionOnboardingApi* | [**AidAccountSettingsConnectionsCollectorPost**](docs/ConnectionOnboardingApi.md#aidaccountsettingsconnectionscollectorpost) | **POST** /accounts/{aid}/management/settings/connections/collector | Collector Bank signup
*ConnectionOnboardingApi* | [**AidAccountSettingsConnectionsCommonPost**](docs/ConnectionOnboardingApi.md#aidaccountsettingsconnectionscommonpost) | **POST** /accounts/{aid}/management/settings/connections/common | Common signup
*ConnectionOnboardingApi* | [**AidAccountSettingsConnectionsInstabankPost**](docs/ConnectionOnboardingApi.md#aidaccountsettingsconnectionsinstabankpost) | **POST** /accounts/{aid}/management/settings/connections/instabank | Instabank signup
*ConnectionOnboardingApi* | [**AidAccountSettingsConnectionsPayexPost**](docs/ConnectionOnboardingApi.md#aidaccountsettingsconnectionspayexpost) | **POST** /accounts/{aid}/management/settings/connections/payex/{payment_product_type} | PayEx signup
*ConnectionOnboardingApi* | [**AidAccountSettingsConnectionsSwishPost**](docs/ConnectionOnboardingApi.md#aidaccountsettingsconnectionsswishpost) | **POST** /accounts/{aid}/management/settings/connections/swish | Swish signup
*ConnectionOnboardingApi* | [**AidAccountSettingsConnectionsVippsPost**](docs/ConnectionOnboardingApi.md#aidaccountsettingsconnectionsvippspost) | **POST** /accounts/{aid}/management/settings/connections/vipps | Vipps signup
*ConnectionOnboardingApi* | [**AidAccountSettingsConnectionsVippsPut**](docs/ConnectionOnboardingApi.md#aidaccountsettingsconnectionsvippsput) | **PUT** /accounts/{aid}/management/settings/connections/vipps | Vipps signup
*GrantsApi* | [**AidAuthsClientGrantsGet**](docs/GrantsApi.md#aidauthsclientgrantsget) | **GET** /accounts/{oid}/auth/client-grants | Client grants collection
*GrantsApi* | [**AidAuthsClientGrantsIdDelete**](docs/GrantsApi.md#aidauthsclientgrantsiddelete) | **DELETE** /accounts/{oid}/auth/client-grants/{id} | Delete client grant 
*GrantsApi* | [**AidAuthsClientGrantsPost**](docs/GrantsApi.md#aidauthsclientgrantspost) | **POST** /accounts/{oid}/auth/client-grants | Create client grant
*KeysApi* | [**AidAuthsKeysGet**](docs/KeysApi.md#aidauthskeysget) | **GET** /accounts/{oid}/auth/keys | Get public keys
*RolesApi* | [**AidAuthsRolesGet**](docs/RolesApi.md#aidauthsrolesget) | **GET** /accounts/{oid}/auth/roles | Roles collection
*RolesApi* | [**AidAuthsRolesIdDelete**](docs/RolesApi.md#aidauthsrolesiddelete) | **DELETE** /accounts/{oid}/auth/roles/{role_id} | Delete role 
*RolesApi* | [**AidAuthsRolesIdGet**](docs/RolesApi.md#aidauthsrolesidget) | **GET** /accounts/{oid}/auth/roles/{role_id} | Get role 
*RolesApi* | [**AidAuthsRolesIdPut**](docs/RolesApi.md#aidauthsrolesidput) | **PUT** /accounts/{oid}/auth/roles/{role_id} | Update role 
*RolesApi* | [**AidAuthsRolesPost**](docs/RolesApi.md#aidauthsrolespost) | **POST** /accounts/{oid}/auth/roles | Create a role


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccessToken](docs/AccessToken.md)
 - [Model.Account](docs/Account.md)
 - [Model.AccountAllOf](docs/AccountAllOf.md)
 - [Model.AccountAllOfConnections](docs/AccountAllOfConnections.md)
 - [Model.AccountAllOfConnectionsPayex](docs/AccountAllOfConnectionsPayex.md)
 - [Model.AccountAllOfServices](docs/AccountAllOfServices.md)
 - [Model.AccountApplicant](docs/AccountApplicant.md)
 - [Model.AccountApplicantAgreement](docs/AccountApplicantAgreement.md)
 - [Model.AccountApplicantAgreementAttachments](docs/AccountApplicantAgreementAttachments.md)
 - [Model.AccountBilling](docs/AccountBilling.md)
 - [Model.AccountCheckoutGateway](docs/AccountCheckoutGateway.md)
 - [Model.AccountCompany](docs/AccountCompany.md)
 - [Model.AccountCompanyBranding](docs/AccountCompanyBranding.md)
 - [Model.AccountConnection](docs/AccountConnection.md)
 - [Model.AccountConnectionAllOf](docs/AccountConnectionAllOf.md)
 - [Model.AccountConnectionAllOfConfiguration](docs/AccountConnectionAllOfConfiguration.md)
 - [Model.AccountConnectionAllOfConfigurationPaymentOptions](docs/AccountConnectionAllOfConfigurationPaymentOptions.md)
 - [Model.AccountConnectionEvent](docs/AccountConnectionEvent.md)
 - [Model.AccountConnectionMeta](docs/AccountConnectionMeta.md)
 - [Model.AccountEvent](docs/AccountEvent.md)
 - [Model.AccountEventComment](docs/AccountEventComment.md)
 - [Model.AccountEventCommentAllOf](docs/AccountEventCommentAllOf.md)
 - [Model.AccountEventStatistics](docs/AccountEventStatistics.md)
 - [Model.AccountEventStatisticsAllOf](docs/AccountEventStatisticsAllOf.md)
 - [Model.AccountJwks](docs/AccountJwks.md)
 - [Model.AccountJwksJwks](docs/AccountJwksJwks.md)
 - [Model.AccountMonthlyStatistics](docs/AccountMonthlyStatistics.md)
 - [Model.AccountMonthlyStatisticsCheckout](docs/AccountMonthlyStatisticsCheckout.md)
 - [Model.AccountMonthlyStatisticsShopping](docs/AccountMonthlyStatisticsShopping.md)
 - [Model.AccountPrivateDetails](docs/AccountPrivateDetails.md)
 - [Model.AccountPrivateDetailsAccountManager](docs/AccountPrivateDetailsAccountManager.md)
 - [Model.AccountPrivateDetailsStatistics](docs/AccountPrivateDetailsStatistics.md)
 - [Model.AccountService](docs/AccountService.md)
 - [Model.AccountSignupPreFillRequest](docs/AccountSignupPreFillRequest.md)
 - [Model.AccountSignupRequest](docs/AccountSignupRequest.md)
 - [Model.AccountSignupRequestExternalIntegrations](docs/AccountSignupRequestExternalIntegrations.md)
 - [Model.AccountSignupRequestExternalIntegrationsWallmobSignup](docs/AccountSignupRequestExternalIntegrationsWallmobSignup.md)
 - [Model.AccountUser](docs/AccountUser.md)
 - [Model.AccountUserAllOf](docs/AccountUserAllOf.md)
 - [Model.AccountUserConfig](docs/AccountUserConfig.md)
 - [Model.AccountUserConfigMfa](docs/AccountUserConfigMfa.md)
 - [Model.AccountUserConfigMfaSms](docs/AccountUserConfigMfaSms.md)
 - [Model.AccountUserResponse](docs/AccountUserResponse.md)
 - [Model.AccountUserResponseAllOf](docs/AccountUserResponseAllOf.md)
 - [Model.AccountsAidManagementSettingsConnectionsVippsCallbackReferenceSubscriptionKeys](docs/AccountsAidManagementSettingsConnectionsVippsCallbackReferenceSubscriptionKeys.md)
 - [Model.AccountsOidManagementUsersRoles](docs/AccountsOidManagementUsersRoles.md)
 - [Model.Address](docs/Address.md)
 - [Model.AuditEvent](docs/AuditEvent.md)
 - [Model.AuthChallenge](docs/AuthChallenge.md)
 - [Model.AuthChallengeAllOf](docs/AuthChallengeAllOf.md)
 - [Model.AuthRole](docs/AuthRole.md)
 - [Model.AuthToken](docs/AuthToken.md)
 - [Model.AuthUser](docs/AuthUser.md)
 - [Model.AuthUserAllOf](docs/AuthUserAllOf.md)
 - [Model.AuthUserMfa](docs/AuthUserMfa.md)
 - [Model.AuthenticatedAccountUser](docs/AuthenticatedAccountUser.md)
 - [Model.AuthenticatedAccountUserAccounts](docs/AuthenticatedAccountUserAccounts.md)
 - [Model.AuthenticatedAccountUserUser](docs/AuthenticatedAccountUserUser.md)
 - [Model.AuthorizationCode](docs/AuthorizationCode.md)
 - [Model.AuthorizationCodeAllOf](docs/AuthorizationCodeAllOf.md)
 - [Model.BamboraConnection](docs/BamboraConnection.md)
 - [Model.BamboraConnectionAllOf](docs/BamboraConnectionAllOf.md)
 - [Model.BamboraConnectionCallback](docs/BamboraConnectionCallback.md)
 - [Model.BamboraConnectionCallbackPaymentOptions](docs/BamboraConnectionCallbackPaymentOptions.md)
 - [Model.BamboraConnectionConfiguration](docs/BamboraConnectionConfiguration.md)
 - [Model.BamboraConnectionSignup](docs/BamboraConnectionSignup.md)
 - [Model.BamboraConnectionSignupApplicant](docs/BamboraConnectionSignupApplicant.md)
 - [Model.BamboraConnectionSignupOwnership](docs/BamboraConnectionSignupOwnership.md)
 - [Model.BamboraConnectionSignupOwnershipOwners](docs/BamboraConnectionSignupOwnershipOwners.md)
 - [Model.BamboraConnectionSignupPaymentOptions](docs/BamboraConnectionSignupPaymentOptions.md)
 - [Model.BamboraConnectionSignupRevenue](docs/BamboraConnectionSignupRevenue.md)
 - [Model.BamboraConnectionSignupSignature](docs/BamboraConnectionSignupSignature.md)
 - [Model.BamboraConnectionSignupSignatureSignatures](docs/BamboraConnectionSignupSignatureSignatures.md)
 - [Model.BamboraConnectionSignupVerifications](docs/BamboraConnectionSignupVerifications.md)
 - [Model.Challenge](docs/Challenge.md)
 - [Model.CheckoutAccountService](docs/CheckoutAccountService.md)
 - [Model.CheckoutAccountServiceAllOf](docs/CheckoutAccountServiceAllOf.md)
 - [Model.CheckoutAccountServiceAllOfGateways](docs/CheckoutAccountServiceAllOfGateways.md)
 - [Model.CheckoutAccountServiceAllOfGatewaysPayex](docs/CheckoutAccountServiceAllOfGatewaysPayex.md)
 - [Model.ClientAllOf](docs/ClientAllOf.md)
 - [Model.ClientCredentials](docs/ClientCredentials.md)
 - [Model.ClientCredentialsAllOf](docs/ClientCredentialsAllOf.md)
 - [Model.CollectorConnection](docs/CollectorConnection.md)
 - [Model.CollectorConnectionAllOf](docs/CollectorConnectionAllOf.md)
 - [Model.CollectorConnectionCallback](docs/CollectorConnectionCallback.md)
 - [Model.CollectorConnectionCallbackPaymentOptions](docs/CollectorConnectionCallbackPaymentOptions.md)
 - [Model.CollectorConnectionConfiguration](docs/CollectorConnectionConfiguration.md)
 - [Model.CollectorConnectionConfigurationPaymentOptions](docs/CollectorConnectionConfigurationPaymentOptions.md)
 - [Model.CollectorConnectionSignup](docs/CollectorConnectionSignup.md)
 - [Model.CommonConnection](docs/CommonConnection.md)
 - [Model.CommonConnectionAllOf](docs/CommonConnectionAllOf.md)
 - [Model.CommonConnectionSignup](docs/CommonConnectionSignup.md)
 - [Model.CommonConnectionSignupApplicant](docs/CommonConnectionSignupApplicant.md)
 - [Model.CommonConnectionSignupBankAccounts](docs/CommonConnectionSignupBankAccounts.md)
 - [Model.CommonConnectionSignupCompanyInformation](docs/CommonConnectionSignupCompanyInformation.md)
 - [Model.CommonConnectionSignupOwnership](docs/CommonConnectionSignupOwnership.md)
 - [Model.CommonConnectionSignupOwnershipOwners](docs/CommonConnectionSignupOwnershipOwners.md)
 - [Model.CommonConnectionSignupPaymentMethodSpecific](docs/CommonConnectionSignupPaymentMethodSpecific.md)
 - [Model.CommonConnectionSignupPaymentMethodSpecificInstabank](docs/CommonConnectionSignupPaymentMethodSpecificInstabank.md)
 - [Model.CommonConnectionSignupPaymentOptions](docs/CommonConnectionSignupPaymentOptions.md)
 - [Model.CommonConnectionSignupVerifications](docs/CommonConnectionSignupVerifications.md)
 - [Model.EmailAuthorizedUser](docs/EmailAuthorizedUser.md)
 - [Model.Entity](docs/Entity.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorError](docs/ErrorError.md)
 - [Model.Exchange](docs/Exchange.md)
 - [Model.ExtendedAccount](docs/ExtendedAccount.md)
 - [Model.Grant](docs/Grant.md)
 - [Model.GrantAllOf](docs/GrantAllOf.md)
 - [Model.InlineObject](docs/InlineObject.md)
 - [Model.InlineObject1](docs/InlineObject1.md)
 - [Model.InlineObject10](docs/InlineObject10.md)
 - [Model.InlineObject11](docs/InlineObject11.md)
 - [Model.InlineObject12](docs/InlineObject12.md)
 - [Model.InlineObject2](docs/InlineObject2.md)
 - [Model.InlineObject3](docs/InlineObject3.md)
 - [Model.InlineObject4](docs/InlineObject4.md)
 - [Model.InlineObject5](docs/InlineObject5.md)
 - [Model.InlineObject6](docs/InlineObject6.md)
 - [Model.InlineObject7](docs/InlineObject7.md)
 - [Model.InlineObject8](docs/InlineObject8.md)
 - [Model.InlineObject9](docs/InlineObject9.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse403](docs/InlineResponse403.md)
 - [Model.InstabankConnection](docs/InstabankConnection.md)
 - [Model.InstabankConnectionAllOf](docs/InstabankConnectionAllOf.md)
 - [Model.InstabankConnectionCallback](docs/InstabankConnectionCallback.md)
 - [Model.InstabankConnectionConfiguration](docs/InstabankConnectionConfiguration.md)
 - [Model.InstabankConnectionConfigurationPaymentOptions](docs/InstabankConnectionConfigurationPaymentOptions.md)
 - [Model.InstabankConnectionConfigurationPaymentProductCodes](docs/InstabankConnectionConfigurationPaymentProductCodes.md)
 - [Model.InstabankConnectionSignup](docs/InstabankConnectionSignup.md)
 - [Model.MfaOob](docs/MfaOob.md)
 - [Model.MfaOobAllOf](docs/MfaOobAllOf.md)
 - [Model.ModelClient](docs/ModelClient.md)
 - [Model.Password](docs/Password.md)
 - [Model.PasswordAllOf](docs/PasswordAllOf.md)
 - [Model.PasswordLess](docs/PasswordLess.md)
 - [Model.PayExConnection](docs/PayExConnection.md)
 - [Model.PayExConnectionAllOf](docs/PayExConnectionAllOf.md)
 - [Model.PayExConnectionCallback](docs/PayExConnectionCallback.md)
 - [Model.PayExConnectionCallbackPaymentOptions](docs/PayExConnectionCallbackPaymentOptions.md)
 - [Model.PayExConnectionConfiguration](docs/PayExConnectionConfiguration.md)
 - [Model.PayExConnectionSignup](docs/PayExConnectionSignup.md)
 - [Model.PayExConnectionSignupContact](docs/PayExConnectionSignupContact.md)
 - [Model.RefreshToken](docs/RefreshToken.md)
 - [Model.RefreshTokenAllOf](docs/RefreshTokenAllOf.md)
 - [Model.RevokeToken](docs/RevokeToken.md)
 - [Model.ServiceStatistic](docs/ServiceStatistic.md)
 - [Model.Subscription](docs/Subscription.md)
 - [Model.SwishConnection](docs/SwishConnection.md)
 - [Model.SwishConnectionAllOf](docs/SwishConnectionAllOf.md)
 - [Model.SwishConnectionCallback](docs/SwishConnectionCallback.md)
 - [Model.SwishConnectionCallbackPaymentOptions](docs/SwishConnectionCallbackPaymentOptions.md)
 - [Model.SwishConnectionConfiguration](docs/SwishConnectionConfiguration.md)
 - [Model.SwishConnectionSignup](docs/SwishConnectionSignup.md)
 - [Model.SwishConnectionSignupPaymentOptions](docs/SwishConnectionSignupPaymentOptions.md)
 - [Model.UtmCampaign](docs/UtmCampaign.md)
 - [Model.VippsConnection](docs/VippsConnection.md)
 - [Model.VippsConnectionAllOf](docs/VippsConnectionAllOf.md)
 - [Model.VippsConnectionAllOfConfiguration](docs/VippsConnectionAllOfConfiguration.md)
 - [Model.VippsConnectionAllOfConfigurationPaymentOptions](docs/VippsConnectionAllOfConfigurationPaymentOptions.md)
 - [Model.VippsConnectionAllOfConfigurationSubscriptionKeys](docs/VippsConnectionAllOfConfigurationSubscriptionKeys.md)
 - [Model.VippsConnectionAllOfSignup](docs/VippsConnectionAllOfSignup.md)
 - [Model.VippsConnectionCallback](docs/VippsConnectionCallback.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="JWT"></a>
### JWT

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

<a name="clientAuth"></a>
### clientAuth

- **Type**: HTTP basic authentication

