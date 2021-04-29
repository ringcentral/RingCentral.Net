namespace RingCentral
{
    // Notification payload body
    public class FaxMessageEventBody
    {
        /// <summary>
        ///     Internal identifier of a message
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public NotificationRecipientInfo[] to { get; set; }

        /// <summary>
        /// </summary>
        public SenderInfo from { get; set; }

        /// <summary>
        ///     Type of a message
        ///     Enum: Fax
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Message creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Datetime when the message was modified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*
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
        public FaxMessageAttachment[] attachments { get; set; }

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
        ///     Internal identifier of a conversation this message belongs to
        /// </summary>
        public string conversationId { get; set; }

        /// <summary>
        ///     Resolution of a fax message. ('High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi)
        /// </summary>
        public string faxResolution { get; set; }

        /// <summary>
        ///     Page count of a fax message
        /// </summary>
        public long? faxPageCount { get; set; }
    }
}