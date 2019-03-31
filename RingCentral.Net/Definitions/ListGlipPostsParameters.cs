namespace RingCentral
{
    public class ListGlipPostsParameters
    {
        /// <summary>
        /// Identifier of a group to filter posts
        /// </summary>
        public string groupId;

        /// <summary>
        /// Token of a page to be returned
        /// </summary>
        public string pageToken;

        /// <summary>
        /// Number of records to be returned. The maximum value is 250, by default - 30
        /// Maximum: 250
        /// Default: 30
        /// </summary>
        public long? recordCount;
    }
}