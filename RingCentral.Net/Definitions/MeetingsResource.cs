namespace RingCentral
{
    public class MeetingsResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public MeetingResponseResource[] records { get; set; }

        /// <summary>
        /// </summary>
        public MeetingsPagingInfo paging { get; set; }

        /// <summary>
        /// </summary>
        public MeetingsNavigationInfo navigation { get; set; }
    }
}