namespace RingCentral
{
    /// <summary>
    ///     Interaction rule create request
    /// </summary>
    public class CommInteractionRuleCreateRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public object[] conditions { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommDispatchingRequest dispatching { get; set; }

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