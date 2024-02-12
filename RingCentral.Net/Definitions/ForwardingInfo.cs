namespace RingCentral
{
    /// <summary>
    ///     Forwarding parameters. Returned if 'ForwardCalls' is specified in 'callHandlingAction'. These settings determine
    ///     the forwarding numbers to which the call will be forwarded
    /// </summary>
    public class ForwardingInfo
    {
        /// <summary>
        ///     Specifies if the user's softphone(s) are notified before forwarding the incoming call to desk phones and forwarding
        ///     numbers
        /// </summary>
        public bool? notifyMySoftPhones { get; set; }

        /// <summary>
        ///     Deprecated parameter. Specifies if the administrator's softphone is notified before forwarding the incoming call to
        ///     desk phones and forwarding numbers. The default value is `false`
        /// </summary>
        public bool? notifyAdminSoftPhones { get; set; }

        /// <summary>
        ///     Number of rings before forwarding starts
        ///     Format: int32
        /// </summary>
        public long? softPhonesRingCount { get; set; }

        /// <summary>
        ///     Specifies that desktop and mobile applications of the user will ring till the end of their forwarding list. If set
        ///     to `true` then `softPhonesRingCount` is ignored
        ///     Default: true
        /// </summary>
        public bool? softPhonesAlwaysRing { get; set; }

        /// <summary>
        ///     Specifies the order in which the forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing
        ///     one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ring all at the same time
        ///     Enum: Sequentially, Simultaneously
        /// </summary>
        public string ringingMode { get; set; }

        /// <summary>
        ///     Information on a call forwarding rule
        /// </summary>
        public ForwardingRuleInfo[] rules { get; set; }

        /// <summary>
        ///     Specifies if desktop and mobile applications of the user are notified before (true) or after (false) forwarding the
        ///     incoming call to desk phones and forwarding numbers. Applicable only if `notifyMySoftPhones` parameter is set to
        ///     `true`
        /// </summary>
        public bool? softPhonesPositionTop { get; set; }

        /// <summary>
        ///     Deprecated parameter. Specifies if mobile timeout is activated for the rule
        /// </summary>
        public bool? mobileTimeout { get; set; }
    }
}