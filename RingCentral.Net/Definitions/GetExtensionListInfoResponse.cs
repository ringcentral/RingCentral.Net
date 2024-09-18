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
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public ContactInfo contact { get; set; }

        /// <summary>
        ///     Extension short number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Extension name. For user extension types the value is a combination
        ///     of the specified first name and last name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionPermissions permissions { get; set; }

        /// <summary>
        /// </summary>
        public ProfileImageInfo profileImage { get; set; }

        /// <summary>
        ///     Extension status
        ///     Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Extension type. Please note that legacy `Department` extension type
        ///     corresponds to 'Call Queue' extensions in modern RingCentral product
        ///     terminology
        ///     Enum: User, FaxUser, FlexibleUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup,
        ///     PagingOnly, IvrMenu, ApplicationExtension, ParkLocation, Bot, Room, Limited, Site, ProxyAdmin, DelegatedLinesGroup,
        ///     GroupCallPickup
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
        ///     Hides extension from showing in company directory.
        ///     Supported for extensions of User type only
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public AssignedCountryInfo assignedCountry { get; set; }

        /// <summary>
        /// </summary>
        public CostCenterInfo costCenter { get; set; }

        /// <summary>
        ///     Extension creation date/time, in ISO 8601 format
        ///     Format: date-time
        ///     Example: 2024-06-06T07:01:14.123Z
        /// </summary>
        public string creationTime { get; set; }
    }
}