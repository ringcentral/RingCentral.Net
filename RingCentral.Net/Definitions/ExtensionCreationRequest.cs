namespace RingCentral
{
    public class ExtensionCreationRequest
    {
        /// <summary>
        /// Contact Information
        /// Required
        /// </summary>
        public ContactInfoCreationRequest contact;

        /// <summary>
        /// Number of extension
        /// </summary>
        public string extensionNumber;

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
        public Roles[] roles;

        /// <summary>
        /// Extension region data (timezone, home country, language)
        /// </summary>
        public RegionalSettings regionalSettings;

        /// <summary>
        /// Specifies extension configuration wizard state (web service setup).
        /// Default: NotStarted
        /// Enum: NotStarted, Incomplete, Completed
        /// </summary>
        public string setupWizardState;

        /// <summary>
        /// Extension current state
        /// Enum: Enabled, Disabled, NotActivated, Unassigned
        /// </summary>
        public string status;

        /// <summary>
        /// Status information (reason, comment). For 'Disabled' status only
        /// </summary>
        public ExtensionStatusInfo statusInfo;

        /// <summary>
        /// Extension type
        /// Required
        /// Enum: User, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, ParkLocation
        /// </summary>
        public string type;

        /// <summary>
        /// Hides extension from showing in company directory. Supported for extensions of User type only. For unassigned extensions the value is set to 'True' by default. For assigned extensions the value is set to 'False' by default
        /// </summary>
        public bool? hidden;
    }
}