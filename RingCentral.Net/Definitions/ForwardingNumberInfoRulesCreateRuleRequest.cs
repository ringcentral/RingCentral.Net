namespace RingCentral
{
    public class ForwardingNumberInfoRulesCreateRuleRequest
    {
        /// <summary>
        ///     Internal identifier of a forwarding number
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Forwarding phone number type
        ///     Enum: Home, Mobile, Work, PhoneLine, Outage, Other, BusinessMobilePhone, ExternalCarrier
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Canonical URI of a forwarding/call flip phone number
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Forwarding/Call flip phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Forwarding/Call flip number title
        /// </summary>
        public string label { get; set; }
    }
}