namespace RingCentral
{
    /// <summary>
    ///     Filtering of calls based on the overall call length
    /// </summary>
    public class CallDurationFilter
    {
        /// <summary>
        ///     Minimum duration of call in seconds
        ///     Format: int64
        /// </summary>
        public long? minSeconds { get; set; }

        /// <summary>
        ///     Maximum duration of call in seconds
        ///     Format: int64
        /// </summary>
        public long? maxSeconds { get; set; }
    }
}