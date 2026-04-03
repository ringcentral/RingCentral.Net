namespace RingCentral
{
    /// <summary>
    /// Used as selection hint when a "toll" number is selected from the number pool
    /// </summary>
    public class PhoneNumberDefinitionPreferredAreaCode
    {
        /// <summary>
        ///     Preferred area code to use if the numbers are available
        ///     Required
        ///     Example: 650
        /// </summary>
        public string preferredAreaCode { get; set; }

        /// <summary>
        ///     Indicates if a number is toll or toll-free
        ///     Example: Toll
        ///     Enum: Toll, TollFree
        /// </summary>
        public string tollType { get; set; }

        /// <summary>
        ///     Type of a phone number
        ///     Enum: VoiceFax, VoiceOnly, FaxOnly
        /// </summary>
        public string type { get; set; }
    }
}