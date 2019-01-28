namespace RingCentral
{
    public class CompanyAnsweringRuleList
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