namespace RingCentral
{
    /// <summary>
    ///     Information on navigation
    /// </summary>
    public class PresenceNavigationInfo
    {
        /// <summary>
        /// </summary>
        public PresenceNavigationInfoURI firstPage { get; set; }

        /// <summary>
        /// </summary>
        public PresenceNavigationInfoURI nextPage { get; set; }

        /// <summary>
        /// </summary>
        public PresenceNavigationInfoURI previousPage { get; set; }

        /// <summary>
        /// </summary>
        public PresenceNavigationInfoURI lastPage { get; set; }
    }
}