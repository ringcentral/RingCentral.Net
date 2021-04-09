namespace RingCentral
{
    // Query parameters for operation listExtensionGrants
    public class ListExtensionGrantsParameters
    {
        /// <summary>
        ///     Type of extension to be returned. Multiple values are supported. Please note that legacy 'Department' extension
        ///     type corresponds to 'Call Queue' extensions in modern RingCentral product terminology
        ///     Enum: User, FaxUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly,
        ///     IvrMenu, ApplicationExtension, ParkLocation, Limited, Bot
        /// </summary>
        public string extensionType { get; set; }

        /// <summary>
        ///     Default: 1
        /// </summary>
        public string page { get; set; }

        /// <summary>
        ///     Default: 100
        /// </summary>
        public string perPage { get; set; }
    }
}