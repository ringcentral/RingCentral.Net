using System;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RingCentral.Net.WebSocket
{
    public class WebSocketExtension : SdkExtension
    {
        private RestClient _rc;
        private readonly WebSocketOptions _options;
        private Wsc _wsc;
        private ClientWebSocket _ws;
        private ConnectionDetails _connectionDetails;
        public event EventHandler<WsgMessage> WebSocketMessage;

        private Task<WsgMessage> WaitForMessage(Func<WsgMeta, bool> condition)
        {
            var taskCompletionSource = new TaskCompletionSource<WsgMessage>();

            void Handler(object sender, WsgMessage msg)
            {
                if (condition(msg.meta))
                {
                    WebSocketMessage -= Handler;
                    taskCompletionSource.SetResult(msg);
                }
            }

            WebSocketMessage += Handler;
            return taskCompletionSource.Task;
        }

        public WebSocketExtension(WebSocketOptions options = null)
        {
            this._options = options ?? WebSocketOptions.DefaultInstance;
        }

        public override async void Install(RestClient rc)
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

            _ws = new ClientWebSocket();
            await _ws.ConnectAsync(new Uri(wsUri), CancellationToken.None);
            
            await Receive().ConfigureAwait(false);
            
            // listen for new wsc data
            WebSocketMessage += (sender, msg) =>
            {
                if (msg.meta.wsc != null && (_wsc == null ||
                                             (msg.meta.type ==
                                              MessageType.ConnectionDetails &&
                                              msg.body.GetType().GetProperty("recoveryState") != null) ||
                                             _wsc?.sequence < msg.meta.wsc.sequence))
                {
                    _wsc = msg.meta.wsc;
                }
            };
            
            // get ConnectionDetails data
            var cdsMsg = await WaitForMessage(meta => meta.type == MessageType.ConnectionDetails);
            this._connectionDetails = cdsMsg.body;
        }

        public async Task Send(string message)
        {
            var encoded = Encoding.UTF8.GetBytes(message);
            var buffer = new ArraySegment<Byte>(encoded, 0, encoded.Length);
            await _ws.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
            Console.WriteLine("Sent", message);
        }

        private async Task Receive()
        {
            while (true)
            {
                var buffer = new ArraySegment<byte>(new Byte[8192]);
                using (var ms = new MemoryStream())
                {
                    WebSocketReceiveResult result = null;
                    do
                    {
                        result = await _ws.ReceiveAsync(buffer, CancellationToken.None);
                        // ReSharper disable once AssignNullToNotNullAttribute
                        
                        ms.Write(buffer.Array, buffer.Offset, result.Count);
                    } while (!result.EndOfMessage);

                    ms.Seek(0, SeekOrigin.Begin);
                    using (var reader = new StreamReader(ms, Encoding.UTF8))
                    {
                        var message = await reader.ReadToEndAsync();
                        WebSocketMessage?.Invoke(this, WsgMessage.Parse((message)));
                        Console.WriteLine("Received", message);
                    }
                }
            }
        }
    }
}