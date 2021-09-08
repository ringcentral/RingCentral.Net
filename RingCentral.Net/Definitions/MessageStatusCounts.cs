namespace RingCentral
{
    public class MessageStatusCounts
    {
        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? count { get; set; }

        /// <summary>
        ///     Cost of a message
        ///     Format: double
        ///     Example: 0.007
        /// </summary>
        public decimal? cost { get; set; }

        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? errorCodeCounts { get; set; }
    }
}