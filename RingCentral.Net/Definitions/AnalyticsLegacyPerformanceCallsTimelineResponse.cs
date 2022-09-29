namespace RingCentral
{
    public class AnalyticsLegacyPerformanceCallsTimelineResponse
    {
        /// <summary>
        ///     A list of time-value points of call aggregations as per the grouping and filtering options specified in the request
        /// </summary>
        public AnalyticsLegacyTimelineData[] data { get; set; }
    }
}