namespace RingCentral
{
    // Notification payload body
    public class FaxMessageEventBody
    {
        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public NotificationRecipientInfo[] to;

        /// <summary>
        /// </summary>
        public SenderInfo from;

        /// <summary>
        /// Type of a message
        /// Enum: Fax
        /// </summary>
        public string type;

        /// <summary>
        /// Message creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Datetime when the message was modified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// Status of a message
        /// Default: Unread
        /// </summary>
        public string readStatus;

        /// <summary>
        /// Default: Normal
        /// </summary>
        public string priority;

        /// <summary>
        /// Message attachment data
        /// </summary>
        public FaxMessageAttachment[] attachments;

        /// <summary>
        /// Message direction
        /// Default: Inbound
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
        /// Resolution of a fax message. ('High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi)
        /// </summary>
        public string faxResolution;

        /// <summary>
        /// Page count of a fax message
        /// </summary>
        public long? faxPageCount;
    }
}