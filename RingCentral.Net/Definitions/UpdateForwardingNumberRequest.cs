namespace RingCentral
{
    public class UpdateForwardingNumberRequest
    {
        /// <summary>
        /// Forwarding/Call flip phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// Forwarding/Call flip number title
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// Number assigned to the call flip phone number, corresponds to the shortcut dial number
        /// </summary>
        public string flipNumber { get; set; }

        /// <summary>
        /// Forwarding phone number type
        /// Enum: Home, Mobile, Work, PhoneLine, Outage, Other, BusinessMobilePhone, ExternalCarrier
        /// </summary>
        public string type { get; set; }
    }
}