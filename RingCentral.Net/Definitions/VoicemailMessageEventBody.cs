namespace RingCentral
{
    /// <summary>
    ///     Notification payload body
    /// </summary>
    public class VoicemailMessageEventBody
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
        ///     Type of a message
        ///     Enum: Voicemail
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Message creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for
        ///     example *2019-03-10T18:07:52.534Z*
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Datetime when the message was modified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including
        ///     timezone, for example *2019-03-10T18:07:52.534Z*
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Status of a message
        ///     Default: Unread
        /// </summary>
        public string readStatus { get; set; }

        /// <summary>
        ///     Message priority
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
        ///     Enum: Inbound, Outbound
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
        ///     Internal identifier of a conversation this message belongs to
        /// </summary>
        public string conversationId { get; set; }

        /// <summary>
        ///     Specifies if a voicemail message transcription is already completed or not
        /// </summary>
        public string vmTranscriptionStatus { get; set; }
    }
}