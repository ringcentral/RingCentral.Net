namespace RingCentral
{
    /// <summary>
    ///     Filtering of calls based on the time spent by specified mailbox(es) on call
    /// </summary>
    public class TimeSpentFilter
    {
        /// <summary>
        ///     Minimum duration in seconds
        ///     Format: int64
        /// </summary>
        public long? minSeconds { get; set; }

        /// <summary>
        ///     Maximum duration in seconds
        ///     Format: int64
        /// </summary>
        public long? maxSeconds { get; set; }
    }
}