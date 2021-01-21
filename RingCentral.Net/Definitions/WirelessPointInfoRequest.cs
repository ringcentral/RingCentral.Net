namespace RingCentral
{
    public class WirelessPointInfoRequest
    {
        /// <summary>
        /// Internal identifier of a wireless point
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Unique 48-bit identifier of the wireless access point complying with MAC address conventions
        /// </summary>
        public string bssid { get; set; }

        /// <summary>
        /// Wireless access point name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public LocationUpdatesEmergencyAddressInfoRequest emergencyAddress { get; set; }

        /// <summary>
        /// Emergency response location (address) internal identifier. Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId { get; set; }
    }
}