namespace RingCentral
{
    /// <summary>
    /// Emergency response location information
    /// </summary>
    public class EmergencyLocationInfo
    {
        /// <summary>
        ///     Internal identifier of an emergency response location
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Emergency response location name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Address format identifier
        /// </summary>
        public string addressFormatId { get; set; }

        /// <summary>
        ///     Emergency address status. Only supported for extension-level (personal) endpoints
        ///     Enum: Valid, Invalid, Provisioning, Deprovisioned
        /// </summary>
        public string addressStatus { get; set; }
    }
}