namespace RingCentral
{
    public class SIPFlagsResponse
    {
        // If 'True' VoIP calling feature is enabled
        // Enum: True, False
        public string voipFeatureEnabled;

        // If 'True' the request is sent from IP address of a country blocked for VoIP calling
        // Enum: True, False
        public string voipCountryBlocked;

        // If 'True' outbound calls are enabled
        // Enum: True, False
        public string outboundCallsEnabled;
    }
}