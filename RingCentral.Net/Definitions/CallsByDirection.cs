namespace RingCentral
{
    public class CallsByDirection
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? inbound { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? outbound { get; set; }
    }
}