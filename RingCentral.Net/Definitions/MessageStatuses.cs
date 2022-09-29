namespace RingCentral
{
    /// <summary>
    ///     The messages status object with details of each status
    /// </summary>
    public class MessageStatuses
    {
        /// <summary>
        /// </summary>
        public MessageStatusCounts Queued { get; set; }

        /// <summary>
        /// </summary>
        public MessageStatusCounts Delivered { get; set; }

        /// <summary>
        /// </summary>
        public MessageStatusCounts DeliveryFailed { get; set; }

        /// <summary>
        /// </summary>
        public MessageStatusCounts Sent { get; set; }

        /// <summary>
        /// </summary>
        public MessageStatusCounts SendingFailed { get; set; }
    }
}