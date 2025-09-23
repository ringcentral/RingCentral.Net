namespace RingCentral
{
    /// <summary>
    ///     Updates either blocked or allowed phone number list with a new phone number.
    /// </summary>
    public class AddBlockedAllowedPhoneNumber
    {
        /// <summary>
        ///     A blocked/allowed phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Custom name of a blocked/allowed phone number
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Status of a phone number blocking
        ///     Default: Blocked
        ///     Enum: Blocked, Allowed
        /// </summary>
        public string status { get; set; }
    }
}