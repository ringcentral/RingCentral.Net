namespace RingCentral
{
    public class ListMessagesParameters
    {
        // Specifies the availability status for the resulting messages. Multiple values are accepted
        public string[] availability;

        // Specifies the conversation identifier for the resulting messages
        public long? conversationId;

        // The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
        public string dateFrom;

        // The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
        public string dateTo;

        // The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
        public string[] direction;

        // If 'True', then the latest messages per every conversation ID are returned
        public bool? distinctConversations;

        // The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted
        public string[] messageType;

        // The read status for the resulting messages. Multiple values are accepted
        public string[] readStatus;

        // Indicates the page number to retrieve. Only positive number values are accepted
        // Default: 1
        public long? page;

        // Indicates the page size (number of items)
        // Default: 100
        public long? perPage;

        // The phone number. If specified, messages are returned for this particular phone number only
        public string phoneNumber;
    }
}