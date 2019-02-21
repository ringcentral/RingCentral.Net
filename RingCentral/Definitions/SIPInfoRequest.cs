namespace RingCentral
{
    public class SIPInfoRequest
    {
        // Supported transport. SIP info will be returned for this transport if supported
        // Enum: UDP, TCP, TLS, WS, WSS
        public string transport;
    }
}