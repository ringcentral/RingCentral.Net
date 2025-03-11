namespace RingCentral
{
    /// <summary>
    ///     Message owner information. Supported for shared voicemail and sms messages only
    /// </summary>
    public class OwnerResource
    {
        /// <summary>
        ///     Name of a voicemail owner
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     ExtensionType
        ///     Enum: User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup,
        ///     DelegatedLinesGroup, GroupCallPickup, IvrMenu, ApplicationExtension, ProxyAdmin, RoomConnector, ParkLocation,
        ///     Limited, Bot, Site, Room, FlexibleUser
        /// </summary>
        public string extensionType { get; set; }

        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }
    }
}