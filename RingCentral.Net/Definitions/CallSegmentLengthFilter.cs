namespace RingCentral
{
    /// <summary>
    ///     Duration bounds for the segment
    /// </summary>
    public class CallSegmentLengthFilter
    {
        /// <summary>
        ///     Minimum duration of segment in seconds
        ///     Format: int64
        /// </summary>
        public long? minSeconds { get; set; }

        /// <summary>
        ///     Maximum duration of segment in seconds
        ///     Format: int64
        /// </summary>
        public long? maxSeconds { get; set; }
    }
}