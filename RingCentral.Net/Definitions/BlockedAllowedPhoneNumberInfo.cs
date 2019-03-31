namespace RingCentral
{
    // Information on a blocked/allowed phone number
    public class BlockedAllowedPhoneNumberInfo
    {
        /// <summary>
        /// Link to a blocked/allowed phone number
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a blocked/allowed phone number
        /// </summary>
        public string id;

        /// <summary>
        /// A blocked/allowed phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Custom name of a blocked/allowed phone number
        /// </summary>
        public string label;

        /// <summary>
        /// Status of a phone number
        /// Enum: Blocked, Allowed
        /// </summary>
        public string status;
    }
}