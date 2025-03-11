namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listExtensionGrants
    /// </summary>
    public class ListExtensionGrantsParameters
    {
        /// <summary>
        ///     Type of extension to be returned. Multiple values are supported.
        ///     **Please note that legacy 'Department' extension type corresponds
        ///     to 'Call Queue' extensions in modern RingCentral product terminology**
        ///     Enum: User, FaxUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly,
        ///     IvrMenu, ApplicationExtension, ParkLocation, Limited, Bot, Room, DelegatedLinesGroup
        /// </summary>
        public string[] extensionType { get; set; }

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
    }
}