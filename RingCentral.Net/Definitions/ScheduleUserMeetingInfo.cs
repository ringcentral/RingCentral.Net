namespace RingCentral
{
    /// <summary>
    ///     Scheduling meeting settings locked on account level || Settings defining how to schedule user meetings
    /// </summary>
    public class ScheduleUserMeetingInfo
    {
        /// <summary>
        ///     If true, then only signed-in users can join this meeting
        /// </summary>
        public bool? enforceLogin { get; set; }

        /// <summary>
        ///     Starting meetings with host video on/off (true/false)
        /// </summary>
        public bool? startHostVideo { get; set; }

        /// <summary>
        ///     Starting meetings with participant video on/off (true/false)
        /// </summary>
        public bool? startParticipantsVideo { get; set; }

        /// <summary>
        ///     Determines how participants can join the audio channel of a meeting
        ///     Enum: Phone, ComputerAudio, ThirdParty
        /// </summary>
        public string[] audioOptions { get; set; }

        /// <summary>
        ///     Allows participants to join the meeting before the host arrives
        /// </summary>
        public bool? allowJoinBeforeHost { get; set; }

        /// <summary>
        ///     Determines whether to use Personal Meeting ID (PMI) when scheduling a meeting
        /// </summary>
        public bool? usePmiForScheduledMeetings { get; set; }

        /// <summary>
        ///     Determines whether to use Personal Meeting ID (PMI) when starting an instant meeting
        /// </summary>
        public bool? usePmiForInstantMeetings { get; set; }

        /// <summary>
        ///     A password will be generated when scheduling a meeting and participants will require password to join a meeting.
        ///     The Personal Meeting ID (PMI) meetings are not included
        /// </summary>
        public bool? requirePasswordForSchedulingNewMeetings { get; set; }

        /// <summary>
        ///     Specifies whether to require a password for meetings which have already been scheduled
        /// </summary>
        public bool? requirePasswordForScheduledMeetings { get; set; }

        /// <summary>
        ///     Password for already scheduled meetings. Users can set it individually
        /// </summary>
        public string defaultPasswordForScheduledMeetings { get; set; }

        /// <summary>
        ///     A random password will be generated for an instant meeting, if set to `true`. If you use PMI for your instant
        ///     meetings, this option will be disabled
        /// </summary>
        public bool? requirePasswordForInstantMeetings { get; set; }

        /// <summary>
        ///     Specifies whether to require a password for meetings using Personal Meeting ID (PMI). The supported values are:
        ///     'none', 'all' and 'jbhOnly' (joined before host only)
        ///     Enum: all, none, jbhOnly
        /// </summary>
        public string requirePasswordForPmiMeetings { get; set; }

        /// <summary>
        ///     The default password for Personal Meeting ID (PMI) meetings
        /// </summary>
        public string pmiPassword { get; set; }

        /// <summary>
        ///     Specifies whether to generate and require a password for participants joining by phone
        /// </summary>
        public bool? pstnPasswordProtected { get; set; }

        /// <summary>
        /// </summary>
        public bool? muteParticipantsOnEntry { get; set; }
    }
}