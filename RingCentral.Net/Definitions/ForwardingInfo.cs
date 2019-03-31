namespace RingCentral
{
    public class ForwardingInfo
    {
        /// <summary>
        /// Specifies if the user's softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers
        /// </summary>
        public bool? notifyMySoftPhones;

        /// <summary>
        /// Specifies if the administrator's softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is 'False'
        /// </summary>
        public bool? notifyAdminSoftPhones;

        /// <summary>
        /// Number of rings before forwarding starts
        /// </summary>
        public long? softPhonesRingCount;

        /// <summary>
        /// Specifies the order in which forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ring all at the same time
        /// Enum: Sequentially, Simultaneously
        /// </summary>
        public string ringingMode;

        /// <summary>
        /// Information on a call forwarding rule
        /// </summary>
        public RuleInfo[] rules;

        /// <summary>
        /// Specifies if mobile timeout is activated for the rule
        /// </summary>
        public bool? mobileTimeout;
    }
}