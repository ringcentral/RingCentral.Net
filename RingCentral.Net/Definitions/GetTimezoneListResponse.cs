namespace RingCentral
{
    public class GetTimezoneListResponse
    {
        /// <summary>
        /// List of timezones
        /// Required
        /// </summary>
        public GetTimezoneInfoResponse[] records;

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