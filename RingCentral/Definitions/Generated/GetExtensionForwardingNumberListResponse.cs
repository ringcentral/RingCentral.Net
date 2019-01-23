namespace RingCentral
{
    public class GetExtensionForwardingNumberListResponse : Serializable
    {
        // List of forwarding phone numbers
        public ForwardingNumberInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}