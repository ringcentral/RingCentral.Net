namespace RingCentral
{
    public class MeetingRequestResource
    {
        /// <summary>
        /// </summary>
        public string topic;

        /// <summary>
        /// Enum: Instant, Scheduled, ScheduledRecurring, Recurring
        /// </summary>
        public string meetingType;

        /// <summary>
        /// </summary>
        public MeetingScheduleResource schedule;

        /// <summary>
        /// </summary>
        public string password;

        /// <summary>
        /// </summary>
        public HostInfoRequest host;

        /// <summary>
        /// </summary>
        public bool? allowJoinBeforeHost;

        /// <summary>
        /// </summary>
        public bool? startHostVideo;

        /// <summary>
        /// </summary>
        public bool? startParticipantsVideo;

        /// <summary>
        /// </summary>
        public bool? usePersonalMeetingId;

        /// <summary>
        /// </summary>
        public string[] audioOptions;

        /// <summary>
        /// Recurrence settings
        /// </summary>
        public RecurrenceInfo recurrence;

        /// <summary>
        /// Automatic record type
        /// Default: local
        /// Enum: local, cloud, none
        /// </summary>
        public string autoRecordType;
    }
}