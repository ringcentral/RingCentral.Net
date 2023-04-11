namespace RingCentral
{
    /// <summary>
    ///     Paging
    /// </summary>
    public class Paging
    {
        /// <summary>
        ///     Current page offset token
        /// </summary>
        public string currentPageToken { get; set; }

        /// <summary>
        ///     Next page offset token
        /// </summary>
        public string nextPageToken { get; set; }
    }
}