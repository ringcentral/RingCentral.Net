namespace RingCentral
{
    public class UserAnsweringRuleList
    {
        // Link to an answering rule resource
        public string uri;

        // List of user answering rules
        public ListCompanyAnsweringRuleInfo[] records;

        // Information on paging
        public CallHandlingPagingInfo paging;

        // Information on navigation
        public CallHandlingNavigationInfo navigation;
    }
}