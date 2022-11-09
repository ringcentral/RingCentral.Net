namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readGlipPostsNew
    /// </summary>
    public class ReadGlipPostsNewParameters
    {
        /// <summary>
        ///     Max number of posts to be fetched by one request (not more than 250).
        ///     Maximum: 250
        ///     Format: int32
        ///     Default: 30
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        ///     Pagination token.
        /// </summary>
        public string pageToken { get; set; }
    }
}