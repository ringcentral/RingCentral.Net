namespace RingCentral
{
    public class SipInfoResource
    {
        /// <summary>
        ///     SIP domain
        /// </summary>
        public string domain { get; set; }

        /// <summary>
        ///     List of outbound proxies
        /// </summary>
        public OutboundProxyInfo[] outboundProxies { get; set; }

        /// <summary>
        ///     User credentials
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        ///     User password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        ///     Internal identifier for SIP authorization
        /// </summary>
        public string authorizationId { get; set; }
    }
}