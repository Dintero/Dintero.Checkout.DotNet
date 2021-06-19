using System;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Dintero.OpenApiClient.Checkout.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticateApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Get Token
        /// </summary>
        /// <remarks>
        /// Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </remarks>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
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
        private Dintero.OpenApiClient.Checkout.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

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
            this.Configuration = Dintero.OpenApiClient.Checkout.Client.Configuration.MergeConfigurations(
                Dintero.OpenApiClient.Checkout.Client.GlobalConfiguration.Instance,
                new Dintero.OpenApiClient.Checkout.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Dintero.OpenApiClient.Checkout.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Dintero.OpenApiClient.Checkout.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Dintero.OpenApiClient.Checkout.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticateApi(Dintero.OpenApiClient.Checkout.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Dintero.OpenApiClient.Checkout.Client.Configuration.MergeConfigurations(
                Dintero.OpenApiClient.Checkout.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Dintero.OpenApiClient.Checkout.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Dintero.OpenApiClient.Checkout.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Dintero.OpenApiClient.Checkout.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthenticateApi(Dintero.OpenApiClient.Checkout.Client.ISynchronousClient client, Dintero.OpenApiClient.Checkout.Client.IAsynchronousClient asyncClient, Dintero.OpenApiClient.Checkout.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Dintero.OpenApiClient.Checkout.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Dintero.OpenApiClient.Checkout.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Dintero.OpenApiClient.Checkout.Client.ISynchronousClient Client { get; set; }

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
        public Dintero.OpenApiClient.Checkout.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Dintero.OpenApiClient.Checkout.Client.ExceptionFactory ExceptionFactory
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
        /// Get Token Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>AccessToken</returns>
        public AccessToken AidAuthsOauthTokenPost(string oid, AuthToken data)
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<AccessToken> localVarResponse = AidAuthsOauthTokenPostWithHttpInfo(oid, data);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Token Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AccessToken</returns>
        public Dintero.OpenApiClient.Checkout.Client.ApiResponse<AccessToken> AidAuthsOauthTokenPostWithHttpInfo(string oid, AuthToken data)
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthsOauthTokenPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthsOauthTokenPost");

            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(oid)); // path parameter
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
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Dintero.OpenApiClient.Checkout.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessToken</returns>
        public async System.Threading.Tasks.Task<AccessToken> AidAuthsOauthTokenPostAsync(string oid, AuthToken data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dintero.OpenApiClient.Checkout.Client.ApiResponse<AccessToken> localVarResponse = await AidAuthsOauthTokenPostWithHttpInfoAsync(oid, data, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Token Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type &#x60;client_credentials&#x60;, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;authorization_code&#x60; or &#x60;password&#x60;, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;account_user_token&#x60;, where the Bearer value must be a account user JWT token.  &gt; Use ID token as Bearer toke if the user was authenticated &gt; externally. The ID must include a &#x60;email&#x60; claim that &gt; identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type &#x60;refresh_token&#x60; where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with &#x60;error.code: mfa_required&#x60;.  When an &#x60;mfa_required&#x60; error is returned, the client must perform a &#x60;challenge&#x60;. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with &#x60;grant_type&#x3D;mfa-oob&#x60;. Include the &#x60;oob_code&#x60; you received from the challenge response, as well as the &#x60;mfa_token&#x60; you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 
        /// </summary>
        /// <exception cref="Dintero.OpenApiClient.Checkout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oid">An id that uniquely identifies the account or owner (partner) </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessToken)</returns>
        public async System.Threading.Tasks.Task<Dintero.OpenApiClient.Checkout.Client.ApiResponse<AccessToken>> AidAuthsOauthTokenPostWithHttpInfoAsync(string oid, AuthToken data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oid' is set
            if (oid == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'oid' when calling AuthenticateApi->AidAuthsOauthTokenPost");

            // verify the required parameter 'data' is set
            if (data == null)
                throw new Dintero.OpenApiClient.Checkout.Client.ApiException(400, "Missing required parameter 'data' when calling AuthenticateApi->AidAuthsOauthTokenPost");


            Dintero.OpenApiClient.Checkout.Client.RequestOptions localVarRequestOptions = new Dintero.OpenApiClient.Checkout.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Dintero.OpenApiClient.Checkout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("oid", Dintero.OpenApiClient.Checkout.Client.ClientUtils.ParameterToString(oid)); // path parameter
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
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Dintero.OpenApiClient.Checkout.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
