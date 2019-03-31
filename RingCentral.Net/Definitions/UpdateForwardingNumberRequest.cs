namespace RingCentral
{
    public class UpdateForwardingNumberRequest
    {
        /// <summary>
        /// Forwarding/Call flip phone number
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Forwarding/Call flip number title
        /// </summary>
        public string label;

        /// <summary>
        /// Number assigned to the call flip phone number, corresponds to the shortcut dial number
        /// </summary>
        public string flipNumber;

        /// <summary>
        /// Forwarding phone number type
        /// Enum: Home, Mobile, Work, PhoneLine, Outage, Other
        /// </summary>
        public string type;
    }
}