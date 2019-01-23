namespace RingCentral
{
    public class FaxResponse : Serializable
    {
        // Internal identifier of a message
        public long? id;

        // Canonical URI of a message
        public string uri;

        // Message type - 'Fax'
        public string type;

        // Sender information
        public CallerInfoFrom from;

        // Recipient information
        public CallerInfoTo[] to;

        // Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string creationTime;

        // Message read status
        // Enum: Read, Unread
        public string readStatus;

        // Message priority
        // Enum: Normal, High
        public string priority;

        // The list of message attachments
        public MessageAttachmentInfoIntId[] attachments;

        // Message direction
        // Enum: Inbound, Outbound
        public string direction;

        // Message availability status. Message in 'Deleted' state is still preserved with all its attachments and can be restored. 'Purged' means that all attachments are already deleted and the message itself is about to be physically deleted shortly
        // Enum: Alive, Deleted, Purged
        public string availability;

        // Message status. 'Queued' - the message is queued for sending; 'Sent' - a message is successfully sent; 'SendingFailed' - a message sending attempt has failed; 'Received' - a message is received (inbound messages have this status by default)
        // Enum: Queued, Sent, SendingFailed, Received
        public string messageStatus;

        // Resolution of a fax message. ('High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi)
        // Enum: High, Low
        public string faxResolution;

        // Page count in a fax message
        public long? faxPageCount;

        // Datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string lastModifiedTime;

        // Cover page identifier. For the list of available cover page identifiers please call the method Fax Cover Pages
        public long? coverIndex;

        // Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols
        public string coverPageText;
    }
}