namespace RingCentral
{
    public class NotificationSettings
    {
        // Canonical URI of notifications settings resource
        public string uri;

        // List of notification recipient email addresses
        public string[] emailAddresses;

        // List of notification recipient email addresses
        public string[] smsEmailAddresses;

        // Specifies notifications settings mode. If 'True' then advanced mode is on, it allows using different emails and/or phone numbers for each notification type. If 'False' then basic mode is on. Advanced mode settings are returned in both modes, if specified once, but if basic mode is switched on, they are not applied
        public bool? advancedMode;
        public VoicemailsInfo voicemails;
        public InboundFaxesInfo inboundFaxes;
        public OutboundFaxesInfo outboundFaxes;
        public InboundTextsInfo inboundTexts;
        public MissedCallsInfo missedCalls;
    }
}