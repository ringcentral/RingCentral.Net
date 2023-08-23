namespace RingCentral
{
    public class SwitchInfo
    {
        /// <summary>
        ///     Link to the network switch resource
        ///     Format: uri
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
        ///     Emergency address information (or information assigned to the
        ///     switch or wireless point - in case of using them). Only one of a pair
        ///     `emergencyAddress` or `emergencyLocationId` should be specified,
        ///     otherwise an error is returned
        /// </summary>
        public SwitchInfoEmergencyAddress emergencyAddress { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyLocationInfo emergencyLocation { get; set; }
    }
}