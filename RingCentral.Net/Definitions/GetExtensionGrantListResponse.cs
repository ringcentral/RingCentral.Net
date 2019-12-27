namespace RingCentral
{
    public class GetExtensionGrantListResponse
    {
        /// <summary>
        /// Link to the list of extension grants
        /// </summary>
        public string uri;

        /// <summary>
        /// List of extension grants with details
        /// Required
        /// </summary>
        public GrantInfo[] records;

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