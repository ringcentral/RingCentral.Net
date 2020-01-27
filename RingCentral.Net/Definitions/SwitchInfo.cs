namespace RingCentral
{
    public class SwitchInfo
    {
        /// <summary>
        /// Link to the network switch resource
        /// </summary>
        public string uri;

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
        /// Emergency address assigned to the switch. Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public LocationUpdatesEmergencyAddressInfo emergencyAddress;

        /// <summary>
        /// Emergency response location (address) internal identifier. Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId;
    }
}