namespace RingCentral
{
    public class ListGlipGroupPostsParameters
    {
        /// <summary>
        /// Max number of records to be returned
        /// Maximum: 250
        /// Default: 30
        /// </summary>
        public long? recordCount;

        /// <summary>
        /// Pagination token
        /// </summary>
        public string pageToken;
    }
}