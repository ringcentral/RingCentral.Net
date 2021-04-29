namespace RingCentral
{
    public class VoicemailsInfo
    {
        /// <summary>
        ///     Email notification flag
        /// </summary>
        public bool? notifyByEmail { get; set; }

        /// <summary>
        ///     SMS notification flag
        /// </summary>
        public bool? notifyBySms { get; set; }

        /// <summary>
        ///     List of recipient email addresses for voicemail notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        /// </summary>
        public string[] advancedEmailAddresses { get; set; }

        /// <summary>
        ///     List of recipient phone numbers for voicemail notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        /// </summary>
        public string[] advancedSmsEmailAddresses { get; set; }

        /// <summary>
        ///     Indicates whether voicemail should be attached to email
        /// </summary>
        public bool? includeAttachment { get; set; }

        /// <summary>
        ///     Specifies whether to add voicemail transcription or not
        /// </summary>
        public bool? includeTranscription { get; set; }

        /// <summary>
        ///     Indicates whether a voicemail should be automatically marked as read
        /// </summary>
        public bool? markAsRead { get; set; }
    }
}