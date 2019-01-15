using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CreateAnsweringRuleRequest : Serializable
    {
        // Specifies if the rule is active or inactive. The default value is 'True'
        public bool? enabled;
        // Type of an answering rule. The 'Custom' value should be specified
        public string type; // Required
        // Name of an answering rule specified by user
        public string name; // Required
        // Answering rule will be applied when calls are received from the specified caller(s)
        public CallersInfoRequest[] callers;
        // Answering rules are applied when calling to selected number(s)
        public CalledNumberInfo[] calledNumbers;
        // Schedule when an answering rule should be applied
        public ScheduleInfo schedule;
        // Specifies how incoming calls are forwarded
        // Enum: ForwardCalls, UnconditionalForwarding, AgentQueue, TransferToExtension, TakeMessagesOnly, PlayAnnouncementOnly
        public string callHandlingAction;
        // Forwarding parameters. Returned if 'ForwardCalls' is specified in 'callHandlingAction'. These settings determine the forwarding numbers to which the call will be forwarded
        public ForwardingInfo forwarding;
        // Unconditional forwarding parameters. Returned if 'UnconditionalForwarding' is specified in 'callHandlingAction'
        public UnconditionalForwardingInfo unconditionalForwarding;
        // Queue settings applied for department (call queue) extension type, with the 'AgentQueue' value specified as a call handling action
        public QueueInfo queue;
        // Transfer settings applied for department (call queue) extension type, with 'TransferToExtension' call handling action
        public TransferredExtensionInfo transfer;
        // Specifies whether to take a voicemail and who should do it
        public VoicemailInfo voicemail;
        // Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List
        public GreetingInfo[] greetings;
        // Call screening status. 'Off' - no call screening; 'NoCallerId' - if caller ID is missing, then callers are asked to say their name before connecting; 'UnknownCallerId' - if caller ID is not in contact list, then callers are asked to say their name before connecting; 'Always' - the callers are always asked to say their name before connecting. The default value is 'Off'
        // Enum: Off, NoCallerId, UnknownCallerId, Always
        public string screening;
    }
}