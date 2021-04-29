namespace RingCentral
{
    public class CustomAnsweringRuleInfo
    {
        /// <summary>
        ///     Canonical URI to an answering rule resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an answering rule
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of an answering rule
        ///     Enum: BusinessHours, AfterHours, Custom
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Name of an answering rule specified by user
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Specifies if an answering rule is active or inactive
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        /// </summary>
        public ScheduleInfo schedule { get; set; }

        /// <summary>
        ///     Answering rules are applied when calling to selected number(s)
        /// </summary>
        public CalledNumberInfo[] calledNumbers { get; set; }

        /// <summary>
        ///     Answering rules are applied when calls are received from specified caller(s)
        /// </summary>
        public CallersInfo[] callers { get; set; }

        /// <summary>
        ///     Specifies how incoming calls are forwarded
        ///     Enum: ForwardCalls, UnconditionalForwarding, AgentQueue, TransferToExtension, TakeMessagesOnly, PlayAnnouncementOnly, SharedLines
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
        ///     Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List
        /// </summary>
        public GreetingInfo[] greetings { get; set; }

        /// <summary>
        ///     Call screening status. 'Off' - no call screening; 'NoCallerId' - if caller ID is missing, then callers are asked to say their name before connecting; 'UnknownCallerId' - if caller ID is not in contact list, then callers are asked to say their name before connecting; 'Always' - the callers are always asked to say their name before connecting. The default value is 'Off'
        ///     Enum: Off, NoCallerId, UnknownCallerId, Always
        /// </summary>
        public string screening { get; set; }

        /// <summary>
        /// </summary>
        public SharedLinesInfo sharedLines { get; set; }
    }
}