namespace RingCentral
{
    public class CompanyAnsweringRuleList
    {
        /// <summary>
        ///     Link to an answering rule resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of company answering rules
        /// </summary>
        public ListCompanyAnsweringRuleInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPaging paging { get; set; }

        /// <summary>
        /// </summary>
        public NavigationInfo navigation { get; set; }
    }
}