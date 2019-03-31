namespace RingCentral
{
    public class SIPInfoResponse
    {
        /// <summary>
        /// User credentials
        /// </summary>
        public string username;

        /// <summary>
        /// User password
        /// </summary>
        public string password;

        /// <summary>
        /// Identifier for SIP authorization
        /// </summary>
        public string authorizationId;

        /// <summary>
        /// SIP domain
        /// </summary>
        public string domain;

        /// <summary>
        /// SIP outbound proxy
        /// </summary>
        public string outboundProxy;

        /// <summary>
        /// Preferred transport. SIP info will be returned for this transport if supported
        /// Enum: UDP, TCP, TLS, WS, WSS
        /// </summary>
        public string transport;

        /// <summary>
        /// For TLS transport only Base64 encoded certificate
        /// </summary>
        public string certificate;

        /// <summary>
        /// The interval in seconds after which the app must try to switch back to primary proxy if it was previously switched to backup. If this parameter is not returned, the app must stay on backup proxy and try to switch to primary proxy after the next SIP-provision call.
        /// </summary>
        public long? switchBackInterval;
    }
}