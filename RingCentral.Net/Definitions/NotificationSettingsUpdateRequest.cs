namespace RingCentral
{
    public class NotificationSettingsUpdateRequest
    {
        /// <summary>
        ///     Canonical URI of notifications settings resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of notification recipient email addresses. Should not be empty
        ///     if 'includeManagers' parameter is set to false
        /// </summary>
        public string[] emailAddresses { get; set; }

        /// <summary>
        ///     List of notification recipient email addresses
        /// </summary>
        public string[] smsEmailAddresses { get; set; }

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

        /// <summary>
        ///     Specifies if managers' emails are included in the list of emails to
        ///     which notifications are sent. If not specified, then the value is `true`
        ///     Default: true
        /// </summary>
        public bool? includeManagers { get; set; }
    }
}