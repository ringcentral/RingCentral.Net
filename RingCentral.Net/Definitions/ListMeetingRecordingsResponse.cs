namespace RingCentral
{
    public class ListMeetingRecordingsResponse
    {
        /// <summary>
        /// </summary>
        public MeetingRecordings[] records { get; set; }

        /// <summary>
        /// </summary>
        public MeetingRecordingsPagingInfo paging { get; set; }

        /// <summary>
        /// </summary>
        public MeetingRecordingsNavigationInfo navigation { get; set; }
    }
}