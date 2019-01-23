using Newtonsoft.Json;

namespace RingCentral
{
    public class LanguageList : Serializable
    {
        // Canonical URI of the language list resource
        public string uri;
        // Language data
        public LanguageInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}