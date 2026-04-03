namespace RingCentral
{
    public class CommInteractionRulesResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommInteractionRuleResource[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}