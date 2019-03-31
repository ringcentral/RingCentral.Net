namespace RingCentral
{
    public class ListGlipChatsParameters
    {
        /* Type of chats to be fetched. By default all type of chats will be fetched */
        public string[] type;

        /* Number of chats to be fetched by one request. The maximum value is 250, by default - 30. */
        // Maximum: 250
        // Default: 30
        public long? recordCount;

        /* Pagination token. */
        public string pageToken;
    }
}