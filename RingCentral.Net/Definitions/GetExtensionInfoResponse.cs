namespace RingCentral
{
    public class GetExtensionInfoResponse
    {
        /* Internal identifier of an extension */
        public long? id; // Required

        /* Canonical URI of an extension */
        public string uri; // Required

        /* Contact detailed information */
        public ContactInfo contact;

        /* Information on department extension(s), to which the requested extension belongs. Returned only for user extensions, members of department, requested by single extensionId */
        public DepartmentInfo[] departments;

        /* Number of department extension */
        public string extensionNumber;

        /* Extension user name */
        public string name;

        /* For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension */
        public string partnerId;

        public ExtensionPermissions permissions;

        /* Information on profile image */
        public ProfileImageInfo profileImage; // Required

        /* List of non-RC internal identifiers assigned to an extension */
        public ReferenceInfo[] references;

        public Roles[] roles;

        /* Extension region data (timezone, home country, language) */
        public RegionalSettings regionalSettings;

        /* Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features */
        public ExtensionServiceFeatureInfo[] serviceFeatures;

        /* Specifies extension configuration wizard state (web service setup). */
        // Default: NotStarted
        // Enum: NotStarted, Incomplete, Completed
        public string setupWizardState;

        /* Extension current state. If the status is 'Unassigned'. Returned for all extensions */
        // Enum: Enabled, Disabled, NotActivated, Unassigned
        public string status; // Required

        /* Status information (reason, comment). Returned for 'Disabled' status only */
        public ExtensionStatusInfo statusInfo;

        /* Extension type */
        // Enum: User, FaxUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnlyGroup, IvrMenu, ApplicationExtension, ParkLocation
        public string type; // Required

        /* For Department extension type only. Call queue settings */
        public CallQueueExtensionInfo callQueueExtensionInfo;

        /* Hides extension from showing in company directory. Supported for extensions of User type only */
        public bool? hidden;
    }
}