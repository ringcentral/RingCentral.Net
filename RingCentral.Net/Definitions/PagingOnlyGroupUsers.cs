namespace RingCentral
{
    public class PagingOnlyGroupUsers
    {
        /// <summary>
        /// List of users allowed to page this group
        /// </summary>
        public PagingGroupExtensionInfo[] records;

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