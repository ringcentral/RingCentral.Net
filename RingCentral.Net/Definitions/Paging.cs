namespace RingCentral
{
    /// <summary>
    ///     Paging information
    /// </summary>
    public class Paging
    {
        /// <summary>
        ///     Current offset token
        ///     Required
        /// </summary>
        public string currentPageToken { get; set; }

        /// <summary>
        ///     Next page offset token
        /// </summary>
        public string nextPageToken { get; set; }

        /// <summary>
        ///     Number of records returned
        ///     Required
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }
    }
}