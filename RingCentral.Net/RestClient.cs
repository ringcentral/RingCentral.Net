using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using RingCentral.Paths.Restapi;

namespace RingCentral
{
    public partial class RestClient : IDisposable
    {
        public const string SandboxServer = "https://platform.devtest.ringcentral.com";
        public const string ProductionServer = "https://platform.ringcentral.com";

        public static HttpClient httpClient = new HttpClient();

        private static readonly string[] BasicAuthPaths =
        {
            "/restapi/oauth/token",
            "/restapi/oauth/revoke",
            "/restapi/oauth/authorize"
        };

        public string appName = "Unknown";
        public string appVersion = "0.0.1";

        public string clientId;
        public string clientSecret;

        public Func<HttpRequestMessage, RestRequestConfig, Task<HttpResponseMessage>> extensibleRequest;

        public List<SdkExtension> sdkExtensions = new List<SdkExtension>();
        public Uri server;
        public TokenInfo token;

        private RestClient(string clientId, string clientSecret, Uri server, string appName = "Unknown",
            string appVersion = "0.0.1")
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.server = server;
            this.appName = appName;
            this.appVersion = appVersion;
            extensibleRequest = Request;
        }

        public RestClient(string clientId, string clientSecret, string server, string appName = "Unknown",
            string appVersion = "0.0.1")
            : this(clientId, clientSecret, new Uri(server), appName, appVersion)
        {
        }

        public RestClient(string clientId, string clientSecret, bool production = false, string appName = "Unknown",
            string appVersion = "0.0.1")
            : this(clientId, clientSecret, production ? ProductionServer : SandboxServer, appName, appVersion)
        {
        }

        public async void Dispose()
        {
            await Revoke();
        }

        public async Task InstallExtension(SdkExtension sdkExtension)
        {
            sdkExtensions.Add(sdkExtension);
            await sdkExtension.Install(this);
        }

        public async Task<HttpResponseMessage> Request(HttpRequestMessage httpRequestMessage,
            RestRequestConfig restRequestConfig = null)
        {
            restRequestConfig = restRequestConfig ?? RestRequestConfig.DefaultInstance;

            httpRequestMessage.Headers.Add("X-User-Agent", $"{appName}/{appVersion} RingCentral.Net/6.0.0-beta3");
            httpRequestMessage.Headers.Authorization =
                BasicAuthPaths.Contains(httpRequestMessage.RequestUri.AbsolutePath)
                    ? new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(
                            Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}")))
                    : new AuthenticationHeaderValue("Bearer", token.access_token);

            var httpResponseMessage =
                await httpClient.SendAsync(httpRequestMessage, restRequestConfig.cancellationToken);
            if (!httpResponseMessage.IsSuccessStatusCode)
                throw new RestException(httpResponseMessage, httpRequestMessage);

            return httpResponseMessage;
        }

        public async Task<TokenInfo> Authorize(GetTokenRequest getTokenRequest)
        {
            token = await Restapi(null).Oauth().Token().Post(getTokenRequest);
            return token;
        }

        public Task<TokenInfo> Authorize(string username, string extension, string password)
        {
            var getTokenRequest = new GetTokenRequest
            {
                grant_type = "password",
                username = username,
                extension = extension,
                password = password
            };
            return Authorize(getTokenRequest);
        }

        public Task<TokenInfo> Authorize(string authCode, string redirectUri)
        {
            var getTokenRequest = new GetTokenRequest
            {
                grant_type = "authorization_code",
                code = authCode,
                redirect_uri = redirectUri
            };
            return Authorize(getTokenRequest);
        }

        public Task<TokenInfo> Authorize(string jwt)
        {
            var getTokenRequest = new GetTokenRequest
            {
                grant_type = "urn:ietf:params:oauth:grant-type:jwt-bearer",
                assertion = jwt
            };
            return Authorize(getTokenRequest);
        }

        public Task<TokenInfo> Refresh(string refreshToken = null)
        {
            var tokenToRefresh = refreshToken ?? token?.refresh_token;
            if (tokenToRefresh == null) throw new ArgumentNullException(nameof(tokenToRefresh));

            var getTokenRequest = new GetTokenRequest
            {
                grant_type = "refresh_token",
                refresh_token = tokenToRefresh
            };
            return Authorize(getTokenRequest);
        }

        public async Task Revoke(string tokenToRevoke = null)
        {
            if (tokenToRevoke == null && token == null) // nothing  to revoke
                return;

            tokenToRevoke = tokenToRevoke ?? token.access_token ?? token.refresh_token;
            await Restapi(null).Oauth().Revoke().Post(new RevokeTokenRequest
            {
                token = tokenToRevoke
            });
            token = null;
        }

        // bridge methods to start the call chain, like rc.Restapi().Account()
        public Index Restapi(string apiVersion = "v1.0")
        {
            return new Index(this, apiVersion);
        }

        public Paths.Scim.Index Scim(string version = "v2")
        {
            return new Paths.Scim.Index(this, version);
        }

        public Paths.Analytics.Index Analytics()
        {
            return new Paths.Analytics.Index(this);
        }

        public Paths.TeamMessaging.Index TeamMessaging()
        {
            return new Paths.TeamMessaging.Index(this);
        }

        public Paths.Ai.Index Ai()
        {
            return new Paths.Ai.Index(this);
        }

        public Paths.Rcvideo.Index Rcvideo()
        {
            return new Paths.Rcvideo.Index(this);
        }

        public Paths.Webinar.Index Webinar()
        {
            return new Paths.Webinar.Index(this);
        }
    }
}