namespace RingCentral
{
    /// <summary>
    ///     SIP flags information
    /// </summary>
    public class SipFlagsResponse
    {
        /// <summary>
        ///     Indicates that VoIP calling feature is enabled
        /// </summary>
        public bool? voipFeatureEnabled { get; set; }

        /// <summary>
        ///     Indicates that the request is sent from IP address of a country where VoIP calling is disallowed
        /// </summary>
        public bool? voipCountryBlocked { get; set; }

        /// <summary>
        ///     Indicates that outbound calls are enabled
        /// </summary>
        public bool? outboundCallsEnabled { get; set; }

        /// <summary>
        /// </summary>
        public bool? dscpEnabled { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? dscpSignaling { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? dscpVoice { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? dscpVideo { get; set; }
    }
}