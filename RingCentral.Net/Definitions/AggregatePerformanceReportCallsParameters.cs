namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation aggregatePerformanceReportCalls
    /// </summary>
    public class AggregatePerformanceReportCallsParameters
    {
        /// <summary>
        ///     The current page number
        ///     Minimum: 1
        ///     Format: int32
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Number of records displayed on a page
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }
    }
}