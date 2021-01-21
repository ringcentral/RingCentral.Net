namespace RingCentral
{
    public class GetExtensionGrantListResponse
    {
        /// <summary>
        /// Link to the list of extension grants
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of extension grants with details
        /// Required
        /// </summary>
        public GrantInfo[] records { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}