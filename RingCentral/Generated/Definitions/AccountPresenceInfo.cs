using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AccountPresenceInfo : Serializable
    {
        // Canonical URI of account presence resource
        public string uri;
        // List of Prompts
        public GetPresenceInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}