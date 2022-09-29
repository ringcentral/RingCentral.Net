namespace RingCentral
{
    public class ForwardingNumberResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Enum: CallFlip, CallForwarding
        /// </summary>
        public string[] features { get; set; }

        /// <summary>
        /// </summary>
        public string flipNumber { get; set; }

        /// <summary>
        ///     Forwarding phone number type
        ///     Enum: Home, Mobile, Work, PhoneLine, Outage, Other
        /// </summary>
        public string type { get; set; }
    }
}