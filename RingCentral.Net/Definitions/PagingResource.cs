namespace RingCentral
{
    // Pagination details
    public class PagingResource
    {
        /// <summary>
        ///     Page token of the current response list
        ///     Example: pgt1
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Number of records per page
        ///     Example: 3
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     First page token of the current filter criteria
        ///     Example: fpgt1
        /// </summary>
        public string firstPageToken { get; set; }

        /// <summary>
        ///     Previous page token of the current filter criteria
        ///     Example: lpgt1
        /// </summary>
        public string previousPageToken { get; set; }

        /// <summary>
        ///     Next page token of the current filter criteria
        ///     Example: npgt1
        /// </summary>
        public string nextPageToken { get; set; }
    }
}