namespace RingCentral
{
    public class ListMeetingRecordingsResponse
    {
        /// <summary>
        /// </summary>
        public MeetingRecording[] records { get; set; }

        /// <summary>
        /// </summary>
        public MeetingRecordingsPagingInfo paging { get; set; }

        /// <summary>
        /// </summary>
        public MeetingRecordingsNavigationInfo navigation { get; set; }
    }
}