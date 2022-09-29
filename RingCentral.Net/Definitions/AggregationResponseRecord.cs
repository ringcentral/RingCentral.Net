namespace RingCentral
{
    public class AggregationResponseRecord
    {
        /// <summary>
        ///     Grouping key
        ///     Required
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// </summary>
        public KeyInfo info { get; set; }

        /// <summary>
        /// </summary>
        public CallsTimers timers { get; set; }

        /// <summary>
        /// </summary>
        public CallsCounters counters { get; set; }
    }
}