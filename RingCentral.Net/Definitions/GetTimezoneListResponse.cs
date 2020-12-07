namespace RingCentral
{
    public class GetTimezoneListResponse
    {
        /// <summary>
        /// Link to the timezone list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of timezones
        /// Required
        /// </summary>
        public GetTimezoneInfoResponse[] records;

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