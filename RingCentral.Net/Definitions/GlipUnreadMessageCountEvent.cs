namespace RingCentral
{
    public class GlipUnreadMessageCountEvent
    {
        /// <summary>
        /// Universally unique identifier of a notification
        /// </summary>
        public string uuid { get; set; }

        /// <summary>
        /// </summary>
        public GlipAPNSInfo pn_apns { get; set; }

        /// <summary>
        /// </summary>
        public GCMInfo pn_gcm { get; set; }

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}