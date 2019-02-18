namespace RingCentral
{
    public class PagingOnlyGroupDevices
    {
        // List of paging devices assigned to this group
        public PagingDeviceInfo[] records;

        // Information on navigation
        public ProvisioningNavigationInfo navigation;

        // Information on paging
        public ProvisioningPagingInfo paging;
    }
}