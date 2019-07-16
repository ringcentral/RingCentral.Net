namespace RingCentral
{
    public class WirelessPointInfo
    {
        /// <summary>
        /// Internal identifier of a wireless point
        /// </summary>
        public string id;

        /// <summary>
        /// Unique 48-bit identifier of the wireless access point that follows MAC address conventions
        /// </summary>
        public string bssid;

        /// <summary>
        /// Wireless access point name
        /// </summary>
        public string name;

        /// <summary>
        /// Site data (internal identifier and custom name of a site)
        /// </summary>
        public EmergencyAddressAutoUpdateSiteInfo site;

        /// <summary>
        /// Emergency address assigned to the point
        /// </summary>
        public LocationUpdatesEmergencyAddressInfo emergencyAddress;
    }
}