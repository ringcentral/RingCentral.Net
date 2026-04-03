namespace RingCentral
{
    public class TimelineResponse
    {
        /// <summary>
        ///     Required
        /// </summary>
        public ResponsePaging paging { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public TimelineResponseData data { get; set; }
    }
}