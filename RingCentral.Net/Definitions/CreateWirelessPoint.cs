namespace RingCentral
{
    public class CreateWirelessPoint
    {
        /// <summary>
        ///     Unique 48-bit identifier of wireless access point that follows MAC address conventions.  Mask: XX:XX:XX:XX:XX:XX,
        ///     where X can be a symbol in the range of 0-9 or A-F
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
        public EmergencyAddressAutoUpdateSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyAddressInfoDefault emergencyAddress { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyLocationInfo emergencyLocation { get; set; }
    }
}