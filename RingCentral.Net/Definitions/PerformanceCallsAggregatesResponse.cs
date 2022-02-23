namespace RingCentral
{
    public class PerformanceCallsAggregatesResponse
    {
        /// <summary>
        ///     Required
        /// </summary>
        public ResponsePaging paging { get; set; }

        /// <summary>
        ///     A list of call aggregations as per the grouping and filtering options specified in the request
        /// </summary>
        public PerformanceCallsData[] data { get; set; }
    }
}