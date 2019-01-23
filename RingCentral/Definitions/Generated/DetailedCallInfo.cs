using Newtonsoft.Json;

namespace RingCentral
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