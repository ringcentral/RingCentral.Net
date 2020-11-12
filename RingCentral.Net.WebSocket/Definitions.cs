using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace RingCentral.Net.WebSocket
{
    public class WebSocketOptions
    {
        public static readonly WebSocketOptions DefaultInstance = new WebSocketOptions();
        public bool restOverWebSocket = false;
        public bool debugMode = false;
        public bool autoRecover = true;
    }

    public class WsToken
    {
        public string uri;
        public string ws_access_token;
        public int expires_in;
    }

    public class Wsc
    {
        public string token;
        public int sequence;
    }

    public enum MessageType
    {
        ClientRequest,
        ServerNotification,
        Error,
        ConnectionDetails,
    }

    public class WsgMeta
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageType type;

        public string messageId;
        public int status;
        public Dictionary<string, string> headers;
        public Wsc wsc;
    }

    public class WsgMessage
    {
        public WsgMeta meta;
        public dynamic body;

        public static WsgMessage Parse(string message)
        {
            if (message.Contains(",--Boundary"))
            {
                var index = message.IndexOf(",--Boundary", StringComparison.Ordinal);
                return new WsgMessage
                {
                    meta = JsonConvert.DeserializeObject<WsgMeta>(message.Substring(1, index)),
                    body = message.Substring(index + 1, message.Length - 1),
                };
            }
            else
            {
                var parsed = JsonConvert.DeserializeObject<dynamic>(message);
                return new WsgMessage
                {
                    meta = parsed[0].ToObject<WsgMeta>(),
                    body = parsed[1],
                };
            }
        }
    }

    public enum RecoveryState
    {
        Successful,
        Failed,
    }

    public class ConnectionDetails
    {
        public string creationTime;
        public int maxConnectionsPerSession;
        public int recoveryBufferSize;
        public int recoveryTimeout;
        public int idleTimeout;
        public int absoluteTimeout;

        [JsonConverter(typeof(StringEnumConverter))]
        public RecoveryState recoveryState;

        public string recoveryErrorCode;
    };

    public class SubscriptionRequestBody
    {
        public SubscriptionRequestBodyDeliveryMode deliveryMode;
        public string[] eventFilters;
    }

    public class SubscriptionRequestBodyDeliveryMode
    {
        public string transportType;
    }

    public class RestRequestHeaders
    {
        public string type;
        public string messageId;
        public string method;
        public string path;
    }
}