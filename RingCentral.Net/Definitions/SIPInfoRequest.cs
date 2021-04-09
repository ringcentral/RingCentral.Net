namespace RingCentral
{
    public class SIPInfoRequest
    {
        /// <summary>
        ///     Supported transport. SIP info will be returned for this transport if supported
        ///     Enum: UDP, TCP, TLS, WS, WSS
        /// </summary>
        public string transport { get; set; }
    }
}