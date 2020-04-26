namespace RingCentral
{
    public class ExtensionUpdateRequest
    {
        /// <summary>
        /// Enum: Disabled, Enabled, NotActivated, Frozen
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
        /// Additional extension identifier, created by partner application and applied on client side
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

        /// <summary>
        /// </summary>
        public CustomFieldInfo[] customFields;

        /// <summary>
        /// Hides extension from showing in company directory. Supported for extensions of User type only
        /// </summary>
        public bool? hidden;

        /// <summary>
        /// Site data. If multi-site feature is turned on for the account, then internal identifier of a site must be specified. To assign the wireless point to the main site (company) set site ID to `main-site`
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site;

        /// <summary>
        /// Extension type
        /// Enum: User, Fax User, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, IvrMenu, ApplicationExtension, ParkLocation
        /// </summary>
        public string type;
    }
}