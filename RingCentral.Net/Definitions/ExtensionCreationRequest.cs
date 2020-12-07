namespace RingCentral
{
    public class ExtensionCreationRequest
    {
        /// <summary>
        /// </summary>
        public ContactInfoCreationRequest contact;

        /// <summary>
        /// Number of extension
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// </summary>
        public CustomFieldInfo[] customFields;

        /// <summary>
        /// Password for extension. If not specified, the password is auto-generated
        /// </summary>
        public string password;

        /// <summary>
        /// List of non-RC internal identifiers assigned to an extension
        /// </summary>
        public ReferenceInfo[] references;

        /// <summary>
        /// </summary>
        public RegionalSettings regionalSettings;

        /// <summary>
        /// Additional extension identifier, created by partner application and applied on client side
        /// </summary>
        public string partnerId;

        /// <summary>
        /// IVR PIN
        /// </summary>
        public string ivrPin;

        /// <summary>
        /// Specifies extension configuration wizard state (web service setup).
        /// Default: NotStarted
        /// Enum: NotStarted, Incomplete, Completed
        /// </summary>
        public string setupWizardState;

        /// <summary>
        /// </summary>
        public SiteInfo site;

        /// <summary>
        /// Extension current state
        /// Enum: Enabled, Disabled, NotActivated, Unassigned, Frozen
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public ExtensionStatusInfo statusInfo;

        /// <summary>
        /// Extension type
        /// Enum: User, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, ParkLocation, Limited
        /// </summary>
        public string type;

        /// <summary>
        /// Hides extension from showing in company directory. Supported for extensions of User type only. For unassigned extensions the value is set to 'True' by default. For assigned extensions the value is set to 'False' by default
        /// </summary>
        public bool? hidden;
    }
}