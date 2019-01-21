using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class VoicemailsInfo : Serializable
    {
        // Email notification flag
        public bool? notifyByEmail;
        // SMS notification flag
        public bool? notifyBySms;
        // List of recipient email addresses for voicemail notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] advancedEmailAddresses;
        // List of recipient phone numbers for voicemail notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] advancedSmsEmailAddresses;
        // Indicates whether voicemail should be attached to email
        public bool? includeAttachment;
        // Indicates whether email should be automatically marked as read
        public bool? markAsRead;
    }
}