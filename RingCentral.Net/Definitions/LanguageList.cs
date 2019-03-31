namespace RingCentral
{
    public class LanguageList
    {
        /// <summary>
        /// Canonical URI of the language list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Language data
        /// </summary>
        public LanguageInfo[] records;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}