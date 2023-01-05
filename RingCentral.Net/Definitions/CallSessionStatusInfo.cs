namespace RingCentral
{
    public class CallSessionStatusInfo
    {
        /// <summary>
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        /// </summary>
        public string parkData { get; set; }

        /// <summary>
        /// </summary>
        public PeerInfo peerId { get; set; }

        /// <summary>
        /// </summary>
        public MobilePickupData mobilePickupData { get; set; }
    }
}