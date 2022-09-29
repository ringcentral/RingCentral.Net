namespace RingCentral
{
    /// <summary>
    ///     This field provides mapping of possible breakdown options for call aggregation and aggregation formula
    /// </summary>
    public class AggregationResponseOptions
    {
        /// <summary>
        /// </summary>
        public AggregationResponseOptionsCounters counters { get; set; }

        /// <summary>
        /// </summary>
        public AggregationResponseOptionsTimers timers { get; set; }
    }
}