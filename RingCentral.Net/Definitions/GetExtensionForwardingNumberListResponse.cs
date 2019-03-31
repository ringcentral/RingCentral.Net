namespace RingCentral
{
    public class GetExtensionForwardingNumberListResponse
    {
        /// <summary>
        /// List of forwarding phone numbers
        /// </summary>
        public ForwardingNumberInfo[] records;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public CallHandlingNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public CallHandlingPagingInfo paging;
    }
}