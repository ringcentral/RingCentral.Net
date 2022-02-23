namespace RingCentral
{
    public class PerformanceCallsData
    {
        /// <summary>
        ///     Grouping key.
        ///     Required
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// </summary>
        public KeyInfo keyInfo { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsTimers timers { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCounters counters { get; set; }
    }
}