namespace RingCentral
{
    // Information on an extension to which the phone number is assigned
    public class PhoneNumberExtensionInfo
    {
        /// <summary>
        /// Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string partnerId { get; set; }

        /// <summary>
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public string loginName { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionContactInfo contact { get; set; }

        /// <summary>
        /// </summary>
        public Reference[] references { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Extension type. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral product terminology
        /// Enum: Unknown, User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup, IvrMenu, ApplicationExtension, ParkLocation
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public StatusInfo statusInfo { get; set; }

        /// <summary>
        /// </summary>
        public DepartmentResource[] departments { get; set; }

        /// <summary>
        /// </summary>
        public ServiceFeatureValue[] serviceFeatures { get; set; }

        /// <summary>
        /// </summary>
        public RegionalSettingsInfo regionalSettings { get; set; }

        /// <summary>
        /// Enum: NotStarted, Incomplete, Completed, Unknown
        /// </summary>
        public string setupWizardState { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionPermissionsResource permissions { get; set; }

        /// <summary>
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// </summary>
        public string ivrPin { get; set; }

        /// <summary>
        /// </summary>
        public ProfileImageResource profileImage { get; set; }
    }
}