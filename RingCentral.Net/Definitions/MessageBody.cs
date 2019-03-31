namespace RingCentral
{
    public class MessageBody
    {
        /* Canonical URI of a message */
        public string uri;

        /* Internal identifier of a message */
        public string id;

        /* The list of message attachments */
        public MessageAttachmentInfo[] attachments;

        /* Message availability status. Message in 'Deleted' state is still preserved with all its attachments and can be restored. 'Purged' means that all attachments are already deleted and the message itself is about to be physically deleted shortly */
        // Enum: Alive, Deleted, Purged
        public string availability;

        /* SMS and Pager only. Identifier of a conversation the message belongs to */
        public long? conversationId;

        /* SMS and Pager only. Identifier of a conversation the message belongs to */
        public ConversationInfo conversation;

        /* Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z */
        public string creationTime;

        /* SMS only. Delivery error code returned by gateway */
        public string deliveryErrorCode;

        /* Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound */
        // Enum: Inbound, Outbound
        public string direction;

        /* Fax only. Page count in a fax message */
        public long? faxPageCount;

        /* Fax only. Resolution of a fax message. 'High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi */
        // Enum: High, Low
        public string faxResolution;

        /* Sender information */
        public MessageSenderInfo from;

        /* The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z */
        public string lastModifiedTime;

        /* Message status. Different message types may have different allowed status values.For outbound faxes the aggregated message status is returned: If status for at least one recipient is 'Queued', then 'Queued' value is returned If status for at least one recipient is 'SendingFailed', then 'SendingFailed' value is returned In other cases Sent status is returned */
        // Enum: Queued, Sent, Delivered, DeliveryFailed, SendingFailed, Received
        public string messageStatus;

        /* 'Pager' only. 'True' if at least one of the message recipients is 'Department' extension */
        public bool? pgToDepartment;

        /* Message priority */
        // Enum: Normal, High
        public string priority;

        /* Message read status */
        // Enum: Read, Unread
        public string readStatus;

        /* SMS only. The datetime when outbound SMS was delivered to recipient's handset in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. It is filled only if the carrier sends a delivery receipt to RingCentral */
        public string smsDeliveryTime;

        /* SMS only. Number of attempts made to send an outbound SMS to the gateway (if gateway is temporary unavailable) */
        public long? smsSendingAttemptsCount;

        /* Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment */
        public string subject;

        /* Recipient information */
        public MessageRecipientInfo[] to;

        /* Message type */
        // Enum: Fax, SMS, VoiceMail, Pager, Text
        public string type;

        /* Voicemail only. Status of voicemail to text transcription. If VoicemailToText feature is not activated for account, the 'NotAvailable' value is returned */
        // Enum: NotAvailable, InProgress, TimedOut, Completed, CompletedPartially, Failed
        public string vmTranscriptionStatus;
    }
}