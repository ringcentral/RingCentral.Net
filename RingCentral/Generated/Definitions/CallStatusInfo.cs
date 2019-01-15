using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallStatusInfo : Serializable
    {
        // Status code of a call
        public string code;
        // Peer session / party data. Valid in Gone state only
        public PeerInfo peerId;
        // Reason of call termination. For 'Disconnected' code only
        public string reason;
        // Optional message
        public string description;
    }
}