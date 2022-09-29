namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listBlockedAllowedNumbers
    /// </summary>
    public class ListBlockedAllowedNumbersParameters
    {
        /// <summary>
        ///     Status of a phone number
        ///     Default: Blocked
        ///     Enum: Blocked, Allowed
        /// </summary>
        public string status { get; set; }
    }
}