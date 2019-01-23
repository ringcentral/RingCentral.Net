namespace RingCentral
{
    // Peer session / party data. Valid in Gone state only
    public class PeerInfo : Serializable
    {
        public string sessionId;
        public string partyId;
    }
}