﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Websocket.Client;

namespace RingCentral.Net.WebSocket
{
    public class WebSocketExtension : SdkExtension
    {
        private readonly WebSocketOptions _options;
        private Subscription _subscription = default(Subscription);
        private ConnectionDetails _connectionDetails;
        private RestClient _rc;
        private WebsocketClient _ws;
        private Wsc _wsc;

        public WebSocketExtension(WebSocketOptions options = null)
        {
            _options = options ?? WebSocketOptions.DefaultInstance;
        }

        public event EventHandler<WsgMessage> MessageReceived;

        public override async Task Install(RestClient rc)
        {
            _rc = rc;
            await Connect();
        }

        private async Task Connect(bool recoverSession = false)
        {
            var wsToken = await _rc.Post<WsToken>("/restapi/oauth/wstoken");
            var wsUri = $"{wsToken.uri}?access_token={wsToken.ws_access_token}";
            if (recoverSession) wsUri = $"{wsUri}&wsc={_wsc.token}";

            _ws = new WebsocketClient(new Uri(wsUri));
            _ws.ReconnectTimeout = TimeSpan.FromMinutes(2);

            _ws.ReconnectionHappened.Subscribe(async info =>
            {
                if (info.Type != ReconnectionType.Initial)
                {
                    _ws.Dispose();
                    await Connect(true);
                    if (!recoverSession || _connectionDetails.recoveryState == RecoveryState.Failed)
                        if (_subscription != default(Subscription) && _subscription.SubscriptionInfo != null)
                            // otherwise it has been revoked explicitly
                            await _subscription.SubScribe();
                }

                _ws.MessageReceived.Subscribe(responseMessage =>
                {
                    var wsgMessage = WsgMessage.Parse(responseMessage.Text);
                    if (_options.debugMode)
                        Console.WriteLine(
                            $"***WebSocket incoming message ({DateTime.Now.ToString(CultureInfo.CurrentCulture)}): ***" +
                            $"\n{JsonConvert.SerializeObject(wsgMessage, Formatting.Indented)}" +
                            "\n******");

                    MessageReceived?.Invoke(this, wsgMessage);
                });
            });

            MessageReceived += (sender, wsgMessage) =>
            {
                if (wsgMessage.meta.wsc != null && (_wsc == null ||
                                                    (wsgMessage.meta.type ==
                                                     MessageType.ConnectionDetails &&
                                                     wsgMessage.body.GetType().GetProperty("recoveryState") != null) ||
                                                    _wsc?.sequence < wsgMessage.meta.wsc.sequence))
                    _wsc = wsgMessage.meta.wsc;

                if (wsgMessage.meta.type == MessageType.ConnectionDetails)
                    _connectionDetails = wsgMessage.body.ToObject<ConnectionDetails>();
            };

            await _ws.Start();
        }

        private Task Send(string message)
        {
            if (_options.debugMode)
                Console.WriteLine(
                    $"***WebSocket outgoing message ({DateTime.Now.ToString(CultureInfo.CurrentCulture)}): ***" +
                    $"\n{JsonConvert.SerializeObject(JsonConvert.DeserializeObject(message), Formatting.Indented)}" +
                    "\n******");

            return Task.Run(() => _ws.Send(message));
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
            await _subscription.SubScribe();
            return _subscription;
        }

        public async Task Revoke()
        {
            await _subscription.Revoke();
            _subscription = default(Subscription);
            _ws.Dispose();
        }
    }
}