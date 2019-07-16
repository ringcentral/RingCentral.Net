namespace RingCentral
{
    public class ListDevicesAutomaticLocationUpdates
    {
        /// <summary>
        /// Link to devices resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of users' devices with the current status of Emergency Address Auto Update Feature
        /// </summary>
        public AutomaticLocationUpdatesDeviceInfo[] records;

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}