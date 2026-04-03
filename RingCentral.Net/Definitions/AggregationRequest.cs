namespace RingCentral
{
    public class AggregationRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public Grouping grouping { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public TimeSettings timeSettings { get; set; }

        /// <summary>
        /// </summary>
        public CallFilters callFilters { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AggregationResponseOptions responseOptions { get; set; }
    }
}