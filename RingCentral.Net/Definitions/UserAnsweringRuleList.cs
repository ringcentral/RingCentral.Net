namespace RingCentral
{
    public class UserAnsweringRuleList
    {
        /* Canonical URI of an answering rule list resource */
        public string uri;

        /* List of answering rules */
        public UserAnsweringRuleListRecord[] records;

        public UserAnsweringRuleListPaging paging;

        public UserAnsweringRuleListNavigation navigation;
    }
}