namespace RingCentral
  {
    /// <summary>
/// Message owner information. Supported for shared voicemail and sms messages only
/// </summary>
      public class OwnerResource
      {
          /// <summary>
        ///     Name of a voicemail owner
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

        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }
      }
  }