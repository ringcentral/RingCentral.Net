using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AnsweringRuleInfo : Serializable
    {
        // Canonical URI to an answering rule resource
        public string uri;
        // Internal identifier of an answering rule
        public string id;
        // Type of an answering rule
        public string type;
        // Name of an answering rule specified by user
        public string name;
        // Specifies if an answering rule is active or inactive
        public bool? enabled;
        // Schedule when an answering rule should be applied
        public ScheduleInfo schedule;
        // Answering rules are applied when calling to selected number(s)
        public CalledNumberInfo[] calledNumbers;
        // Answering rules are applied when calls are received from specified caller(s)
        public CallersInfo[] callers;
        // Specifies how incoming calls are forwarded
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
        public string screening;
    }
}