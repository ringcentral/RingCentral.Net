namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listGlipChats
    /// </summary>
    public class ListGlipChatsParameters
    {
        /// <summary>
        ///     Type of chats to be fetched. By default all type of chats will be fetched
        ///     Enum: Personal, Direct, Group, Team, Everyone
        /// </summary>
        public string[] type { get; set; }

        /// <summary>
        ///     Number of chats to be fetched by one request. The maximum value is 250, by default - 30.
        ///     Maximum: 250
        ///     Default: 30
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        ///     Pagination token.
        /// </summary>
        public string pageToken { get; set; }
    }
}