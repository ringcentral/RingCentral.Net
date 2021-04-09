namespace RingCentral
{
    public class PagingOnlyGroupDevices
    {
        /// <summary>
        ///     Link to the list of devices assigned to the paging only group
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of paging devices assigned to this group
        /// </summary>
        public PagingDeviceInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}