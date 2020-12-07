namespace RingCentral
{
    public class CreateAnsweringRuleRequest
    {
        /// <summary>
        /// Specifies if the rule is active or inactive. The default value is 'True'
        /// </summary>
        public bool? enabled;

        /// <summary>
        /// Type of an answering rule. The 'Custom' value should be specified
        /// </summary>
        public string type;

        /// <summary>
        /// Name of an answering rule specified by user
        /// </summary>
        public string name;

        /// <summary>
        /// Answering rule will be applied when calls are received from the specified caller(s)
        /// </summary>
        public CallersInfoRequest[] callers;

        /// <summary>
        /// Answering rules are applied when calling to selected number(s)
        /// </summary>
        public CalledNumberInfo[] calledNumbers;

        /// <summary>
        /// </summary>
        public ScheduleInfo schedule;

        /// <summary>
        /// Specifies how incoming calls are forwarded
        /// Enum: ForwardCalls, UnconditionalForwarding, AgentQueue, TransferToExtension, TakeMessagesOnly, PlayAnnouncementOnly, SharedLines
        /// </summary>
        public string callHandlingAction;

        /// <summary>
        /// </summary>
        public ForwardingInfo forwarding;

        /// <summary>
        /// </summary>
        public UnconditionalForwardingInfo unconditionalForwarding;

        /// <summary>
        /// </summary>
        public QueueInfo queue;

        /// <summary>
        /// </summary>
        public TransferredExtensionInfo transfer;

        /// <summary>
        /// </summary>
        public VoicemailInfo voicemail;

        /// <summary>
        /// Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List
        /// </summary>
        public GreetingInfo[] greetings;

        /// <summary>
        /// Call screening status. 'Off' - no call screening; 'NoCallerId' - if caller ID is missing, then callers are asked to say their name before connecting; 'UnknownCallerId' - if caller ID is not in contact list, then callers are asked to say their name before connecting; 'Always' - the callers are always asked to say their name before connecting. The default value is 'Off'
        /// Enum: Off, NoCallerId, UnknownCallerId, Always
        /// </summary>
        public string screening;
    }
}