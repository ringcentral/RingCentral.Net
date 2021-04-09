namespace RingCentral
{
    public class GetStateListResponse
    {
        /// <summary>
        ///     Link to the states list resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of states
        /// </summary>
        public GetStateInfoResponse[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}