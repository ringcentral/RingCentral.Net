namespace RingCentral
{
    /// <summary>
    ///     This field provides mapping of possible breakdown options for call aggregation time intervals
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