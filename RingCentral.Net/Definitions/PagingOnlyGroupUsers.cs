namespace RingCentral
{
    public class PagingOnlyGroupUsers
    {
        /* List of users allowed to page this group */
        public PagingGroupExtensionInfo[] records;

        /* Information on navigation */
        public ProvisioningNavigationInfo navigation;

        /* Information on paging */
        public ProvisioningPagingInfo paging;
    }
}