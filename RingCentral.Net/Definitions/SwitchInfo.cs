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
        ///     Name of a network switch
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public SwitchSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyAddressInfo emergencyAddress { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyLocationInfo emergencyLocation { get; set; }
    }
}