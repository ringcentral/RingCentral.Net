namespace RingCentral
{
    public class MeetingResponseResource
    {
        /// <summary>
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public string uuid;

        /// <summary>
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public string topic;

        /// <summary>
        /// </summary>
        public string meetingType;

        /// <summary>
        /// </summary>
        public string password;

        /// <summary>
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public MeetingLinks links;

        /// <summary>
        /// </summary>
        public MeetingScheduleResource schedule;

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