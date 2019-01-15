using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class MeetingsResource : Serializable
    {
        public string uri;
        public MeetingResponseResource[] records;
        public Paging paging;
        public Navigation navigation;
    }
}