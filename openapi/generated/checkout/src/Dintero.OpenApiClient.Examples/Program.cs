using System;
using System.Collections.Generic;
using Dintero.OpenApiClient.Checkout.Api;
using Dintero.OpenApiClient.Checkout.Client;
using Dintero.OpenApiClient.Checkout.Model;

namespace Dintero.OpenApiClient.Examples
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var accountId = args[0];
            var clientId = args[1];
            var clientSecret = args[2];

            var configurationDefaultHeaders = new Dictionary<string, string>
            {
                {"Content-Type", "application/json"},
            };

            const string authApiBaseUrl = "https://test.dintero.com/v1";
            var authConfiguration = new Configuration
            {
                BasePath = authApiBaseUrl,
                DefaultHeaders = configurationDefaultHeaders,
                Username = clientId,
                Password = clientSecret
            };

            var authApi = new AuthenticateApi(authConfiguration);

            var clientCredentials = new ClientCredentials(authApiBaseUrl + "/accounts/" + accountId);
            var accessTokenResponse = authApi.AidAuthsOauthTokenPost(accountId, clientCredentials);
            var accessToken = accessTokenResponse._AccessToken;

            var apiKeyPrefix = new Dictionary<string, string>
            {
                {"Authorization", "Bearer " + accessToken}
            };
            var checkoutConfiguration = new Configuration
            {
                BasePath = "https://checkout.test.dintero.com/v1",
                DefaultHeaders = configurationDefaultHeaders,
                ApiKeyPrefix = apiKeyPrefix,
            };

            var sessionApi = new SessionApi(checkoutConfiguration);
            var session = new SessionOptions(
                new SessionUrls(
                    returnUrl: "https://example.com/return",
                    callbackUrl: "https://example.com/callback"
                ),
                new SessionCustomer(
                    email: "email@email.com",
                    phoneNumber: "+4748059134"
                ),
                new SessionOrder(
                    amount: 29990,
                    currency: "NOK",
                    vatAmount: 4990,
                    merchantReference: "mref"
                ),
                configuration: new PaymentConfiguration(
                    vipps: new VippsConfiguration(true)
                )
            );
            var apiResponse = sessionApi.CheckoutSessionPostWithHttpInfo(session);
            Console.WriteLine(apiResponse.RawContent);
        }
    }
}
