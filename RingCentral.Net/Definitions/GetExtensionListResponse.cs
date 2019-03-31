namespace RingCentral
{
    public class GetExtensionListResponse
    {
        /// <summary>
        /// List of extensions with extension information
        /// Required
        /// </summary>
        public GetExtensionInfoResponse[] records;

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