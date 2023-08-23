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
        ///     Switch entity extension for better diversity. Should be used together with chassisId.
        /// </summary>
        public string port { get; set; }

        /// <summary>
        ///     Name of a network switch
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public SwitchSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyAddressInfoDefault emergencyAddress { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyLocationInfo emergencyLocation { get; set; }
    }
}