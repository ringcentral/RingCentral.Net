namespace RingCentral
{
    public class CreateSwitchInfo
    {
        /// <summary>
        ///     Unique identifier of a network switch. The supported formats are: XX:XX:XX:XX:XX:XX (symbols 0-9 and A-F) for MAC
        ///     address and X.X.X.X for IP address (symbols 0-255)
        ///     Required
        /// </summary>
        public string chassisId { get; set; }

        /// <summary>
        ///     Name of a network switch
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public SwitchSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public LocationUpdatesEmergencyAddressInfoRequest emergencyAddress { get; set; }

        /// <summary>
        ///     Deprecated. Emergency response location (address) internal identifier. Only one of a pair `emergencyAddress` or
        ///     `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId { get; set; }

        /// <summary>
        /// </summary>
        public ERLLocationInfo emergencyLocation { get; set; }
    }
}