namespace RingCentral
{
    public class AccountPresenceInfo
    {
        /// <summary>
        /// Canonical URI of account presence resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of Prompts
        /// </summary>
        public GetPresenceInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PresenceNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public PresencePagingInfo paging { get; set; }
    }
}