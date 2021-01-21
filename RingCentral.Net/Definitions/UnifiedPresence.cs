namespace RingCentral
{
    public class UnifiedPresence
    {
        /// <summary>
        /// Aggregated presence status of the user
        /// Enum: Available, Offline, DND, Busy
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public UnifiedPresenceGlip glip { get; set; }

        /// <summary>
        /// </summary>
        public UnifiedPresenceTelephony telephony { get; set; }

        /// <summary>
        /// </summary>
        public UnifiedPresenceMeeting meeting { get; set; }
    }
}