namespace RingCentral
{
    public class ListExtensionsParameters
    {
        /// <summary>
        /// Number of extension to be retrieved
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Extension email address
        /// </summary>
        public string email;

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are allowed
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage;

        /// <summary>
        /// Extension current state. Multiple values are supported. If 'Unassigned' is specified, then extensions without `extensionNumber` attribute are returned. If not specified, then all extensions are returned.
        /// Enum: Enabled, Disabled, NotActivated, Unassigned
        /// </summary>
        public string[] status;

        /// <summary>
        /// Extension type. Multiple values are supported
        /// Enum: User, FaxUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, IvrMenu, ApplicationExtension, ParkLocation, Limited, Bot, ProxyAdmin, DelegatedLinesGroup
        /// </summary>
        public string[] type;
    }
}