namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listGlipGroupPosts
    /// </summary>
    public class ListGlipGroupPostsParameters
    {
        /// <summary>
        ///     Max number of records to be returned
        ///     Maximum: 250
        ///     Default: 30
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        ///     Pagination token
        /// </summary>
        public string pageToken { get; set; }
    }
}