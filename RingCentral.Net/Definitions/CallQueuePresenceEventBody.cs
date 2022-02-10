namespace RingCentral
{
    /// <summary>
    ///     Notification payload body
    /// </summary>
    public class CallQueuePresenceEventBody
    {
        /// <summary>
        ///     Agent extension ID
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Call queue extension ID
        /// </summary>
        public string callQueueId { get; set; }

        /// <summary>
        ///     Call queue agent availability for calls of this queue
        /// </summary>
        public bool? acceptCalls { get; set; }
    }
}