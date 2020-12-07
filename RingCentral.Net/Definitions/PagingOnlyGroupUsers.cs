namespace RingCentral
{
    public class PagingOnlyGroupUsers
    {
        /// <summary>
        /// Link to the list of users allowed to page the Paging Only group
        /// </summary>
        public string uri;

        /// <summary>
        /// List of users allowed to page the Paging Only group
        /// </summary>
        public PagingGroupExtensionInfo[] records;

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}