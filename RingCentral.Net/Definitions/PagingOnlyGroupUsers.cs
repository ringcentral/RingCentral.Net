namespace RingCentral
{
    public class PagingOnlyGroupUsers
    {
        /// <summary>
        /// Link to the list of users allowed to page the Paging Only group
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of users allowed to page the Paging Only group
        /// </summary>
        public PagingGroupExtensionInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}