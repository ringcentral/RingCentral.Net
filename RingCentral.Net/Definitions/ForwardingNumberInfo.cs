namespace RingCentral
{
    public class ForwardingNumberInfo
    {
        /// <summary>
        ///     Internal identifier of a forwarding/call flip phone number
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
        ///     Type of option this phone number is used for. Multiple values are accepted
        ///     Enum: CallFlip, CallForwarding
        /// </summary>
        public string[] features { get; set; }

        /// <summary>
        ///     Number assigned to the call flip phone number, corresponds to the shortcut dial number
        /// </summary>
        public string flipNumber { get; set; }

        /// <summary>
        /// </summary>
        public CreateForwardingNumberDeviceInfo device { get; set; }

        /// <summary>
        ///     Forwarding phone number type
        ///     Enum: Home, Mobile, Work, PhoneLine, Outage, Other, BusinessMobilePhone, ExternalCarrier
        /// </summary>
        public string type { get; set; }
    }
}