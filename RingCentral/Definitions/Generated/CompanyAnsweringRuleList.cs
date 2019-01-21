using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CompanyAnsweringRuleList : Serializable
    {
        // Link to an answering rule resource
        public string uri;
        // List of company answering rules
        public ListCompanyAnsweringRuleInfo[] records;
        // Information on paging
        public PagingInfo paging;
        // Information on navigation
        public NavigationInfo navigation;
    }
}