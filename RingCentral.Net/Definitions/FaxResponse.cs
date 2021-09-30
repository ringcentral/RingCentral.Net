namespace RingCentral
{
    public class FaxResponse
    {
        /// <summary>
        ///     Internal identifier of a message
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of a message
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Message type - 'Fax'
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CallerInfoFrom from { get; set; }

        /// <summary>
        ///     Recipient information
        /// </summary>
        public CallerInfoTo[] to { get; set; }

        /// <summary>
        ///     Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

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
        ///     The list of message attachments
        /// </summary>
        public MessageAttachmentInfoIntId[] attachments { get; set; }

        /// <summary>
        ///     Message direction
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     Message availability status. Message in 'Deleted' state is still preserved with all its attachments and can be
        ///     restored. 'Purged' means that all attachments are already deleted and the message itself is about to be physically
        ///     deleted shortly
        ///     Enum: Alive, Deleted, Purged
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     Message status. 'Queued' - the message is queued for sending; 'Sent' - a message is successfully sent;
        ///     'SendingFailed' - a message sending attempt has failed; 'Received' - a message is received (inbound messages have
        ///     this status by default)
        ///     Enum: Queued, Sent, SendingFailed, Received
        /// </summary>
        public string messageStatus { get; set; }

        /// <summary>
        ///     Resolution of a fax message. ('High' for black and white image scanned at 200 dpi, 'Low' for black and white image
        ///     scanned at 100 dpi)
        ///     Enum: High, Low
        /// </summary>
        public string faxResolution { get; set; }

        /// <summary>
        ///     Page count in a fax message
        /// </summary>
        public long? faxPageCount { get; set; }

        /// <summary>
        ///     Datetime when the message was modified on server in ISO 8601 format including timezone, for example
        ///     2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Cover page identifier. If coverIndex is set to '0' (zero) cover page is not attached. For the list of available
        ///     cover page identifiers (1-13) please call the Fax Cover Pages method. If not specified, the default cover page is
        ///     attached (which is configured in 'Outbound Fax Settings')
        /// </summary>
        public long? coverIndex { get; set; }

        /// <summary>
        ///     Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols
        /// </summary>
        public string coverPageText { get; set; }
    }
}