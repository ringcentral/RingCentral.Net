namespace RingCentral
{
    public class GetStateListResponse
    {
        /// <summary>
        /// List of states
        /// Required
        /// </summary>
        public GetStateInfoResponse[] records;

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