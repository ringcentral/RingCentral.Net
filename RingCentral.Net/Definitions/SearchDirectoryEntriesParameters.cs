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
        ///     A list of Account IDs. Deprecated, use the appropriate body field 'accountIds' instead.
        /// </summary>
        public string[] accountId { get; set; }

        /// <summary>
        ///     Department name. Deprecated, use the appropriate body field 'department' instead.
        ///     Example: North office
        /// </summary>
        public string department { get; set; }

        /// <summary>
        ///     A list of Site IDs. Deprecated, use the appropriate body field 'siteIds' instead.
        /// </summary>
        public string[] siteId { get; set; }

        /// <summary>
        ///     List of extension current statuses. Deprecated, use the appropriate body field 'extensionStatuses' instead.
        /// </summary>
        public string[] extensionStatus { get; set; }

        /// <summary>
        ///     Types of extension to filter the contacts
        ///     Enum: User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup,
        ///     IvrMenu, ApplicationExtension, ParkLocation, Limited, Bot, Site, Room, ProxyAdmin, DelegatedLinesGroup,
        ///     FlexibleUser, GroupCallPickup, RoomConnector
        /// </summary>
        public string[] extensionType { get; set; }
    }
}