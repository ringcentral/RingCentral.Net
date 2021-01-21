namespace RingCentral
{
    public class WirelessPointsList
    {
        /// <summary>
        /// Link to the wireless point list resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of wireless points with assigned emergency addresses
        /// </summary>
        public WirelessPointInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}