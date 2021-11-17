namespace RingCentral
{
    public class PerformanceCallsTimelineResponse
    {
        /// <summary>
        ///     A list of time-value points of call aggregations as per the grouping and filtering options specified in the request
        /// </summary>
        public TimelineData[] data { get; set; }
    }
}