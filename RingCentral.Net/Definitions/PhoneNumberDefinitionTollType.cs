namespace RingCentral
{
    /// <summary>
    /// Filtering criteria when a number is selected from the number pool
    /// </summary>
    public class PhoneNumberDefinitionTollType
    {
        /// <summary>
        ///     Indicates if a number is toll or toll-free
        ///     Required
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