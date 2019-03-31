namespace RingCentral
{
    public class GetLocationListResponse
    {
        /// <summary>
        /// List of locations
        /// </summary>
        public LocationInfo[] records;

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