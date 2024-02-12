namespace RingCentral
{
    public class CreateAnsweringRuleRequest
    {
        /// <summary>
        ///     Specifies if the rule is active or inactive. The default value
        ///     is `true`
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Type of an answering rule. The 'Custom' value should be specified
        ///     Required
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Name of an answering rule specified by user
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Answering rule will be applied when calls are received from the specified caller(s)
        /// </summary>
        public CallersInfoRequest[] callers { get; set; }

        /// <summary>
        ///     Answering rules are applied when calling to selected number(s)
        /// </summary>
        public CalledNumberInfo[] calledNumbers { get; set; }

        /// <summary>
        /// </summary>
        public ScheduleInfo schedule { get; set; }

        /// <summary>
        ///     Specifies how incoming calls are forwarded
        ///     Enum: ForwardCalls, UnconditionalForwarding, AgentQueue, TransferToExtension, TakeMessagesOnly,
        ///     PlayAnnouncementOnly, SharedLines
        /// </summary>
        public string callHandlingAction { get; set; }

        /// <summary>
        /// </summary>
        public ForwardingInfo forwarding { get; set; }

        /// <summary>
        /// </summary>
        public UnconditionalForwardingInfo unconditionalForwarding { get; set; }

        /// <summary>
        /// </summary>
        public QueueInfo queue { get; set; }

        /// <summary>
        /// </summary>
        public TransferredExtensionInfo transfer { get; set; }

        /// <summary>
        /// </summary>
        public VoicemailInfo voicemail { get; set; }

        /// <summary>
        /// </summary>
        public MissedCallInfo missedCall { get; set; }

        /// <summary>
        ///     Greetings applied for an answering rule; only predefined greetings
        ///     can be applied, see Dictionary Greeting List
        /// </summary>
        public GreetingInfo[] greetings { get; set; }

        /// <summary>
        ///     Call screening status. 'Off' - no call screening; 'NoCallerId'
        ///     - if caller ID is missing, then callers are asked to say their name before
        ///     connecting; 'UnknownCallerId' - if caller ID is not in contact list, then
        ///     callers are asked to say their name before connecting; 'Always' - the
        ///     callers are always asked to say their name before connecting. The default
        ///     value is 'Off'
        ///     Default: Off
        ///     Enum: Off, NoCallerId, UnknownCallerId, Always
        /// </summary>
        public string screening { get; set; }
    }
}