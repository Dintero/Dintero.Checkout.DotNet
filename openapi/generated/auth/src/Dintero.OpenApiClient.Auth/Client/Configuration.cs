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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dintero.OpenApiClient.Auth.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration : IReadableConfiguration
    {
        #region Constants

        /// <summary>
        /// Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "1.0.0";

        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        #endregion Constants

        #region Static Members

        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            var status = (int)response.StatusCode;
            if (status >= 400)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.RawContent),
                    response.RawContent, response.Headers);
            }
            if (status == 0)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.ErrorText), response.ErrorText);
            }
            return null;
        };

        #endregion Static Members

        #region Private Members

        /// <summary>
        /// Defines the base path of the target API server.
        /// Example: http://localhost:3000/v1/
        /// </summary>
        private String _basePath;

        /// <summary>
        /// Gets or sets the API key based on the authentication name.
        /// This is the key and value comprising the "secret" for acessing an API.
        /// </summary>
        /// <value>The API key.</value>
        private IDictionary<string, string> _apiKey;

        /// <summary>
        /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        private IDictionary<string, string> _apiKeyPrefix;

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        private string _tempFolderPath = Path.GetTempPath();

        /// <summary>
        /// Gets or sets the servers defined in the OpenAPI spec.
        /// </summary>
        /// <value>The servers</value>
        private IList<IReadOnlyDictionary<string, object>> _servers;
        #endregion Private Members

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Configuration()
        {
            Proxy = null;
            UserAgent = "OpenAPI-Generator/1.0.0/csharp";
            BasePath = "http://localhost/v1";
            DefaultHeaders = new ConcurrentDictionary<string, string>();
            ApiKey = new ConcurrentDictionary<string, string>();
            ApiKeyPrefix = new ConcurrentDictionary<string, string>();
            Servers = new List<IReadOnlyDictionary<string, object>>()
            {
                {
                    new Dictionary<string, object> {
                        {"url", "/v1"},
                        {"description", "No description provided"},
                    }
                }
            };

            // Setting Timeout has side effects (forces ApiClient creation).
            Timeout = 100000;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Configuration(
            IDictionary<string, string> defaultHeaders,
            IDictionary<string, string> apiKey,
            IDictionary<string, string> apiKeyPrefix,
            string basePath = "http://localhost/v1") : this()
        {
            if (string.IsNullOrWhiteSpace(basePath))
                throw new ArgumentException("The provided basePath is invalid.", "basePath");
            if (defaultHeaders == null)
                throw new ArgumentNullException("defaultHeaders");
            if (apiKey == null)
                throw new ArgumentNullException("apiKey");
            if (apiKeyPrefix == null)
                throw new ArgumentNullException("apiKeyPrefix");

            BasePath = basePath;

            foreach (var keyValuePair in defaultHeaders)
            {
                DefaultHeaders.Add(keyValuePair);
            }

            foreach (var keyValuePair in apiKey)
            {
                ApiKey.Add(keyValuePair);
            }

            foreach (var keyValuePair in apiKeyPrefix)
            {
                ApiKeyPrefix.Add(keyValuePair);
            }
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the base path for API access.
        /// </summary>
        public virtual string BasePath {
            get { return _basePath; }
            set { _basePath = value; }
        }

        /// <summary>
        /// Gets or sets the default header.
        /// </summary>
        [Obsolete("Use DefaultHeaders instead.")]
        public virtual IDictionary<string, string> DefaultHeader
        {
            get
            {
                return DefaultHeaders;
            }
            set
            {
                DefaultHeaders = value;
            }
        }

        /// <summary>
        /// Gets or sets the default headers.
        /// </summary>
        public virtual IDictionary<string, string> DefaultHeaders { get; set; }

        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        public virtual int Timeout { get; set; }

        /// <summary>
        /// Gets or sets the proxy
        /// </summary>
        /// <value>Proxy.</value>
        public virtual WebProxy Proxy { get; set; }

        /// <summary>
        /// Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public virtual string Password { get; set; }

        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix(string apiKeyIdentifier)
        {
            string apiKeyValue;
            ApiKey.TryGetValue(apiKeyIdentifier, out apiKeyValue);
            string apiKeyPrefix;
            if (ApiKeyPrefix.TryGetValue(apiKeyIdentifier, out apiKeyPrefix))
            {
                return apiKeyPrefix + " " + apiKeyValue;
            }

            return apiKeyValue;
        }

        /// <summary>
        /// Gets or sets certificate collection to be sent with requests.
        /// </summary>
        /// <value>X509 Certificate collection.</value>
        public X509CertificateCollection ClientCertificates { get; set; }

        /// <summary>
        /// Gets or sets the access token for OAuth2 authentication.
        ///
        /// This helper property simplifies code generation.
        /// </summary>
        /// <value>The access token.</value>
        public virtual string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public virtual string TempFolderPath
        {
            get { return _tempFolderPath; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _tempFolderPath = Path.GetTempPath();
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                {
                    Directory.CreateDirectory(value);
                }

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                {
                    _tempFolderPath = value;
                }
                else
                {
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
                }
            }
        }

        /// <summary>
        /// Gets or sets the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public virtual string DateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        ///
        /// Whatever you set here will be prepended to the value defined in AddApiKey.
        ///
        /// An example invocation here might be:
        /// <example>
        /// ApiKeyPrefix["Authorization"] = "Bearer";
        /// </example>
        /// … where ApiKey["Authorization"] would then be used to set the value of your bearer token.
        ///
        /// <remarks>
        /// OAuth2 workflows should set tokens via AccessToken.
        /// </remarks>
        /// </summary>
        /// <value>The prefix of the API key.</value>
        public virtual IDictionary<string, string> ApiKeyPrefix
        {
            get { return _apiKeyPrefix; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("ApiKeyPrefix collection may not be null.");
                }
                _apiKeyPrefix = value;
            }
        }

        /// <summary>
        /// Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        public virtual IDictionary<string, string> ApiKey
        {
            get { return _apiKey; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("ApiKey collection may not be null.");
                }
                _apiKey = value;
            }
        }

        /// <summary>
        /// Gets or sets the servers.
        /// </summary>
        /// <value>The servers.</value>
        public virtual IList<IReadOnlyDictionary<string, object>> Servers
        {
            get { return _servers; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("Servers may not be null.");
                }
                _servers = value;
            }
        }

        /// <summary>
        /// Returns URL based on server settings without providing values
        /// for the variables
        /// </summary>
        /// <param name="index">Array index of the server settings.</param>
        /// <return>The server URL.</return>
        public string GetServerUrl(int index)
        {
            return GetServerUrl(index, null);
        }

        /// <summary>
        /// Returns URL based on server settings.
        /// </summary>
        /// <param name="index">Array index of the server settings.</param>
        /// <param name="inputVariables">Dictionary of the variables and the corresponding values.</param>
        /// <return>The server URL.</return>
        public string GetServerUrl(int index, Dictionary<string, string> inputVariables)
        {
            if (index < 0 || index >= Servers.Count)
            {
                throw new InvalidOperationException($"Invalid index {index} when selecting the server. Must be less than {Servers.Count}.");
            }

            if (inputVariables == null)
            {
                inputVariables = new Dictionary<string, string>();
            }

            IReadOnlyDictionary<string, object> server = Servers[index];
            string url = (string)server["url"];

            // go through variable and assign a value
            foreach (KeyValuePair<string, object> variable in (IReadOnlyDictionary<string, object>)server["variables"])
            {

                IReadOnlyDictionary<string, object> serverVariables = (IReadOnlyDictionary<string, object>)(variable.Value);

                if (inputVariables.ContainsKey(variable.Key))
                {
                    if (((List<string>)serverVariables["enum_values"]).Contains(inputVariables[variable.Key]))
                    {
                        url = url.Replace("{" + variable.Key + "}", inputVariables[variable.Key]);
                    }
                    else
                    {
                        throw new InvalidOperationException($"The variable `{variable.Key}` in the server URL has invalid value #{inputVariables[variable.Key]}. Must be {(List<string>)serverVariables["enum_values"]}");
                    }
                }
                else
                {
                    // use defualt value
                    url = url.Replace("{" + variable.Key + "}", (string)serverVariables["default_value"]);
                }
            }

            return url;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Returns a string with essential information for debugging.
        /// </summary>
        public static String ToDebugReport()
        {
            String report = "C# SDK (Dintero.OpenApiClient.Auth) Debug Report:\n";
            report += "    OS: " + System.Environment.OSVersion + "\n";
            report += "    .NET Framework Version: " + System.Environment.Version  + "\n";
            report += "    Version of the API: LATEST\n";
            report += "    SDK Package Version: 1.0.0\n";

            return report;
        }

        /// <summary>
        /// Add Api Key Header.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        /// <returns></returns>
        public void AddApiKey(string key, string value)
        {
            ApiKey[key] = value;
        }

        /// <summary>
        /// Sets the API key prefix.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        public void AddApiKeyPrefix(string key, string value)
        {
            ApiKeyPrefix[key] = value;
        }

        #endregion Methods

        #region Static Members
        /// <summary>
        /// Merge configurations.
        /// </summary>
        /// <param name="first">First configuration.</param>
        /// <param name="second">Second configuration.</param>
        /// <return>Merged configuration.</return>
        public static IReadableConfiguration MergeConfigurations(IReadableConfiguration first, IReadableConfiguration second)
        {
            if (second == null) return first ?? GlobalConfiguration.Instance;

            Dictionary<string, string> apiKey = first.ApiKey.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<string, string> apiKeyPrefix = first.ApiKeyPrefix.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<string, string> defaultHeaders = first.DefaultHeaders.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in second.ApiKey) apiKey[kvp.Key] = kvp.Value;
            foreach (var kvp in second.ApiKeyPrefix) apiKeyPrefix[kvp.Key] = kvp.Value;
            foreach (var kvp in second.DefaultHeaders) defaultHeaders[kvp.Key] = kvp.Value;

            var config = new Configuration
            {
                ApiKey = apiKey,
                ApiKeyPrefix = apiKeyPrefix,
                DefaultHeaders = defaultHeaders,
                BasePath = second.BasePath ?? first.BasePath,
                Timeout = second.Timeout,
                Proxy = second.Proxy ?? first.Proxy,
                UserAgent = second.UserAgent ?? first.UserAgent,
                Username = second.Username ?? first.Username,
                Password = second.Password ?? first.Password,
                AccessToken = second.AccessToken ?? first.AccessToken,
                TempFolderPath = second.TempFolderPath ?? first.TempFolderPath,
                DateTimeFormat = second.DateTimeFormat ?? first.DateTimeFormat
            };
            return config;
        }
        #endregion Static Members
    }
}
