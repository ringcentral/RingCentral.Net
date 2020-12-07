namespace RingCentral
{
    public class MeetingRequestResource
    {
        /// <summary>
        /// Custom topic of a meeting
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
        /// Meeting password
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
        /// Starting meetings with participant video on/off (true/false)
        /// </summary>
        public bool? startParticipantsVideo;

        /// <summary>
        /// If true, then personal user's meeting ID is applied for creation of this meeting
        /// </summary>
        public bool? usePersonalMeetingId;

        /// <summary>
        /// Enum: Phone, ComputerAudio
        /// </summary>
        public string[] audioOptions;

        /// <summary>
        /// </summary>
        public RecurrenceInfo recurrence;

        /// <summary>
        /// Automatic record type
        /// Default: none
        /// Enum: local, cloud, none
        /// </summary>
        public string autoRecordType;

        /// <summary>
        /// If true, then only signed-in users can join this meeting
        /// </summary>
        public bool? enforceLogin;

        /// <summary>
        /// If true, then participants are muted on entry
        /// </summary>
        public bool? muteParticipantsOnEntry;

        /// <summary>
        /// If true, then the waiting room for participants is enabled
        /// </summary>
        public bool? enableWaitingRoom;

        /// <summary>
        /// List of global dial-in countries (eg. US, UK, AU, etc.)
        /// </summary>
        public string[] globalDialInCountries;
    }
}