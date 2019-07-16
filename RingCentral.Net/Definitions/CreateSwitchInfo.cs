namespace RingCentral
{
    public class CreateSwitchInfo
    {
        /// <summary>
        /// Unique identifier of a network switch. The supported formats are: XX:XX:XX:XX:XX:XX (symbols 0-9 and A-F) for MAC address and X.X.X.X for IP address (symbols 0-255)
        /// Required
        /// </summary>
        public string chassisId;

        /// <summary>
        /// Name of a network switch
        /// </summary>
        public string name;

        /// <summary>
        /// Site data
        /// </summary>
        public SwitchSiteInfo site;

        /// <summary>
        /// Emergency address assigned to the switch
        /// Required
        /// </summary>
        public LocationUpdatesEmergencyAddressInfo emergencyAddress;
    }
}