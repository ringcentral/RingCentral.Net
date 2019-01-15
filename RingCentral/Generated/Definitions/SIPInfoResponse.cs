using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class SIPInfoResponse : Serializable
    {
        // User credentials
        public string username;
        // User password
        public string password;
        // Identifier for SIP authorization
        public string authorizationId;
        // SIP domain
        public string domain;
        // SIP outbound proxy
        public string outboundProxy;
        // Preferred transport. SIP info will be returned for this transport if supported
        public string transport;
        // For TLS transport only Base64 encoded certificate
        public string certificate;
        // The interval in seconds after which the app must try to switch back to primary proxy if it was previously switched to backup. If this parameter is not returned, the app must stay on backup proxy and try to switch to primary proxy after the next SIP-provision call.
        public long? switchBackInterval;
    }
}