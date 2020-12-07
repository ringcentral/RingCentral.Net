namespace RingCentral
{
    public class CreateWirelessPoint
    {
        /// <summary>
        /// Unique 48-bit identifier of wireless access point complying with MAC address conventions. The Mask is XX:XX:XX:XX:XX:XX, where X can be a symbol in the range of 0-9 or A-F
        /// Required
        /// </summary>
        public string bssid;

        /// <summary>
        /// Wireless access point name
        /// Required
        /// </summary>
        public string name;

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site;

        /// <summary>
        /// Required
        /// </summary>
        public LocationUpdatesEmergencyAddressInfoRequest emergencyAddress;

        /// <summary>
        /// Deprecated. Internal identifier of the emergency response location (address). Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId;

        /// <summary>
        /// </summary>
        public ERLLocationInfo emergencyLocation;
    }
}