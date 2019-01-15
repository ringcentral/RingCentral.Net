using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class InboundMessageEvent : Serializable
    {
        // Information on a notification
        public NotificationInfo aps;
        // Internal identifier of a message
        public string messageId;
        // Internal identifier of an conversation
        public string conversationId;
        // Sender phone number. For GCM transport type '_from' property should be used
        public string from;
        // Receiver phone number
        public string to;
        // Internal identifier of a subscription owner extension
        public string ownerId;
    }
}