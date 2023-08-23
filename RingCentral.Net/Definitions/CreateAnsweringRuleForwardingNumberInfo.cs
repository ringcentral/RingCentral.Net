namespace RingCentral
{
    public class CreateAnsweringRuleForwardingNumberInfo
    {
        /// <summary>
        ///     Internal identifier of a forwarding number
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a forwarding/call flip phone number
        ///     Format: uri
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

        /// <summary>
        ///     Type of a forwarding number
        ///     Enum: Home, Mobile, Work, PhoneLine, Outage, Other, BusinessMobilePhone, ExternalCarrier, ExtensionApps
        /// </summary>
        public string type { get; set; }
    }
}