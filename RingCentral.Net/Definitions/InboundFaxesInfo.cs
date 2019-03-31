namespace RingCentral
{
    public class InboundFaxesInfo
    {
        /// <summary>
        /// Email notification flag
        /// </summary>
        public bool? notifyByEmail;

        /// <summary>
        /// SMS notification flag
        /// </summary>
        public bool? notifyBySms;

        /// <summary>
        /// List of recipient email addresses for inbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        /// </summary>
        public string[] advancedEmailAddresses;

        /// <summary>
        /// List of recipient phone numbers for inbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        /// </summary>
        public string[] advancedSmsEmailAddresses;

        /// <summary>
        /// Indicates whether fax should be attached to email
        /// </summary>
        public bool? includeAttachment;

        /// <summary>
        /// Indicates whether email should be automatically marked as read
        /// </summary>
        public bool? markAsRead;
    }
}