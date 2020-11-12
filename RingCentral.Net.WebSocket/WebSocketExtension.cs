using System;
using System.Globalization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Websocket.Client;

namespace RingCentral.Net.WebSocket
{
    public class WebSocketExtension : SdkExtension
    {
        private RestClient _rc;
        private readonly WebSocketOptions _options;
        private Wsc _wsc;
        private WebsocketClient _ws;
        private ConnectionDetails _connectionDetails;
        
        public event EventHandler<WsgMessage> MessageReceived;
        
        public WebSocketExtension(WebSocketOptions options = null)
        {
            _options = options ?? WebSocketOptions.DefaultInstance;
        }

        public override async Task Install(RestClient rc)
        {
            _rc = rc;
            await Connect();
        }

        private async Task Connect(bool recoverSession = false)
        {
            var wsToken = await this._rc.Post<WsToken>("/restapi/oauth/wstoken");
            var wsUri = $"{wsToken.uri}?access_token={wsToken.ws_access_token}";
            if (recoverSession)
            {
                wsUri = $"{wsUri}&wsc={_wsc.token}";
            }
            _ws = new WebsocketClient(new Uri(wsUri));
            _ws.ReconnectTimeout = TimeSpan.FromMinutes(2);
            
            _ws.ReconnectionHappened.Subscribe(async info =>
            {
                if (info.Type != ReconnectionType.Initial)
                {
                    _ws.Dispose();
                    await Connect(true);
                    if (this._connectionDetails.recoveryState == RecoveryState.Successful)
                    {
                        // todo: manually recover subscriptions
                    }
                }

                _ws.MessageReceived.Subscribe(responseMessage =>
                {
                    var wsgMessage = WsgMessage.Parse(responseMessage.Text);
                    if (_options.debugMode)
                    {
                        Console.WriteLine($"***WebSocket incoming message ({DateTime.Now.ToString(CultureInfo.CurrentCulture)}): ***" +
                                          $"\n{JsonConvert.SerializeObject(wsgMessage, Formatting.Indented)}" +
                                          $"\n******");
                    }
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
                {
                    _wsc = wsgMessage.meta.wsc;
                }

                if (wsgMessage.meta.type == MessageType.ConnectionDetails)
                {
                    _connectionDetails = wsgMessage.body.ToObject<ConnectionDetails>();
                }
            };
            
            await _ws.Start();
        }

        public Task Send(string message)
        {
            if (_options.debugMode)
            {
                Console.WriteLine($"***WebSocket outgoing message ({DateTime.Now.ToString(CultureInfo.CurrentCulture)}): ***" +
                                  $"\n{JsonConvert.SerializeObject(JsonConvert.DeserializeObject(message), Formatting.Indented)}" +
                                  $"\n******");
            }
            return Task.Run(() => _ws.Send(message));
        }

        public async Task<Subscription> Subscribe(string[] eventFilters, Action<string> callback)
        {
            var subscription = new Subscription(this, eventFilters, callback);
            await subscription.SubScribe();
            return subscription;
        }
    }
}