namespace RingCentral
{
    public class GetSMSMessageInfoResponse
    {
        /// <summary>
        ///     Internal identifier of a message
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of a message
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of message attachments
        /// </summary>
        public MessageAttachmentInfo[] attachments { get; set; }

        /// <summary>
        ///     Message availability status. Message in 'Deleted' state is still
        ///     preserved with all its attachments and can be restored. 'Purged' means
        ///     that all attachments are already deleted and the message itself is about
        ///     to be physically deleted shortly
        ///     Enum: Alive, Deleted, Purged
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     SMS and Pager only. Identifier of a conversation that the message
        ///     belongs to
        ///     Format: int64
        /// </summary>
        public long? conversationId { get; set; }

        /// <summary>
        /// </summary>
        public ConversationInfo conversation { get; set; }

        /// <summary>
        ///     Message creation date/time in ISO 8601 format including timezone,
        ///     for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     SMS only. Delivery error code returned by gateway
        /// </summary>
        public string deliveryErrorCode { get; set; }

        /// <summary>
        ///     Text message direction. Note that for some message types not all
        ///     directions are allowed. For example voicemail messages can
        ///     be only inbound
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        /// </summary>
        public MessageStoreCallerInfoResponseFrom from { get; set; }

        /// <summary>
        ///     Date/time when the message was modified on server in ISO
        ///     8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

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
        ///     SMS only. The date/time when outbound SMS was delivered to
        ///     recipient's handset in ISO 8601 format including timezone,
        ///     for example 2016-03-10T18:07:52.534Z. It is filled only if
        ///     the carrier sends a delivery receipt to RingCentral
        ///     Format: date-time
        /// </summary>
        public string smsDeliveryTime { get; set; }

        /// <summary>
        ///     SMS only. Number of attempts made to send an outbound SMS to
        ///     the Gateway (if Gateway is temporary unavailable)
        ///     Format: int32
        /// </summary>
        public long? smsSendingAttemptsCount { get; set; }

        /// <summary>
        ///     Message subject. For SMS and Pager messages it replicates message
        ///     text which is also returned as an attachment
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
    }
}