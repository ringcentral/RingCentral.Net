namespace RingCentral
{
    public class MeetingResponseResource : Serializable
    {
        public string uri;
        public string uuid;
        public string id;
        public string topic;
        public string meetingType;
        public string password;
        public string status;
        public MeetingLinks links;
        public MeetingScheduleResource schedule;
        public bool? allowJoinBeforeHost;
        public bool? startHostVideo;
        public bool? startParticipantsVideo;
        public string[] audioOptions;
    }
}