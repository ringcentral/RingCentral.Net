namespace RingCentral
{
    public class GetExtensionForwardingNumberListResponse
    {
        // List of forwarding phone numbers
        public ForwardingNumberInfo[] records;

        // Information on navigation
        public CallHandlingNavigationInfo navigation;

        // Information on paging
        public CallHandlingPagingInfo paging;
    }
}