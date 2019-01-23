namespace RingCentral
{
    public class ForwardingNumberInfo : Serializable
    {
        // Internal identifier of a forwarding/call flip phone number
        public string id;

        // Canonical URI of a forwarding/call flip phone number
        public string uri;

        // Forwarding/Call flip phone number
        public string phoneNumber;

        // Forwarding/Call flip number title
        public string label;

        // Type of option this phone number is used for. Multiple values are accepted
        public string[] features;

        // Number assigned to the call flip phone number, corresponds to the shortcut dial number
        public long? flipNumber;

        // Forwarding phone number type
        // Enum: Home, Mobile, Work, PhoneLine, Outage, Other
        public string type;
    }
}