namespace RingCentral
{
    public class NotificationSettings
    {
        /// <summary>
        /// Canonical URI of notifications settings resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of extensions specified as email notification recipients. Returned only for call queues where queue managers are assigned as user extensions.
        /// </summary>
        public EmailRecipientInfo[] emailRecipients;

        /// <summary>
        /// List of notification recipient email addresses
        /// </summary>
        public string[] emailAddresses;

        /// <summary>
        /// List of notification recipient email addresses
        /// </summary>
        public string[] smsEmailAddresses;

        /// <summary>
        /// Specifies notifications settings mode. If 'True' then advanced mode is on, it allows using different emails and/or phone numbers for each notification type. If 'False' then basic mode is on. Advanced mode settings are returned in both modes, if specified once, but if basic mode is switched on, they are not applied
        /// </summary>
        public bool? advancedMode;

        /// <summary>
        /// </summary>
        public VoicemailsInfo voicemails;

        /// <summary>
        /// </summary>
        public InboundFaxesInfo inboundFaxes;

        /// <summary>
        /// </summary>
        public OutboundFaxesInfo outboundFaxes;

        /// <summary>
        /// </summary>
        public InboundTextsInfo inboundTexts;

        /// <summary>
        /// </summary>
        public MissedCallsInfo missedCalls;
    }
}