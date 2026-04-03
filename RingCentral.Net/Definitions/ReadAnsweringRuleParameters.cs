namespace RingCentral
{
    /// <summary>
    /// Query parameters for operation readAnsweringRule
    /// </summary>
    public class ReadAnsweringRuleParameters
    {
        /// <summary>
        ///     Indicates whether inactive numbers should be returned or not
        /// </summary>
        public bool? showInactiveNumbers { get; set; }

        /// <summary>
        ///     If true, internal identifiers are returned in the response
        /// </summary>
        public bool? internalIds { get; set; }
    }
}