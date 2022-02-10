namespace RingCentral
{
    /// <summary>
    ///     Information on an answering rule that the greeting is applied to
    /// </summary>
    public class CustomGreetingAnsweringRuleInfo
    {
        /// <summary>
        ///     Canonical URI of an answering rule
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an answering rule
        /// </summary>
        public string id { get; set; }
    }
}