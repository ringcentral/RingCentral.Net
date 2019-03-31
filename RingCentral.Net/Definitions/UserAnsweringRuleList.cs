namespace RingCentral
{
    public class UserAnsweringRuleList
    {
        /// <summary>
        /// Canonical URI of an answering rule list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of answering rules
        /// </summary>
        public UserAnsweringRuleListRecord[] records;

        /// <summary>
        /// </summary>
        public UserAnsweringRuleListPaging paging;

        /// <summary>
        /// </summary>
        public UserAnsweringRuleListNavigation navigation;
    }
}