namespace RingCentral
{
    public class OutboundFaxesInfo : Serializable
    {
        // Email notification flag
        public bool? notifyByEmail;

        // SMS notification flag
        public bool? notifyBySms;

        // List of recipient email addresses for outbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] advancedEmailAddresses;

        // List of recipient phone numbers for outbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] advancedSmsEmailAddresses;
    }
}