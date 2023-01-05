namespace RingCentral
{
    public class ListDevicesAutomaticLocationUpdates
    {
        /// <summary>
        ///     Link to a devices resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of the user(s) devices with the current status of Emergency
        ///     Address Auto Update Feature
        /// </summary>
        public AutomaticLocationUpdatesDeviceInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}