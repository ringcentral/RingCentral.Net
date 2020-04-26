namespace RingCentral
{
    public class CreateAnsweringRuleForwardingNumberInfo
    {
        /// <summary>
        /// Internal identifier of a forwarding number
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of a forwarding/call flip phone number
        /// </summary>
        public string uri;

        /// <summary>
        /// Forwarding/Call flip phone number
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Forwarding/Call flip number title
        /// </summary>
        public string label;

        /// <summary>
        /// Type of a forwarding number
        /// Enum: Home, Mobile, Work, PhoneLine, Outage, Other
        /// </summary>
        public string type;
    }
}