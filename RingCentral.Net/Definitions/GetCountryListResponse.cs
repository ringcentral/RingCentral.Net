namespace RingCentral
{
    public class GetCountryListResponse
    {
        /// <summary>
        /// Link to the list of countries supported
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of countries with the country data
        /// Required
        /// </summary>
        public GetCountryInfoDictionaryResponse[] records { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}