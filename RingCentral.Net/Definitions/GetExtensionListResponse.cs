namespace RingCentral
{
    public class GetExtensionListResponse
    {
        /// <summary>
        /// Link to the extension list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of extensions with extension information
        /// Required
        /// </summary>
        public GetExtensionInfoResponse[] records;

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