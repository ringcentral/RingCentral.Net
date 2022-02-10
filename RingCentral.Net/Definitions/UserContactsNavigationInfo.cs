namespace RingCentral
{
    /// <summary>
    ///     Information on navigation
    /// </summary>
    public class UserContactsNavigationInfo
    {
        /// <summary>
        /// </summary>
        public UserContactsNavigationInfoUri firstPage { get; set; }

        /// <summary>
        /// </summary>
        public UserContactsNavigationInfoUri nextPage { get; set; }

        /// <summary>
        /// </summary>
        public UserContactsNavigationInfoUri previousPage { get; set; }

        /// <summary>
        /// </summary>
        public UserContactsNavigationInfoUri lastPage { get; set; }
    }
}