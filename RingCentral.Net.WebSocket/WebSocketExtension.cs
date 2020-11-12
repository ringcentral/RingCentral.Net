using System;
using System.Threading.Tasks;
using Websocket.Client;

namespace RingCentral.Net.WebSocket
{
    public class WebSocketExtension : SdkExtension
    {
        private RestClient _rc;
        private readonly WebSocketOptions _options;
        private Wsc _wsc;
        public WebsocketClient ws;
        private ConnectionDetails _connectionDetails;
        
        public event EventHandler<WebsocketClient> AutoRecoverSuccess;

        public WebSocketExtension(WebSocketOptions options = null)
        {
            this._options = options ?? WebSocketOptions.DefaultInstance;
        }

        public override async Task Install(RestClient rc)
        {
            this._rc = rc;
            await this.Connect();
        }

        private async Task Connect(bool recoverSession = false)
        {
            var wsToken = await this._rc.Post<WsToken>("/restapi/oauth/wstoken");
            var wsUri = $"{wsToken.uri}?access_token={wsToken.ws_access_token}";
            if (recoverSession)
            {
                wsUri = $"{wsUri}&wsc={_wsc.token}";
            }

            ws = new WebsocketClient(new Uri(wsUri));
            ws.ReconnectTimeout = TimeSpan.FromMinutes(3);
            // listen for incoming events
            ws.MessageReceived.Subscribe(responseMessage =>
            {
                var wsgMsg = WsgMessage.Parse(responseMessage.Text);
                if (wsgMsg.meta.wsc != null && (_wsc == null ||
                                                (wsgMsg.meta.type ==
                                                 MessageType.ConnectionDetails &&
                                                 wsgMsg.body.GetType().GetProperty("recoveryState") != null) ||
                                                _wsc?.sequence < wsgMsg.meta.wsc.sequence))
                {
                    _wsc = wsgMsg.meta.wsc;
                }

                if (wsgMsg.meta.type == MessageType.ConnectionDetails)
                {
                    _connectionDetails = wsgMsg.body.ToObject<ConnectionDetails>();
                }
            });
            await ws.Start();
            ws.ReconnectionHappened.Subscribe(async info =>
            {
                ws.Dispose();
                await Connect(true);
                if (this._connectionDetails.recoveryState == RecoveryState.Successful)
                {
                    AutoRecoverSuccess?.Invoke(this, ws);
                }
            });
        }

        public Task Send(string message)
        {
            return Task.Run(() => ws.Send(message));
        }

        public async Task<Subscription> Subscribe(string[] eventFilters, Action<string> callback)
        {
            var subscription = new Subscription(this, eventFilters, callback);
            await subscription.SubScribe();
            return subscription;
        }
    }
}