using Newtonsoft.Json;

namespace RingCentral.Net
{
    // Peer session / party data. Valid in Gone state only
    public class PeerInfo : Serializable
    {
        public string sessionId;
        public string partyId;
    }
}