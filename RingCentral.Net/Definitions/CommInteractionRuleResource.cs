namespace RingCentral
{
    /// <summary>
    ///     Interaction rule
    /// </summary>
    public class CommInteractionRuleResource
    {
        /// <summary>
        ///     Internal identifier of a rule
        ///     Required
        ///     Example: 400133463175
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public object[] conditions { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommInteractionDispatchingResource dispatching { get; set; }

        /// <summary>
        ///     Specifies if a rule is enabled or not. *Work Hours* and *After Hours* rules cannot be disabled
        ///     Required
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Custom name of a rule
        ///     Required
        /// </summary>
        public string displayName { get; set; }
    }
}