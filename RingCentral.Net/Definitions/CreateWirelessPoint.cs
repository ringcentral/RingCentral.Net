namespace RingCentral
{
    public class CreateWirelessPoint
    {
        /// <summary>
        /// Unique 48-bit identifier of wireless access point that follows MAC address conventions.  The Mask is XX:XX:XX:XX:XX:XX, where X can be a symbol in the range of 0-9 or A-F
        /// Required
        /// </summary>
        public string bssid;

        /// <summary>
        /// Wireless access point name
        /// Required
        /// </summary>
        public string name;

        /// <summary>
        /// Site data. If multi-site feature is turned on for the account, then internal identifier of a site must be specified. To assign the wireless point to the main site (company) set site ID to `main-site`
        /// </summary>
        public EmergencyAddressAutoUpdateSiteInfo site;

        /// <summary>
        /// Required
        /// </summary>
        public LocationUpdatesEmergencyAddressInfo emergencyAddress;
    }
}