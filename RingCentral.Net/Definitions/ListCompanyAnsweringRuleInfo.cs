namespace RingCentral
{
    public class ListCompanyAnsweringRuleInfo
    {
        /// <summary>
        /// Internal identifier of an answering rule
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Canonical URI of an answering rule
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Specifies if the rule is active or inactive. The default value is 'True'
        /// Default: true
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        /// Type of an answering rule, the default value is 'Custom' = ['BusinessHours', 'AfterHours', 'Custom']
        /// Enum: BusinessHours, AfterHours, Custom
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Name of an answering rule specified by user. Max number of symbols is 30. The default value is 'My Rule N' where 'N' is the first free number
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Answering rules are applied when calling to selected number(s)
        /// </summary>
        public CalledNumberInfo[] calledNumbers { get; set; }

        /// <summary>
        /// </summary>
        public CompanyAnsweringRuleExtensionInfo extension { get; set; }
    }
}