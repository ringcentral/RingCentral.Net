namespace RingCentral
{
    public class OutboundProxyInfo
    {
        /// <summary>
        ///     Geographical region
        ///     Example: APAC
        /// </summary>
        public string region { get; set; }

        /// <summary>
        ///     SIP outbound proxy
        /// </summary>
        public string proxy { get; set; }

        /// <summary>
        ///     SIP details for TLS (Transport Layer Security)
        /// </summary>
        public string proxyTLS { get; set; }
    }
}