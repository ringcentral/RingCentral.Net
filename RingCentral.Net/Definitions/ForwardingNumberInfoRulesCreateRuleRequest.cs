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
        ///     Enum: Home, Mobile, Work, PhoneLine, Outage, Other, BusinessMobilePhone, ExternalCarrier, ExtensionApps
        /// </summary>
        public string type { get; set; }

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