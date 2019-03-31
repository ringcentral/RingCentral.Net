namespace RingCentral
{
    public class InboundFaxesInfo
    {
        /* Email notification flag */
        public bool? notifyByEmail;

        /* SMS notification flag */
        public bool? notifyBySms;

        /* List of recipient email addresses for inbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only */
        public string[] advancedEmailAddresses;

        /* List of recipient phone numbers for inbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only */
        public string[] advancedSmsEmailAddresses;

        /* Indicates whether fax should be attached to email */
        public bool? includeAttachment;

        /* Indicates whether email should be automatically marked as read */
        public bool? markAsRead;
    }
}