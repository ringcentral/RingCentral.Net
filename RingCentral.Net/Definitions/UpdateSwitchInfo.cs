namespace RingCentral
{
    public class UpdateSwitchInfo
    {
        /// <summary>
        /// internal identifier of a switch
        /// </summary>
        public string id;

        /// <summary>
        /// Unique identifier of a network switch. The supported formats are: XX:XX:XX:XX:XX:XX (symbols 0-9 and A-F) for MAC address and X.X.X.X for IP address (symbols 0-255)
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
        /// </summary>
        public LocationUpdatesEmergencyAddressInfo emergencyAddress;
    }
}