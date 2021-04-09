namespace RingCentral
{
    public class MeetingRequestResource
    {
        /// <summary>
        ///     Custom topic of a meeting
        /// </summary>
        public string topic { get; set; }

        /// <summary>
        ///     Enum: Instant, Scheduled, ScheduledRecurring, Recurring
        /// </summary>
        public string meetingType { get; set; }

        /// <summary>
        /// </summary>
        public MeetingScheduleResource schedule { get; set; }

        /// <summary>
        ///     Meeting password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// </summary>
        public HostInfoRequest host { get; set; }

        /// <summary>
        /// </summary>
        public bool? allowJoinBeforeHost { get; set; }

        /// <summary>
        /// </summary>
        public bool? startHostVideo { get; set; }

        /// <summary>
        ///     Starting meetings with participant video on/off (true/false)
        /// </summary>
        public bool? startParticipantsVideo { get; set; }

        /// <summary>
        ///     If true, then personal user's meeting ID is applied for creation of this meeting
        /// </summary>
        public bool? usePersonalMeetingId { get; set; }

        /// <summary>
        ///     Enum: Phone, ComputerAudio
        /// </summary>
        public string[] audioOptions { get; set; }

        /// <summary>
        /// </summary>
        public RecurrenceInfo recurrence { get; set; }

        /// <summary>
        ///     Automatic record type
        ///     Default: none
        ///     Enum: local, cloud, none
        /// </summary>
        public string autoRecordType { get; set; }

        /// <summary>
        ///     If true, then only signed-in users can join this meeting
        /// </summary>
        public bool? enforceLogin { get; set; }

        /// <summary>
        ///     If true, then participants are muted on entry
        /// </summary>
        public bool? muteParticipantsOnEntry { get; set; }

        /// <summary>
        ///     If true, then the waiting room for participants is enabled
        /// </summary>
        public bool? enableWaitingRoom { get; set; }

        /// <summary>
        ///     List of global dial-in countries (eg. US, UK, AU, etc.)
        /// </summary>
        public string[] globalDialInCountries { get; set; }
    }
}