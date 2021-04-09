namespace RingCentral
{
    public class LanguageList
    {
        /// <summary>
        ///     Canonical URI of the language list resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Language data
        /// </summary>
        public LanguageInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}