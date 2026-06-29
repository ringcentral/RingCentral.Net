namespace RingCentral
{
    public class ThreadUserModel
    {
        /// <summary>
        ///     Thread user's extension ID
        ///     Required
        ///     Example: 9876453210
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Thread user's name (first + last)
        ///     Example: John Doe
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Type of the extension. For unrecognized types the `Unknown` value is returned.
        ///     Please note that legacy 'Department' extension type corresponds to 'Call Queue'
        ///     extensions in modern RingCentral product terminology
        ///     Example: User
        ///     Enum: User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup, DelegatedLinesGroup, GroupCallPickup, IvrMenu, ApplicationExtension, ProxyAdmin, RoomConnector, ParkLocation, Limited, Bot, Site, Room, FlexibleUser, TieLine, Unknown
        /// </summary>
        public string extensionType { get; set; }
    }
}