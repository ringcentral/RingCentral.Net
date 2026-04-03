namespace RingCentral
{
    public class CreateForwardingNumberRequest
    {
        /// <summary>
        ///     Internal identifier of a forwarding/call flip phone number
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Number assigned to the call flip phone number, corresponds to the shortcut dial number
        ///     Format: int32
        /// </summary>
        public long? flipNumber { get; set; }

        /// <summary>
        ///     Forwarding/call flip phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Forwarding/call flip number title
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Forwarding/call flip phone type. If specified, 'label' attribute value is ignored
        ///     Default: Other
        ///     Enum: PhoneLine, Home, Mobile, Work, Other
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CreateForwardingNumberDeviceInfo device { get; set; }
    }
}