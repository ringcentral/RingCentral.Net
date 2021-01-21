namespace RingCentral
{
    // Pagination details
    public class PagingResource
    {
        /// <summary>
        /// Page token of the current response list
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        /// Number of records per page
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        /// First page token of the current filter criteria
        /// </summary>
        public string firstPageToken { get; set; }

        /// <summary>
        /// Previous page token of the current filter criteria
        /// </summary>
        public string previousPageToken { get; set; }

        /// <summary>
        /// Next page token of the current filter criteria
        /// </summary>
        public string nextPageToken { get; set; }
    }
}