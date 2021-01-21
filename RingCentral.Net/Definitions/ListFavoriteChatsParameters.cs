namespace RingCentral
{
    public class ListFavoriteChatsParameters
    {
        /// <summary>
        /// Max number of chats to be fetched by one request (Not more than 250).
        /// Maximum: 250
        /// Default: 30
        /// </summary>
        public long? recordCount { get; set; }
    }
}