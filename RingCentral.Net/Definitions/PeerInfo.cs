namespace RingCentral
{
    /// <summary>
    ///     Peer (linked) session/party details. Valid in 'Gone' state of a call
    /// </summary>
    public class PeerInfo
    {
        /// <summary>
        /// </summary>
        public string sessionId { get; set; }

        /// <summary>
        /// </summary>
        public string telephonySessionId { get; set; }

        /// <summary>
        /// </summary>
        public string partyId { get; set; }
    }
}