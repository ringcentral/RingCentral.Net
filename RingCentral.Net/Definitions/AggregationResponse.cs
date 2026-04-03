namespace RingCentral
{
    public class AggregationResponse
    {
        /// <summary>
        ///     Required
        /// </summary>
        public ResponsePaging paging { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AggregationResponseData data { get; set; }
    }
}