using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallQueueMemberInfo : Serializable
    {
        // Link to a call queue member
        public string uri;
        // Internal identifier of a call queue member
        public string id;
        // Extension number of a call queue member
        public string extensionNumber;
    }
}