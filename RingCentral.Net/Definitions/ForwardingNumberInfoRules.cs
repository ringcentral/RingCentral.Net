namespace RingCentral
{
    public class ForwardingNumberInfoRules
    {
        /// <summary>
        /// Link to a forwarding number resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a forwarding number
        /// </summary>
        public string id;

        /// <summary>
        /// Phone number to which the call is forwarded
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Title of a forwarding number
        /// </summary>
        public string label;

        /// <summary>
        /// Type of a forwarding number
        /// Enum: Home, Mobile, Work, PhoneLine, Outage, Other
        /// </summary>
        public string type;
    }
}