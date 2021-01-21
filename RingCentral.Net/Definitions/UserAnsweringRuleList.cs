namespace RingCentral
{
    public class UserAnsweringRuleList
    {
        /// <summary>
        /// Canonical URI of an answering rule list resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of answering rules
        /// </summary>
        public UserAnsweringRuleListRecord[] records { get; set; }

        /// <summary>
        /// </summary>
        public UserAnsweringRuleListPaging paging { get; set; }

        /// <summary>
        /// </summary>
        public UserAnsweringRuleListNavigation navigation { get; set; }
    }
}