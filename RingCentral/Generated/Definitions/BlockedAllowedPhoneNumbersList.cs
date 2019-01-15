using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class BlockedAllowedPhoneNumbersList : Serializable
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