namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation aggregatePerformanceReportCalls
    /// </summary>
    public class AggregatePerformanceReportCallsParameters
    {
        /// <summary>
        ///     Page number
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Number of records displayed on a page
        /// </summary>
        public long? perPage { get; set; }
    }
}