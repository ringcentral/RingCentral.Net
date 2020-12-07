namespace RingCentral
{
    public class GetExtensionForwardingNumberListResponse
    {
        /// <summary>
        /// Link to the forwarding number list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of forwarding phone numbers
        /// </summary>
        public ForwardingNumberInfo[] records;

        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public CallHandlingPagingInfo paging;
    }
}