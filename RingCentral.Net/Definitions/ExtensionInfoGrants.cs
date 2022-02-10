namespace RingCentral
{
    /// <summary>
    ///     Extension information
    /// </summary>
    public class ExtensionInfoGrants
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Extension short number (usually 3 or 4 digits)
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Name of extension
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Extension type. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in
        ///     modern RingCentral product terminology
        ///     Enum: User, Fax User, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly,
        ///     IvrMenu, ApplicationExtension, ParkLocation
        /// </summary>
        public string type { get; set; }
    }
}