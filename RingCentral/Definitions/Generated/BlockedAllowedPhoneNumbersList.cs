namespace RingCentral
{
    // List of blocked or allowed phone numbers
    public class BlockedAllowedPhoneNumbersList
    {
        // Link to a list of blocked/allowed phone numbers resource
        public string uri;

        public BlockedAllowedPhoneNumberInfo[] records;

        // Information on navigation
        public NavigationInfo navigation;

        // Information on paging
        public PagingInfo paging;
    }
}