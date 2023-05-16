namespace RingCentral
{
    /// <summary>
    ///     To use as selection criteria when a number to be selected from the number pool.
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
    }
}