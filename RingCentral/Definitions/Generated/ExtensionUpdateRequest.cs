namespace RingCentral
{
    public class ExtensionUpdateRequest : Serializable
    {
        // Enum: Disabled, Enabled, NotActivated
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
        // Enum: NotStarted, Incomplete, Completed
        public string setupWizardState;
        // Extension partner identifier
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