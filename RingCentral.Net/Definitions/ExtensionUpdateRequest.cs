namespace RingCentral
{
    public class ExtensionUpdateRequest
    {
        /// <summary>
        /// Enum: Disabled, Enabled, NotActivated, Frozen
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionStatusInfo statusInfo { get; set; }

        /// <summary>
        /// Type of suspension
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        /// Free Form user comment
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        /// Extension number available
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public ContactInfoUpdateRequest contact { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionRegionalSettingRequest regionalSettings { get; set; }

        /// <summary>
        /// Enum: NotStarted, Incomplete, Completed
        /// </summary>
        public string setupWizardState { get; set; }

        /// <summary>
        /// Additional extension identifier, created by partner application and applied on client side
        /// </summary>
        public string partnerId { get; set; }

        /// <summary>
        /// IVR PIN
        /// </summary>
        public string ivrPin { get; set; }

        /// <summary>
        /// Password for extension
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// </summary>
        public CallQueueInfoRequest callQueueInfo { get; set; }

        /// <summary>
        /// </summary>
        public UserTransitionInfo transition { get; set; }

        /// <summary>
        /// </summary>
        public CustomFieldInfo[] customFields { get; set; }

        /// <summary>
        /// Hides extension from showing in company directory. Supported for extensions of User type only
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site { get; set; }

        /// <summary>
        /// Extension type. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral product terminology
        /// Enum: User, Fax User, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, IvrMenu, ApplicationExtension, ParkLocation, DelegatedLinesGroup, GroupCallPickup
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// List of non-RC internal identifiers assigned to an extension
        /// </summary>
        public ReferenceInfo[] references { get; set; }
    }
}