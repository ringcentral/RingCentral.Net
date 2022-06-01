namespace RingCentral
{
    /// <summary>
    ///     This field provides mapping of possible breakdown options that will be used for aggregation within every time
    ///     interval
    /// </summary>
    public class TimelineResponseDataOptions
    {
        /// <summary>
        /// </summary>
        public TimelineCountersResponseOptions counters { get; set; }

        /// <summary>
        /// </summary>
        public TimelineTimersResponseOptions timers { get; set; }
    }
}