namespace RingCentral
{
    public class VoicemailMessageEventBody
    {
        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        public string id;

        /// <summary>
        /// Message receiver(s) information
        /// </summary>
        public NotificationRecipientInfo[] to;

        /// <summary>
        /// Message sender information
        /// </summary>
        public SenderInfo from;

        /// <summary>
        /// Type of a message
        /// Enum: Voicemail
        /// </summary>
        public string type;

        /// <summary>
        /// Message creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2019-03-10T18:07:52.534Z*
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Datetime when the message was modified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2019-03-10T18:07:52.534Z*
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// Status of a message
        /// Default: Unread
        /// </summary>
        public string readStatus;

        /// <summary>
        /// Message priority
        /// Default: Normal
        /// </summary>
        public string priority;

        /// <summary>
        /// Message attachment data
        /// </summary>
        public MessageAttachmentInfo[] attachments;

        /// <summary>
        /// Message direction
        /// Default: Inbound
        /// Enum: Inbound, Outbound
        /// </summary>
        public string direction;

        /// <summary>
        /// Message availability status
        /// Default: Alive
        /// </summary>
        public string availability;

        /// <summary>
        /// Message subject. It replicates message text which is also returned as an attachment
        /// </summary>
        public string subject;

        /// <summary>
        /// Status of a message
        /// Default: Received
        /// </summary>
        public string messageStatus;

        /// <summary>
        /// Internal identifier of a conversation this message belongs to
        /// </summary>
        public string conversationId;

        /// <summary>
        /// Specifies if a voicemail message transcription is already completed or not
        /// </summary>
        public string vmTranscriptionStatus;
    }
}