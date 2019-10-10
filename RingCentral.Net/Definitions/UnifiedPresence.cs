namespace RingCentral
{
    public class UnifiedPresence
    {
        /// <summary>
        /// Aggregated presence status of the user
        /// Enum: Available, Offline, DND, Busy
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public UnifiedPresenceGlip glip;

        /// <summary>
        /// </summary>
        public UnifiedPresenceTelephony telephony;

        /// <summary>
        /// </summary>
        public UnifiedPresenceMeeting meeting;
    }
}