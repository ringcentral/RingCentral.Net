namespace RingCentral
{
    public class GetMessageInfoResponse
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
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     The list of message attachments
        /// </summary>
        public MessageAttachmentInfo[] attachments { get; set; }

        /// <summary>
        ///     Message availability status. Message in 'Deleted' state is still preserved with all its attachments and can be restored. 'Purged' means that all attachments are already deleted and the message itself is about to be physically deleted shortly
        ///     Enum: Alive, Deleted, Purged
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     SMS and Pager only. Identifier of a conversation the message belongs to
        ///     Format: int64
        /// </summary>
        public long? conversationId { get; set; }

        /// <summary>
        /// </summary>
        public ConversationInfo conversation { get; set; }

        /// <summary>
        ///     Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     SMS only. Delivery error code returned by gateway
        /// </summary>
        public string deliveryErrorCode { get; set; }

        /// <summary>
        ///     Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     Fax only. Page count in a fax message
        /// </summary>
        public long? faxPageCount { get; set; }

        /// <summary>
        ///     Fax only. Resolution of a fax message. 'High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi
        ///     Enum: High, Low
        /// </summary>
        public string faxResolution { get; set; }

        /// <summary>
        /// </summary>
        public MessageStoreCallerInfoResponseFrom from { get; set; }

        /// <summary>
        ///     The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Message status. Different message types may have different allowed status values. For outbound faxes the aggregated message status is returned: If status for at least one recipient is 'Queued', then 'Queued' value is returned If status for at least one recipient is 'SendingFailed', then 'SendingFailed' value is returned In other cases Sent status is returned
        ///     Enum: Queued, Sent, Delivered, DeliveryFailed, SendingFailed, Received
        /// </summary>
        public string messageStatus { get; set; }

        /// <summary>
        ///     'Pager' only. 'True' if at least one of the message recipients is 'Department' extension
        /// </summary>
        public bool? pgToDepartment { get; set; }

        /// <summary>
        ///     Message priority
        ///     Enum: Normal, High
        /// </summary>
        public string priority { get; set; }

        /// <summary>
        ///     Message read status
        ///     Enum: Read, Unread
        /// </summary>
        public string readStatus { get; set; }

        /// <summary>
        ///     SMS only. The datetime when outbound SMS was delivered to recipient's handset in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. It is filled only if the carrier sends a delivery receipt to RingCentral
        ///     Format: date-time
        /// </summary>
        public string smsDeliveryTime { get; set; }

        /// <summary>
        ///     SMS only. Number of attempts made to send an outbound SMS to the gateway (if gateway is temporary unavailable)
        /// </summary>
        public long? smsSendingAttemptsCount { get; set; }

        /// <summary>
        ///     Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment
        /// </summary>
        public string subject { get; set; }

        /// <summary>
        ///     Recipient information
        /// </summary>
        public MessageStoreCallerInfoResponseTo[] to { get; set; }

        /// <summary>
        ///     Message type
        ///     Enum: Fax, SMS, VoiceMail, Pager, Text
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Voicemail only. Status of voicemail to text transcription. If VoicemailToText feature is not activated for account, the 'NotAvailable' value is returned
        ///     Enum: NotAvailable, InProgress, TimedOut, Completed, CompletedPartially, Failed, Unknown
        /// </summary>
        public string vmTranscriptionStatus { get; set; }

        /// <summary>
        ///     Cover page identifier. If coverIndex is set to '0' (zero) cover page is not attached. For the list of available cover page identifiers (1-13) please call the Fax Cover Pages method. If not specified, the default cover page is attached (which is configured in 'Outbound Fax Settings')
        /// </summary>
        public long? coverIndex { get; set; }

        /// <summary>
        ///     Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols
        /// </summary>
        public string coverPageText { get; set; }
    }
}