namespace RingCentral
{
    // Information on an answering rule that the greeting is applied to
    public class CustomGreetingAnsweringRuleInfo
    {
        /// <summary>
        /// Canonical URI of an answering rule
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Internal identifier of an answering rule
        /// </summary>
        public string id { get; set; }
    }
}