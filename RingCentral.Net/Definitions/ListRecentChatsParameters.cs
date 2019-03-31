namespace RingCentral
{
    public class ListRecentChatsParameters
    {
        /* Type of chats to be fetched. By default all chat types are returned */
        public string[] type;

        /* Max number of chats to be fetched by one request (Not more than 250). */
        // Maximum: 250
        // Default: 30
        public long? recordCount;
    }
}