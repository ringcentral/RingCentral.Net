namespace RingCentral
{
    public class ExtensionCreationRequest
    {
        /// <summary>
        /// </summary>
        public ContactInfoCreationRequest contact { get; set; }

        /// <summary>
        ///     Extension short number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public CostCenterInfo costCenter { get; set; }

        /// <summary>
        /// </summary>
        public CustomFieldInfo[] customFields { get; set; }

        /// <summary>
        ///     Password for extension. If not specified, the password is auto-generated
        /// </summary>
        public string password { get; set; }

        /// <summary>
        ///     List of non-RC internal identifiers assigned to an extension
        /// </summary>
        public ReferenceInfo[] references { get; set; }

        /// <summary>
        /// </summary>
        public RegionalSettings regionalSettings { get; set; }

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
        ///     Initial configuration wizard state
        ///     Default: NotStarted
        ///     Enum: NotStarted, Incomplete, Completed
        /// </summary>
        public string setupWizardState { get; set; }

        /// <summary>
        /// </summary>
        public SiteInfo site { get; set; }

        /// <summary>
        ///     Extension status
        ///     Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionStatusInfo statusInfo { get; set; }

        /// <summary>
        ///     Extension type. Please note that legacy 'Department' extension type
        ///     corresponds to 'Call Queue' extensions in modern RingCentral product
        ///     terminology
        ///     Enum: User, VirtualUser, DigitalUser, FlexibleUser, Department, Announcement, Voicemail, SharedLinesGroup,
        ///     PagingOnly, ParkLocation, Limited
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Hides extension from showing in company directory. Supported
        ///     for extensions of 'User' type only. For unassigned extensions the value
        ///     is set to `true` by default. For assigned extensions the value is set
        ///     to `false` by default
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        ///     Extension name. For user extension types the value is a combination
        ///     of the specified first name and last name
        /// </summary>
        public string name { get; set; }
    }
}