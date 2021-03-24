namespace RingCentral
{
    // Query parameters for operation syncMessages
    public class SyncMessagesParameters
    {
        /// <summary>
        /// Conversation identifier for the resulting messages. Meaningful for SMS and Pager messages only.
        /// </summary>
        public long? conversationId { get; set; }

        /// <summary>
        /// The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        /// The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        /// Direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
        /// Enum: Inbound, Outbound
        /// </summary>
        public string[] direction { get; set; }

        /// <summary>
        /// If 'True', then the latest messages per every conversation ID are returned
        /// </summary>
        public bool? distinctConversations { get; set; }

        /// <summary>
        /// Type for the resulting messages. If not specified, all types of messages are returned. Multiple values are accepted
        /// Enum: Fax, SMS, VoiceMail, Pager, Text
        /// </summary>
        public string[] messageType { get; set; }

        /// <summary>
        /// Limits the number of records to be returned (works in combination with dateFrom and dateTo if specified)
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        /// Value of syncToken property of last sync request response
        /// </summary>
        public string syncToken { get; set; }

        /// <summary>
        /// Type of message synchronization
        /// Enum: FSync, ISync
        /// </summary>
        public string syncType { get; set; }
    }
}