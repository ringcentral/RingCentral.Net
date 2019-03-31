namespace RingCentral
{
    public class ListGlipChatsParameters
    {
        /// <summary>
        /// Type of chats to be fetched. By default all type of chats will be fetched
        /// </summary>
        public string[] type;

        /// <summary>
        /// Number of chats to be fetched by one request. The maximum value is 250, by default - 30.
        /// Maximum: 250
        /// Default: 30
        /// </summary>
        public long? recordCount;

        /// <summary>
        /// Pagination token.
        /// </summary>
        public string pageToken;
    }
}