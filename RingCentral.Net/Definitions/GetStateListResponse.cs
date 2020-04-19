namespace RingCentral
{
    public class GetStateListResponse
    {
        /// <summary>
        /// Link to the states list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of states
        /// </summary>
        public GetStateInfoResponse[] records;

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