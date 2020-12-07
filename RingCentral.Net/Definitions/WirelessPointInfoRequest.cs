namespace RingCentral
{
    public class WirelessPointInfoRequest
    {
        /// <summary>
        /// Internal identifier of a wireless point
        /// </summary>
        public string id;

        /// <summary>
        /// Unique 48-bit identifier of the wireless access point complying with MAC address conventions
        /// </summary>
        public string bssid;

        /// <summary>
        /// Wireless access point name
        /// </summary>
        public string name;

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site;

        /// <summary>
        /// </summary>
        public LocationUpdatesEmergencyAddressInfoRequest emergencyAddress;

        /// <summary>
        /// Emergency response location (address) internal identifier. Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId;
    }
}