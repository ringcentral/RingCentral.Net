namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation analyticsCallsAggregationFetch
    /// </summary>
    public class AnalyticsCallsAggregationFetchParameters
    {
        /// <summary>
        ///     The current page number (positive numbers only)
        ///     Minimum: 1
        ///     Format: int32
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Number of records displayed on a page (positive numbers only, max value of 200)
        ///     Maximum: 200
        ///     Minimum: 1
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }
    }
}