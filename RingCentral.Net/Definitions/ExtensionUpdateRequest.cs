namespace RingCentral
{
    public class ExtensionUpdateRequest
    {
        /// <summary>
        ///     Enum: Disabled, Enabled, NotActivated, Frozen
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionStatusInfo statusInfo { get; set; }

        /// <summary>
        ///     Extension number available
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public ContactInfoUpdateRequest contact { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionRegionalSettingRequest regionalSettings { get; set; }

        /// <summary>
        ///     Initial configuration wizard state
        ///     Default: NotStarted
        ///     Enum: NotStarted, Incomplete, Completed
        /// </summary>
        public string setupWizardState { get; set; }

        /// <summary>
        ///     Additional extension identifier, created by partner application
        ///     and applied on client side
        /// </summary>
        public string partnerId { get; set; }

        /// <summary>
        ///     IVR PIN
        /// </summary>
        public string ivrPin { get; set; }

        /// <summary>
        ///     Password for extension
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
        /// </summary>
        public SiteReference site { get; set; }

        /// <summary>
        ///     Extension type. Please note that legacy 'Department' extension
        ///     type corresponds to 'Call Queue' extensions in modern RingCentral
        ///     product terminology
        ///     Enum: User, FaxUser, FlexibleUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup,
        ///     PagingOnly, IvrMenu, ApplicationExtension, ParkLocation, DelegatedLinesGroup, GroupCallPickup
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Extension subtype, if applicable. For any unsupported subtypes
        ///     the 'Unknown' value will be returned
        ///     Enum: VideoPro, VideoProPlus, DigitalSignageOnlyRooms, Unknown, Emergency
        /// </summary>
        public string subType { get; set; }

        /// <summary>
        ///     List of non-RC internal identifiers assigned to an extension
        /// </summary>
        public ReferenceInfo[] references { get; set; }
    }
}