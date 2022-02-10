namespace RingCentral
{
    /// <summary>
    ///     SIP flags data
    /// </summary>
    public class SIPFlagsResponse
    {
        /// <summary>
        ///     If 'True' VoIP calling feature is enabled
        ///     Enum: True, False
        /// </summary>
        public string voipFeatureEnabled { get; set; }

        /// <summary>
        ///     If 'True' the request is sent from IP address of a country blocked for VoIP calling
        ///     Enum: True, False
        /// </summary>
        public string voipCountryBlocked { get; set; }

        /// <summary>
        ///     If 'True' outbound calls are enabled
        ///     Enum: True, False
        /// </summary>
        public string outboundCallsEnabled { get; set; }

        /// <summary>
        /// </summary>
        public bool? dscpEnabled { get; set; }

        /// <summary>
        /// </summary>
        public long? dscpSignaling { get; set; }

        /// <summary>
        /// </summary>
        public long? dscpVoice { get; set; }

        /// <summary>
        /// </summary>
        public long? dscpVideo { get; set; }
    }
}