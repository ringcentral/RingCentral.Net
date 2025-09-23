namespace RingCentral
{
    public class BaseNotificationSettings
    {
        /// <summary>
        ///     Canonical URI of notifications settings resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     The parameter contains the list of phone Numbers which should be used for SMS notifications sending
        ///     (if advanced mode disabled)
        /// </summary>
        public string[] smsPhoneNumbers { get; set; }

        /// <summary>
        ///     Specifies notifications settings mode. If `true` then advanced
        ///     mode is on, it allows using different emails and/or phone numbers for
        ///     each notification type. If `false` then basic mode is on. Advanced mode
        ///     settings are returned in both modes, if specified once, but if basic mode
        ///     is switched on, they are not applied
        /// </summary>
        public bool? advancedMode { get; set; }

        /// <summary>
        /// </summary>
        public VoicemailsInfo voicemails { get; set; }

        /// <summary>
        /// </summary>
        public InboundFaxesInfo inboundFaxes { get; set; }

        /// <summary>
        /// </summary>
        public OutboundFaxesInfo outboundFaxes { get; set; }

        /// <summary>
        /// </summary>
        public InboundTextsInfo inboundTexts { get; set; }

        /// <summary>
        /// </summary>
        public MissedCallsInfo missedCalls { get; set; }
    }
}