namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation analyticsCallsTimelineFetch
    /// </summary>
    public class AnalyticsCallsTimelineFetchParameters
    {
        /// <summary>
        ///     Aggregation interval
        ///     Enum: Hour, Day, Week, Month
        /// </summary>
        public string interval { get; set; }

        /// <summary>
        ///     The current page number (positive numbers only)
        ///     Minimum: 1
        ///     Format: int32
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Number of records displayed on a page (positive numbers only, max value of 20)
        ///     Maximum: 20
        ///     Minimum: 1
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }
    }
}