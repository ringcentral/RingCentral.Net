namespace RingCentral
{
    // Pagination details
    public class PagingResource
    {
        /// <summary>
        /// Page token of the current response list
        /// </summary>
        public string pageToken;

        /// <summary>
        /// Number of records per page
        /// </summary>
        public long? perPage;

        /// <summary>
        /// First page token of the current filter criteria
        /// </summary>
        public string firstPageToken;

        /// <summary>
        /// Previous page token of the current filter criteria
        /// </summary>
        public string previousPageToken;

        /// <summary>
        /// Next page token of the current filter criteria
        /// </summary>
        public string nextPageToken;
    }
}