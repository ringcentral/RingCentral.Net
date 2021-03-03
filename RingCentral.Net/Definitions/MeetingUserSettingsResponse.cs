namespace RingCentral
{
    public class MeetingUserSettingsResponse
    {
        /// <summary>
        /// </summary>
        public UserMeetingRecordingSetting recording { get; set; }

        /// <summary>
        /// </summary>
        public ScheduleUserMeetingInfo scheduleMeeting { get; set; }

        /// <summary>
        /// </summary>
        public TelephonyUserMeetingSettings telephony { get; set; }
    }
}