namespace RingCentral
{
    public class CreateWirelessPoint
    {
        /// <summary>
        ///     Unique 48-bit identifier of wireless access point complying with MAC address conventions. The Mask is XX:XX:XX:XX:XX:XX, where X can be a symbol in the range of 0-9 or A-F
        ///     Required
        /// </summary>
        public string bssid { get; set; }

        /// <summary>
        ///     Wireless access point name
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public LocationUpdatesEmergencyAddressInfoRequest emergencyAddress { get; set; }

        /// <summary>
        ///     Deprecated. Internal identifier of the emergency response location (address). Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId { get; set; }

        /// <summary>
        /// </summary>
        public ERLLocationInfo emergencyLocation { get; set; }
    }
}