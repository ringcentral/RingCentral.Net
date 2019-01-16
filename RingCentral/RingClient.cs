using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.WebSockets;
using System.Linq;

namespace RingCentral.Net
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public WebSocketMessageType type;
        public byte[] bytes;
        public string text
        {
            get
            {
                if (type == WebSocketMessageType.Text)
                {
                    return Encoding.UTF8.GetString(bytes);
                }
                return null;
            }
        }
    }

    public partial class RingClient : IDisposable
    {
        public const string SANDBOX_HTTPS_SERVER = "https://platform.devtest.ringcentral.com";
        public const string PRODUCTION_HTTPS_SERVER = "https://platform.ringcentral.com";
        public const string SANDBOX_WSS_SERVER = "wss://ws-api.devtest.ringcentral.com/ws";
        public const string PRODUCTION_WSS_SERVER = "wss://ws-api.ringcentral.com/ws";

        public string clientId;
        public string clientSecret;
        public TokenInfo token;

        public Uri wssServer;
        public ClientWebSocket wssClient;
        public CancellationTokenSource cancelSource = new CancellationTokenSource();
        public event EventHandler<MessageReceivedEventArgs> MessageReceivedEventHandler;

        public RingClient(string clientId, string clientSecret, string server)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            if (!server.StartsWith("wss://"))
            {
                if (server.StartsWith(SANDBOX_HTTPS_SERVER))
                {
                    server = SANDBOX_WSS_SERVER;
                }
                else if (server.StartsWith(PRODUCTION_HTTPS_SERVER))
                {
                    server = PRODUCTION_WSS_SERVER;
                }
                else
                {
                    throw new ArgumentException("wssServer should start with \"wss://\"", "wssServer");
                }
            }
            wssServer = new Uri(server);
            wssClient = new ClientWebSocket();
            wssClient.Options.KeepAliveInterval = TimeSpan.FromDays(40);
            wssClient.ConnectAsync(wssServer, cancelSource.Token).Wait();
            Console.WriteLine("wssClient.ConnectAsync");
            Task.Factory.StartNew(
                async () =>
                {
                    var buffer = new ArraySegment<byte>(new byte[1024]);
                    var bytesList = new List<byte>();
                    while (true)
                    {
                        var result = await wssClient.ReceiveAsync(buffer, cancelSource.Token);
                        var bytes = buffer.Skip(buffer.Offset).Take(result.Count).ToArray();
                        bytesList.AddRange(bytes);
                        if (result.EndOfMessage)
                        {
                            Console.WriteLine("MessageReceivedEventHandler");
                            MessageReceivedEventHandler(this, new MessageReceivedEventArgs
                            {
                                type = result.MessageType,
                                bytes = bytesList.ToArray()
                            });
                            bytesList.Clear();
                        }
                    }
                },
                cancelSource.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default
            );
        }
        public RingClient(string clientId, string clientSecret, bool production = false)
            : this(clientId, clientSecret, production ? PRODUCTION_WSS_SERVER : SANDBOX_WSS_SERVER)
        {
        }

        public Task<Response> Request(string method, string path, string body = null, bool basicAuth = false)
        {
            var messageId = Guid.NewGuid().ToString();
            var metadata = new Metadata
            {
                type = "ClientRequest",
                method = method,
                path = path,
                messageId = messageId,
                headers = GetHeaders(basicAuth)
            };
            var requestItems = new List<string>();
            requestItems.Add(metadata.ToJsonString());
            if (body != null)
            {
                requestItems.Add(basicAuth ? $"\"{body}\"" : body);
            }
            var requestBody = $"[{string.Join(",", requestItems)}]";
            var t = new TaskCompletionSource<Response>();
            EventHandler<MessageReceivedEventArgs> handler = null;
            handler = (sender, args) =>
            {
                var message = args.text;
                if (message != null && message.Contains($"\"messageId\":\"{messageId}\""))
                {
                    MessageReceivedEventHandler -= handler;
                    var response = new Response(message);
                    t.TrySetResult(response);
                }
            };
            MessageReceivedEventHandler += handler;
            wssClient.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(requestBody)), WebSocketMessageType.Text, true, cancelSource.Token);
            return t.Task;
        }

        public async Task<Response<TokenInfo>> Authorize(string username, string extension, string password)
        {
            var oauthTokenRequest = new OauthTokenRequest
            {
                grant_type = "password",
                username = username,
                extension = extension,
                password = password
            };
            var r = await Request<TokenInfo>("POST", "/restapi/oauth/token", oauthTokenRequest.ToQueryString(), true);
            this.token = r.body;
            return r;
        }
        public async Task<Response> Revoke()
        {
            if (this.token == null) // nothing  to revoke
            {
                return null;
            }
            var body = $"token={this.token.access_token}";
            var r = await this.Request("POST", "/restapi/oauth/revoke", body, true);
            this.token = null;
            return r;
        }
        public async Task<Response<TokenInfo>> Refresh()
        {
            if (this.token == null) // nothing  to refresh
            {
                return null;
            }
            var oauthTokenRequest = new OauthTokenRequest
            {
                grant_type = "refresh_token",
                refresh_token = this.token.refresh_token,
            };
            var r = await this.Request<TokenInfo>("POST", "/restapi/oauth/token", oauthTokenRequest.ToQueryString(), true);
            this.token = r.body;
            return r;
        }

        public async void Dispose()
        {
            await this.Revoke();
        }

        const string userAgent = "tylerlong/RingCentral.Net";
        private Dictionary<string, string> GetHeaders(bool basicAuth = false)
        {
            var dict = new Dictionary<string, string>();
            dict["X-User-Agent"] = userAgent;
            dict["RC-User-Agent"] = userAgent;
            if (basicAuth)
            {
                dict["Content-Type"] = "application/x-www-form-urlencoded";
                dict["Authorization"] = $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this.clientId}:{this.clientSecret}"))}";
            }
            else
            {
                dict["Authorization"] = $"Bearer {this.token.access_token}";
            }
            return dict;
        }
    }
}
