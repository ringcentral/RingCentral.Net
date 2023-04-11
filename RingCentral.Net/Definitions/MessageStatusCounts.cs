namespace RingCentral
{
    /// <summary>
    ///     Message status parameters
    /// </summary>
    public class MessageStatusCounts
    {
        /// <summary>
        ///     Total cost of all messages with this status code
        ///     Format: float
        /// </summary>
        public decimal? cost { get; set; }

        /// <summary>
        ///     Count of messages with this status code
        ///     Format: int64
        ///     Example: 7
        /// </summary>
        public long? count { get; set; }

        /// <summary>
        /// </summary>
        public object errorCodeCounts { get; set; }
    }
}