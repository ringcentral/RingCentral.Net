namespace RingCentral
{
    /// <summary>
    ///     Information on navigation
    /// </summary>
    public class CallLogNavigationInfo
    {
        /// <summary>
        /// </summary>
        public CallLogNavigationInfoURI firstPage { get; set; }

        /// <summary>
        /// </summary>
        public CallLogNavigationInfoURI nextPage { get; set; }

        /// <summary>
        /// </summary>
        public CallLogNavigationInfoURI previousPage { get; set; }
    }
}