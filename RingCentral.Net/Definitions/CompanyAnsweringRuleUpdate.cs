namespace RingCentral
{
    public class CompanyAnsweringRuleUpdate
    {
        /// <summary>
        ///     Specifies if the rule is active or inactive. The default value is 'True'
        ///     Default: true
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Name of an answering rule specified by user. Max number of symbols is 30. The default value is 'My Rule N' where
        ///     'N' is the first free number
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Answering rule will be applied when calls are received from the specified caller(s)
        /// </summary>
        public CompanyAnsweringRuleCallersInfoRequest[] callers { get; set; }

        /// <summary>
        ///     Answering rule will be applied when calling the specified number(s)
        /// </summary>
        public CompanyAnsweringRuleCalledNumberInfo[] calledNumbers { get; set; }

        /// <summary>
        /// </summary>
        public CompanyAnsweringRuleScheduleInfoRequest schedule { get; set; }

        /// <summary>
        ///     Specifies how incoming calls are forwarded. The default value is 'Operator' 'Operator' - play company greeting and
        ///     forward to operator extension 'Disconnect' - play company greeting and disconnect 'Bypass' - bypass greeting to go
        ///     to selected extension = ['Operator', 'Disconnect','Bypass']
        ///     Enum: Operator, Disconnect, Bypass
        /// </summary>
        public string callHandlingAction { get; set; }

        /// <summary>
        ///     Type of an answering rule
        ///     Default: Custom
        ///     Enum: BusinessHours, AfterHours, Custom
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CompanyAnsweringRuleCallersInfoRequest extension { get; set; }

        /// <summary>
        ///     Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List
        /// </summary>
        public GreetingInfo[] greetings { get; set; }
    }
}