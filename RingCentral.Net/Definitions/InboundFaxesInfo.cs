namespace RingCentral
{
    public class InboundFaxesInfo
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
        ///     The parameter contains the list of phone Numbers which should be used for SMS notifications sending (if advanced
        ///     mode enabled)
        /// </summary>
        public string[] advancedSmsPhoneNumbers { get; set; }

        /// <summary>
        ///     List of recipient email addresses for inbound fax notifications.
        ///     Returned if specified, in both modes (advanced/basic). Applied in advanced
        ///     mode only
        /// </summary>
        public string[] advancedEmailAddresses { get; set; }

        /// <summary>
        ///     List of recipient phone numbers for inbound fax notifications.
        ///     Returned if specified, in both modes (advanced/basic). Applied in advanced
        ///     mode only
        /// </summary>
        public string[] advancedSmsEmailAddresses { get; set; }

        /// <summary>
        ///     Indicates whether fax should be attached to email
        /// </summary>
        public bool? includeAttachment { get; set; }

        /// <summary>
        ///     Indicates whether email should be automatically marked as read
        /// </summary>
        public bool? markAsRead { get; set; }
    }
}