using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ExtensionCreationRequest : Serializable
    {
        // Contact Information
        public ContactInfoCreationRequest contact;
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
        public string setupWizardState;
        // Extension current state
        public string status;
        // Status information (reason, comment). For 'Disabled' status only
        public ExtensionStatusInfo statusInfo;
        // Extension type
        public string type;
        // Hides extension from showing in company directory. Supported for extensions of User type only. For unassigned extensions the value is set to 'True' by default. For assigned extensions the value is set to 'False' by default
        public bool? hidden;
    }
}