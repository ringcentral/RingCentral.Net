namespace RingCentral
{
    public class ListMessagesParameters
    {
        /// <summary>
        /// Specifies the availability status for the resulting messages. Multiple values are accepted
        /// Enum: Alive, Deleted, Purged
        /// </summary>
        public string[] availability;

        /// <summary>
        /// Specifies the conversation identifier for the resulting messages
        /// </summary>
        public long? conversationId;

        /// <summary>
        /// The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
        /// </summary>
        public string dateFrom;

        /// <summary>
        /// The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
        /// </summary>
        public string dateTo;

        /// <summary>
        /// The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
        /// Enum: Inbound, Outbound
        /// </summary>
        public string[] direction;

        /// <summary>
        /// If 'True', then the latest messages per every conversation ID are returned
        /// </summary>
        public bool? distinctConversations;

        /// <summary>
        /// The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted
        /// Enum: Fax, SMS, VoiceMail, Pager, Text
        /// </summary>
        public string[] messageType;

        /// <summary>
        /// The read status for the resulting messages. Multiple values are accepted
        /// Enum: Read, Unread
        /// </summary>
        public string[] readStatus;

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage;

        /// <summary>
        /// The phone number. If specified, messages are returned for this particular phone number only
        /// </summary>
        public string phoneNumber;
    }
}