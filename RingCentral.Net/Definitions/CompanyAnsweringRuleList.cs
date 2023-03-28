namespace RingCentral
{
    public class CompanyAnsweringRuleList
    {
        /// <summary>
        ///     Link to an answering rule resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of company answering rules
        /// </summary>
        public ListCompanyAnsweringRuleInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }
    }
}