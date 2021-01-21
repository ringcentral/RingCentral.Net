namespace RingCentral
{
    // Forwarding parameters. Returned if 'ForwardCalls' is specified in 'callHandlingAction'. These settings determine the forwarding numbers to which the call will be forwarded
    public class ForwardingInfoCreateRuleRequest
    {
        /// <summary>
        /// Specifies if the first ring on desktop/mobile apps is enabled. The default value is 'True'
        /// </summary>
        public bool? notifyMySoftPhones { get; set; }

        /// <summary>
        /// Specifies if the administrator's softphone (desktop application) is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is 'True'
        /// </summary>
        public bool? notifyAdminSoftPhones { get; set; }

        /// <summary>
        /// Specifies delay between ring on apps and starting of a call forwarding
        /// </summary>
        public long? softPhonesRingCount { get; set; }

        /// <summary>
        /// Specifies the order in which forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ringing all at the same time. The default value is 'Sequentially'
        /// Enum: Sequentially, Simultaneously
        /// </summary>
        public string ringingMode { get; set; }

        /// <summary>
        /// Information on a call forwarding rule
        /// </summary>
        public RuleInfoCreateRuleRequest[] rules { get; set; }

        /// <summary>
        /// Specifies if mobile timeout is activated for the rule
        /// </summary>
        public bool? mobileTimeout { get; set; }
    }
}