using System;
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

        private RestClient(string clientId, string clientSecret, Uri server, string appName = "Unknown",
            string appVersion = "0.0.1")
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.server = server;
            this.appName = appName;
            this.appVersion = appVersion;
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

        public async Task<HttpResponseMessage> Request(HttpRequestMessage httpRequestMessage)
        {
            httpRequestMessage.Headers.Add("X-User-Agent", $"{appName}/{appVersion} RingCentral.Net/3.0.0");
            httpRequestMessage.Headers.Authorization = token == null
                ? new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}")))
                : new AuthenticationHeaderValue("Bearer", token.access_token);
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            if (!httpResponseMessage.IsSuccessStatusCode)
                throw new RestException(httpResponseMessage, httpRequestMessage);
            AfterHttpCall?.Invoke(this, new HttpCallEventArgs(httpResponseMessage, httpRequestMessage));
            return httpResponseMessage;
        }

        public async Task<TokenInfo> Authorize(GetTokenRequest getTokenRequest)
        {
            token = null; // force it to use basicAuth
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
                return System.Threading.Tasks.Task.FromResult<TokenInfo>(null);
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

        public async System.Threading.Tasks.Task Revoke(string tokenToRevoke = null)
        {
            if (tokenToRevoke == null && token == null) // nothing  to revoke
            {
                return;
            }

            tokenToRevoke = tokenToRevoke ?? token.access_token ?? token.refresh_token;
            token = null; // force it to use basicAuth
            await Restapi(null).Oauth().Revoke().Post(new RevokeTokenRequest
            {
                token = tokenToRevoke
            });
        }

        public async void Dispose()
        {
            await Revoke();
        }

        public string AuthorizeUri(AuthorizeRequest request)
        {
            if (request.response_type == null)
            {
                request.response_type = "code";
            }

            if (request.client_id == null)
            {
                request.client_id = clientId;
            }

            var uriBuilder = new UriBuilder(server)
            {
                Path = "/restapi/oauth/authorize",
                Query = string.Join("&",
                    Utils.GetPairs(request).Select(t => $"{t.name}={Uri.EscapeUriString(t.value.ToString())}"))
            };
            return uriBuilder.Uri.ToString();
        }

        public string AuthorizeUri(string redirectUri, string state = "")
        {
            return AuthorizeUri(new AuthorizeRequest
            {
                redirect_uri = redirectUri,
                state = state
            });
        }
    }
}