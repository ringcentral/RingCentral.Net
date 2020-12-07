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
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}