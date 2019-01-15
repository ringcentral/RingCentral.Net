using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallersInfoRequest : Serializable
    {
        // Phone number of a caller
        public string callerId;
        // Contact name of a caller
        public string name;
    }
}