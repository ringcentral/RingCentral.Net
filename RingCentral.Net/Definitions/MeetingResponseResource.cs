namespace RingCentral
{
    public class MeetingResponseResource
    {
        /// <summary>
        /// Link to a meeting resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Universally unique identifier of a meeting"
        /// </summary>
        public string uuid;

        /// <summary>
        /// Internal identifier of a meeting
        /// </summary>
        public string id;

        /// <summary>
        /// Custom topic of a meeting
        /// </summary>
        public string topic;

        /// <summary>
        /// Enum: Instant, Scheduled, ScheduledRecurring, Recurring
        /// </summary>
        public string meetingType;

        /// <summary>
        /// Meeting password
        /// </summary>
        public string password;

        /// <summary>
        /// </summary>
        public string h323Password;

        /// <summary>
        /// Status of a meeting
        /// </summary>
        public string status;

        /// <summary>
        /// Meeting links
        /// </summary>
        public MeetingLinks links;

        /// <summary>
        /// Meeting schedule information
        /// </summary>
        public MeetingScheduleResource schedule;

        /// <summary>
        /// Meeting host information
        /// </summary>
        public HostInfoRequest host;

        /// <summary>
        /// If true, then participants can join the meeting before host arrives
        /// </summary>
        public bool? allowJoinBeforeHost;

        /// <summary>
        /// Starting meetings with host video on/off (true/false)
        /// </summary>
        public bool? startHostVideo;

        /// <summary>
        /// Starting meetings with participant video on/off (true/false)
        /// </summary>
        public bool? startParticipantsVideo;

        /// <summary>
        /// Enum: Phone, ComputerAudio
        /// </summary>
        public string[] audioOptions;

        /// <summary>
        /// Meeting recurrence information
        /// </summary>
        public RecurrenceInfo reccurence;

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