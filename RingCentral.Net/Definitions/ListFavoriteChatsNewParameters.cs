namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listFavoriteChatsNew
    /// </summary>
    public class ListFavoriteChatsNewParameters
    {
        /// <summary>
        ///     Max number of chats to be fetched by one request (Not more than 250).
        ///     Maximum: 250
        ///     Format: int32
        ///     Default: 30
        /// </summary>
        public long? recordCount { get; set; }
    }
}