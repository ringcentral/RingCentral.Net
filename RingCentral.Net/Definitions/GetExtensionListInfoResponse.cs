namespace RingCentral
{
    public class GetExtensionListInfoResponse
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public ContactInfo contact { get; set; }

        /// <summary>
        ///     Number of an extension
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Extension name. For user extension types the value is a combination of the specified first name and last name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionPermissions permissions { get; set; }

        /// <summary>
        /// </summary>
        public ProfileImageInfo profileImage { get; set; }

        /// <summary>
        ///     Extension current state. If 'Unassigned' is specified, then extensions without ‘extensionNumber’ are returned. If
        ///     not specified, then all extensions are returned
        ///     Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Extension type. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in
        ///     modern RingCentral product terminology
        ///     Enum: User, FaxUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly,
        ///     IvrMenu, ApplicationExtension, ParkLocation, Bot, Room, Limited, Site, ProxyAdmin, DelegatedLinesGroup,
        ///     GroupCallPickup
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CallQueueExtensionInfo callQueueInfo { get; set; }

        /// <summary>
        ///     Hides extension from showing in company directory. Supported for extensions of User type only
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site { get; set; }
    }
}