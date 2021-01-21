namespace RingCentral
{
    // List of blocked or allowed phone numbers
    public class BlockedAllowedPhoneNumbersList
    {
        /// <summary>
        /// Link to a list of blocked/allowed phone numbers resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public BlockedAllowedPhoneNumberInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingPagingInfo paging { get; set; }
    }
}