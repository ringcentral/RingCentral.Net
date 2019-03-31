namespace RingCentral
{
    public class SyncMessagesParameters
    {
        /* Conversation identifier for the resulting messages. Meaningful for SMS and Pager messages only. */
        public long? conversationId;

        /* The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours */
        public string dateFrom;

        /* The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time */
        public string dateTo;

        /* Direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted */
        public string[] direction;

        /* If 'True', then the latest messages per every conversation ID are returned */
        public bool? distinctConversations;

        /* Type for the resulting messages. If not specified, all types of messages are returned. Multiple values are accepted */
        public string[] messageType;

        /* Limits the number of records to be returned (works in combination with dateFrom and dateTo if specified) */
        public long? recordCount;

        /* Value of syncToken property of last sync request response */
        public string syncToken;

        /* Type of message synchronization */
        public string[] syncType;
    }
}