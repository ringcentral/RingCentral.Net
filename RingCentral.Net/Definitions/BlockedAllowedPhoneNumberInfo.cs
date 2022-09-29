namespace RingCentral
{
    /// <summary>
    ///     Information on a blocked/allowed phone number
    /// </summary>
    public class BlockedAllowedPhoneNumberInfo
    {
        /// <summary>
        ///     Link to a blocked/allowed phone number
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a blocked/allowed phone number
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     A blocked/allowed phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Custom name of a blocked/allowed phone number
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Status of a phone number
        ///     Default: Blocked
        ///     Enum: Blocked, Allowed
        /// </summary>
        public string status { get; set; }
    }
}