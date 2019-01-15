using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class MeetingRecordingInfo : Serializable
    {
        public MeetingInfo meeting;
        public RecordingInfo[] recordings;
    }
}