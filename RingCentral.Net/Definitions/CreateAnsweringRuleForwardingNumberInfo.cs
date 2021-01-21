namespace RingCentral
{
    public class CreateAnsweringRuleForwardingNumberInfo
    {
        /// <summary>
        /// Internal identifier of a forwarding number
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Canonical URI of a forwarding/call flip phone number
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Forwarding/Call flip phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// Forwarding/Call flip number title
        /// Enum: Business Mobile Phone
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// Type of a forwarding number
        /// Enum: Home, Mobile, Work, PhoneLine, Outage, Other, BusinessMobilePhone
        /// </summary>
        public string type { get; set; }
    }
}