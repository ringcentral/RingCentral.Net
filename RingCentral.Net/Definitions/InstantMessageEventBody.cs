namespace RingCentral
{
    /// <summary>
    ///     Notification payload body
    /// </summary>
    public class InstantMessageEventBody
    {
        /// <summary>
        ///     Internal identifier of a message
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Message receiver(s) information
        /// </summary>
        public NotificationRecipientInfo[] to { get; set; }

        /// <summary>
        /// </summary>
        public SenderInfo from { get; set; }

        /// <summary>
        ///     Type of a message. The default value is 'SMS'
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Datetime when the message was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Status of a message
        ///     Default: Unread
        /// </summary>
        public string readStatus { get; set; }

        /// <summary>
        ///     Default: Normal
        /// </summary>
        public string priority { get; set; }

        /// <summary>
        ///     Message attachment data
        /// </summary>
        public MessageAttachmentInfo[] attachments { get; set; }

        /// <summary>
        ///     Message direction
        ///     Default: Inbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     Message availability status
        ///     Default: Alive
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     Message subject. It replicates message text which is also returned as an attachment
        /// </summary>
        public string subject { get; set; }

        /// <summary>
        ///     Status of a message
        ///     Default: Received
        /// </summary>
        public string messageStatus { get; set; }

        /// <summary>
        ///     Deprecated. Identifier of a conversation the message belongs to
        /// </summary>
        public string conversationId { get; set; }

        /// <summary>
        /// </summary>
        public ConversationInfo conversation { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}