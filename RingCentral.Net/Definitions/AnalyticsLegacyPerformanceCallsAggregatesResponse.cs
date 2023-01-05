namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsAggregatesResponse
    {
        /// <summary>
        ///     Required
        /// </summary>
        public AnalyticsLegacyResponsePaging paging { get; set; }

        /// <summary>
        ///     A list of call aggregations as per the grouping and filtering options specified in the request
        /// </summary>
        public AnalyticsLegacyPerformanceCallsData[] data { get; set; }
    }
}