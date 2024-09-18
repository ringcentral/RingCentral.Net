namespace RingCentral
{
    public class ListMeetingRecordingsResponse
    {
        /// <summary>
        /// </summary>
        public MeetingRecordings[] records { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }
    }
}