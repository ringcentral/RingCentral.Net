namespace RingCentral
{
    // Peer session / party data. Valid in Gone state only || Peer session / party data.'Gone'state only || Contains details of the 'linked' Session. Appears in 'Gone' State Code
    public class PeerInfo
    {
        /// <summary>
        /// </summary>
        public string sessionId;

        /// <summary>
        /// </summary>
        public string telephonySessionId;

        /// <summary>
        /// </summary>
        public string partyId;
    }
}