namespace RingCentral
{
    public class InboundMessageEvent
    {
        /// <summary>
        /// </summary>
        public NotificationInfo aps;

        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        public string messageId;

        /// <summary>
        /// Internal identifier of a conversation
        /// </summary>
        public string conversationId;

        /// <summary>
        /// Sender phone number. For GCM transport type '_from' property should be used
        /// </summary>
        public string from;

        /// <summary>
        /// Receiver phone number
        /// </summary>
        public string to;

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId;
    }
}