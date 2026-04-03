namespace RingCentral
{
    public class UpdateWirelessPoint
    {
        /// <summary>
        ///     Internal identifier of a wireless point
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Unique 48-bit identifier of wireless access point that follows
        ///     MAC address conventions. Mask: XX:XX:XX:XX:XX:XX, where X can be a symbol
        ///     in the range of 0-9 or A-F
        /// </summary>
        public string bssid { get; set; }

        /// <summary>
        ///     Name of a wireless access point
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyAddressAutoUpdateSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyAddressInfo emergencyAddress { get; set; }

        /// <summary>
        ///     Emergency response location (address) internal identifier. 
        ///     Only one of a pair `emergencyAddress` or `emergencyLocationId`
        ///     can be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyLocationInfo emergencyLocation { get; set; }
    }
}