namespace RingCentral
{
    // Query parameters for operation readGlipPosts
    public class ReadGlipPostsParameters
    {
        /// <summary>
        /// Max number of posts to be fetched by one request (not more than 250)
        /// Maximum: 250
        /// Default: 30
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        /// Pagination token.
        /// </summary>
        public string pageToken { get; set; }
    }
}