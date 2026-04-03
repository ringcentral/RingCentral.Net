namespace RingCentral
{
    public class SipInfoResponse
    {
        /// <summary>
        ///     User credentials
        /// </summary>
        public string username { get; set; }

        /// <summary>
        ///     User password. Not returned if SipDigest is not enabled
        ///     Format: password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        ///     Supported authorization types and their priority for clients
        ///     Enum: SipDigest, BearerToken
        /// </summary>
        public string[] authorizationTypes { get; set; }

        /// <summary>
        ///     Identifier for SIP authorization
        /// </summary>
        public string authorizationId { get; set; }

        /// <summary>
        ///     SIP domain
        /// </summary>
        public string domain { get; set; }

        /// <summary>
        ///     SIP outbound proxy server address (in the format <host:port>)
        /// </summary>
        public string outboundProxy { get; set; }

        /// <summary>
        ///     SIP outbound IPv6 proxy server address (in the format <host:port>)
        /// </summary>
        public string outboundProxyIPv6 { get; set; }

        /// <summary>
        ///     SIP outbound proxy server backup address (in the format <host:port>)
        /// </summary>
        public string outboundProxyBackup { get; set; }

        /// <summary>
        ///     SIP outbound IPv6 proxy server backup address (in the format <host:port>)
        /// </summary>
        public string outboundProxyIPv6Backup { get; set; }

        /// <summary>
        ///     Preferred transport. SIP info will be returned for this transport if supported
        ///     Enum: UDP, TCP, TLS, WSS
        /// </summary>
        public string transport { get; set; }

        /// <summary>
        ///     For TLS transport only, Base64 encoded certificate
        /// </summary>
        public string certificate { get; set; }

        /// <summary>
        ///     The interval in seconds after which the app must try to switch
        ///     back to primary proxy if it was previously switched to backup. If this
        ///     parameter is not returned, the app must stay on backup proxy and try to
        ///     switch to primary proxy after the next SIP-provision call.
        ///     Format: int32
        /// </summary>
        public long? switchBackInterval { get; set; }

        /// <summary>
        ///     List of stun servers in the format <host:port>
        /// </summary>
        public string[] stunServers { get; set; }
    }
}