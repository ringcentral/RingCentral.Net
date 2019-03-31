namespace RingCentral
{
    public class AccountPresenceInfo
    {
        /// <summary>
        /// Canonical URI of account presence resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of Prompts
        /// </summary>
        public GetPresenceInfo[] records;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public PresenceNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public PresencePagingInfo paging;
    }
}