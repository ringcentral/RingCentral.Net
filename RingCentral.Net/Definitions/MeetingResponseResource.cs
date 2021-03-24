namespace RingCentral
{
    public class MeetingResponseResource
    {
        /// <summary>
        /// Link to a meeting resource
        /// Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Universally unique identifier of a meeting"
        /// </summary>
        public string uuid { get; set; }

        /// <summary>
        /// Internal identifier of a meeting
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Custom topic of a meeting
        /// </summary>
        public string topic { get; set; }

        /// <summary>
        /// Enum: Instant, Scheduled, ScheduledRecurring, Recurring
        /// </summary>
        public string meetingType { get; set; }

        /// <summary>
        /// Meeting password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// </summary>
        public string h323Password { get; set; }

        /// <summary>
        /// Status of a meeting
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public MeetingLinks links { get; set; }

        /// <summary>
        /// </summary>
        public MeetingScheduleResource schedule { get; set; }

        /// <summary>
        /// </summary>
        public HostInfoRequest host { get; set; }

        /// <summary>
        /// If true, then participants can join the meeting before host arrives
        /// </summary>
        public bool? allowJoinBeforeHost { get; set; }

        /// <summary>
        /// Starting meetings with host video on/off (true/false)
        /// </summary>
        public bool? startHostVideo { get; set; }

        /// <summary>
        /// Starting meetings with participant video on/off (true/false)
        /// </summary>
        public bool? startParticipantsVideo { get; set; }

        /// <summary>
        /// Enum: Phone, ComputerAudio
        /// </summary>
        public string[] audioOptions { get; set; }

        /// <summary>
        /// </summary>
        public RecurrenceInfo reccurence { get; set; }

        /// <summary>
        /// Automatic record type
        /// Default: none
        /// Enum: local, cloud, none
        /// </summary>
        public string autoRecordType { get; set; }

        /// <summary>
        /// If true, then only signed-in users can join this meeting
        /// </summary>
        public bool? enforceLogin { get; set; }

        /// <summary>
        /// If true, then participants are muted on entry
        /// </summary>
        public bool? muteParticipantsOnEntry { get; set; }

        /// <summary>
        /// If true, then the waiting room for participants is enabled
        /// </summary>
        public bool? enableWaitingRoom { get; set; }

        /// <summary>
        /// List of global dial-in countries (eg. US, UK, AU, etc.)
        /// </summary>
        public string[] globalDialInCountries { get; set; }
    }
}