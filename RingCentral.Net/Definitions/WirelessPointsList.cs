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
        /// Information on navigation
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}