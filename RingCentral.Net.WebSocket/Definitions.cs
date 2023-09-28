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
        public bool autoRecover = true;

        /// <summary>
        ///     Will print logs for debugging purpose
        /// </summary>
        public bool debugMode = false;
    }

    public class WsToken
    {
        public int expires_in;
        public string uri;
        public string ws_access_token;
    }

    public class Wsc
    {
        public int sequence;
        public string token;
    }

    public enum MessageType
    {
        ClientRequest,
        ServerNotification,
        Error,
        ConnectionDetails,
        Heartbeat,
    }

    public class WsgMeta
    {
        public Dictionary<string, string> headers;

        public string messageId;
        public int status;

        [JsonConverter(typeof(StringEnumConverter))]
        public MessageType type;

        public Wsc wsc;
    }

    public class WsgMessage
    {
        public dynamic body;
        public WsgMeta meta;

        public static WsgMessage Parse(string message)
        {
            if (message.Contains(",--Boundary"))
            {
                var index = message.IndexOf(",--Boundary", StringComparison.Ordinal);
                return new WsgMessage
                {
                    meta = JsonConvert.DeserializeObject<WsgMeta>(message.Substring(1, index)),
                    body = message.Substring(index + 1, message.Length - 1)
                };
            }

            var parsed = JsonConvert.DeserializeObject<dynamic>(message) as JArray;
            return new WsgMessage
            {
                meta = parsed[0].ToObject<WsgMeta>(),
                body = parsed.Count> 1 ? parsed[1] : null,
            };
        }
    }

    public enum RecoveryState
    {
        Successful,
        Failed
    }

    public class ConnectionDetails
    {
        public int absoluteTimeout;
        public string creationTime;
        public int idleTimeout;
        public int maxConnectionsPerSession;
        public int recoveryBufferSize;

        public string recoveryErrorCode;

        [JsonConverter(typeof(StringEnumConverter))]
        public RecoveryState recoveryState;

        public int recoveryTimeout;
    }

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
        public string messageId;
        public string method;
        public string path;
        public string type;
    }
}