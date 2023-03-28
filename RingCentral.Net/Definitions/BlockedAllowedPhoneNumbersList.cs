namespace RingCentral
{
    /// <summary>
    ///     List of blocked or allowed phone numbers
    /// </summary>
    public class BlockedAllowedPhoneNumbersList
    {
        /// <summary>
        ///     Link to a list of blocked/allowed phone numbers resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public BlockedAllowedPhoneNumberInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}