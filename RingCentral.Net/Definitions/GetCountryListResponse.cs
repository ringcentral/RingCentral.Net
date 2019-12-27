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
        /// Information on navigation
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}