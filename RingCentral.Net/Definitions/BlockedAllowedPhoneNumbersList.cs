namespace RingCentral
{
    // List of blocked or allowed phone numbers
    public class BlockedAllowedPhoneNumbersList
    {
        /// <summary>
        /// Link to a list of blocked/allowed phone numbers resource
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public BlockedAllowedPhoneNumberInfo[] records;

        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public CallHandlingPagingInfo paging;
    }
}