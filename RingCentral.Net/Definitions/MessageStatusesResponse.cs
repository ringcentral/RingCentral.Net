namespace RingCentral
{
    public class MessageStatusesResponse
    {
        /// <summary>
        /// </summary>
        public MessageStatusCounts queued { get; set; }

        /// <summary>
        /// </summary>
        public MessageStatusCounts delivered { get; set; }

        /// <summary>
        /// </summary>
        public MessageStatusCounts deliveryFailed { get; set; }

        /// <summary>
        /// </summary>
        public MessageStatusCounts sent { get; set; }

        /// <summary>
        /// </summary>
        public MessageStatusCounts sendingFailed { get; set; }
    }
}