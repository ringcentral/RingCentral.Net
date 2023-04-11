namespace RingCentral
{
    public class RcwPagingForwardModel
    {
        /// <summary>
        ///     Number of items per page
        ///     Required
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Current page token
        ///     Required
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Next page token (absent for the last page of the result set)
        /// </summary>
        public string nextPageToken { get; set; }

        /// <summary>
        ///     Previous page token (absent for the first page of the result set)
        ///     May be omitted if the result set does not support backward navigation.
        /// </summary>
        public string previousPageToken { get; set; }
    }
}