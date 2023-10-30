using System;
using System.Globalization;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Websocket.Client;

namespace RingCentral.Net.WebSocket
{
    public class WebSocketExtension : SdkExtension
    {
        private readonly WebSocketOptions _options;
        private ConnectionDetails _connectionDetails;
        private Timer _keepAliveTimer;
        private RestClient _rc;
        private Subscription _subscription;
        private Wsc _wsc;
        public WebsocketClient ws;

        public WebSocketExtension(WebSocketOptions options = null)
        {
            _options = options ?? WebSocketOptions.DefaultInstance;
        }

        public event EventHandler<WsgMessage> MessageReceived;
        public event EventHandler<string> RawMessageReceived;

        public override async Task Install(RestClient rc)
        {
            _rc = rc;
            MessageReceived += (sender, wsgMessage) =>
            {
                if (wsgMessage.meta.wsc != null && (_wsc == null ||
                                                    (wsgMessage.meta.type ==
                                                     MessageType.ConnectionDetails &&
                                                     wsgMessage.body.GetType().GetProperty("recoveryState") != null) ||
                                                    _wsc?.sequence < wsgMessage.meta.wsc.sequence))
                    _wsc = wsgMessage.meta.wsc;

                if (wsgMessage.meta.type == MessageType.ConnectionDetails)
                {
                    _connectionDetails = wsgMessage.body.ToObject<ConnectionDetails>();
                    if (_connectionDetails.recoveryState == RecoveryState.Failed) _subscription?.Subscribe();
                }
            };
            await Reconnect(false);
        }

        /// <summary>
        ///     Reconnect to WebSocket server
        /// </summary>
        /// <param name="recoverSubscription">
        ///     recover your existing subscription if there is one. You will have to re-subscribe
        ///     your existing subscription if you don't specify `true` here.
        /// </param>
        /// <returns></returns>
        public async Task Reconnect(bool recoverSubscription = true)
        {
            var wsToken = await _rc.Post<WsToken>("/restapi/oauth/wstoken");
            var wsUri = $"{wsToken.uri}?access_token={wsToken.ws_access_token}";
            if (recoverSubscription) wsUri = $"{wsUri}&wsc={_wsc.token}";
            var factory = new Func<ClientWebSocket>(() => new ClientWebSocket
            {
                Options = {KeepAliveInterval = TimeSpan.FromSeconds(30)}
            });
            ws?.Dispose(); // if ws already exist, dispose it
            ws = new WebsocketClient(new Uri(wsUri), factory);
            ws.ReconnectTimeout = null;
            ws.MessageReceived.Subscribe(responseMessage =>
            {
                RawMessageReceived?.Invoke(this, responseMessage.Text);
                var wsgMessage = WsgMessage.Parse(responseMessage.Text);
                if (_options.debugMode)
                    Console.WriteLine(
                        $"***WebSocket incoming message ({DateTime.Now.ToString(CultureInfo.CurrentCulture)}): ***" +
                        $"\n{JsonConvert.SerializeObject(wsgMessage, Formatting.Indented)}" +
                        "\n******");
                MessageReceived?.Invoke(this, wsgMessage);
            });
            await ws.Start();
            _keepAliveTimer?.Dispose(); // if there is already a timer, dispose it
            _keepAliveTimer = new Timer(state =>
            {
                dynamic[] requestBody =
                {
                    new
                    {
                        type = "Heartbeat",
                        messageId = Guid.NewGuid().ToString()
                    }
                };
                Send(JsonConvert.SerializeObject(requestBody));
            }, null, 600000, 600000); // every 10 minutes
        }

        private Task Send(string message)
        {
            if (_options.debugMode)
                Console.WriteLine(
                    $"***WebSocket outgoing message ({DateTime.Now.ToString(CultureInfo.CurrentCulture)}): ***" +
                    $"\n{JsonConvert.SerializeObject(JsonConvert.DeserializeObject(message), Formatting.Indented)}" +
                    "\n******");

            return Task.Run(() => ws.Send(message));
        }

        public async Task<T> Request<T>(string method, string endpoint, object content = null)
        {
            var tcs = new TaskCompletionSource<T>();
            var uuid = Guid.NewGuid().ToString();
            dynamic[] requestBody = {null, null};
            requestBody[0] = new RestRequestHeaders
            {
                type = "ClientRequest",
                messageId = uuid,
                method = method,
                path = endpoint
            };
            requestBody[1] = content;

            void Handler(object sender, WsgMessage wsgMessage)
            {
                if (wsgMessage.meta.messageId == uuid)
                {
                    MessageReceived -= Handler;
                    tcs.TrySetResult(JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(wsgMessage.body)));
                }
            }

            MessageReceived += Handler;
            await Send(JsonConvert.SerializeObject(requestBody));
            return await tcs.Task;
        }

        public async Task<Subscription> Subscribe(string[] eventFilters, Action<string> callback)
        {
            _subscription = new Subscription(this, eventFilters, callback);
            await _subscription.Subscribe();
            return _subscription;
        }

        public async Task Revoke()
        {
            await _subscription.Revoke();
            _subscription = default;
            _keepAliveTimer.Dispose();
            ws.Dispose();
        }
    }
}