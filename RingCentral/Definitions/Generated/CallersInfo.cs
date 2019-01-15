using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallersInfo : Serializable
    {
        // Phone number of a caller
        public string callerId;
        // Contact name of a caller
        public string name;
    }
}