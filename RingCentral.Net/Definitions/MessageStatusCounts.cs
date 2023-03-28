namespace RingCentral
{
    /// <summary>
    ///     The count of the status
    /// </summary>
    public class MessageStatusCounts
    {
        /// <summary>
        ///     The count of the status
        ///     Format: int64
        ///     Example: 7
        /// </summary>
        public long? count { get; set; }

        /// <summary>
        /// </summary>
        public object errorCodeCounts { get; set; }
    }
}