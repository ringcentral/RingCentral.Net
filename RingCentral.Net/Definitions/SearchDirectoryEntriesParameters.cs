namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation searchDirectoryEntries
    /// </summary>
    public class SearchDirectoryEntriesParameters
    {
        /// <summary>
        ///     Allows to make lookups across a whole directory skipping a filtering logic of Cross-Site access management feature.
        ///     Default: true
        /// </summary>
        public bool? accessibleSitesOnly { get; set; }

        /// <summary>
        ///     A list of Account IDs
        ///     Example: 400131426008
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     A list of department names
        ///     Example: North office
        /// </summary>
        public string department { get; set; }

        /// <summary>
        ///     A list of Site IDs
        ///     Example: 872781797006
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        ///     Extension current state
        ///     Example: Enabled
        /// </summary>
        public string extensionStatus { get; set; }

        /// <summary>
        ///     Type of extension to filter the contacts
        ///     Example: User
        ///     Enum: User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup,
        ///     IvrMenu, ApplicationExtension, ParkLocation, Limited, Bot, Site, Room, ProxyAdmin, DelegatedLinesGroup,
        ///     FlexibleUser, GroupCallPickup, RoomConnector
        /// </summary>
        public string extensionType { get; set; }
    }
}