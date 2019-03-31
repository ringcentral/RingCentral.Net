namespace RingCentral
{
    public class PagingOnlyGroupDevices
    {
        /// <summary>
        /// List of paging devices assigned to this group
        /// </summary>
        public PagingDeviceInfo[] records;

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