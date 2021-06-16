# Dintero.OpenApiClient.Auth.Api.AuthenticateApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AidAuthAccountPasswordlessPost**](AuthenticateApi.md#aidauthaccountpasswordlesspost) | **POST** /accounts/{oid}/auth/passwordless | Passwordless
[**AidAuthPasswordlessPost**](AuthenticateApi.md#aidauthpasswordlesspost) | **POST** /accounts/{oid}/auth/passwordless/code | Passwordless Code
[**AidAuthsOauthAuthorizePost**](AuthenticateApi.md#aidauthsoauthauthorizepost) | **POST** /accounts/{oid}/auth/authorize | Authorize Passwordless link
[**AidAuthsOauthExchangeTokenPost**](AuthenticateApi.md#aidauthsoauthexchangetokenpost) | **POST** /accounts/{partner_id}/auth/exchange_token | Exchange Token
[**AidAuthsOauthRedirectPost**](AuthenticateApi.md#aidauthsoauthredirectpost) | **POST** /accounts/{oid}/auth/redirect | Redirect with ID token
[**AidAuthsOauthRevokePost**](AuthenticateApi.md#aidauthsoauthrevokepost) | **POST** /accounts/{oid}/auth/revoke | Revoke Token
[**AidAuthsOauthTokenPost**](AuthenticateApi.md#aidauthsoauthtokenpost) | **POST** /accounts/{oid}/auth/token | Get Token


<a name="aidauthaccountpasswordlesspost"></a>
# **AidAuthAccountPasswordlessPost**
> void AidAuthAccountPasswordlessPost (string oid, PasswordLess data)

Passwordless

Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  - The client_id/audience must have a grant with type   `authorization_code` to allow sending verification-code - This endpoint is designed to be called from the client-side   and is subjected to rate limits  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless - write:accounts:/auth/passwordless-sms - write:accounts:/auth/passwordless-email 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthAccountPasswordlessPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticateApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new PasswordLess(); // PasswordLess | 

            try
            {
                // Passwordless
                apiInstance.AidAuthAccountPasswordlessPost(oid, data);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticateApi.AidAuthAccountPasswordlessPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oid** | **string**| An id that uniquely identifies the account or owner (partner)  | 
 **data** | [**PasswordLess**](PasswordLess.md)|  | 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | request processed |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  * Retry-After - Indicates how long the user agent should wait in seconds before making a follow-up request.  <br>  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthpasswordlesspost"></a>
# **AidAuthPasswordlessPost**
> InlineResponse2005 AidAuthPasswordlessPost (string oid, UNKNOWN_BASE_TYPE data)

Passwordless Code

Passwordless connections do not require the user to remember a password. Instead, another mechanism is used to prove identity, such as a one-time code sent through email or SMS, every time the account user logs in.  Use this endpoint to generate a one-time verification-code that can be sent to the user.  The client_id/audience must have a grant with type `authorization_code` to allow creating a verification-code  scopes: - admin:accounts - write:accounts - write:accounts:/auth/passwordless/code 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthPasswordlessPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticateApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 

            try
            {
                // Passwordless Code
                InlineResponse2005 result = apiInstance.AidAuthPasswordlessPost(oid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticateApi.AidAuthPasswordlessPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oid** | **string**| An id that uniquely identifies the account or owner (partner)  | 
 **data** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | access code |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource was not found |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsoauthauthorizepost"></a>
# **AidAuthsOauthAuthorizePost**
> void AidAuthsOauthAuthorizePost (string oid, string audience, string responseType, string clientId, string verificationCode, string scope = null, string state = null, string redirectUri = null, string connection = null)

Authorize Passwordless link

This endpoint is used to authorize Passwordless link sent to user by email/sms.  A valid request will redirect to This is the OAuth 2.0 grant that Client-side web apps utilize in order to access an API. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsOauthAuthorizePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticateApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var audience = audience_example;  // string | The unique identifier of the target API you want to access. 
            var responseType = responseType_example;  // string | This will specify the type of token you will receive at the end of the flow. Use token to get only an access_token  If `response_type=token`, after the user authenticates with the provider, this will redirect them to your application callback URL while passing the access_token in the address location.hash. This is used for Single Page Apps and on Native Mobile SDKs. 
            var clientId = clientId_example;  // string | Your application's Client ID. 
            var verificationCode = verificationCode_example;  // string | one-time verification-code
            var scope = scope_example;  // string | The scopes which you want to request authorization for. (optional) 
            var state = state_example;  // string | An opaque value the clients adds to the initial request that Dintero includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks.  (optional) 
            var redirectUri = redirectUri_example;  // string | The URL to which Dintero will redirect the browser after authorization has been granted by the user.  The `redirect_uri` value must be specified as a valid callback URL under your Client's Settings.  (optional) 
            var connection = connection_example;  // string | The name of the connection configured to your client. (optional) 

            try
            {
                // Authorize Passwordless link
                apiInstance.AidAuthsOauthAuthorizePost(oid, audience, responseType, clientId, verificationCode, scope, state, redirectUri, connection);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticateApi.AidAuthsOauthAuthorizePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oid** | **string**| An id that uniquely identifies the account or owner (partner)  | 
 **audience** | **string**| The unique identifier of the target API you want to access.  | 
 **responseType** | **string**| This will specify the type of token you will receive at the end of the flow. Use token to get only an access_token  If &#x60;response_type&#x3D;token&#x60;, after the user authenticates with the provider, this will redirect them to your application callback URL while passing the access_token in the address location.hash. This is used for Single Page Apps and on Native Mobile SDKs.  | 
 **clientId** | **string**| Your application&#39;s Client ID.  | 
 **verificationCode** | **string**| one-time verification-code | 
 **scope** | **string**| The scopes which you want to request authorization for. | [optional] 
 **state** | **string**| An opaque value the clients adds to the initial request that Dintero includes when redirecting the back to the client. This value must be used by the client to prevent CSRF attacks.  | [optional] 
 **redirectUri** | **string**| The URL to which Dintero will redirect the browser after authorization has been granted by the user.  The &#x60;redirect_uri&#x60; value must be specified as a valid callback URL under your Client&#39;s Settings.  | [optional] 
 **connection** | **string**| The name of the connection configured to your client. | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Found |  * Location - the URL to redirect to  - &#x60;id_token&#x60; will be included in the redirect URL as a   &#x60;query&#x60; parameter  A valid &#x60;id_token&#x60; will contain following claims   query name | type         | description                    | required - -- -- -- -- -- | :- -- -- -- -- -: | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | :- -- -- -- -- --: sub         |   string     | User Id                        | true email       |   string     | User email                     | false name        |   string     | User name                      | false aud         |   string     | Redirect URI                   | true iss         |   string     | Issuer (Dintero)               | true exp         |   int        | Token expiry                   | true ext_property name* |   string  | Custom claims                  | false  &#x60;&#x60;&#x60; {   \&quot;kid\&quot; : \&quot;1234example\&quot;   \&quot;alg\&quot; : \&quot;RS256\&quot; }  {   \&quot;aud\&quot;: \&quot;${redirect_uri}   \&quot;iss\&quot;: \&quot;https://P12345678@api.dintero.com\&quot;,   \&quot;sub\&quot;: \&quot;dintero:user:id\&quot;,   \&quot;email\&quot;: \&quot;janedoe@example.com\&quot;   \&quot;exp\&quot;: 1386899131,   \&quot;property name*\&quot;: \&quot;custom-claim\&quot; } &#x60;&#x60;&#x60; The kid (key ID) should be used to match specific key to use when validating the &#x60;id_token&#x60;. The &#x60;aud&#x60; in a valid token will contain the original &#x60;redirect_uri&#x60; (without id_token) that should be used to authorize the request.  <br>  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsoauthexchangetokenpost"></a>
# **AidAuthsOauthExchangeTokenPost**
> AccessToken AidAuthsOauthExchangeTokenPost (string partnerId, Exchange data)

Exchange Token

Use this endpoint to exchange access_token to a sub-account  scopes: - admin:accounts - read:accounts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsOauthExchangeTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticateApi(config);
            var partnerId = partnerId_example;  // string | An id that uniquely identifies the partner account 
            var data = new Exchange(); // Exchange | 

            try
            {
                // Exchange Token
                AccessToken result = apiInstance.AidAuthsOauthExchangeTokenPost(partnerId, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticateApi.AidAuthsOauthExchangeTokenPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **partnerId** | **string**| An id that uniquely identifies the partner account  | 
 **data** | [**Exchange**](Exchange.md)|  | 

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsoauthredirectpost"></a>
# **AidAuthsOauthRedirectPost**
> InlineResponse2006 AidAuthsOauthRedirectPost (string oid, InlineObject11 data)

Redirect with ID token

Use this endpoint to redirect to an URL with a ID token added. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsOauthRedirectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticateApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new InlineObject11(); // InlineObject11 | 

            try
            {
                // Redirect with ID token
                InlineResponse2006 result = apiInstance.AidAuthsOauthRedirectPost(oid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticateApi.AidAuthsOauthRedirectPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oid** | **string**| An id that uniquely identifies the account or owner (partner)  | 
 **data** | [**InlineObject11**](InlineObject11.md)|  | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response with redirect URL in response body. &#x60;Accept: application/json&#x60;  |  -  |
| **302** | Redirect to URL with ID token |  * Location - the URL to redirect to  - &#x60;id_token&#x60; will be included in the redirect URL as a   &#x60;query&#x60; parameter  A valid &#x60;id_token&#x60; will contain following claims   query name | type         | description                    | required - -- -- -- -- -- | :- -- -- -- -- -: | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | :- -- -- -- -- --: sub         |   string     | User Id                        | true email       |   string     | User email                     | false name        |   string     | User name                      | false aud         |   string     | Redirect URI                   | true iss         |   string     | Issuer (Dintero)               | true exp         |   int        | Token expiry                   | true ext_property name* |   string  | Custom claims                  | false  &#x60;&#x60;&#x60; {   \&quot;kid\&quot; : \&quot;1234example\&quot;   \&quot;alg\&quot; : \&quot;RS256\&quot; }  {   \&quot;aud\&quot;: \&quot;${redirect_uri}   \&quot;iss\&quot;: \&quot;https://P12345678@api.dintero.com\&quot;,   \&quot;sub\&quot;: \&quot;dintero:user:id\&quot;,   \&quot;email\&quot;: \&quot;janedoe@example.com\&quot;   \&quot;exp\&quot;: 1386899131,   \&quot;property name*\&quot;: \&quot;custom-claim\&quot; } &#x60;&#x60;&#x60; The kid (key ID) should be used to match specific key to use when validating the &#x60;id_token&#x60;. The &#x60;aud&#x60; in a valid token will contain the original &#x60;redirect_uri&#x60; (without id_token) that should be used to authorize the request.  <br>  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsoauthrevokepost"></a>
# **AidAuthsOauthRevokePost**
> Object AidAuthsOauthRevokePost (string oid, RevokeToken data)

Revoke Token

Use this endpoint to invalidate a Refresh Token if it has been compromised.  scopes: - admin:accounts - write:accounts - create:accounts:auth:refresh_token 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsOauthRevokePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticateApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new RevokeToken(); // RevokeToken | 

            try
            {
                // Revoke Token
                Object result = apiInstance.AidAuthsOauthRevokePost(oid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticateApi.AidAuthsOauthRevokePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oid** | **string**| An id that uniquely identifies the account or owner (partner)  | 
 **data** | [**RevokeToken**](RevokeToken.md)|  | 

### Return type

**Object**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidauthsoauthtokenpost"></a>
# **AidAuthsOauthTokenPost**
> AccessToken AidAuthsOauthTokenPost (string oid, AuthToken data)

Get Token

Use this endpoint to directly request an access_token  ### Client Access Token Use HTTP Basic authentication scheme for authenticating grant_type `client_credentials`, use client_id/client_secret as user/password.  ### Code/Password Token Use HTTP Bearer authentication scheme for authenticating grant_type `authorization_code` or `password`, where the Bearer value must be a JWT toke with access to the token endpoint.  ### Account User Token Use HTTP Bearer authentication scheme for authenticating grant_type `account_user_token`, where the Bearer value must be a account user JWT token.  > Use ID token as Bearer toke if the user was authenticated > externally. The ID must include a `email` claim that > identifies the account user.  ### Refresh Token Use HTTP Bearer authentication scheme for authenticating grant_type `refresh_token` where the Bearer value **must** be an Access Token for the clients that was used to create the Refresh Token.  ### Multi-factor authentication (MFA)  When a request is made to the endpoint to get an access token, normally you either get an error, or you get an access token. However, when the MFA is enabled, the endpoint may return a new error with `error.code: mfa_required`.  When an `mfa_required` error is returned, the client must perform a `challenge`. This is done by sending a request to the [auth/mfa/challenge](#operation/aid_auth_mfa_challenge_post) endpoint  To verify MFA using an OOB challenge, the client must make a request to this endpoint with `grant_type=mfa-oob`. Include the `oob_code` you received from the challenge response, as well as the `mfa_token` you received as part of mfa_required error.  scopes: - admin:accounts - write:accounts - write:accounts:/auth/users - write:accounts:/auth/users/no-mfa 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dintero.OpenApiClient.Auth.Api;
using Dintero.OpenApiClient.Auth.Client;
using Dintero.OpenApiClient.Auth.Model;

namespace Example
{
    public class AidAuthsOauthTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: clientAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthenticateApi(config);
            var oid = oid_example;  // string | An id that uniquely identifies the account or owner (partner) 
            var data = new AuthToken(); // AuthToken | 

            try
            {
                // Get Token
                AccessToken result = apiInstance.AidAuthsOauthTokenPost(oid, data);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticateApi.AidAuthsOauthTokenPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oid** | **string**| An id that uniquely identifies the account or owner (partner)  | 
 **data** | [**AuthToken**](AuthToken.md)|  | 

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

[JWT](../README.md#JWT), [clientAuth](../README.md#clientAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad / Invalid request |  -  |
| **401** | Access forbidden, invalid JWT token was used |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  * Retry-After - Indicates how long the user agent should wait in seconds before making a follow-up request.  <br>  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

