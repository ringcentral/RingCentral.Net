using Newtonsoft.Json;

namespace RingCentral
{
    public class ExtensionCreationRequest : Serializable
    {
        // Contact Information
        public ContactInfoCreationRequest contact; // Required
        // Number of extension
        public string extensionNumber;
        // Password for extension. If not specified, the password is auto-generated
        public string password;
        // List of non-RC internal identifiers assigned to an extension
        public ReferenceInfo[] references;
        public Roles[] roles;
        // Extension region data (timezone, home country, language)
        public RegionalSettings regionalSettings;
        // Specifies extension configuration wizard state (web service setup).
        // Enum: NotStarted, Incomplete, Completed
        public string setupWizardState;
        // Extension current state
        // Enum: Enabled, Disabled, NotActivated, Unassigned
        public string status;
        // Status information (reason, comment). For 'Disabled' status only
        public ExtensionStatusInfo statusInfo;
        // Extension type
        // Enum: User, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnlyGroup, ParkLocation
        public string type; // Required
        // Hides extension from showing in company directory. Supported for extensions of User type only. For unassigned extensions the value is set to 'True' by default. For assigned extensions the value is set to 'False' by default
        public bool? hidden;
    }
}