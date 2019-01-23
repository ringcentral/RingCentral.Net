using Newtonsoft.Json;

namespace RingCentral
{
    public class ForwardingInfo : Serializable
    {
        // Specifies if the user's softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers
        public bool? notifyMySoftPhones;
        // Specifies if the administrator's softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is 'False'
        public bool? notifyAdminSoftPhones;
        // Number of rings before forwarding starts
        public long? softPhonesRingCount;
        // Specifies the order in which forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ring all at the same time
        // Enum: Sequentially, Simultaneously
        public string ringingMode;
        // Information on a call forwarding rule
        public RuleInfo[] rules;
        // Specifies if mobile timeout is activated for the rule
        public bool? mobileTimeout;
    }
}