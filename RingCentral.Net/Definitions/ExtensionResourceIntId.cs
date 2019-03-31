namespace RingCentral
{
    public class ExtensionResourceIntId
    {
        /// <summary>
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public long? id;

        /// <summary>
        /// </summary>
        public string partnerId;

        /// <summary>
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// </summary>
        public string loginName;

        /// <summary>
        /// </summary>
        public ExtensionContactInfo contact;

        /// <summary>
        /// </summary>
        public Reference[] references;

        /// <summary>
        /// </summary>
        public string name;

        /// <summary>
        /// Enum: Unknown, User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup, IvrMenu, ApplicationExtension, ParkLocation
        /// </summary>
        public string type;

        /// <summary>
        /// Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public StatusInfo statusInfo;

        /// <summary>
        /// </summary>
        public DepartmentResource[] departments;

        /// <summary>
        /// </summary>
        public ServiceFeatureValue[] serviceFeatures;

        /// <summary>
        /// </summary>
        public RegionalSettingsInfo regionalSettings;

        /// <summary>
        /// Enum: NotStarted, Incomplete, Completed, Unknown
        /// </summary>
        public string setupWizardState;

        /// <summary>
        /// </summary>
        public ExtensionPermissionsResource permissions;

        /// <summary>
        /// </summary>
        public string password;

        /// <summary>
        /// </summary>
        public string ivrPin;

        /// <summary>
        /// </summary>
        public ProfileImageResource profileImage;
    }
}