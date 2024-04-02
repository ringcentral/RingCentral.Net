namespace RingCentral
{
    /// <summary>
    ///     Notification payload body
    /// </summary>
    public class VoicemailMessageEventBody
    {
        /// <summary>
        ///     Internal identifier of a message
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Message receiver(s) information
        /// </summary>
        public NotificationRecipientInfo[] to { get; set; }

        /// <summary>
        /// </summary>
        public SenderInfo from { get; set; }

        /// <summary>
        ///     Type of message
        ///     Enum: Voicemail
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Message creation date/time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)
        ///     format including timezone, for example *2019-03-10T18:07:52.534Z*
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Date/time when a message was modified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)
        ///     format including timezone, for example *2019-03-10T18:07:52.534Z*
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Message read status
        ///     Enum: Read, Unread
        /// </summary>
        public string readStatus { get; set; }

        /// <summary>
        ///     Message priority
        ///     Enum: Normal, High
        /// </summary>
        public string priority { get; set; }

        /// <summary>
        ///     Message attachment data
        /// </summary>
        public MessageAttachmentInfo[] attachments { get; set; }

        /// <summary>
        ///     Text message direction. Note that for some message types not all
        ///     directions are allowed. For example voicemail messages can
        ///     be only inbound
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     Message availability status. Message in 'Deleted' state is still
        ///     preserved with all its attachments and can be restored. 'Purged' means
        ///     that all attachments are already deleted and the message itself is about
        ///     to be physically deleted shortly
        ///     Enum: Alive, Deleted, Purged
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     Message subject. It replicates message text which is also returned as an attachment
        /// </summary>
        public string subject { get; set; }

        /// <summary>
        ///     Message status. Different message types may have different
        ///     allowed status values. For outbound faxes the aggregated message status
        ///     is returned. If, for outbound message, a status for at least one recipient is 'Queued', then
        ///     the 'Queued' value is returned. If a status for at least one recipient is
        ///     'SendingFailed', then the 'SendingFailed' value is returned. In other cases
        ///     the 'Sent' status is returned
        ///     Enum: Queued, Sent, Delivered, DeliveryFailed, SendingFailed, Received
        /// </summary>
        public string messageStatus { get; set; }

        /// <summary>
        ///     Status of a voicemail to text transcription. Specifies if a voicemail message transcription is already completed or
        ///     not
        ///     If 'VoicemailToText' feature is not activated for account, the 'NotAvailable' value is returned
        ///     Enum: NotAvailable, InProgress, TimedOut, Completed, CompletedPartially, Failed, Unknown
        /// </summary>
        public string vmTranscriptionStatus { get; set; }
    }
}