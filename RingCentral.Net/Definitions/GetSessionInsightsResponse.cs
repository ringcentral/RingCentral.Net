namespace RingCentral
{
    public class GetSessionInsightsResponse
    {
        /// <summary>
        ///     Required
        /// </summary>
        public RecordingInsights[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RSPagingModel paging { get; set; }
    }
}