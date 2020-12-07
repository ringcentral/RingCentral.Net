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
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}