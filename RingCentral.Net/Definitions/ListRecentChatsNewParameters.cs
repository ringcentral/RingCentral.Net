namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listRecentChatsNew
    /// </summary>
    public class ListRecentChatsNewParameters
    {
        /// <summary>
        ///     Type of chats to be fetched. By default, all chat types are returned
        ///     Enum: Everyone, Group, Personal, Direct, Team
        /// </summary>
        public string[] type { get; set; }

        /// <summary>
        ///     Max number of chats to be fetched by one request (Not more than 250).
        ///     Maximum: 250
        ///     Format: int32
        ///     Default: 30
        /// </summary>
        public long? recordCount { get; set; }
    }
}