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
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}