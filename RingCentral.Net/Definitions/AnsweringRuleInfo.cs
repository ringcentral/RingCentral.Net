namespace RingCentral
{
    public class AnsweringRuleInfo
    {
        /// <summary>
        /// Canonical URI to an answering rule resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of an answering rule
        /// </summary>
        public string id;

        /// <summary>
        /// Type of an answering rule
        /// Enum: BusinessHours, AfterHours, Custom
        /// </summary>
        public string type;

        /// <summary>
        /// Name of an answering rule specified by user
        /// </summary>
        public string name;

        /// <summary>
        /// Specifies if an answering rule is active or inactive
        /// </summary>
        public bool? enabled;

        /// <summary>
        /// </summary>
        public ScheduleInfo schedule;

        /// <summary>
        /// Answering rules are applied when calling to selected number(s)
        /// </summary>
        public CalledNumberInfo[] calledNumbers;

        /// <summary>
        /// Answering rules are applied when calls are received from specified caller(s)
        /// </summary>
        public CallersInfo[] callers;

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

        /// <summary>
        /// </summary>
        public SharedLinesInfo sharedLines;
    }
}