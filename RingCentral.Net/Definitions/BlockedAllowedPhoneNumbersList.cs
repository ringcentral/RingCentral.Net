namespace RingCentral
{
    /// <summary>
    ///     List of blocked or allowed phone numbers
    /// </summary>
    public class BlockedAllowedPhoneNumbersList
    {
        /// <summary>
        ///     Link to a list of blocked/allowed phone numbers resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public BlockedAllowedPhoneNumberInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public NavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPaging paging { get; set; }
    }
}