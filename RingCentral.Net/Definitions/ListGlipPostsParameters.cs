namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listGlipPosts
    /// </summary>
    public class ListGlipPostsParameters
    {
        /// <summary>
        ///     Identifier of a group to filter posts
        /// </summary>
        public string groupId { get; set; }

        /// <summary>
        ///     Token of a page to be returned
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Number of records to be returned. The maximum value is 250, by default - 30
        ///     Maximum: 250
        ///     Format: int64
        ///     Default: 30
        /// </summary>
        public long? recordCount { get; set; }
    }
}