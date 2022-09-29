namespace RingCentral
{
    /// <summary>
    ///     Counters and timers options for calls breakdown
    /// </summary>
    public class TimelineResponseOptions
    {
        /// <summary>
        /// </summary>
        public TimelineResponseOptionsCounters counters { get; set; }

        /// <summary>
        /// </summary>
        public TimelineResponseOptionsTimers timers { get; set; }
    }
}