namespace RingCentral
{
    // Scheduling meeting settings locked on account level || Settings defining how to schedule user meetings
    public class ScheduleUserMeetingInfo
    {
        /// <summary>
        /// Starting meetings with host video on/off (true/false)
        /// </summary>
        public bool? startHostVideo;

        /// <summary>
        /// Starting meetings with participant video on/off (true/false)
        /// </summary>
        public bool? startParticipantsVideo;

        /// <summary>
        /// Determines how participants can join the audio channel of a meeting
        /// Enum: Phone, ComputerAudio
        /// </summary>
        public string[] audioOptions;

        /// <summary>
        /// Allows participants to join the meeting before the host arrives
        /// </summary>
        public bool? allowJoinBeforeHost;

        /// <summary>
        /// Determines whether to use Personal Meeting ID (PMI) when scheduling a meeting
        /// </summary>
        public bool? usePmiForScheduledMeetings;

        /// <summary>
        /// Determines whether to use Personal Meeting ID (PMI) when starting an instant meeting
        /// </summary>
        public bool? usePmiForInstantMeetings;

        /// <summary>
        /// A password will be generated when scheduling a meeting and participants will require password to join a meeting. The Personal Meeting ID (PMI) meetings are not included
        /// </summary>
        public bool? requirePasswordForSchedulingNewMeetings;

        /// <summary>
        /// Specifies whether to require a password for meetings which have already been scheduled
        /// </summary>
        public bool? requirePasswordForScheduledMeetings;

        /// <summary>
        /// Password for already scheduled meetings. Users can set it individually
        /// </summary>
        public string defaultPasswordForScheduledMeetings;

        /// <summary>
        /// A random password will be generated for an instant meeting, if set to 'True'. If you use PMI for your instant meetings, this option will be disabled
        /// </summary>
        public bool? requirePasswordForInstantMeetings;

        /// <summary>
        /// Specifies whether to require a password for meetings using Personal Meeting ID (PMI). The supported values are: 'none', 'all' and 'jbhOnly' (joined before host only)
        /// Enum: all, none, jbhOnly
        /// </summary>
        public string requirePasswordForPmiMeetings;

        /// <summary>
        /// The default password for Personal Meeting ID (PMI) meetings
        /// </summary>
        public string pmiPassword;

        /// <summary>
        /// Specifies whether to generate and require a password for participants joining by phone
        /// </summary>
        public bool? pstnPasswordProtected;
    }
}