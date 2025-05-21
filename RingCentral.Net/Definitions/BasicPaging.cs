namespace RingCentral
{
    /// <summary>
    ///     Paging information
    /// </summary>
    public class BasicPaging
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
    }
}