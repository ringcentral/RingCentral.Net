namespace RingCentral
{
    public class ForwardingNumberResource
    {
        public string uri;

        public string id;

        public string phoneNumber;

        public string label;

        public string[] features;

        public string flipNumber;

        /* Forwarding phone number type */
        // Enum: Home, Mobile, Work, PhoneLine, Outage, Other
        public string type;
    }
}