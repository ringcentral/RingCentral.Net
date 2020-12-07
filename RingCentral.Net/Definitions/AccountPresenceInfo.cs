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
        /// </summary>
        public PresenceNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public PresencePagingInfo paging;
    }
}