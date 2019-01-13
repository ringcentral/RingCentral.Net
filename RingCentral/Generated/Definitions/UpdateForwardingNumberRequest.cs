using Newtonsoft.Json;

namespace RingCentral
{
    public class UpdateForwardingNumberRequest : Serializable
    {
        // Forwarding/Call flip phone number
        public string phoneNumber;
        // Forwarding/Call flip number title
        public string label;
        // Number assigned to the call flip phone number, corresponds to the shortcut dial number
        public string flipNumber;
        // Forwarding phone number type
        public string type;
    }
}