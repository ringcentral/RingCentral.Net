namespace RingCentral
{
    public class WirelessPointsList
    {
        /// <summary>
        /// Link to the wireless point list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of wireless points with assigned emergency addresses
        /// </summary>
        public WirelessPointInfo[] records;

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}