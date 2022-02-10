namespace RingCentral
{
    /// <summary>
    ///     Information on navigation
    /// </summary>
    public class CallHandlingNavigationInfo
    {
        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfoUri firstPage { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfoUri nextPage { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfoUri previousPage { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfoUri lastPage { get; set; }
    }
}