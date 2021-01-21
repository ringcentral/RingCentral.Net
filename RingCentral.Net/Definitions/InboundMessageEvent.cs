namespace RingCentral
{
    public class InboundMessageEvent
    {
        /// <summary>
        /// </summary>
        public NotificationInfo aps { get; set; }

        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        public string messageId { get; set; }

        /// <summary>
        /// Internal identifier of a conversation
        /// </summary>
        public string conversationId { get; set; }

        /// <summary>
        /// Sender phone number. For GCM transport type '_from' property should be used
        /// </summary>
        public string from { get; set; }

        /// <summary>
        /// Receiver phone number
        /// </summary>
        public string to { get; set; }

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}