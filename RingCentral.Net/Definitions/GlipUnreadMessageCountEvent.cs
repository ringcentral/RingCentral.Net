namespace RingCentral
{
    public class GlipUnreadMessageCountEvent
    {
        /// <summary>
        /// Universally unique identifier of a notification
        /// </summary>
        public string uuid;

        /// <summary>
        /// Apple notification data
        /// </summary>
        public GlipAPNSInfo pn_apns;

        /// <summary>
        /// GCM data
        /// </summary>
        public GCMInfo pn_gcm;

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId;
    }
}