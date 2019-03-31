namespace RingCentral
{
    public class ListGlipConversationsParameters
    {
        /// <summary>
        /// Number of conversations to be fetched by one request. The maximum value is 250, by default - 30
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