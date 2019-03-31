namespace RingCentral
{
    public class MeetingRequestResource
    {
        /// <summary>
        /// </summary>
        public string topic;

        /// <summary>
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
        public string[] audioOptions;
    }
}