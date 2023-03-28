namespace RingCentral
{
    /// <summary>
    ///     Paging
    /// </summary>
    public class Paging
    {
        /// <summary>
        ///     current offset token
        /// </summary>
        public string currentPageToken { get; set; }

        /// <summary>
        ///     next page offset token
        /// </summary>
        public string nextPageToken { get; set; }
    }
}