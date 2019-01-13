using Newtonsoft.Json;

namespace RingCentral
{
    public class SIPFlagsResponse : Serializable
    {
        // If 'True' VoIP calling feature is enabled
        public string voipFeatureEnabled;
        // If 'True' the request is sent from IP address of a country blocked for VoIP calling
        public string voipCountryBlocked;
        // If 'True' outbound calls are enabled
        public string outboundCallsEnabled;
    }
}