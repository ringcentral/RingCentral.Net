namespace RingCentral
{
    public class GetCountryListResponse
    {
        /// <summary>
        /// Link to the list of countries supported
        /// </summary>
        public string uri;

        /// <summary>
        /// List of countries with the country data
        /// Required
        /// </summary>
        public GetCountryInfoDictionaryResponse[] records;

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}