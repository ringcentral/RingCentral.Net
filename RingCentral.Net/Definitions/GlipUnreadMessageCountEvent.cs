namespace RingCentral
{
    public class GlipUnreadMessageCountEvent
    {
        /// <summary>
        /// Universally unique identifier of a notification
        /// </summary>
        public string uuid;

        /// <summary>
        /// </summary>
        public GlipAPNSInfo pn_apns;

        /// <summary>
        /// </summary>
        public GCMInfo pn_gcm;

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId;
    }
}