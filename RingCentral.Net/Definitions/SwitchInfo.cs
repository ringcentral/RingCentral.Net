namespace RingCentral
{
    public class SwitchInfo
    {
        /// <summary>
        ///     Link to the network switch resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a network switch
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Unique identifier of a network switch
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
        public LocationUpdatesEmergencyAddressInfo emergencyAddress { get; set; }

        /// <summary>
        ///     Deprecated. Emergency response location (address) internal identifier. Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId { get; set; }

        /// <summary>
        /// </summary>
        public ERLLocationInfo emergencyLocation { get; set; }
    }
}