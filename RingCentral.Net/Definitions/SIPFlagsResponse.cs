namespace RingCentral
{
    public class SIPFlagsResponse
    {
        /// <summary>
        /// If 'True' VoIP calling feature is enabled
        /// Enum: True, False
        /// </summary>
        public string voipFeatureEnabled;

        /// <summary>
        /// If 'True' the request is sent from IP address of a country blocked for VoIP calling
        /// Enum: True, False
        /// </summary>
        public string voipCountryBlocked;

        /// <summary>
        /// If 'True' outbound calls are enabled
        /// Enum: True, False
        /// </summary>
        public string outboundCallsEnabled;
    }
}