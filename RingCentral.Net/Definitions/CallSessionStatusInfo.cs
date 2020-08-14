namespace RingCentral
{
    public class CallSessionStatusInfo
    {
        /// <summary>
        /// </summary>
        public string code;

        /// <summary>
        /// </summary>
        public string reason;

        /// <summary>
        /// </summary>
        public string parkData;

        /// <summary>
        /// Contains details of the 'linked' Session. Appears in 'Gone' State Code
        /// </summary>
        public PeerInfo peerId;

        /// <summary>
        /// </summary>
        public MobilePickupData mobilePickupData;
    }
}