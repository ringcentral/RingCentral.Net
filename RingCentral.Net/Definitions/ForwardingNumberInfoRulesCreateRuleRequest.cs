namespace RingCentral
{
    public class ForwardingNumberInfoRulesCreateRuleRequest
    {
        /// <summary>
        /// Internal identifier of a forwarding number
        /// </summary>
        public string id;

        /// <summary>
        /// Forwarding phone number type
        /// Enum: Home, Mobile, Work, PhoneLine, Outage, Other, BusinessMobilePhone
        /// </summary>
        public string type;

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
        /// Enum: Business Mobile Phone
        /// </summary>
        public string label;
    }
}