using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ExtensionUpdateRequest : Serializable
    {
        public string status;
        public ExtensionStatusInfo statusInfo;
        // Type of suspension
        public string reason;
        // Free Form user comment
        public string comment;
        // Extension number available
        public string extensionNumber;
        public ContactInfoUpdateRequest contact;
        public ExtensionRegionalSettingRequest regionalSettings;
        public string setupWizardState;
        //  Extension partner identifier
        public string partnerId;
        // IVR PIN
        public string ivrPin;
        // Password for extension
        public string password;
        // For Department extension type only. Call queue settings
        public CallQueueInfoRequest callQueueInfo;
        // For NotActivated extensions only. Welcome email settings
        public UserTransitionInfo transition;
    }
}