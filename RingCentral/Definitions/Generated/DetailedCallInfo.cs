using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class DetailedCallInfo : Serializable
    {
        public string callId;
        public string toTag;
        public string fromTag;
        public string remoteUri;
        public string localUri;
        public string rcSessionId;
    }
}