namespace RingCentral
{
    public class ExtensionUpdateRequest
    {
        /// <summary>
        /// Enum: Disabled, Enabled, NotActivated
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public ExtensionStatusInfo statusInfo;

        /// <summary>
        /// Type of suspension
        /// </summary>
        public string reason;

        /// <summary>
        /// Free Form user comment
        /// </summary>
        public string comment;

        /// <summary>
        /// Extension number available
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// </summary>
        public ContactInfoUpdateRequest contact;

        /// <summary>
        /// </summary>
        public ExtensionRegionalSettingRequest regionalSettings;

        /// <summary>
        /// Enum: NotStarted, Incomplete, Completed
        /// </summary>
        public string setupWizardState;

        /// <summary>
        /// Extension partner identifier
        /// </summary>
        public string partnerId;

        /// <summary>
        /// IVR PIN
        /// </summary>
        public string ivrPin;

        /// <summary>
        /// Password for extension
        /// </summary>
        public string password;

        /// <summary>
        /// For Department extension type only. Call queue settings
        /// </summary>
        public CallQueueInfoRequest callQueueInfo;

        /// <summary>
        /// </summary>
        public UserTransitionInfo[] transition;
    }
}