using Newtonsoft.Json;

namespace RingCentral.Net
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
        // Enum: Home, Mobile, Work, PhoneLine, Outage, Other
        public string type;
    }
}