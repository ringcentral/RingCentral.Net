namespace RingCentral
{
    /// <summary>
    ///     Opt-out record
    /// </summary>
    public class OptOutResponse
    {
        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the recipient has opted out
        ///     Example: 15551234567
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format which is opted out
        ///     Example: 15551234567
        /// </summary>
        public string to { get; set; }

        /// <summary>
        ///     Status of a phone number
        ///     Enum: OptIn, OptOut
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Enum: Recipient, Account, Upstream, Carrier
        /// </summary>
        public string source { get; set; }
    }
}