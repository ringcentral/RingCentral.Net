namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listExtensions
    /// </summary>
    public class ListExtensionsParameters
    {
        /// <summary>
        ///     Extension short number to filter records
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Extension email address. Multiple values are accepted
        ///     Example: alice.smith@example.com,bob.johnson@example.com
        /// </summary>
        public string[] email { get; set; }

        /// <summary>
        ///     Indicates a page number to retrieve. Only positive number values
        ///     are allowed
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates a page size (number of items)
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Extension status. Multiple values are supported. If `Unassigned`
        ///     is specified, then extensions without `extensionNumber` attribute are returned.
        ///     If not specified, then all extensions are returned
        ///     Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        /// </summary>
        public string[] status { get; set; }

        /// <summary>
        ///     Extension type. Please note
        ///     that legacy 'Department' extension type corresponds to 'Call Queue'
        ///     extensions in modern RingCentral product terminology
        ///     Enum: User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup,
        ///     DelegatedLinesGroup, GroupCallPickup, IvrMenu, ApplicationExtension, ProxyAdmin, RoomConnector, ParkLocation,
        ///     Limited, Bot, Site, Room, FlexibleUser, Unknown
        /// </summary>
        public string[] type { get; set; }
    }
}