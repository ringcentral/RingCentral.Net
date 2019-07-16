namespace RingCentral
{
    public class SwitchInfo
    {
        /// <summary>
        /// Internal identifier of a network switch
        /// </summary>
        public string id;

        /// <summary>
        /// Unique identifier of a network switch
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