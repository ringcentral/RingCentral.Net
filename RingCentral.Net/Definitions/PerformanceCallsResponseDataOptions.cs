namespace RingCentral
{
    /// <summary>
    ///     Provides mapping of possible breakdown options for call aggregation and aggregation formula
    /// </summary>
    public class PerformanceCallsResponseDataOptions
    {
        /// <summary>
        /// </summary>
        public PerformanceCallsCountersResponseOptions counters { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimersResponseOptions timers { get; set; }
    }
}