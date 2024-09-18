namespace RingCentral
{
    public class GetExtensionInfoResponse
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public GetExtensionAccountInfo account { get; set; }

        /// <summary>
        /// </summary>
        public ContactInfo contact { get; set; }

        /// <summary>
        /// </summary>
        public CostCenterInfo costCenter { get; set; }

        /// <summary>
        /// </summary>
        public CustomFieldInfo[] customFields { get; set; }

        /// <summary>
        ///     Information on department extension(s), to which the requested
        ///     extension belongs. Returned only for user extensions, members of
        ///     department, requested by single extensionId. Please note that
        ///     legacy 'Department' extension type corresponds to 'Call Queue'
        ///     extensions in modern RingCentral product terminology
        /// </summary>
        public DepartmentInfo[] departments { get; set; }

        /// <summary>
        ///     Extension short number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public string[] extensionNumbers { get; set; }

        /// <summary>
        ///     Extension name. For user extension types the value is a combination
        ///     of the specified first name and last name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     For Partner Applications Internal identifier of an extension
        ///     created by partner. The RingCentral supports mapping of accounts and
        ///     stores the corresponding account ID/extension ID for each partner ID of
        ///     a client application. In request URIs partner IDs are accepted instead
        ///     of regular RingCentral native IDs as path parameters using `pid=XXX` clause.
        ///     Though in response URIs contain the corresponding account IDs and extension
        ///     IDs. In all request and response bodies these values are reflected via
        ///     partnerId attributes of account and extension
        /// </summary>
        public string partnerId { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionPermissions permissions { get; set; }

        /// <summary>
        /// </summary>
        public ProfileImageInfo profileImage { get; set; }

        /// <summary>
        ///     List of non-RC internal identifiers assigned to an extension
        /// </summary>
        public ReferenceInfo[] references { get; set; }

        /// <summary>
        /// </summary>
        public Roles[] roles { get; set; }

        /// <summary>
        /// </summary>
        public RegionalSettings regionalSettings { get; set; }

        /// <summary>
        ///     Extension service features is returned in response only when the
        ///     logged-in user requests their own extension info, see also Extension
        ///     Service Features
        /// </summary>
        public ExtensionServiceFeatureInfo[] serviceFeatures { get; set; }

        /// <summary>
        ///     Initial configuration wizard state
        ///     Default: NotStarted
        ///     Enum: NotStarted, Incomplete, Completed
        /// </summary>
        public string setupWizardState { get; set; }

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
        ///     Enum: User, FaxUser, FlexibleUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup,
        ///     PagingOnly, IvrMenu, ApplicationExtension, ParkLocation, Bot, Room, RoomConnector, Limited, Site, ProxyAdmin,
        ///     DelegatedLinesGroup, GroupCallPickup
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Extension subtype, if applicable. For any unsupported subtypes the
        ///     `Unknown` value will be returned
        ///     Enum: VideoPro, VideoProPlus, DigitalSignage, Unknown, Emergency
        /// </summary>
        public string subType { get; set; }

        /// <summary>
        /// </summary>
        public CallQueueExtensionInfo callQueueInfo { get; set; }

        /// <summary>
        ///     Hides extension from showing in company directory. Supported for
        ///     extensions of User type only
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public AssignedCountryInfo assignedCountry { get; set; }

        /// <summary>
        ///     Extension creation date/time, in ISO 8601 format
        ///     Format: date-time
        ///     Example: 2024-06-06T07:01:14.123Z
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Site access status for cross-site limitation
        ///     Enum: Limited, Unlimited
        /// </summary>
        public string siteAccess { get; set; }
    }
}