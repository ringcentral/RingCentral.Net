namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listMessages
    /// </summary>
    public class ListMessagesParameters
    {
        /// <summary>
        ///     Specifies the availability status for resulting messages.
        ///     Multiple values are accepted
        ///     Enum: Alive, Deleted, Purged
        /// </summary>
        public string[] availability { get; set; }

        /// <summary>
        ///     Specifies a conversation identifier for the resulting messages
        /// </summary>
        public string conversationId { get; set; }

        /// <summary>
        ///     Start date/time for resulting messages in ISO 8601 format
        ///     including timezone, for example 2016-03-10T18:07:52.534Z. The default value
        ///     is dateTo minus 24 hours
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     End date/time for resulting messages in ISO 8601 format including
        ///     timezone, for example 2016-03-10T18:07:52.534Z. The default value is current
        ///     time
        ///     Format: date-time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     Direction for resulting messages. If not specified, both
        ///     inbound and outbound messages are returned. Multiple values are accepted
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string[] direction { get; set; }

        /// <summary>
        ///     If `true`, then the latest messages per every conversation ID
        ///     are returned
        /// </summary>
        public bool? distinctConversations { get; set; }

        /// <summary>
        ///     Type of resulting messages. If not specified, all messages
        ///     without message type filtering are returned. Multiple values are accepted
        ///     Enum: Fax, SMS, VoiceMail, Pager
        /// </summary>
        public string[] messageType { get; set; }

        /// <summary>
        ///     Read status for resulting messages. Multiple values are
        ///     accepted
        ///     Enum: Read, Unread
        /// </summary>
        public string[] readStatus { get; set; }

        /// <summary>
        ///     Indicates a page number to retrieve. Only positive number values
        ///     are accepted
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates a page size (number of items)
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Phone number. If specified, messages are returned for this
        ///     particular phone number only
        /// </summary>
        public string phoneNumber { get; set; }
    }
}