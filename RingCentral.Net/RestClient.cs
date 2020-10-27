using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RingCentral
{
    public partial class RestClient : IDisposable
    {
        public const string SandboxServer = "https://platform.devtest.ringcentral.com";
        public const string ProductionServer = "https://platform.ringcentral.com";

        public string clientId;
        public string clientSecret;
        public Uri server;
        public TokenInfo token;
        public string appName = "Unknown";
        public string appVersion = "0.0.1";

        public static HttpClient httpClient = new HttpClient();

        public List<SdkExtension> sdkExtensions = new List<SdkExtension>();

        public void InstallExtension(SdkExtension sdkExtension)
        {
            sdkExtensions.Add(sdkExtension);
            sdkExtension.Install(this);
        }

        private RestClient(string clientId, string clientSecret, Uri server, string appName = "Unknown",
            string appVersion = "0.0.1")
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.server = server;
            this.appName = appName;
            this.appVersion = appVersion;
            this.extensibleRequest = Request;
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

        public Func<HttpRequestMessage, RestRequestConfig, Task<HttpResponseMessage>> extensibleRequest;

        public async Task<HttpResponseMessage> Request(HttpRequestMessage httpRequestMessage,
            RestRequestConfig restRequestConfig = null)
        {
            restRequestConfig = restRequestConfig ?? RestRequestConfig.DefaultInstance;

            httpRequestMessage.Headers.Add("X-User-Agent", $"{appName}/{appVersion} RingCentral.Net/5.0.0-beta1");
            httpRequestMessage.Headers.Authorization =
                httpRequestMessage.RequestUri.AbsolutePath.StartsWith("/restapi/oauth/")
                    ? new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(
                            Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}")))
                    : new AuthenticationHeaderValue("Bearer", token.access_token);

            var httpResponseMessage =
                await httpClient.SendAsync(httpRequestMessage, restRequestConfig.cancellationToken);
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new RestException(httpResponseMessage, httpRequestMessage);
            }

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
                redirect_uri = redirectUri,
            };
            return Authorize(getTokenRequest);
        }

        public Task<TokenInfo> Refresh(string refreshToken = null)
        {
            var tokenToRefresh = refreshToken ?? token?.refresh_token;
            if (tokenToRefresh == null)
            {
                throw new System.ArgumentNullException(nameof(tokenToRefresh));
            }

            var getTokenRequest = new GetTokenRequest
            {
                grant_type = "refresh_token",
                refresh_token = tokenToRefresh
            };
            return Authorize(getTokenRequest);
        }

        private System.Timers.Timer _autoRefreshTimer = null;

        public void AutoRefresh(double interval = 1000 * 60 * 30)
        {
            _autoRefreshTimer = new System.Timers.Timer();
            _autoRefreshTimer.Elapsed += (sender, args) => { Refresh(); };
            _autoRefreshTimer.Interval = interval;
            _autoRefreshTimer.Start();
        }

        public void StopAutoRefresh()
        {
            if (_autoRefreshTimer != null)
            {
                _autoRefreshTimer.Stop();
                _autoRefreshTimer.Dispose();
                _autoRefreshTimer = null;
            }
        }

        public async Task Revoke(string tokenToRevoke = null)
        {
            if (tokenToRevoke == null && token == null) // nothing  to revoke
            {
                return;
            }

            tokenToRevoke = tokenToRevoke ?? token.access_token ?? token.refresh_token;
            await Restapi(null).Oauth().Revoke().Post(new RevokeTokenRequest
            {
                token = tokenToRevoke
            });
            token = null;
        }

        public async void Dispose()
        {
            await Revoke();
        }
    }
}