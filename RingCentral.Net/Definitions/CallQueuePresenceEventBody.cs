namespace RingCentral
{
    // Notification payload body
    public class CallQueuePresenceEventBody
    {
        /// <summary>
        /// Agent extension ID
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Call queue extension ID
        /// </summary>
        public string callQueueId;

        /// <summary>
        /// Call queue agent availability for calls of this queue
        /// </summary>
        public bool? acceptCalls;
    }
}