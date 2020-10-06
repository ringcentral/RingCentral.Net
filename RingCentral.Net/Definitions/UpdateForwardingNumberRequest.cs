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
        /// Enum: Business Mobile Phone
        /// </summary>
        public string label;

        /// <summary>
        /// Number assigned to the call flip phone number, corresponds to the shortcut dial number
        /// </summary>
        public string flipNumber;

        /// <summary>
        /// Forwarding phone number type
        /// Enum: Home, Mobile, Work, PhoneLine, Outage, Other, BusinessMobilePhone
        /// </summary>
        public string type;
    }
}