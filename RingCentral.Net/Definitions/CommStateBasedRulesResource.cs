namespace RingCentral
{
    /// <summary>
    ///     State-based rule information
    /// </summary>
    public class CommStateBasedRulesResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommStateBasedRuleResource[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}