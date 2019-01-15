using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ForwardingNumberInfoRules : Serializable
    {
        // Link to a forwarding number resource
        public string uri;
        // Internal identifier of a forwarding number
        public string id;
        // Phone number to which the call is forwarded
        public string phoneNumber;
        // Title of a forwarding number
        public string label;
        // Type of a forwarding number
        public string type;
    }
}