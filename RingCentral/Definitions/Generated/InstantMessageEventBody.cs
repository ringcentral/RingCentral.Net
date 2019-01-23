namespace RingCentral
{
    public class InstantMessageEventBody : Serializable
    {
        // Internal identifier of a message
        public string id;
        // Message receiver(s) information
        public NotificationRecipientInfo[] to;
        // Extension Type. For GCM transport type '_from' property should be used
        public SenderInfo from;
        // Type of a message. The default value is 'SMS'
        public string type;
        // Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string creationTime;
        // Datetime when the message was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string lastModifiedTime;
        // Status of a message
        public string readStatus;
        public string priority;
        // Message attachment data
        public MessageAttachmentInfo[] attachments;
        // Message direction
        public string direction;
        // Message availability status
        public string availability;
        // Message subject. It replicates message text which is also returned as an attachment
        public string subject;
        // Status of a message
        public string messageStatus;
        // Deprecated. Identifier of a conversation the message belongs to
        public string conversationId;
        // Information about a conversation the message belongs to
        public ConversationInfo conversation;
        // Internal identifier of a subscription owner extension
        public string ownerId;
    }
}