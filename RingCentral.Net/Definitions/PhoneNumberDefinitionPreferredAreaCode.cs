namespace RingCentral
{
    /// <summary>
    ///     To use as selection hint when a "toll" number to be selected from the number pool.
    /// </summary>
    public class PhoneNumberDefinitionPreferredAreaCode
    {
        /// <summary>
        ///     Preferred area code to use if numbers available
        ///     Required
        ///     Example: 650
        /// </summary>
        public string preferredAreaCode { get; set; }
    }
}