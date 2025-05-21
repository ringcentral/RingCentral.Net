namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation syncMessages
    /// </summary>
    public class SyncMessagesParameters
    {
        /// <summary>
        ///     Conversation identifier for the resulting messages. Meaningful
        ///     for SMS and Pager messages only.
        ///     Format: int64
        /// </summary>
        public long? conversationId { get; set; }

        /// <summary>
        ///     The start date/time for resulting messages in ISO 8601 format
        ///     including timezone, for example 2016-03-10T18:07:52.534Z. The default value
        ///     is dateTo minus 24 hours
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     The end date/time for resulting messages in ISO 8601 format including
        ///     timezone, for example 2016-03-10T18:07:52.534Z. The default value is current
        ///     time
        ///     Format: date-time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     Direction for the resulting messages. If not specified, both
        ///     inbound and outbound messages are returned. Multiple values are accepted
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string[] direction { get; set; }

        /// <summary>
        ///     If `true`, then the latest messages per every conversation ID
        ///     are returned
        /// </summary>
        public bool? distinctConversations { get; set; }

        /// <summary>
        ///     Type for the resulting messages. If not specified, all types
        ///     of messages are returned. Multiple values are accepted
        ///     Enum: Fax, SMS, VoiceMail, Pager
        /// </summary>
        public string[] messageType { get; set; }

        /// <summary>
        ///     Limits the number of records to be returned (works in combination
        ///     with dateFrom and dateTo if specified)
        ///     Format: int32
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        ///     A `syncToken` value from the previous sync response (for `ISync` mode only, mandatory)
        /// </summary>
        public string syncToken { get; set; }

        /// <summary>
        ///     Type of message synchronization request:
        ///     - FSync -- full sync
        ///     - ISync -- incremental sync
        ///     Enum: FSync, ISync
        /// </summary>
        public string syncType { get; set; }

        /// <summary>
        ///     Deprecated. Filters voicemail messages based on the owner extension. Supported if the 'SharedVoicemail'
        ///     feature is enabled.
        ///     Default: Personal
        ///     Enum: Any, Personal, Shared
        /// </summary>
        public string[] voicemailOwner { get; set; }

        /// <summary>
        ///     Filters shared messages based on the owner extension. Supported if the 'SharedVoicemail' or 'CallQueueSmsRecipient'
        ///     feature is enabled.
        ///     Default: Personal
        ///     Enum: Any, Personal, Shared
        /// </summary>
        public string[] owner { get; set; }

        /// <summary>
        ///     Filters shared messages based on the owner extension type. Supported if "SharedVoicemail" or
        ///     "CallQueueSmsRecipient"
        ///     feature is enabled.
        ///     Enum: User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup,
        ///     DelegatedLinesGroup, GroupCallPickup, IvrMenu, ApplicationExtension, ProxyAdmin, RoomConnector, ParkLocation,
        ///     Limited, Bot, Site, Room, FlexibleUser, Unknown
        /// </summary>
        public string[] ownerExtensionType { get; set; }
    }
}