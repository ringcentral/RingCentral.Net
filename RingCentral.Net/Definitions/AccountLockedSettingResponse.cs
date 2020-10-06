namespace RingCentral
{
    public class AccountLockedSettingResponse
    {
        /// <summary>
        /// Scheduling meeting settings locked on account level
        /// </summary>
        public ScheduleUserMeetingInfo scheduleMeeting;

        /// <summary>
        /// Meeting recording settings locked on account level
        /// </summary>
        public UserMeetingRecordingSetting recording;
    }
}