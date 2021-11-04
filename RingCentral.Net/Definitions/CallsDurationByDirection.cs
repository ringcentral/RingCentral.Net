namespace RingCentral
{
    public class CallsDurationByDirection
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? inboundCallsSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? outboundCallsSeconds { get; set; }
    }
}